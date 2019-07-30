using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaDeVisuaalizacaoDeValores.Model
{
    public class Contrac
    {
        /// <summary>
        /// Identity
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Property for get and set value in contact
        /// </summary>
        public int Value { get; set; }  
        /// <summary>
        /// Get value on date contact set
        /// </summary>
        public DateTime DatInc { get; set; }
    }
}
