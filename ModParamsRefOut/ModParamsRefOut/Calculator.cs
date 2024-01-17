namespace ModParamsRefOut
{
    class Calculator
    {
        public static void Triple(ref int x) // ref vai tornar a variavel no code pricipal em referencia 
        {
            x = x * 3;
        }

        public static void Triple (int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
//Diferença:
//• A variável passada como parâmetro ref DEVE ter sido iniciada
//• A variável passada como parâmetro out não precisa ter sido iniciada
//ambos são muito similares, mas ref é uma forma de fazer o compilador obrigar o usuário a iniciar a variável.
//ambos sao "code smells",  devem ser evitados