amespace Project
{
    class Program
    {
        static int entrada1(string texto)
        {
            return texto.Length;
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Digite uma palavra : ");
            string texto = Console.ReadLine();
            int Contador = entrada1(texto);
            Console.WriteLine($"O números de letras digitadas foi : {Contador}" );

            Console.ReadKey();
        }
    }
}
