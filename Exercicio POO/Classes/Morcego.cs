using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Morcego : Animal, IVoar
    {
        public Morcego(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento)
        {
        }

        public int AltitudeMaximaEmMetros { get; set ; }
        public double VelocidadeDoVoo { get; set; }
    }
}
