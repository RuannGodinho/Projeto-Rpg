using System;
using Projeto_Rpg.src.entities;

namespace Projeto_Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 25, "Knight");
            Wizard wizard = new Wizard("Jennica", 25, "White Wizard");

            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(knight.Attack());
        }
    }
}
