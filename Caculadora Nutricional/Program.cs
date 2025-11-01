using System;
using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Buffers.Text;
using CalculadoraNutricional.Classes;
namespace calcnutri
{
    /// <summary>
    /// Descrição principal da classe ou método.
    /// Autor: Rafael Machado
    /// Versão: 1.0-alpha
    /// </summary>
    class Program
    {
        
        public static String arquivoSaida = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Calculadora Nutricional\Arquivos\Paciente.csv";
        public static Paciente Cliente = new Paciente();
        public static ManipulacaoDados Dados = new ManipulacaoDados();
        public static List<string> linhas = new List<string>();
        
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

            MenuCalculos();

            /*
            // usado para testes
            Console.WriteLine($"Id: {Cliente.Id}");
            Console.WriteLine($"Nome: {Cliente.Nome}");
            Console.WriteLine($"Peso: {Cliente.Peso}");
            Console.WriteLine($"Idade: {Cliente.Idade}");
            Console.WriteLine($"Altura: {Cliente.Altura}");
            Console.WriteLine($"Genero: {Cliente.Genero}");
            */

        }

        // paciente antigo
        public static void PacienteAntigo()
        {
            Console.Write("Digite a ID do paciente: ");
            int idEscolha = int.Parse(Console.ReadLine());
        }

        // menu de opções (Novo paciente | paciente antigo)
        public static void MenuOpcoes()
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


        // Calculo Taxa Metabolica Basal
        public static void TmbHomem()
        {
            //Console.WriteLine("Homem");

            float tmbH = (float)(88.36 + (13.4 * Cliente.Peso) + (4.8 * Cliente.Altura) - (5.7 * Cliente.Idade));
            Cliente.TaxaBasal = tmbH;

            Console.Write("Digite o FAF do paciente: ");
            Cliente.Faf = float.Parse(Console.ReadLine());

            Cliente.Get = tmbH * Cliente.Faf;

            Console.WriteLine($"Idade: {Cliente.Idade}");
            Console.WriteLine($"Altura: {Cliente.Altura}");
            Console.WriteLine($"Peso: {Cliente.Peso}");
            Console.WriteLine($"TMB: {Cliente.TaxaBasal:F2}Kcal");
            Console.WriteLine($"Get: {Cliente.Get:F2}Kcal");
            Console.WriteLine($"Faf: {Cliente.Faf}");

            MenuCalculos();
        }

        public static void TmbMulher()
        {
            //Console.WriteLine("Mulher");

            float tmbM = (float)(447.6 + (9.2 * Cliente.Peso) + (3.1 * Cliente.Altura) - (4.3 * Cliente.Idade));
            Cliente.TaxaBasal = tmbM;

            Console.Write("Digite o FAF do paciente: ");
            Cliente.Faf = float.Parse(Console.ReadLine());

            Cliente.Get = tmbM * Cliente.Faf;

            Console.WriteLine($"Idade: {Cliente.Idade}");
            Console.WriteLine($"Altura: {Cliente.Altura}");
            Console.WriteLine($"Peso: {Cliente.Peso}");
            Console.WriteLine($"TMB: {Cliente.TaxaBasal:F2}Kcal");
            Console.WriteLine($"Get: {Cliente.Get:F2}Kcal");
            Console.WriteLine($"Faf: {Cliente.Faf}");

            MenuCalculos();
            
        }

        // %BF
        public static void PorcentHomem()
        {

        }
        public static void PorcentMulher()
        {

        }

        // distribuição de macro-nutrientes
        public static void DistHipertrofia()
        {
            // calculos de ptn e lip
            Cliente.Ptn = Cliente.Peso * 2;
            Cliente.Lip = Cliente.Peso * 1;

            // calculo de kcal
            float kcalPtn = Cliente.Ptn * 8;
            float kcalLip = Cliente.Lip * 9;
            float kcalCho = Cliente.Get - (kcalLip + kcalPtn);

            // calculo cho pq é viadagem do caralho
            Cliente.Cho = kcalCho / 4;
            
            Console.WriteLine($"PTN: {Cliente.Ptn}g");
            Console.WriteLine($"LIP: {Cliente.Lip}g");
            Console.WriteLine($"CHO: {Cliente.Cho}g");
            Console.WriteLine($"Kcal PTN: {kcalPtn:F2}Kcal");
            Console.WriteLine($"Kcal LIP: {kcalLip:F2}Kcal");
            Console.WriteLine($"Kcal CHO: {kcalCho}Kcal");

            MenuCalculos();
        }
        public static void DistObeso()
        {
            // calculos ptn e lip
            Cliente.Ptn = Cliente.Peso * 2;
            Cliente.Lip = (float)(Cliente.Peso * 0.8);

            // calculos de kcal
            float kcalPtn = Cliente.Ptn * 8;
            float KcalLip = (float)(Cliente.Lip * 7.2);
            float KcalCho = Cliente.Get - (KcalLip + kcalPtn);

            // calculo cho pq é uma viadagem do caralho
            Cliente.Cho = KcalCho / 4;

            MenuCalculos();
        }
        public static void DistFalsoMagro()
        {
            // calculos ptn e lip
            Cliente.Ptn = (float)(Cliente.Peso * 2.2);
            Cliente.Lip = Cliente.Peso * 1;

            // calculos de kcal
            float kcalPtn = (float)(Cliente.Ptn * 8.8);
            float KcalLip = Cliente.Lip * 9;
            float KcalCho = Cliente.Get - (KcalLip + kcalPtn);

            // calculo cho pq é uma viadagem do caralho
            Cliente.Cho = KcalCho / 4;

            MenuCalculos();
        }
        public static void DistManutencao()
        {
            // calculos ptn e lip
            Cliente.Ptn = (float)(Cliente.Peso * 1.8);
            Cliente.Lip = Cliente.Peso * 1;

            // calculos de kcal
            float kcalPtn = (float)(Cliente.Ptn * 7.2);
            float KcalLip = Cliente.Lip * 9;
            float KcalCho = Cliente.Get - (KcalLip + kcalPtn);

            // calculo cho pq é uma viadagem do caralho
            Cliente.Cho = KcalCho / 4;

            MenuCalculos();
        }

        // funções de chamada para calculos
        public static void TaxaMetabolicaChamada()
        {
            Console.WriteLine("============================");
            Console.WriteLine("    TAXA METABOLICA BASAL   ");
            Console.WriteLine("============================");

            switch (Cliente.Genero)
            {
                case 'H': TmbHomem(); break;
                case 'M': TmbMulher(); break;
            }
        }
        public static void PorcentGordChamada()
        {
            Console.WriteLine("============================");
            Console.WriteLine("     PORCENTAGEM GORDURA    ");
            Console.WriteLine("============================");

            switch (Cliente.Genero)
            {
                case 'H': PorcentHomem(); break;
                case 'M': PorcentMulher(); break;
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
                case 1: DistHipertrofia(); break;
                case 2: DistObeso(); break;
                case 3: DistFalsoMagro(); break;
                case 4: DistManutencao(); break;
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