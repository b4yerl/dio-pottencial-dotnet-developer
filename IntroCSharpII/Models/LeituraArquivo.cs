using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroCSharpII.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int Quantidade) LerArquivo(string path) {
            try {
                string[] linhas = File.ReadAllLines(path);
                return (true, linhas, linhas.Count());
            }catch(Exception) {
                return (false, new string[0], 0);
            }
        }
    }
}