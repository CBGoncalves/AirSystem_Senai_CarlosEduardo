using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSistem_Senai.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}
