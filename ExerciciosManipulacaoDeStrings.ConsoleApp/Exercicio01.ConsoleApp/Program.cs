namespace ExerciciosManipulacaoDeStrings.ConsoleApp
{
    internal class Program
    {
        /*Escreva um programa que receba uma frase do usuário e converta todas as palavras para o formato &quot;Title Case&quot;, ou
        seja, todas as primeiras letras das palavras devem ser maiúsculas.*/
        static string[] palavrasSeparadas;
        static void Main(string[] args)
        {
            string palavrasMudadas = "";
            string textoDoUsuario = PegaValoresDoUsuario();
            TransformaTextoDoUsuarioEmPalavrasSeparadas(textoDoUsuario);
            MostraTituloOriginal(textoDoUsuario);
            Console.Write("Palavras Mudadas: ");
            MostrarTituloMudado(palavrasMudadas);

        }

        private static string MostrarTituloMudado(string palavrasMudadas)
        {
            palavrasMudadas = TransformaPalavrasDevoltaParaString(palavrasMudadas);
            Console.WriteLine(palavrasMudadas);
            return palavrasMudadas;
        }

        private static string TransformaPalavrasDevoltaParaString(string palavrasMudadas)
        {
            for (int i = 0; i < palavrasSeparadas.Length; i++)
            {
                palavrasMudadas = TransformaPalavraEmChars(palavrasMudadas, i);                
            }

            return palavrasMudadas;
        }

        private static string TransformaPalavraEmChars(string palavrasMudadas, int i)
        {
            char[] char1 = palavrasSeparadas[i].ToCharArray();
            string palavraFinal = "";
            for (int j = 0; j < char1.Length; j++)
            {
                if (j == 0)
                {
                    string m = char1[j].ToString();
                    m = m.ToUpper();
                    char1[j] = Convert.ToChar(m);
                }
                 palavraFinal = new string(char1);
            }
            palavrasMudadas += palavraFinal + " ";

            return palavrasMudadas;
        }

        private static void MostraTituloOriginal(string textoDoUsuario)
        {
            Console.Write("Palavras Originais ");
            Console.WriteLine(textoDoUsuario);
        }

        private static string[] TransformaTextoDoUsuarioEmPalavrasSeparadas(string textoDoUsuario)
        {
            palavrasSeparadas = textoDoUsuario.Split(" ");
            return palavrasSeparadas;
        }

        private static string PegaValoresDoUsuario()
        {
            Console.Write("Digite um Titulo: ");
            string textoDoUsuario = Console.ReadLine();
            return textoDoUsuario;
        }
    }
}