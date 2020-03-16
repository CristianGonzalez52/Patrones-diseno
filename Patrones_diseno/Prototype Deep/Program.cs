using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Deep
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro oPerro = new Perro() { Nombre = "Lucas", Edad = 5 };
            oPerro.Rasgos = new Detalles() {Raza="Labrador",Color="Cafe"};

            Console.WriteLine($"Se crea el primer objeto perro: {oPerro.Nombre}, edad {oPerro.Edad}" +
                                            $", raza {oPerro.Rasgos.Raza}, color {oPerro.Rasgos.Color}");

            Perro oPerroClon = oPerro.Clone() as Perro;

            Console.WriteLine($"Se crea el segundo objeto a partir del primero: {oPerroClon.Nombre}, edad {oPerroClon.Edad}" +
                                            $", raza {oPerroClon.Rasgos.Raza}, color {oPerroClon.Rasgos.Color}");

            oPerroClon.Rasgos.Raza = "Golden";
            oPerroClon.Rasgos.Color = "Dorado";

            Console.WriteLine($"Se modifican atributos del clon");

            Console.WriteLine($"Se crea el primer objeto perro: {oPerro.Nombre}, edad {oPerro.Edad}" +
                                            $", raza {oPerro.Rasgos.Raza}, color {oPerro.Rasgos.Color}");

            Console.WriteLine($"Se crea el segundo objeto a partir del primero: {oPerroClon.Nombre}, edad {oPerroClon.Edad}" +
                                            $", raza {oPerroClon.Rasgos.Raza}, color {oPerroClon.Rasgos.Color}");

            Console.ReadLine();
        }
    }
}
