namespace Calculos
{
    class Testes
    {
        public static bool TestaTudo()
        {
            return
                TestaSoma()    &&
                TestaSubtrai() &&
                TestaMult()    &&
                TestaDividir();
        }

        private static bool TestaSoma()
        {
            return
                Calculadora.Somar(2,  2) ==  4 &&
                Calculadora.Somar(2, -5) == -3 &&
                Calculadora.Somar(3, -3) ==  0;
        }

        private static bool TestaSubtrai()
        {
            return
                Calculadora.Subtrair(2, 2)  ==  0 &&
                Calculadora.Subtrair(-5, 4) == -9 &&
                Calculadora.Subtrair(5, -3) ==  8;
        }

        private static bool TestaMult()
        {
            return
                Calculadora.Mult(2,  2) ==   4 &&
                Calculadora.Mult(2, -5) == -10 &&
                Calculadora.Mult(3,  0) ==   0;
        }

        private static bool TestaDividir()
        {
            return
                Calculadora.Dividir( 2, 2) == 1 &&
                Calculadora.Dividir( 3, 1) == 3 &&
                Calculadora.Dividir(10, 2) == 5;
        }
    }
}
