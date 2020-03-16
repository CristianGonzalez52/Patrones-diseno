using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Deep
{
    public class Perro : ICloneable
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Detalles Rasgos { get; set; }

        public object Clone()
        {
            Perro clonado = this.MemberwiseClone() as Perro;
            Detalles detalles = new Detalles() { Raza = this.Rasgos.Raza, Color = this.Rasgos.Color };
            clonado.Rasgos = detalles;

            return clonado;
        }
    }

    public class Detalles
    {
        public string Raza { get; set; }
        public string Color { get; set; }
    }
}
