using calcnutri;
using System.IO; // necessario para StreamWriter e Path
namespace CalculadoraNutricional.Classes
{
    class ManipulacaoDados
    {
        public static String arquivoSaida = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Calculadora Nutricional\Calculadora Nutricional\data\Paciente.csv";
        public static List<string> linhas = new List<string>();

        // metodos para manipulação de arquivos

        public static void SelectId()
        {
            Console.Write("Digite a ID do paciente: ");
            int idEscolha = int.Parse(Console.ReadLine());
        }

        // cria arquivo se ele ainda não existir
        public static void CriarArquivo()
        {
            if (File.Exists(arquivoSaida)) { return; }
            else
            {
                File.Create(arquivoSaida); //File.AppendAllLines("Id;Nome;Peso;Idade;Altura;Genero;Kcal;Ptn;Lip;Cho;Bf;Faf;Get;Tmb");
            }
        }

        // carrega dados

        public static string[] CarregarDados() // metodo coringa (sempre usado)
        {
            string[] linhas = File.ReadAllLines(arquivoSaida);
            return linhas;
        }

        // armazena dados do paciente no arquivo

        public static void ArmazenarDados(Paciente pacienteParaSalvar) // metodo coringa (sempre usado)
        {
            CriarArquivo();

            try
            {
                string formatacao = $"{pacienteParaSalvar.Id};" +
                                    $"{pacienteParaSalvar.Nome};" +
                                    $"{pacienteParaSalvar.Peso};" +
                                    $"{pacienteParaSalvar.Idade};" +
                                    $"{pacienteParaSalvar.Altura};" +
                                    $"{pacienteParaSalvar.Genero};" +
                                    $"{pacienteParaSalvar.Kcal};" +
                                    $"{pacienteParaSalvar.Ptn};" +
                                    $"{pacienteParaSalvar.Lip};" +
                                    $"{pacienteParaSalvar.Cho};" +
                                    $"{pacienteParaSalvar.Bf};" +
                                    $"{pacienteParaSalvar.Faf};" +
                                    $"{pacienteParaSalvar.Get};" +
                                    $"{pacienteParaSalvar.TaxaBasal}";

                using(StreamWriter sw = new StreamWriter(arquivoSaida, true))
                {
                    sw.WriteLine(formatacao); // escreve nova linha no fim do arquivo
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao armazenar dados: {ex.Message}");
            }

        }

        public static void AlterarDados()
        {
            SelectId();
        }

        public static void DeletarDados()
        {
            SelectId();
            
        }

        public static void MostrarDados1(string[] linhas)
        {
            CarregarDados();

            try
            {
                foreach (var linha in linhas)
                {
                    string[] colunas = linha.Split(';');
                    foreach (var coluna in colunas)
                    {
                        Console.WriteLine($" {coluna} |");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public static void MostrarDados2()
        {
            string[] linhas = CarregarDados();
            MostrarDados1(linhas);
        }
    }
}