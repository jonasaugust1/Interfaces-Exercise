using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Mamifero
    {
        public int QtdeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CordDoPelo { get; set; }

        public Mamifero(int qtdeDeMamas, bool pelos, string corDoPelo)
        {
            QtdeDeMamas = qtdeDeMamas;
            Pelos = pelos;
            CordDoPelo= corDoPelo;
        }

        public void Amamentar() { }
    }
}
