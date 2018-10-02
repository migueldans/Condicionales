using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1,num2,num3,suma,resta,multiplicacion,media,hora,minutos;

            ////Escribe un programa que pida dos números y que muestre la suma, la resta,
            ////la multiplicación, la media, el máximo y el mínimo.

            //Console.WriteLine("Escribe un numero");
            //num1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //suma = (num1 + num2);
            //resta = (num1 - num2);
            //multiplicacion = (num1 * num2);
            //media = ((num1 + num2) / 2);

            //Console.WriteLine("La suma de " + num1 + " y " + num2 + " es " + suma);
            //Console.WriteLine("La resta de " + num1 + " y " + num2 + " es " + resta);
            //Console.WriteLine("La multiplicacion de " + num1 + " y " + num2 + " es " + multiplicacion);
            //Console.WriteLine("La media de " + num1 + " y " + num2 + " es " + media);
            //if (num1 > num2)
            //{
            //    Console.WriteLine("Maximo " + num1);
            //}
            //else
            //{
            //    Console.WriteLine("Maximo " +num2);
            //}
            //if (num1 < num2)
            //{
            //    Console.WriteLine("Minimo " + num1);
            //}
            //else
            //{
            //    Console.WriteLine("Minimo " +num2);
            //}

            ////Escribe un programa que pida al usuario 3 números. Si el resultado de la
            ////suma de los dos primeros es igual al tercer número, mostrarlo en pantalla,
            ////sino mostrar que el tercero no es la suma de los dos anteriores.

            //Console.WriteLine("Escribe un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //suma = (num1 + num2);
            //if (suma == num3)
            //{
            //    Console.WriteLine(suma + " = " + num3);
            //}
            //else
            //{
            //    Console.WriteLine(suma + " != " + num3);
            //}

            //Escribe un programa que convierta los segundos a horas, minutos y segundos.

            //Console.WriteLine("Escribe un numero de segundos");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //hora = num1 / 3600;
            //minutos = num1 / 60;

            //Console.WriteLine(hora + " horas " + (minutos % 60) + " minutos " + (num1 % 60) + " segundos");

            //Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.

            //Console.WriteLine("Escribe un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //num3 = Convert.ToInt32(Console.ReadLine());
            //if(num1>= (num2 +20))
            //{
            //    Console.WriteLine(num2 + " es al menos 20 numeros mas pequeño que " + num1);
            //}
            //else if (num1 >= (num3 + 20))
            //{
            //    Console.WriteLine(num3 + " es al menos 20 numeros mas pequeño que " + num1);
            //}
            //else if (num2 >= (num1 + 20))
            //{
            //    Console.WriteLine(num1 + " es al menos 20 numeros mas pequeño que " + num2);
            //}
            //else if (num2 >= (num3 + 20))
            //{
            //    Console.WriteLine(num3 + " es al menos 20 numeros mas pequeño que " + num2);
            //}
            //else if (num3 >= (num1 + 20))
            //{
            //    Console.WriteLine(num1 + " es al menos 20 numeros mas pequeño que " + num3);
            //}
            //else if (num3 >= (num2 + 20))
            //{
            //    Console.WriteLine(num2+ " es al menos 20 numeros mas pequeño que " + num3);
            //}

            ////Escribe un programa que pida dos valores del usuario y 
            ////Si los dos valores son iguales muestre 0
            ////Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            ////Si no que muestre el más grande de los dos

            //Console.WriteLine("Escribe un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine("es 0");
            //}
            //else if (num1 % 6 == num2 % 6)
            //{
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine("el numero mas pequeño es " + num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("el numero mas pequeño es " + num1);
            //    }
            //}
            //else if (num1 % 6 != num2 % 6)
            //{
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine("el numero mas grande es " +num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("el numero mas grande es " + num2);
            //    }
            //}

            ////Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.

            //Console.WriteLine("Escribe un numero entero entre 25 y 75");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero entero entre 25 y 75");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 / 10 == num2 / 10)
            //{
            //    Console.WriteLine("Hay un numero en comun");
            //}
            //else if (num1 / 10 == num2 % 10)
            //{
            //    Console.WriteLine("Hay un numero en comun");
            //}
            //else if (num2%10 == num1 / 10)
            //{
            //    Console.WriteLine("Hay un numero en comun");
            //}
            //else if (num2%10 == num1 % 10)
            //{
            //    Console.WriteLine("Hay un numero en comun");
            //}

            ////Vamos a escribir varios programas que saludan al usuario al iniciar. El usuario tiene asociadas 3 variables,
            ////una que indica si ha pagado la entrada, una que indica si es cliente VIP y la otro el saldo que tiene 
            ////(positivo para saldo de más, negativo para deuda). Haz un programa por cada punto:

            //string pagado, vip, saldo;
            //int diners;

            ////Comprobar si se ha pagado la entrada.Si se ha pagado, mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".

            //Console.WriteLine("¿Has pagado la entrada? Responda si ó no");
            //pagado = Console.ReadLine();
            //if(pagado=="si")
            //{
            //    Console.WriteLine("Bienvenido");
            //}
            //else if (pagado=="no")
            //{
            //    Console.WriteLine("Tienes que pagar la entrada");
            //}
            ////A todos se les dice "Bienvenido", pero si es cliente VIP después de "Bienvenido" también se le dice "Que pase un buen día"

            //Console.WriteLine("¿Eres un cliente VIP? Responde con si ó no");
            //vip = Console.ReadLine();
            //if (vip == "no")
            //{
            //    Console.WriteLine("Bienvenido");
            //}
            //else if (vip=="si")
            //{
            //    Console.WriteLine("Bienvenido, que pase un buen día");
            //}
            ////Si no tiene deudas, le damos la bienvenida.En caso contrario no hacemos nada.

            //Console.WriteLine("¿Tienes deudas?");
            //saldo = Console.ReadLine();
            //if(saldo=="no")
            //{
            //    Console.WriteLine("Bienvenido");
            //}

            ////Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0

            //Console.WriteLine("¿Eres cliente VIP?");
            //vip = Console.ReadLine();
            //if (vip == "si")
            //{
            //    Console.WriteLine("¿Cual es tu saldo?");
            //    diners= Convert.ToInt32(Console.ReadLine());
            //    if (diners > 0)
            //    {
            //        Console.WriteLine("Bienvenido");
            //    }

            //}

            ////Resultado de carrera. Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó.
            //string puesto;

            //Console.WriteLine("¿en que puesto has quedado?");
            //puesto = Console.ReadLine();

            ////Después:
            ////Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            //switch(puesto)
            //{ case "primero":
            //        Console.WriteLine("Ganaste");
            //        break;
            //  default:
            //        Console.WriteLine("Lo importante es participar");
            //        break;
            //}
            ////Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, mostramos el mensaje con 
            ////"Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            //if (puesto == "primero")
            //{
            //    Console.WriteLine("Medalla de Oro");
            //}
            //else if (puesto == "segundo")
            //{
            //    Console.WriteLine("Medalla de Plata");
            //}
            //else if (puesto=="tercero")
            //{
            //    Console.WriteLine("Medalla de Bronce");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar");
            //}

            ////Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2,
            ////mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            //switch(puesto)
            //{
            //    case "primero":
            //        Console.WriteLine("Medalla de oro");
            //        break;
            //    case "segundo":
            //        Console.WriteLine("Medalla de plata");
            //        break;
            //    case "tercero":
            //        Console.WriteLine("Medalla de Bronce");
            //        break;
            //    default:
            //        Console.WriteLine("Lo importante es participar");
            //        break;
            //}


            ////Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".Hazlo usando un if/else y usando switch

            //if (puesto == "primero")
            //{
            //    Console.WriteLine("Sube al podium");
            //}
            //else if (puesto == "segundo")
            //{
            //    Console.WriteLine("Sube al podium");
            //}
            //else if (puesto=="tercero")
            //{
            //    Console.WriteLine("Sube al podium");
            //}
            //else
            //{
            //    Console.WriteLine("Se acabó la carrera");
            //}

            //switch(puesto)
            //{
            //    case "primero":
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    case "segundo":
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    case "tercero":
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    default:
            //        Console.WriteLine("Se acabó la carrera");
            //        break;

            //}

            ////Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", si no mostramos "Eres demasiado mayor para usar el tobogán" 
            //int edad;
            //Console.WriteLine("¿Cuantos años tienes?");
            //edad = Convert.ToInt32(Console.ReadLine());

            //if (edad<=8)
            //{
            //    Console.WriteLine("Pasa al tobogán");
            //}
            //else
            //{
            //    Console.WriteLine("Eres demasiado mayor para usar el tobogán");

            //}


            ////Comprobar un string que tenga el valor del día de la semana (lunes, martes, ...).
            ////Mostrar en pantalla el día que dice que es si es entre lunes y viernes 
            ////(Por ejemplo "Hoy es lunes") y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.
            //string semana;
            //Console.WriteLine("¿Que dia de la semana es?");
            //semana = Console.ReadLine();
            //switch (semana.ToLower())
            //    {
            //       case "lunes":
            //            Console.WriteLine("Hoy es Lunes");
            //            break;
            //       case "martes":
            //            Console.WriteLine("Hoy es Martes");
            //            break;
            //       case "miercoles":
            //            Console.WriteLine("Hoy es Miercoles");
            //            break;
            //       case "jueves":
            //            Console.WriteLine("Hoy es Jueves");
            //            break;
            //       case "viernes":
            //            Console.WriteLine("Hoy es Miercoles");
            //            break;
            //       default:
            //            Console.WriteLine("Hoy es fin de semana");
            //            break;

            //}

            ////A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7".
            ////Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor.

            //int numero;
            //Console.WriteLine("Escribe un numero");
            //numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El valor absoluto de " + -numero + " es " + numero);
            //if(numero<0)
            //{
            //    Console.WriteLine(-numero);
            //}
            //else
            //{
            //    Console.WriteLine(numero);
            //}

            ////Decir el número de helados que queremos comprar. Cada helado vale 2 euros. 
            ////Si compramos más de 10 helados, nos regalan uno gratis.
            ////Mostrar en pantalla el número de helados que nos dan y cuánto hemos pagado por ellos.

            //int helados;
            //Console.WriteLine("Escribe el numero de helados que quieres comprar");
            //helados = Convert.ToInt32(Console.ReadLine());
            //if (helados>=10)
            //{
            //    Console.WriteLine("Total de helados "+ (helados + helados/10) + " nos cuestan " + helados*2 + " euros");
            //}

            //Tenemos dos números, un numerador y un dividendo.
            //Si el dividendo no es cero, mostramos el resultado de dividir el numerador por el dividendo. 
            //Si el dividendo es cero, mostramos el mensaje "No se puede dividir por cero"

            int numerador, dividendo;
            Console.WriteLine("Escribe un numero");
            numerador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe un numero");
            dividendo = Convert.ToInt32(Console.ReadLine());
            if (dividendo != 0)
            {
                Console.WriteLine(numerador/dividendo);
            }
            else if (dividendo==0)
            {
                Console.WriteLine("No se puede dividir por cero");

            }

            //Con if else if: Mostrar en pantalla un menú con varias opciones.
            //Dependiendo de lo que el usuario elija, mostrar en pantalla la selección. Hacerlo tanto con if else como con switch.





            Console.ReadLine();

        }
    }
}
