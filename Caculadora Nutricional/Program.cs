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
        public static Dictionary<int, String> idIdade = new Dictionary<int, string>(); // Id - Idade
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

        // cadastro de novo paciente
        public static void Cadastro()
        {

        }

        // menu de opções (Distribuição de Macro -  %BF - TMB)
        public static void MenuOpcoes()
        {

        }
        
        // metodo principal do código
        public static void Main(String[] args)
        {
            
        }
    }
}