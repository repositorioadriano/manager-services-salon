using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerSalon.Models
{
    public class Servico
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}