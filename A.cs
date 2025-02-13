namespace alvin
{
    class Program
    {
        static int quadrado(int numero)
        {
            return numero * numero;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero: ");
            int entrada1 = int.Parse(Console.ReadLine());
            int resultado = quadrado(entrada1);
            
           
            Console.WriteLine("O numero {0} ao quadrado é {1}", entrada1, resultado);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
