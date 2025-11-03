using System;
using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Buffers.Text;
using CalculadoraNutricional.Classes;
using CalculoImportante.Classes;

namespace calcnutri
{
    /// <summary>
    /// Descrição principal da classe ou método.
    /// Autor: Rafael Machado
    /// Versão: 1.0-alpha
    /// </summary>
    class Program
    {
        public static Paciente Cliente = new Paciente();
        public static ManipulacaoDados Md = new ManipulacaoDados();

        // cadastro de novo paciente
        public static void Cadastro()
        {

            Console.WriteLine("Cadastro");

            Console.Write("ID: "); // ID
            Cliente.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: "); // Nome
            Cliente.Nome = Console.ReadLine();

            Console.Write("Peso(Kg): "); // Peso
            Cliente.Peso = float.Parse(Console.ReadLine());

            Console.Write("Idade(Anos): "); // Idade
            Cliente.Idade = int.Parse(Console.ReadLine());

            Console.Write("Altura(cm): "); // Altura
            Cliente.Altura = int.Parse(Console.ReadLine());

            Console.Write("Genero:(H/M): "); // Genero >>>>>>
            Cliente.Genero = char.Parse(Console.ReadLine().ToUpper()); // transforma tudo em caixa alta

            Md.ArmazenarDados();
            MenuCalculos();

        }

        // paciente antigo
        public static void PacienteAntigo()
        {
            Console.WriteLine("============================");
            Console.WriteLine("       PACIENTE ANTIGO      ");
            Console.WriteLine("============================");

            Console.WriteLine("1 - Alterar Dados || 2 - Deletar Dados || 3 - Mostrar Dados");

            Console.Write("Digite uma opção: ");
        }

        // menu de opções (Novo paciente | paciente antigo)
        public static void MenuOpcoes()
        {
            Console.WriteLine("============================");
            Console.WriteLine("          BEM-VINDO         ");
            Console.WriteLine("============================");

            Console.WriteLine("1 - novo paciente || 2 - paciente antigo");

            Console.Write("Digite uma opção: ");
            int optnMenu = int.Parse(Console.ReadLine());

            switch (optnMenu)
            {
                case 1: Console.Clear(); Cadastro(); break;
                case 2: Console.Clear(); PacienteAntigo(); break;
            }
        }

        // menu opções (Distribuição de Macro -  %BF - TMB)
        public static void MenuCalculos()
        {
            Console.WriteLine("============================");
            Console.WriteLine("   CALCULADORA NUTRICIONAL  ");
            Console.WriteLine("============================");

            Console.WriteLine("1 - TMB || 2 - Dist Macro || 3 - %BF");

            Console.Write("Digite uma opção: ");
            int optnCalc = int.Parse(Console.ReadLine());

            switch (optnCalc)
            {
                case 1: TaxaMetabolicaChamada(); break;
                case 2: DistMacroChamada(); break;
                case 3: PorcentGordChamada(); break;
                default: break;
            }

        }

        
        // funções de chamada para calculos
        public static void TaxaMetabolicaChamada()
        {
            Console.WriteLine("============================");
            Console.WriteLine("    TAXA METABOLICA BASAL   ");
            Console.WriteLine("============================");

            switch (Cliente.Genero)
            {
                case 'H': Calculo.TmbHomem(); break;
                case 'M': Calculo.TmbMulher(); break;
            }
        }
        public static void PorcentGordChamada()
        {
            Console.WriteLine("============================");
            Console.WriteLine("     PORCENTAGEM GORDURA    ");
            Console.WriteLine("============================");

            switch (Cliente.Genero)
            {
                case 'H': Calculo.PorcentHomem(); break;
                case 'M': Calculo.PorcentMulher(); break;
            }
        }
        public static void DistMacroChamada()
        {
            Console.WriteLine("===============================");
            Console.WriteLine(" DISTRIBUIÇÃO MACRO-NUTRIENTES ");
            Console.WriteLine("===============================");

            Console.WriteLine("1 - Hipertrofia || 2 - Obeso || 3 - Falso Magro || 4 - Manutenção");

            Console.Write("Digite uma opção: ");
            int optnDist = int.Parse(Console.ReadLine());

            switch (optnDist)
            {
                case 1: Calculo.DistHipertrofia(); break;
                case 2: Calculo.DistObeso(); break;
                case 3: Calculo.DistFalsoMagro(); break;
                case 4: Calculo.DistManutencao(); break;
            }
        }

        // metodo principal do código
        public static void Main(String[] args)
        {
            MenuOpcoes();
        }
    }
}

/*
  - contar calorias
 - calculo de gastos caloricos com base (obseso, falso magro, hipertrofia, superafit)
 - equação Harris-Benedicti (taxa metabólica - MTB)
	HOMENS:
	TMB = 88.36 + (13.4 * pesoKg) + (4.8 * alturaCm) - (5.7 * idadeAnos)

	MULHERES:
	TMB = 447.6 + (9.2 * pesoKg) + (3.1 * alturaCm) - (4.3 * idadeAnos)
 - após calcular o TMB, se calcula o Fator de Atividade Física (FAF)
	GET(Gasto Energetico Total) = TMB * FAF

======================================================================================

- quantidade ideal de gordura (LIP), proteina (PTN) e carbohidratos (CHO)
- fazer arquivo com nome, idade, altura, peso, tmb, faf e get do paciente + medições + ver % de gordura por dobras (calc 3, 5 e 7 dobras)
- criar historico de consultas, mostrando sua evolução

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
         
*/