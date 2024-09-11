using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3Grafica
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                Console.WriteLine("Hola mundo");
                game.Run();
            }

        }

    }
}
