
namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public double X { get; set; }   
        public double Y { get; set; }

        public  Matematica (double x, double y)
        {
            X = x;
            Y = y; 

            Calculadora.EventoCalculadora += EventHandler;
        }
         
        public void Somar ()
        {
            Calculadora.Somar(X,Y);
            Calculadora.Subtrair(X,Y);
            Calculadora.Multiplicar(X,Y);
            Calculadora.Dividir(X,Y);
         
        }

       private void EventHandler()
        {
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("   Método executado!");
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("\n ");
        }

    }
}