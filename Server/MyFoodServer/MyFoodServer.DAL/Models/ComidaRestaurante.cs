using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodServer.Dal.Models
{
    public class ComidaRestaurante
    {
        public int IdComida { get; set; }

        public String NomeComida { get; set; }

        public String Descricao { get; set; }

        public Double Valor { get; set; }

        public int IdRestaurante { get; set; }

        public String NomeRestaurante { get; set; }

        public String Logradouro { get; set; }

        public String Complemento { get; set; }

        public int Numero { get; set; }

        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public String Estado { get; set; }

        public String Telefone { get; set; }
    }
}
