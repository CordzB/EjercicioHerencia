namespace EjercicioHerencia
{
    public class Operaciones
    {
        
        public double CalcularAreaRectangulo(double baseRect, double altura)
        {
            return baseRect * altura;
        }

        
        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        
        public double CalcularLongitudCirculo(double radio)
        {
            return 2 * Math.PI * radio;
        }
        
        public double Sumar(double a, double b)
        {
            return a + b;
        }
    }

}
