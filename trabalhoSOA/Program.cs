using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoSOA
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem-Vindo a Simulação de substituição de Página!");
            Program prog = new Program();
            prog.Main1();
        }
        public void Main1()
        {
            metodos met = new metodos();
            met.getCapacidade();
            Console.WriteLine("-----------------------------------------------");
        }
    }
}