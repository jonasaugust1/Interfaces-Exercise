using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Chacal : Animal
    {
        public Chacal(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento)
        {
        }
    }
}
