﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Eduardo";
            aluno.Matricula = "123";
            aluno.Estudar();

            Funcionário funcionario = new Funcionário();
            funcionario.Nome = "Cinara";
            funcionario.Departamento = "Desenvolvimento";
            funcionario.Trabalhar();
            funcionario.Dormir();

            Console.ReadLine();


        }
    }
}
