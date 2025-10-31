using calcnutri;
namespace CalculadoraNutricional.Classes
{
    class ManipulacaoDados
    {
        public static String arquivoSaida = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Calculadora Nutricional\Paciente.csv";
        public static Paciente Cliente = new Paciente();
        public static List<string> linhas = new List<string>();
        
        // metodos para manipulação de arquivos

        // cria arquivo se ele ainda não existir
        public static void CriarArquivo()
        {
            if (File.Exists(arquivoSaida)) { return; }
            else { File.Create(arquivoSaida); }
        }

        // armazena dados do paciente no arquivo
        public static void ArmazenarDados() // metodo coringa (sempre usado)
        {
            try
            {

                linhas.Add($"{Cliente.Id};{Cliente.Nome};{Cliente.Peso};{Cliente.Idade};{Cliente.Altura};{Cliente.Genero};{Cliente.Kcal};{Cliente.Ptn};{Cliente.Lip};{Cliente.Cho};{Cliente.Bf};{Cliente.Faf};{Cliente.Get};{Cliente.TaxaBasal}");
                foreach (var linha in linhas)
                {

                }
               // File.WriteAllLines($"{Cliente.Id};{Cliente.Nome};{Cliente.Peso};{Cliente.Idade};{Cliente.Altura};{Cliente.Genero};{Cliente.Kcal};{Cliente.Ptn};{Cliente.Lip};{Cliente.Cho};{Cliente.Bf};{Cliente.Faf};{Cliente.Get};{Cliente.TaxaBasal}");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        public static void CarregarDados() // metodo coringa (sempre usado)
        {

        }

        public static void AlterarDados()
        {

        }

        public static void DeletarDados()
        {

        }

        public static void MostrarDados()
        {
            
        }
    }
}