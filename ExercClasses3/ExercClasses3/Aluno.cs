using System;

namespace ExercClasses3
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularNotaFinal()
        {
            double notaFinal = Nota1  + Nota2  + Nota3;
            return notaFinal;
        }

        public string Situacao()
        {
            double notaFinal = CalcularNotaFinal();

            if (notaFinal >= 60)
            {
                return "APROVADO";
            }
            else
            {
                double pontosFaltantes = 60 - notaFinal;
                return $"REPROVADO. Faltam {pontosFaltantes.ToString("F2")} pontos para a aprovação.";
            }
        }
    }


}
