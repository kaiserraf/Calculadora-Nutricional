using CalculadoraNutricional;
using calcnutri;
namespace CalculoImportante.Classes
{
    class Calculo
    {

        // Calculo Taxa Metabolica Basal
        public static void TmbHomem()
        {
            //Console.WriteLine("Homem");

            float tmbH = (float)(88.36 + (13.4 * Program.Cliente.Peso) + (4.8 * Program.Cliente.Altura) - (5.7 * Program.Cliente.Idade));
            Program.Cliente.TaxaBasal = tmbH;

            Console.Write("Digite o FAF do paciente: ");
            Program.Cliente.Faf = float.Parse(Console.ReadLine());

            Program.Cliente.Get = tmbH * Program.Cliente.Faf;

            Console.WriteLine($"Idade: {Program.Cliente.Idade}");
            Console.WriteLine($"Altura: {Program.Cliente.Altura}");
            Console.WriteLine($"Peso: {Program.Cliente.Peso}");
            Console.WriteLine($"TMB: {Program.Cliente.TaxaBasal:F2}Kcal");
            Console.WriteLine($"Get: {Program.Cliente.Get:F2}Kcal");
            Console.WriteLine($"Faf: {Program.Cliente.Faf}");

            Program.MenuCalculos();
        }

        public static void TmbMulher()
        {
            //Console.WriteLine("Mulher");

            float tmbM = (float)(447.6 + (9.2 * Program.Cliente.Peso) + (3.1 * Program.Cliente.Altura) - (4.3 * Program.Cliente.Idade));
            Program.Cliente.TaxaBasal = tmbM;

            Console.Write("Digite o FAF do paciente: ");
            Program.Cliente.Faf = float.Parse(Console.ReadLine());

            Program.Cliente.Get = tmbM * Program.Cliente.Faf;

            Console.WriteLine($"Idade: {Program.Cliente.Idade}");
            Console.WriteLine($"Altura: {Program.Cliente.Altura}");
            Console.WriteLine($"Peso: {Program.Cliente.Peso}");
            Console.WriteLine($"TMB: {Program.Cliente.TaxaBasal:F2}Kcal");
            Console.WriteLine($"Get: {Program.Cliente.Get:F2}Kcal");
            Console.WriteLine($"Faf: {Program.Cliente.Faf}");

            Program.MenuCalculos();

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
            Program.Cliente.Ptn = Program.Cliente.Peso * 2;
            Program.Cliente.Lip = Program.Cliente.Peso * 1;

            // calculo de kcal
            float kcalPtn = Program.Cliente.Ptn * 8;
            float kcalLip = Program.Cliente.Lip * 9;
            float kcalCho = Program.Cliente.Get - (kcalLip + kcalPtn);

            // calculo cho pq é viadagem do caralho
            Program.Cliente.Cho = kcalCho / 4;

            Console.WriteLine($"PTN: {Program.Cliente.Ptn}g");
            Console.WriteLine($"LIP: {Program.Cliente.Lip}g");
            Console.WriteLine($"CHO: {Program.Cliente.Cho}g");
            Console.WriteLine($"Kcal PTN: {kcalPtn:F2}Kcal");
            Console.WriteLine($"Kcal LIP: {kcalLip:F2}Kcal");
            Console.WriteLine($"Kcal CHO: {kcalCho}Kcal");

            Program.MenuCalculos();
        }
        public static void DistObeso()
        {
            // calculos ptn e lip
            Program.Cliente.Ptn = Program.Cliente.Peso * 2;
            Program.Cliente.Lip = (float)(Program.Cliente.Peso * 0.8);

            // calculos de kcal
            float kcalPtn = Program.Cliente.Ptn * 8;
            float KcalLip = (float)(Program.Cliente.Lip * 7.2);
            float KcalCho = Program.Cliente.Get - (KcalLip + kcalPtn);

            // calculo cho pq é uma viadagem do caralho
            Program.Cliente.Cho = KcalCho / 4;

            Program.MenuCalculos();
        }
        public static void DistFalsoMagro()
        {
            // calculos ptn e lip
            Program.Cliente.Ptn = (float)(Program.Cliente.Peso * 2.2);
            Program.Cliente.Lip = Program.Cliente.Peso * 1;

            // calculos de kcal
            float kcalPtn = (float)(Program.Cliente.Ptn * 8.8);
            float KcalLip = Program.Cliente.Lip * 9;
            float KcalCho = Program.Cliente.Get - (KcalLip + kcalPtn);

            // calculo cho pq é uma viadagem do caralho
            Program.Cliente.Cho = KcalCho / 4;

            Program.MenuCalculos();
        }
        public static void DistManutencao()
        {
            // calculos ptn e lip
            Program.Cliente.Ptn = (float)(Program.Cliente.Peso * 1.8);
            Program.Cliente.Lip = Program.Cliente.Peso * 1;

            // calculos de kcal
            float kcalPtn = (float)(Program.Cliente.Ptn * 7.2);
            float KcalLip = Program.Cliente.Lip * 9;
            float KcalCho = Program.Cliente.Get - (KcalLip + kcalPtn);

            // calculo cho pq é uma viadagem do caralho
            Program.Cliente.Cho = KcalCho / 4;

            Program.MenuCalculos();
        }

    }
}