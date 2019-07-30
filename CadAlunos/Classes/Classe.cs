using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunos.Classes
{
    public class Classe
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DatInc { get; set; } = DateTime.Now;
    }
}
