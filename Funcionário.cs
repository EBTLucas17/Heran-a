using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
   public class Funcionário: Pessoa
    {
        public String Departamento;

        public void Trabalhar()
    {
            Console.WriteLine(Nome + " está trabalhando no departamento ... " + Departamento);
     
        }

    }
}
