namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar ( double x, double y)
        {
            if (EventoCalculadora!= null)
            {
                System.Console.WriteLine("\n ");
                System.Console.WriteLine ($"A soma dos números é  {x + y}");
                System.Console.WriteLine ($"A subtração é  {x - y}");
                System.Console.WriteLine ($"A multiplicação é  {x * y}");
                System.Console.WriteLine ($"A divisão é  {x / y}");
                
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito!");
            } 
            
        }

        public static void Subtrair ( double x, double y)
        {
            // System.Console.WriteLine($"A subtração do 1º número menos o 2º é {x - y}");
        }
        
        public static void Multiplicar( double x, double y)
        {
            // System.Console.WriteLine($"A multiplicação dos numeros é { x * y}");
        }
        
        public static void Dividir( double x , double y)
        {
            // System.Console.WriteLine($"A divisão dos numeros é {x/y}");
        }
    }
}