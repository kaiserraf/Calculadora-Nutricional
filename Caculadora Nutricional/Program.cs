using System;
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
        public static Dictionary<int, int> idAltura = new Dictionary<int, int>(); // Id - Altura
        public static Dictionary<int, char> idGenero = new Dictionary<int, char>(); // Id - Genero

        // informações preenchidas conforme ocorre consultas
        public static Dictionary<int, float> idKcal = new Dictionary<int, float>(); // Id - kcal
        public static Dictionary<int, float> idPtn = new Dictionary<int, float>(); // Id - PTN
        public static Dictionary<int, float> idLip = new Dictionary<int, float>(); // Id - LIP
        public static Dictionary<int, float> idCho = new Dictionary<int, float>(); // Id - CHO
        public static Dictionary<int, float> idBf = new Dictionary<int, float>(); // Id - %BF
        public static Dictionary<int, float> idTmb = new Dictionary<int, float>(); // Id - TMB
        public static Dictionary<int, float> idFaf = new Dictionary<int, float>(); // Id - FAF
        public static Dictionary<int, float> idGet = new Dictionary<int, float>(); // Id - GET

        // cadastro de novo paciente
        public static void Cadastro()
        {

        }

        // menu de opções (Distribuição de Macro -  %BF - TMB)
        public static void MenuOpcoes()
        {
            Console.WriteLine("Bem vindo | escolha uma opção | 1 - novo paciente | 2 - paciente antigo");
        }
        
        // metodo principal do código
        public static void Main(String[] args)
        {
            
        }
    }
}