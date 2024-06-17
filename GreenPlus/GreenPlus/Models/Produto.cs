using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlus.Models
{
    class Produto
    {
        public string NomePop {  get; set; }
        public string NomeCien { get; set; }
        public string Categoria {  get; set; }
        public string Classificacao { get; set; }
        public int TempoEstimado { get; set; }
        public int Temperatura {  get; set; }
        public string Solo { get; set; }
        public int Irrigação { get; set; }
        public float Valor {  get; set; }
        
    }
}
