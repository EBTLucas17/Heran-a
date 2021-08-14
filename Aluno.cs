using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
   public class Aluno: Pessoa
    {
        public String Matricula;

        public void Estudar()
        {
            Console.WriteLine(Nome + " está estudando");

        }
    }
}
