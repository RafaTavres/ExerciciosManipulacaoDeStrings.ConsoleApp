using System.Reflection.Metadata;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static string fraseDigitada = "";
        static int contador = 0;
        static void Main(string[] args)
        {
            PegaDigitosDoUsuario();
            MostraAsFormatacoes();

        }

        private static void MostraAsFormatacoes()
        {
            Console.Write("Frase em Maísculo: ");
            Console.WriteLine(TransformaFrasePraMAisculo(fraseDigitada));
            Console.Write("Frase em Minúsculo: ");
            Console.WriteLine(TransformaFrasePraMinusculo(fraseDigitada));
            Console.Write("Quantidade de Caracters na frase: ");
            Console.WriteLine(ContaQuantosCaractersTemNafrase());
            Console.Write("primeira palavra da frase: ");
            Console.WriteLine(PegaPrimeirapalavra(fraseDigitada));
            Console.Write("Ultima palavra da frase: ");
            Console.WriteLine(PegaAUltimaPalavraDaFrase(fraseDigitada));
        }

        private static int ContaQuantosCaractersTemNafrase()
        {
            char[] caracters = fraseDigitada.ToCharArray();
            for (int i = 0; i < caracters.Length; i++)
            {
                if (caracters[i] != ' ')
                {
                    contador++;
                }
            }
            return contador;
        }
        private static string PegaPrimeirapalavra(string frasedigitada)
        {
            string[] novaFrase =  frasedigitada.Split();
            return novaFrase[0];
        }
        private static string PegaAUltimaPalavraDaFrase(string frasedigitada)
        {
            string[] novaFrase = frasedigitada.Split();
            int tamanho = novaFrase.Length;
            return novaFrase[tamanho - 1];
        }
        private static void PegaDigitosDoUsuario()
        {
            Console.WriteLine("Frase aleatoria: ");
            fraseDigitada = Console.ReadLine();
        }
        private static string TransformaFrasePraMAisculo(string frasedigitada)
        {
            return frasedigitada.ToUpper();
        }
        private static string TransformaFrasePraMinusculo(string frasedigitada)
        {
            return frasedigitada.ToLower();
        }
    }
}