using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, control, menu;
            do
            {
          
                Console.WriteLine("\n\nEscribe un número según el ejercicio que desees visualizar: \n" +
                                  "1 -> Par e Impar\n" +
                                  "2 -> Tabla de multiplicar\n" +
                                  "3 -> Tablas de multiplicar del 2 al 9\n" +
                                  "4 -> Números primos\n" +
                                  "5 -> Ordenar vector\n" +
                                  "6 -> Busqueda de nombres en vector\n" +
                                  "7 -> Mayor o Menor\n" +
                                  "8 -> Palíndromo\n" +
                                  "0 -> Salir");

                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        //Leer un número por teclado y definir si es par o impar
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Escribe un número entero");
                            num = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (num % 2 == 0)
                            {
                                Console.WriteLine(num + " es un número par");
                            }
                            else
                            {
                                Console.WriteLine(num + " es un número impar");
                            }
                            Console.WriteLine("\n" +
                                "\n" +
                                "\n" +
                                "Desea ingresar otro numero\n" +
                                              "1 -> Si\n" +
                                              "2 -> no");
                            control = Convert.ToInt32(Console.ReadLine());

                        } while (control == 1);
                        Console.Clear();
                        
                        break;


                    case 2:
                        //Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10

                        int n;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Digite el número según la tabla de multiplicar que desea visualizar");
                            n = Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine(n + " x " + i + " = " + (n * i) + "\n");

                            }

                            Console.WriteLine("\n" +
                                "\n" +
                                "\n" +
                                "Desea ingresar otro numero\n" +
                                              "1 -> Si\n" +
                                              "2 -> no");
                            control = Convert.ToInt32(Console.ReadLine());

                        } while (control == 1);
                        Console.Clear();
                        break;


                    case 3:
                        //Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10
                                                                       
                            Console.Clear();
                            for (int i = 2; i <= 9; i++)
                            {
                                Console.WriteLine("\n");
                                for (int x = 1; x <= 10; x++)
                                {
                                    Console.WriteLine(i + " x " + x + " = " + (i * x) + "\n");
                                }
                            }

              
                        break;


                    case 4:
                        //Leer un número por teclado y definir si es primo o no

                        
                        do
                        {
                            Console.Clear();
                            int x = 0;
                            Console.WriteLine("Escriba un número entero");
                            num = Convert.ToInt32(Console.ReadLine());


                            for (int i = 1; i <= num; i++)
                            {
                                if (num % i == 0)
                                {
                                    x++;
                                }

                            }
                            if (x != 2)
                            {
                                Console.WriteLine(num + " No un número primo");
                            }
                            else
                            {
                                Console.WriteLine(num + " Es un número primo");
                            }
                            Console.WriteLine("\n" +
                                "Desea introducir otro número\n" +
                                              "1 -> Si\n" +
                                              "2 -> No");
                            control = Convert.ToInt32(Console.ReadLine());
                        } while (control == 1);
                        Console.Clear();
                        break;


                    case 5:
                        //Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente

                        int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        int tam = edad.Length;
                        int temp;
                        Console.Clear();
                            Console.WriteLine("\n/-Arreglo original-/");
                            foreach (int elemento in edad)
                            {
                                Console.Write(elemento + " | ");
                            }

                            for (int j = 1; j < tam; j++)
                            {
                                for (int i = 0; i < (tam - j); i++)
                                {
                                    if (edad[i] > edad[i + 1])
                                    {
                                        temp = edad[i];
                                        edad[i] = edad[i + 1];
                                        edad[i + 1] = temp;

                                    }
                                }
                            }
                            Console.WriteLine("\n/-Arreglo ordenado-/");
                            foreach (int elemento in edad)
                            {
                                Console.Write(elemento + " | ");
                            }
                                                                                  
                                                 

                        break;

                    case 6:
                        /* Datos los vectores
                           edad = [12,50,23,10,18,35,41,85,16,45]
                           nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                           Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                           que el nombre no existe*/

                        int[] edadd = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        string nom;

                        do
                        {
                            bool cont = true;
                            Console.Clear();
                            Console.WriteLine("Escriba un nombre");
                            nom = Console.ReadLine();

                            for (int i = 0; i < edadd.Length; i++)
                            {

                                if (nom == nombre[i])
                                {
                                    cont = false;
                                    Console.WriteLine(nom + " tiene " + edadd[i] + " años");

                                }


                            }

                            if (cont == true)
                            {
                                Console.WriteLine(nom + " No existe");

                            }
                            Console.WriteLine("\n" +
                                    "¿Desea ingresar otro nombre?\n" +
                                                  "1 -> Si\n" +
                                                  "2 -> No");
                            control = Convert.ToInt32(Console.ReadLine());
                        } while (control == 1);
                        Console.Clear();
                        break;
                        

                    case 7:
                        //  Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres
                        //con su edad.

                        int[] age = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                        string[] name = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                        int t = age.Length;
                        int tempo;
                        string tempo2;
                        


                            Console.WriteLine("\n" +
                                "Arrelo Original\n");
                            foreach (int item in age)
                            {
                                Console.Write(item + " | ");
                            }

                            for (int x = 1; x < t; x++)
                            {
                                for (int i = 0; i < t - x; i++)
                                {
                                    if (age[i] > age[i + 1])
                                    {
                                        tempo = age[i];
                                        age[i] = age[i + 1];
                                        age[i + 1] = tempo;

                                        tempo2 = name[i];
                                        name[i] = name[i + 1];
                                        name[i + 1] = tempo2;

                                    }
                                }
                            }
                            Console.WriteLine("\n \n" +
                                "Arreglo ordenado\n");
                            foreach (int item in age)
                            {
                                Console.Write(item + " | ");
                            }

                        for (int i = 0; i < t; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("\n \n \nEl menor es " +
                                    "\n");
                                Console.WriteLine(name[i] + " tiene " + age[i] + " años ");
                            }
                            if (i == (t - 1))
                            {
                                Console.WriteLine("\nEl mayor es " +
                                    "\n");
                                Console.WriteLine(name[i] + " tiene " + age[i] + " años ");
                            }


                        }
                        break;

                    case 8:
                        //Dado una palabra definir si es palíndromo o no.
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("ingresa la palabra");
                            string palabra = (Console.ReadLine());
                            char[] palabraArray = palabra.ToCharArray();
                            string palabraAlRevez = "";
                            for (int i = palabraArray.Length - 1; i >= 0; i--)
                            {
                                palabraAlRevez += palabraArray[i];


                            }
                            if (palabra == palabraAlRevez)
                            {
                                Console.WriteLine("la palabra es palindromo");
                            }
                            else
                            {
                                Console.WriteLine("la palabra NO es palindromo");
                            }
                                                        

                            Console.WriteLine("\n" +
                                    "¿Desea ingresar otra palabra?\n" +
                                                  "1 -> Si\n" +
                                                  "2 -> No");
                            control = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        } while (control == 1);
                        Console.Clear();

                        break;


                    case 0:
                        Console.Clear();
                        Console.WriteLine("||SALIENDO DEL SISTEMA||");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" *El número digitado no es válido* ");
                        break;

                }
            } while (menu != 0);
                                     
            
            Console.ReadKey();
        }
    }
}
