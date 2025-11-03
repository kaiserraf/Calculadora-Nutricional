using CalculadoraNutricional;
using calcnutri;
namespace CalculoImportante.Classes
{
    class Calculo
    {

        public static Paciente Cliente = new Paciente();
        public static Program p = new Program();

        // Calculo Taxa Metabolica Basal
        public void TmbHomem()
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

            p.MenuCalculos();
        }

        public void TmbMulher()
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

            p.MenuCalculos();

        }

        // %BF
        public void PorcentHomem()
        {

        }
        public void PorcentMulher()
        {

        }

        // distribuição de macro-nutrientes
        public void DistHipertrofia()
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

            p.MenuCalculos();
        }
        public void DistObeso()
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

            p.MenuCalculos();
        }
        public void DistFalsoMagro()
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

            p.MenuCalculos();
        }
        public void DistManutencao()
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

            p.MenuCalculos();
        }

    }
}