using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploData.Models
{
    public class ClientesModels
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Text), StringLength(50)]
        public string Nome { get; set; }

        public int? Idade { get; set; }

        public string Idade12 { get; set; }
    }
}
