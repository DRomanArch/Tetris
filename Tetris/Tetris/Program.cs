using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            Figure[] f = new Figure[2];
            f[0] = new Square (2,3,'*');
            f[1] = new Stick(5,6, '%');

            foreach(Figure fig in f)
            {
                fig.Draw();
            }

            Console.ReadKey();
        }
    }
}
