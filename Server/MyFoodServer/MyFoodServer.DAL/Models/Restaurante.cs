using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFoodServer.Dal.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        public String  Logradouro { get; set; }

        public String Complemento { get; set; }

        public int Numero { get; set; }

        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public String Estado { get; set; }

        public String Telefone { get; set; }

        public List<Comida> Comidas { get; set; }

    }
}
