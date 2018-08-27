using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI01.Models
{
    public class Prato
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idrestaurante { get; set; }
        public Restaurante restaurante { get; set; }
    }
}
