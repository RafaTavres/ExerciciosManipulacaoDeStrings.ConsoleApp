using System.Linq;

namespace Exercicio06.ConsoleApp
{
    internal class Program
    {

        //Desenvolva um programa em C# que leia o arquivo cidades.csv e dê a possibilidade de apresentar as cidades
        //agrupadas pela primeira letra ou pelo estado que pertence.
        static string todosMunicipios = File.ReadAllText(@"C:\Users\Rafael\Desktop\Trabalhos da AdP\ExerciciosManipulacaoDeStrings\Cidades.csv");
        static string[] municipiosCompletos = todosMunicipios.Split('\n');
        static string[] cidades = todosMunicipios.Split(';');
        static string palavradigitada;
        static bool eNumero = false;

        static void Main(string[] args)
        {
            string resposta = "";

            while (resposta.ToUpper() != "S")
            {
                string opcao = MenuInicial();
                if (opcao == "1")
                {
                    PegaDigitoDosUsuario();
                    if (VerificaSeEhNumero())
                        continue;

                    PesquisaMunicipiorPorNome(municipiosCompletos, palavradigitada);
                }
                if (opcao == "2")
                {

                    PegaDigitoDosUsuario();
                    if (VerificaSeEhNumero())
                        continue;

                    PesquisaCidadesPorLetraInicial(cidades, municipiosCompletos);

                }

                resposta = VerificaSeUsuarioQuerContinuar();
            }
            Console.ReadLine();
        }

        private static string VerificaSeUsuarioQuerContinuar()
        {
            string resposta;
            Console.Write("Sai? S/N: ");
            resposta = Console.ReadLine();
            return resposta;
        }

        private static bool VerificaSeEhNumero()
        {
            if (eNumero)
            {
                MensagemDeErro("Deve ser informada pelo menos uma letra");
                return true;
            }
            return false;
        }

        private static string MenuInicial()
        {
            Console.WriteLine("1- Pesquisar por Estado/Cidade ||  2-  Pesquisar por Letra Inicial da Cidade");
            string resposta = Console.ReadLine();
            return resposta;
        }

        private static void PesquisaCidadesPorLetraInicial(string[] cidades, string[] municipiosCompletos)
        {
            for (int i = 0; i < cidades.Length; i++)
            {

                if (cidades[i].StartsWith(palavradigitada, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = 0; j < municipiosCompletos.Length; j++)
                    {
                        string cidadeFormatada = ";" + cidades[i] + ";";
                        if (municipiosCompletos[j].Contains(cidadeFormatada))
                        {
                            Console.WriteLine(municipiosCompletos[j]);
                        }
                    }

                }
            }
            Console.WriteLine("_________________________________");
            Console.ReadLine();
        }

        private static void PegaDigitoDosUsuario()
        {
            municipiosCompletos = todosMunicipios.Split('\n');
            Console.WriteLine("Estado/Cidade que deseja ver: ");
            palavradigitada = Console.ReadLine();
            eNumero = palavradigitada.All(char.IsDigit);
        }

        private static void MensagemDeErro(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        private static void PesquisaMunicipiorPorNome(string[] municipiosCompletos, string palavradigitada)
        {
            for (int i = 0; i < municipiosCompletos.Length; i++)
            {
                if (municipiosCompletos[i].Contains(palavradigitada, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(municipiosCompletos[i]);
                }

            }
            Console.WriteLine("_________________________________");
            Console.ReadLine();
        }
    }
}