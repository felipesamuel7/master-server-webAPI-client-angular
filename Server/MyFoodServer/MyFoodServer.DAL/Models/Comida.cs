using System;
using System.ComponentModel.DataAnnotations;

namespace MyFoodServer.Dal.Models
{
    public class Comida
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        public String Descricao { get; set; }

        [Required]
        public Double Valor { get; set; }

        public Restaurante Restaurante { get; set; }
        

    }
}
