using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroCSharpII.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int i = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento) {
            if(i + 1 < 11){
                array[i] = elemento;
                i++;
            }
        }

        public T this[int index] {
            get { return array[index]; }
            set { array[index] = value;}
        }
    }
}