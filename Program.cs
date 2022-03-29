using System;
using static System.Console;
using ExemploConstrutores.Models;



namespace ExemploConstrutores
{
    class Program 
        {

        public delegate void Operaçao (double x, double y);
        static void Main(string[] args )
        {
            System.Console.WriteLine("Digite um numero para fazer as operações matemáticas: ");
            var x = double.Parse(ReadLine());

            System.Console.WriteLine("Digite outro numero: ");
            var y = double.Parse(ReadLine());


            Matematica m = new Matematica(x,y);
            m.Somar();




            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op += Calculadora.Multiplicar;
            // op += Calculadora.Dividir;

            // op.Invoke(10,10);
        }
    }
}