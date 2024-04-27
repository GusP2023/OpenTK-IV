using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game juego = new Game(920, 600, "Demo OpenTK");
            juego.Run(60);
        }
    }
}
