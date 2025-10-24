using System;
using System.Dynamic;
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
        public static String arquivoSaida = @"C:\Users\Rafae\OneDrive\Área de Trabalho\C#\Calculadora Nutricional\Paciente.csv";

        // metodos para manipulação de arquivos
        public static void ArmazenarDados() // metodo coringa (sempre usado)
        {
            try
            {
                
            }catch(Exception ex)
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

        // cadastro de novo paciente
        public static void Cadastro()
        {
            // variaveis do cadastro
            // string nome;
            //float peso;
            //int idade, altura, id;
            //char genero;
            Paciente pacienteNovo = new Paciente();

            Console.WriteLine("Cadastro");

            Console.WriteLine("ID: "); // ID
            pacienteNovo.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: "); // Nome
            pacienteNovo.Nome = Console.ReadLine();

            Console.WriteLine("Peso(Kg): "); // Peso
            pacienteNovo.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Idade(Anos): "); // Idade
            pacienteNovo.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Altura(cm): "); // Altura
            pacienteNovo.Altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Genero:(H/M): "); // Genero
            pacienteNovo.Genero = char.Parse(Console.ReadLine().ToUpper()); // transforma tudo em caixa alta

            ArmazenarDados();

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