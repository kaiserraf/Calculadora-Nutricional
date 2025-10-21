using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
namespace calcnutri
{
    /// <summary>
    /// Descrição principal da classe ou método.
    /// Autor: Rafael Machado
    /// Versão: 1.0-beta
    /// </summary>
    class Program
    {

        /*
         #  INFORMAÇÕES DO PACIENTE
         # 
         #  nome - String
         #  peso - Float
         #  idade - Int
         #  altura - Int
         #  genero - Char
         #  id - Int
         #  kcal - Float
         #  proteinas(PTN) - Float
         #  lipidios(LIP) - Float
         #  carbohidratos(CHO) - Float
         #  %BF - Float
         #  FAF - Float
         #  GET - Float
         #
        */

        // informações principais para cadastro
        public static Dictionary<int, String> idNome = new Dictionary<int, string>(); // Id - Nome
        public static Dictionary<int, float> idPeso = new Dictionary<int, float>(); // Id - Peso
        public static Dictionary<int, int> idIdade = new Dictionary<int, int>(); // Id - Idade
        public static Dictionary<int, float> idAltura = new Dictionary<int, float>(); // Id - Altura
        public static Dictionary<int, char> idGenero = new Dictionary<int, char>(); // Id - Genero

        // informações preenchidas conforme ocorre consultas
        public static Dictionary<int, String> idKcal = new Dictionary<int, string>(); // Id - kcal
        public static Dictionary<int, String> idPtn = new Dictionary<int, string>(); // Id - PTN
        public static Dictionary<int, String> idLip = new Dictionary<int, string>(); // Id - LIP
        public static Dictionary<int, String> idCho = new Dictionary<int, string>(); // Id - CHO
        public static Dictionary<int, String> idBf = new Dictionary<int, string>(); // Id - %BF
        public static Dictionary<int, String> idTmb = new Dictionary<int, string>(); // Id - TMB
        public static Dictionary<int, String> idFaf = new Dictionary<int, string>(); // Id - FAF
        public static Dictionary<int, String> idGet = new Dictionary<int, string>(); // Id - GET

        // metodos para manipulação de arquivos
        public static void ArmazenarDados() // metodo coringa (sempre usado)
        {

        }

        public static void CarregarDados() // metodo coringa (sempre usado)
        {

        }

        public static void AlterarDados()
        {

        }

        public static void CriarDados()
        {

        }

        public static void DeletarDados()
        {

        }
        
        public static void MostrarDados()
        {
            
        }

        // cadastro de novo paciente
        public static void Cadastro()
        {
            // variaveis do cadastro
            string nome;
            float peso;
            int idade, altura, id;
            char genero;

            Console.WriteLine("Cadastro");

            Console.WriteLine("ID: "); // ID
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: "); // Nome
            nome = Console.ReadLine();
            idNome.Add(id, nome);

            Console.WriteLine("Peso(Kg): "); // Peso
            peso = float.Parse(Console.ReadLine());
            idPeso.Add(id, peso);

            Console.WriteLine("Idade(Anos): "); // Idade
            idade = int.Parse(Console.ReadLine());
            idIdade.Add(id, idade);

            Console.WriteLine("Altura(cm): "); // Altura
            altura = int.Parse(Console.ReadLine());
            idAltura.Add(id, altura);

            Console.WriteLine("Genero(H/M): "); // Genero
            genero = char.Parse(Console.ReadLine().ToUpper()); // transforma tudo em caixa alta
            idGenero.Add(id, genero);

        }

        // menu de opções (Distribuição de Macro -  %BF - TMB)
        public static void MenuOpcoes(string nome, float peso, int idade, int altura, int id, char genero)
        {
            Console.WriteLine("Bem vindo | escolha uma opção | 1 - novo paciente | 2 - paciente antigo");
            int optnMenu = int.Parse(Console.ReadLine());

            switch (optnMenu)
            {
                case 1:
                    Console.Clear();
                    Cadastro();
                    break;

                case 2: // alterações paciente antigo
                    Console.Clear();
                    break;
            }
        }

        // metodo principal do código
        public static void Main(String[] args)
        {
            Cadastro();
        }
    }
}