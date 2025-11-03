using calcnutri;
namespace CalculadoraNutricional.Classes
{
    class ManipulacaoDados
    {
        public static String arquivoSaida = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Calculadora Nutricional\data\Paciente.csv";
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

        public static void CarregarDados() // metodo coringa (sempre usado)
        {

        }

        // armazena dados do paciente no arquivo

        public void ArmazenarDados() // metodo coringa (sempre usado)
        {
            CarregarDados();

            try
            {

                Console.WriteLine(Program.Cliente.Nome);
                // File.WriteAllLines($"{Cliente.Id};{Cliente.Nome};{Cliente.Peso};{Cliente.Idade};{Cliente.Altura};{Cliente.Genero};{Cliente.Kcal};{Cliente.Ptn};{Cliente.Lip};{Cliente.Cho};{Cliente.Bf};{Cliente.Faf};{Cliente.Get};{Cliente.TaxaBasal}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

        public static void MostrarDados()
        {
            SelectId();
            
        }
    }
}