using ManagerSalon.Models;
using ManagerSalon.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagerSalon.Controllers
{
    public class ClientesController : Controller
        {
            private readonly IService<Cliente> _serviceCliente;
            public ClientesController(IService<Cliente> serviceCliente)
            {
                _serviceCliente = serviceCliente;
            }

            public IActionResult Index()
            {
                return View(_serviceCliente.GetAll());
            }
            
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create([Bind("Nome,Cpf, Rg, Email, DataNascimento, Telefone, Celular, Rua, Numero, Cep, Complemento, Bairro, Cidade, Estado")] Cliente cliente)
            {
                if(ModelState.IsValid)
                {
                   _serviceCliente.Save(cliente);
                    TempData["Message"] = "Cliente "+ cliente.Nome.ToUpper() + " cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                else {
                    return View(cliente);
                }
                
            }

            public IActionResult Details(int id)
            {
               Cliente cliente = _serviceCliente.GetById(id);
               return View(cliente);
            }

            
            public IActionResult Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                
                var cliente = _serviceCliente.GetById(id);
                return View(cliente);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(int id, [Bind("Id,Nome,Cpf,Rg,Email,DataNascimento,Telefone,Celular,Rua,Numero,Cep,Complemento,Bairro,Cidade,Estado")] Cliente c)
            {

                try
                {
                        _serviceCliente.Update(c);
                        TempData["Message"] = "Cliente "+ c.Nome.ToUpper() + " atualizado com sucesso!";
                        return RedirectToAction("Index");

                } catch(DbUpdateException ex)
                {
                    ModelState.AddModelError("Erro", ex.Message);
                }

                return View(c);
            }

            public IActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                Cliente cliente = _serviceCliente.GetById(id);

                if (cliente == null)
                {
                    return NotFound();
                }

                return View(cliente);
            }

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public IActionResult DeleteComfirmed(int id)
            {
                Cliente cliente =  _serviceCliente.GetById(id);
                if (cliente == null)
                {
                    return RedirectToAction("Index");
                }

                try
                {
                    _serviceCliente.Delete(cliente);
                    TempData["Message"] = "Cliente "+ cliente.Nome.ToUpper() + " removido com sucesso!";
                    return RedirectToAction("Index");

                } catch(DbUpdateException)

                {
                    return RedirectToAction("Delete");
                }
            }
            
    }

}