using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jonathan_calculadora_cientifica_adicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num4, num5;
            char opcion, operador = ' ', operadorx = ' ';
            double num1, num2, num3, resultado = 0;
            Console.WriteLine(" CALCULADORA ");
            Console.WriteLine("selecciona una opcion");
            Console.Write(" A - suma");
            Console.WriteLine("  B - resta");
            Console.Write("  C - multiplicacion");
            Console.WriteLine(" D - divicion");
            Console.WriteLine("  F - raiz cuadrada");
            Console.Write("  G - al cuadrado");
            Console.WriteLine("  H - al cubo");
            Console.Write(" I - seno");
            Console.WriteLine(" J - coseno");
            Console.Write(" K - tangente");
            Console.WriteLine(" L - lAGORITMO NATURAL");
            Console.Write(" M - RESIDUO (MOD)");
            Console.WriteLine(" N - potencia  ");
            Console.Write(" O - raiz");
            Console.WriteLine(" P - REDONDEAR");
            Console.Write(" Q - FACTORIAL");
            Console.WriteLine(" R - porcentaje");

            Console.WriteLine("  SELECCIONA UN OPCION:  ");
            opcion = char.Parse(Console.ReadLine());

            if (opcion == 'A' || opcion == 'B' || opcion == 'C' || opcion == 'D' || opcion == 'N' || opcion == 'O' || opcion == 'R' | opcion == 'a' || opcion == 'b' || opcion == 'c' || opcion == 'd' || opcion == 'n' || opcion == 'o' || opcion == 'r')
            {
                Console.Write("  1.- INGRESA EL PRIMER NUMERO :  ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("  2.- INGRESA EL SEGUNDO NUMERO : ");
                num2 = double.Parse(Console.ReadLine());
                double t = 0;
                switch (opcion)
                {
                    case 'A':
                    case 'a':
                        resultado = num1 + num2;
                        operador = '+';
                        break;
                    case 'B':
                    case 'b':
                        resultado = num1 - num2;
                        operador = '-';
                        break;
                    case 'C':
                    case 'c':
                        resultado = num1 * num2;
                        operador = 'x';
                        break;
                    case 'D':
                    case 'd':
                        resultado = num1 / num2;
                        operador = '÷';
                        break;
                    case 'M':
                    case 'm':
                        resultado = num1 % num2;
                        operador = '/';
                        break;
                    case 'N':
                    case 'n':
                        resultado = Math.Pow(num1, num2);
                        operador = '^';
                        break;
                    case 'O':
                    case 'o':
                        t = 1 / num1;
                        resultado = Math.Pow(num2, t);
                        operador = '√';
                        break;
                    case 'R':
                    case 'r':
                        resultado = (num1 / 10) * (num2 / 10);
                        operador = '%';
                        break;



                }
                Console.WriteLine("resultado ");
                Console.WriteLine(num1 + " " + operador + " " + num2 + " " + " = " + Math.Round(resultado, 3));
            }
            else
            {
                if (opcion == 'F' || opcion == 'G' || opcion == 'H' || opcion == 'I' || opcion == 'J' || opcion == 'K' || opcion == 'L' || opcion == 'P' || opcion == 'Q' || opcion == 'f' || opcion == 'g' || opcion == 'h' || opcion == 'i' || opcion == 'j' || opcion == 'k' || opcion == 'l' || opcion == 'p' || opcion == 'q')
                {
                    Console.Write("·INGRESE EL DIGITO:  ");
                    num3 = double.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 'F':
                        case 'f':
                            resultado = Math.Sqrt(num3);
                            operador = '√';
                            break;
                        case 'G':
                        case 'g':
                            resultado = Math.Pow(num3, 2);
                            operador = '^';
                            operadorx = '2';
                            break;
                        case 'H':
                        case 'h':
                            resultado = Math.Pow(num3, 3);
                            operador = '^';
                            operadorx = '3';
                            break;
                        case 'I':
                        case 'i':
                            resultado = Math.Sin(num3);
                            operador = 's';
                            operadorx = 'n';
                            break;
                        case 'J':
                        case 'j':
                            resultado = Math.Cos(num3);
                            operador = 'c';
                            operadorx = 's';
                            break;
                        case 'k':
                        case 'K':
                            resultado = Math.Tan(num3);
                            operador = 't';
                            operadorx = 'n';
                            break;
                        case 'l':
                        case 'L':
                            resultado = Math.Log(num3);
                            operador = 'l';
                            operadorx = 'g';
                            break;
                        case 'P':
                        case 'p':
                            resultado = Math.Round(num3);
                            operador = '-';
                            operadorx = '>';
                            break;
                        case 'Q':
                        case 'q':
                            int factorial1 = 1;
                            for (int i = 1; i <= num3; i++)
                            {
                                factorial1 = factorial1 * i;
                            }
                            resultado = factorial1;
                            operador = '!';
                            break;


                    }
                    Console.WriteLine(" RESULTADO ");
                    Console.WriteLine(num3 + "|" + operador + operadorx + "|" + " = " + Math.Round(resultado, 3));
                }

                else
                {
                    if (opcion == 'M' || opcion == 'm')
                    {
                        Console.WriteLine(" 1.-ingresa el primer numero");
                        num4 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" 2.- ingresa el segundo numero");
                        num5 = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 'M':
                            case 'm':
                                resultado = num4 % num5;
                                operador = '/';
                                break;
                        }
                        Console.WriteLine(" resultado");
                        Console.WriteLine(num4 + " " + operador + " " + num5 + " " + " El residuo sera: " + Math.Round(resultado, 3));
                    }
                    else
                    {
                        Console.WriteLine("VERIFICA QUE LA OPCION SEA CORRECTA!!!!");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
