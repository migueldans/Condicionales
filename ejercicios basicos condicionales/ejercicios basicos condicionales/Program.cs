using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_basicos_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2,num3,num4,num5,num6;
            double numa, numb, numc, numd;

            ////Pedir dos numeros y decir si son iguales o no

            //Console.WriteLine("Dame dos números");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if(num1==num2)
            //{
            //    Console.WriteLine("son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("son diferentes");
            //}

            ////Introducir un numero e indicar si es par o impar

            //Console.WriteLine("Introduzca un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("par");
            //}
            //else
            //{
            //    Console.WriteLine("impar");
            //}

            ////Pedir un numero del 1 al 7 y decir que dia de la semana es

            //Console.WriteLine("Dime un numero del uno al siete");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if(num1==1)
            //{
            //    Console.WriteLine("lunes");
            //}
            //else if(num1==2)
            //{
            //    Console.WriteLine("martes");
            //}
            //else if (num1 == 3)
            //{
            //    Console.WriteLine("miercoles");
            //}
            //else if (num1 == 4)
            //{
            //    Console.WriteLine("jueves");
            //}
            //else if (num1 == 5)
            //{
            //    Console.WriteLine("viernes");
            //}
            //else if (num1 == 6)
            //{
            //    Console.WriteLine("sabado");
            //}
            //else if (num1 == 7)
            //{
            //    Console.WriteLine("domingo");
            //}
            //else
            //{
            //    Console.WriteLine("No es un numero entre el 1 y el 7");
            //}

            ////Escribir un numero entre 1 y 12 y que te diga que mes e

            //Console.WriteLine("Escribe un número entre el 1 y el 12 inclusives, gracias");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //switch (num1)
            //{
            //    case 1:
            //        Console.WriteLine("Enero");
            //        break;
            //    case 2:
            //        Console.WriteLine("febrero");
            //        break;
            //    case 3:
            //        Console.WriteLine("marzo");
            //        break;
            //    case 4:
            //        Console.WriteLine("abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("mayo");
            //        break;
            //    case 6:
            //        Console.WriteLine("junio");
            //        break;
            //    case 7:
            //        Console.WriteLine("julio");
            //        break;
            //    case 8:
            //        Console.WriteLine("agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("septiembre");
            //        break;
            //    case 10:
            //        Console.WriteLine("octubre");
            //        break;
            //    case 11:
            //        Console.WriteLine("noviembre");
            //        break;
            //    case 12:
            //        Console.WriteLine("diciembre");
            //        break;
            //    default:
            //        Console.WriteLine("Numero no valido");
            //        break;
            //}

            ////Notas

            //Console.WriteLine("Introduce la nota");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //if(num1<5 && num1>=0)
            //{
            //    Console.WriteLine("Suspenso");
            //}
            //else if (num1>=5 && num1<6)
            //{
            //    Console.WriteLine("Aprobado");
            //}
            //else if (num1>=6 && num1<7)
            //{
            //    Console.WriteLine("Bien");
            //}
            //else if (num1>=7 && num1<8)
            //{
            //    Console.WriteLine("Muy bien");
            //}
            //else if (num1 >= 8 && num1 < 9)
            //{
            //    Console.WriteLine("Notable");
            //}
            //else if (num1 >= 9 && num1 < 10)
            //{
            //    Console.WriteLine("Sobresaliente");
            //}
            //else if (num1 >= 10)
            //{
            //    Console.WriteLine("Matricula de Honor");
            //}
            //else
            //{
            //    Console.WriteLine("Numero no valido");
            //}



            //pedir por teclado el peso y la altura e indicar segun su IMC cual es su clasificacion en la Organizacion mundial de la salud.

            Console.WriteLine("Escribe tu peso en kg");
            numa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe tu altura en metros");
            numb = Convert.ToDouble(Console.ReadLine());
            numc = numa / (Math.Pow(numb,2));

            if (numc < 16 && numc > 12)
            {
                Console.WriteLine("Tu IMC es " + numc + " Infrapeso: Delgadez Extrema");
            }
            else if (numc >= 16 && numc <= 16.99)
            {
                Console.WriteLine("Tu IMC es " + numc + " Infrapeso: Delgadez Moderada");
            }
            else if (numc >= 17 && numc <= 18.49)
            {
                Console.WriteLine("Tu IMC es " + numc + " Infrapeso: Delgadez Aceptable");
            }
            else if (numc >= 18.5 && numc <= 24.99)
            {
                Console.WriteLine("Tu IMC es " + numc + " Peso normal");
            }
            else if (numc >= 25 && numc <= 29.99)
            {
                Console.WriteLine("Tu IMC es " + numc + " Sobrepeso");
            }
            else if (numc >= 30 && numc <= 34.99)
            {
                Console.WriteLine("Tu IMC es " + numc + " Obeso Tipo I");
            }
            else if (numc >= 35 && numc <= 40)
            {
                Console.WriteLine("Tu IMC es " + numc + " Obeso Tipo II");
            }
            else if (numc >= 40 && numc<=59.99)
            {
                Console.WriteLine("Tu IMC es " + numc + " Obeso Tipo III");
            }
            else if (numc <= 12)
            {
                Console.Write("Error, revisa que hayas metido el peso en kg. y la altura en metros");
            }
            else if (numc >= 60)
            {
                Console.Write("Error, revisa que hayas metido el peso en kg. y la altura en metros");
            }

            Console.ReadLine();
        }
    }
}
