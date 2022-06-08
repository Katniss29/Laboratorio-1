using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] arregloNumeros = new int[5]; //Arreglo 
            bool salir = false;

            while (!salir)
            {
                
                menu();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        sumaEspecial(arregloNumeros);

                        break;

                    case 2:
                        ordenarArreglo(arregloNumeros);
                        break;

                    case 3:
                        Console.WriteLine("Digite la cantidad de filas");
                        int cantidadFilas = int.Parse(Console.ReadLine());
                        int[,] matrizTriangulo = new int[cantidadFilas, cantidadFilas];

                        //Pone la primera columna en 1
                        for (int i = 0; i < cantidadFilas; i++)
                        {
                            matrizTriangulo[i, 0] = 1;

                        }
                        //Pone la fila en 1
                        for (int i = 0; i < cantidadFilas; i++)
                        {
                            matrizTriangulo[i, i] = 1;
                        }

                        for (int i = 0; i < cantidadFilas; i++)
                        {
                            for (int j = 1; j < i; j++)
                            {
                                matrizTriangulo[i, j] = matrizTriangulo[i - 1, j] + matrizTriangulo[i - 1, j - 1];

                            }
                        }

                        for (int i = 0; i < cantidadFilas; i++)
                        {
                            string filas = "";
                            for (int j = 0; j <= i; j++)
                            {
                                filas += matrizTriangulo[i, j] + " ";

                            }
                            Console.WriteLine(filas);

                        }




                        Console.ReadKey();
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Has desea salir del programa");
                        Console.ReadLine();
                        salir = true;
                        break;

                }
            }

          
        }

        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("**** Juego de Vectores ****" + "\n");
            Console.WriteLine("1. Suma Especial");
            Console.WriteLine("2. Ordenar Arreglos");
            Console.WriteLine("3. Crear Triángulo de Pascal");
            Console.WriteLine("4. Serie de Fibbonacci");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Ingrese la opcion que desea");
        }

        private static int sumaEspecial(int[] arregloNumeros)
        {
             string cadenaArreglo = "[ "; 
             int suma = 0;

            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                Console.WriteLine("Digite el numero que desea");
                arregloNumeros[i] = int.Parse(Console.ReadLine());

            }

            for(int i = 0; i < arregloNumeros.Length; i++)
            {
                int potenciaNumero = (int)Math.Pow(arregloNumeros[i], i);
                
                suma += potenciaNumero;
                
            }

            for(int i = 0; i < arregloNumeros.Length; i++)
            {
                if(i == arregloNumeros.Length - 1)
                {
                    cadenaArreglo += arregloNumeros[i] + " ] ";
                }
                else
                {
                    cadenaArreglo += arregloNumeros[i] + ",";
                }
                

            }
            

            Console.WriteLine("El resultado es " + suma);
            Console.WriteLine("Arreglo " + cadenaArreglo);
           

            Console.ReadLine();

            

            return suma; 
        }

        private static string ordenarArreglo(int[] arregloNumeros)
        {
            int ordenar = 0;
            int izquierdaArreglo;
            int derechaArreglo;
            string cadenaArregloInicial = "[";
            string cadenaArregloFinal = "[";
            int suma = 0;

            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                Console.WriteLine("Digite el numero que desea");
                arregloNumeros[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                if (i == arregloNumeros.Length - 1)
                {
                    cadenaArregloInicial += arregloNumeros[i] + " ] ";
                }
                else
                {
                    cadenaArregloInicial += arregloNumeros[i] + ",";
                }

            }




             for (ordenar = 0; ordenar < arregloNumeros.Length; ordenar++)
             {
                 for (izquierdaArreglo=0, derechaArreglo=1;derechaArreglo<arregloNumeros.Length;izquierdaArreglo++, derechaArreglo++)
                 {
                     if (arregloNumeros[izquierdaArreglo] > arregloNumeros[derechaArreglo])
                     {
                         int temporal = arregloNumeros[derechaArreglo];
                         arregloNumeros[derechaArreglo] = arregloNumeros[izquierdaArreglo];
                         arregloNumeros[izquierdaArreglo] = temporal;

                        suma += 1;
                        
                     }
                    

                }



            }
            
            

            //Array.Sort(arregloNumeros); //Prueba funciona 

            
                for (ordenar = 0; ordenar < arregloNumeros.Length; ordenar++)
            {
                if (ordenar == arregloNumeros.Length - 1)
                {
                    cadenaArregloFinal += arregloNumeros[ordenar] + " ] ";
                }
                else
                {
                    cadenaArregloFinal += arregloNumeros[ordenar] + ",";
                }
            }

            


            Console.Write("Arreglo Incial " + cadenaArregloInicial + "\n");
            Console.Write("Arreglo Final " + cadenaArregloFinal + "\n");
            Console.Write("Cantidad de veces que recorrio el ciclo " + suma);
            Console.ReadLine();

             


            return cadenaArregloInicial;
        }


       
    }
}
