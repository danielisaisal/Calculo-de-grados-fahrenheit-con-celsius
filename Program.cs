using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    class Program
    {
        #region Examen Final

        //Diseñar un algoritmo que, dados tres números enteros, calcule e imprima el promedio entre ellos.
        static void Main2(string[] args)
        {
            int num1, num2, num3, res;
            string linea;
            Console.WriteLine("Programa para sacar el promedio de 3 numeros");

            Console.WriteLine("ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("ingrese el tercer valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            res =(num1+num2+num3)/3;
            Console.WriteLine($"El promedio es: {res}");
            Console.ReadKey();
        }


        //Diseñar un algoritmo que imprima el área y el perímetro de un rectángulo ingresando su base y altura.
        static void Main3(string[] args)
        {
            double alturaR, baseR, area, perimetro;
            string linea;

            Console.WriteLine("Programa para calcular el area y perimetro de un rectangulo");

            Console.WriteLine("ingrese la altura: ");
            linea = Console.ReadLine();
            alturaR = double.Parse(linea);

            Console.WriteLine("ingrese la base: ");
            linea = Console.ReadLine();
            baseR = double.Parse(linea);

            area = baseR * alturaR;
            perimetro =2*(baseR+alturaR);

            Console.WriteLine($"El area es: {area}");
            Console.WriteLine($"El perimetro es: {perimetro}");
            Console.ReadKey();
        }


        //Realice un algoritmo que calcule el volumen de un cilindro a partir de los valores de su radio y altura
        static void Main4(string[] args) {
            double radio, altura, Ab, vol;
            string linea;

            Console.WriteLine("Programa para calcular el volumen de un cilindro");

            Console.WriteLine("ingrese el radio: ");
            linea = Console.ReadLine();
            radio = double.Parse(linea);

            Console.WriteLine("ingrese la altura: ");
            linea = Console.ReadLine();
            altura = double.Parse(linea);

            Ab =(3.1416*(Math.Pow(radio,2)));
            vol = Ab*altura;

            Console.WriteLine($"El volumen del cilindro es: {vol}");
            Console.ReadKey();
        }


        //Diseñar un algoritmo que convierta y muestre la temperatura en Fahrenheit ingresando la temperatura en Celsius.
        
        static void Main5(string[] args)
        {
            double gradosC, gradosF;
            string linea;

            Console.WriteLine("Programa para convertir grados Celsius a Fahrenheit");

            Console.WriteLine("ingrese la temperatura en grados Celsius: ");
            linea = Console.ReadLine();
            gradosC = double.Parse(linea);

            gradosF= (gradosC * 9) / 5 + 32;

            Console.WriteLine($"La temperatura en Fahrenheit es: {gradosF}");
            Console.ReadKey();
        }
            #endregion
        }
}
