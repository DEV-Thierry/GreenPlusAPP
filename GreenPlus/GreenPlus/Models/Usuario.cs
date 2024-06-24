using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlus.Models
{
    class Usuario
    {
        public string tipo { get; set; }
        public string nome { get; set; }   
        public string cpf { get; set; }
        public string email {  get; set; }
        public string contato {  get; set; }
        public string grupos {  get; set; }
        public string login { get; set; }
        public string senha { get; set; }

    }
}
