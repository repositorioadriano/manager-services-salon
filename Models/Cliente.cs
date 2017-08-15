using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagerSalon.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        public string Cpf { get; set; }
        [Display(Name = "RG")]
        public string Rg { get; set; }
        [Display(Name= "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Data Nascimento")]
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public virtual List<Servico> Servicos {get;set;}

    }
}