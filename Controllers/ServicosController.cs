using ManagerSalon.Models;
using ManagerSalon.Services;
using Microsoft.AspNetCore.Mvc;

namespace ManagerSalon.Controllers
{
    public class ServicosController : Controller
    {
        private readonly IService<Servico> _serviceServico;
        public ServicosController(IService<Servico> serviceServico)
        {
            _serviceServico = serviceServico;
        }
        
        public IActionResult Index()
        {
            return View(_serviceServico.GetAll());
        }
    }
}