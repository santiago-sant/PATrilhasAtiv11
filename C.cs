namespace Project
{
    class Program
    {
        static int equacao(int x,int y)
        {
            return x+y;
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um número  : ");
            int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um segundo numero :");
                int y = int.Parse(Console.ReadLine());

            int soma = equacao(x,y);

            Console.WriteLine($"A soma dos dois números é  : {soma}" );

            Console.ReadKey();
        }
    }
}
