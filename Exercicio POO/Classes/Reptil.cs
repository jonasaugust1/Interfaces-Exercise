using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_POO.Classes
{
    internal class Reptil : Animal, IAquatico, IOviparo
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public Reptil(
            string nome,
            DateTime dataDeNascimento,
            char sexo,
            int idade,
            bool carnivoro,
            bool peconhento,
            bool temEscamas, 
            bool temCasco) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento)
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }
    }
}
