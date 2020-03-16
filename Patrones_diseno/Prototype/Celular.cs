using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Celular : ICloneable
    {
        /// <summary>
        /// La interfaz ICloneable es propia del framework y debe ir definida con el metodo Clone
        /// </summary>
        public int Camaras { get; set; }
        public string Referencia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
