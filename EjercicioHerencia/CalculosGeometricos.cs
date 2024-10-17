

namespace EjercicioHerencia
{
    public class CalculosGeometricos : Operaciones
    {
        public void Imprimir()
        {
            Console.WriteLine("-----------OPERACIONES-----------");
            Console.WriteLine();
            
            double baseRect = 5.0, altura = 10.0;
            double areaRect = CalcularAreaRectangulo(baseRect, altura);
            Console.WriteLine($"Área del rectángulo: {areaRect}");
            Console.WriteLine();

            double lado = 3.0;
            double volumenCubo = CalcularVolumenCubo(lado);
            Console.WriteLine($"Volumen del cubo: {volumenCubo}");
            Console.WriteLine();

            double radio = 4.0;
            double longitudCirculo = CalcularLongitudCirculo(radio);
            Console.WriteLine($"Longitud del círculo: {longitudCirculo}");
            Console.WriteLine();
            
            double num1 = 8.0; 
            double num2 = 12.0; 
            double suma = Sumar(num1, num2);
            Console.WriteLine($"Suma de: {num1} y {num2}: {suma}");
        }
    }

}
