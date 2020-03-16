using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion primer objeto
            Celular oCelular = new Celular() { Referencia = "IPhone 11", Camaras = 4 };

            Console.WriteLine($"Se crea el primer objeto: {oCelular.Referencia} con {oCelular.Camaras} camaras");

            //Clonacion del primer objeto en el segundo
            Celular oCelularClonado = oCelular.Clone() as Celular;

            Console.WriteLine($"Se clona el objeto creado en un segundo objeto: {oCelularClonado.Referencia} con {oCelularClonado.Camaras} camaras");

            //Modificacion de un atributo del segundo objeto

            oCelularClonado.Camaras = 3;
            Console.WriteLine($"Se modifica u atributo del segundo objeto: {oCelularClonado.Referencia} con {oCelularClonado.Camaras} camaras");

            // se imprimen ambos objetos
            Console.WriteLine($"objeto 1: {oCelular.Referencia} con {oCelular.Camaras} camaras");
            Console.WriteLine($"objeto 2 (clon): {oCelularClonado.Referencia} con {oCelularClonado.Camaras} camaras");
            Console.ReadLine();

        }
    }
}
