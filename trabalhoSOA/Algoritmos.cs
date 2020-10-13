using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoSOA
{
    public class Algoritmos
    {
        public int cap;
        public int pages;
        public int escolherAlgoritimo;
        public int faltaPage;
        public void lru(int capacidade, int[] array)
        {
            //Definindo ca capacidade de memória
            int capacity = capacidade;
            int[] arr = array;
            //Criando uma lista com o tamanho inserido pelo input
            List<int> s = new List<int>(capacity);
            int count = 0;
            //Percorrendo a lista de array 
            foreach (int i in arr)
            {
                //Verifica se a página não contém na lista
                if (!s.Contains(i))
                {
                    //Verifica se o número da lista é igual ao número de capacidade
                    if (s.Count == capacity)
                    {
                        //Remove a primeira posição
                        s.RemoveAt(0);
                        s.Insert(capacity - 1, i);
                    }
                    else
                        //Adiciona a página á Lista
                        s.Insert(count, i);
                    //incrementa + 1 no total de falha de páginas
                    faltaPage++;
                }
                else
                {
                    //Remove e insere na última posição
                    s.Remove(i);
                    s.Insert(s.Count, i);
                }
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Total de Falhas de páginas: " + faltaPage);
            Console.ReadLine();
        }
        public void fifo(int capacidade, int[] array)
        {
            //Definindo ca capacidade de memória
            int cap = capacidade;
            //Criando uma lista com o tamanho inserido pelo input
            List<int> s = new List<int>(cap);
            //Percorrendo a Fila
            foreach (int i in array)
            {
                //Verifica se a página já contém na lista
                if (!s.Contains(i))
                {
                    //Adiciona a página na lista
                    s.Add(i);
                    //incrementa + 1 no total de falha de páginas
                    faltaPage++;
                }
            }

            Console.WriteLine("-----------------------------------------------");
            s.RemoveAt(0);

            Console.WriteLine("Total de Falhas de páginas: " + faltaPage + " elementos.");
            Console.Read();
        }

        public void lifo(int capacidade, int[] array)
        {
            //Definindo ca capacidade de memória
            cap = capacidade;
            //Criando uma lista com o tamanho inserido pelo input
            List<int> s = new List<int>(cap);
            //Percorrendo a Pilha
            foreach (int i in array)
            {
                if (!s.Contains(i))
                {
                    //Adiciona a página na lista
                    s.Add(i);
                    //incrementa + 1 no total de falha de páginas
                    faltaPage++;
                }
                //Verifica se o número da lista é igual ao número de capacidade
                if (cap == s.Count)
                {
                    //Remove o último item da Pilha
                    s.Remove(i);
                }
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Total de Falhas de páginas: " + faltaPage + " elementos.");

        }

    }
}
