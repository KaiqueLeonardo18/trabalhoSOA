using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoSOA
{
    public class metodos
    {
        Algoritmos alg = new Algoritmos();
        Program prog = new Program();

        public void getPage(int capacidade)
        {
            Console.WriteLine("\nInsira o conjunto de páginas desejado, é necessário que insira um número por vez.");
            alg.cap = capacidade;
            List<int> s = new List<int>(alg.cap);
            for (int i = 0; i < alg.cap; i++)
            {
                if (!Int32.TryParse(Console.ReadLine(), out alg.pages))
                {
                    Console.WriteLine("\nPor favor, insira um número válido.");
                    getPage(capacidade);
                }
                s.Add(alg.pages);
            }
            int[] array = s.ToArray();
            getAlgoritmo(capacidade, array);

        }

        public void getAlgoritmo(int cap, int[] array)
        {
            Console.WriteLine("Escolha um dos algoritimos de substituição de páginas disponíveis:\n " +
                "1 - Least Recently used(LRU)" +
                "\n 2 - First-in, First-out(FIFO)" +
                "\n 3 - Last-in, first-out(LIFO)\n");
            if (!Int32.TryParse(Console.ReadLine(), out alg.escolherAlgoritimo))
            {
                Console.WriteLine("\nPor favor, insira um número válido.");
                getAlgoritmo(cap, array);
            }
            else
            {
                if (alg.escolherAlgoritimo == 1)
                {
                    alg.lru(cap, array);
                }
                else if (alg.escolherAlgoritimo == 2)
                {
                    alg.fifo(cap, array);
                }
                else if (alg.escolherAlgoritimo == 3)
                {
                    alg.lifo(cap, array);
                }
                else
                {
                    Console.WriteLine("Algoritmo não encontrado, veja novamente a lista de algoritmo");
                    getAlgoritmo(cap, array);
                }
            }
        }

        public void getCapacidade()
        {
            Console.WriteLine("\nPara começarmos, Insira a quantidade de memória desejada");
            if (!Int32.TryParse(Console.ReadLine(), out alg.cap))
            {
                Console.WriteLine("\nPor favor, insira um número válido.");
                prog.Main1();
            }
            getPage(alg.cap);
        }

    }
}
