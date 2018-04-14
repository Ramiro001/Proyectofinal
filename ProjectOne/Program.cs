using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)/*
            Ramiro Junior Fernandez Gonzalez 
            Matricula:15-SISN-1-238
            seccion:0908 
            Daniel Esque Boden seccion:0908
            Matricula:15-MISN-1-101
            seccion:0908
            Miguel angel santana
            Matricula:15-EISM-1-165
            seccion:0908
             
             */


        {
            Console.Write("-------------------- BIENVENIDOS A NUESTROS PROGRAMA  DINAMICO  SELECTION SORT --------------------\n");

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            DisplayMenu();//MENU
        }
        public static void ShowMenu(int opcion)
        {
            switch (opcion)//declaramos un switch case  para las opciones del Menu 
            {
                case 1:
                    DisplayDevelopers();
                    break;
                case 2:
                    DisplayProgram();
                    break;
                case 3:
                    Close();
                    break;
                default:
                    InvalidOption();
                    Main(null);
                    break;
            }
        }
        public static void DisplayMenu()//Menu
        {
            Console.Clear();
            Console.Write("Elige una opcion de menu");
            Console.WriteLine("\n1) Programadores \n2) Programa \n3) Salir");
            int opcion = 0;

            try
            {
                opcion = int.Parse(Console.ReadLine());
                ShowMenu(opcion);
            }
            catch (Exception)
            {
                if (opcion == 0)
                {
                    Console.Write("Debe ingresar solo numeros\n ");
                    DisplayMenu();
                }
                DisplayMenu();
            }
        }
        public static void DisplayDevelopers()//Metodo Muestra las Matriculas de cada integrante
        {
            Console.Clear();
            Console.WriteLine("Ramiro Junior Fernandez 15-SISN-1-238 \n" +
            "Daniel Esquea 15-MISN-1-101 \n" +" Miguel Santana 15-EISM-1-165\n" +
            "Grupo: Los Intelectuales\n");
            Console.WriteLine("Presione <Enter> para volver atras...");
            Console.Read();
            DisplayMenu();
        }
        public static void DisplayProgram()//entrada por teclado, muestra un mensaje al usuario para que introduzca el usuario  una lista de numeros de solo 10 elementos
        {
            Console.Write("Digiete el  numero de elementos que  desea ordenar en el  arreglo: ");
            try
            {
                int qty = int.Parse(Console.ReadLine()); //Capturo el valor ingresado por el usuario y lo asigno a la varible.

                if (qty == 0 || qty > 10)
                {
                    Console.Write("digite numero  del 0 al 10.\nPresione <Enter> para volver al menu...");
                    Console.Read();
                    Console.Clear();
                    DisplayMenu();
                }

                int[] elements = new int[qty]; //creo un nuevo arreglo con el tamano ingresado anteriomente por el usuario.

                //Ciclo para asignarle los valores al arreglo.
                for (int i = 0; i < elements.Length; i++)
                {
                    int nums = i;
                    Console.Write($"Ingrese el {nums} elemento del arreglo: ");
                    elements[i] = int.Parse(Console.ReadLine());
                }

                //Ciclo para imprimir el arreglo completo, con sus elementos.
                for (int i = 0; i < elements.Length; i++)
                {
                    Console.WriteLine($"El arreglo tiene en la posicion {i} los valores {elements[i]} ");
                }

                OrderArray(elements);//invoco Metodo que ordena el arreglo.
                Console.Read();
            }
            catch (Exception ex)//Validacion
            {
                Console.WriteLine("No puedes ingresar letras, solo numeros.\nPresione <Enter> para volver al menu...");
                Console.Read();
                Console.Clear();
                string msg = ex.Message;
                DisplayMenu();
            }
        }
        public static int Close()
        {
            return 0;
        }
        public static void OrderArray(int[] array)
        {
            for (int l = 0; l < array.Length; l++)//Ciclo que itera el arreglo desde la posicion mas baja (l = low).
            {
                if (l == array.Length - 1) //valido que la poscion mas baja nunca sea menor que el tamano del arreglo.
                    break;

                //Ciclo para iterar el arreglo desde la posicion mas allta (h = hight).
                for (int h = array.Length - 1; h < array.Length; h--)
                {
                    if (h == 0 || h < l)//Valido que h nunca sea igual a -1 o que h sea menor que l
                    {
                        break;
                    }

                    if (array[l] > array[h])//Comparo los valores de la posicion mas baja y la mas alta.
                    {
                        int[] temp = new int[array.Length];//Declaro un arreglo temporal para hacer el cambio.

                        temp[l] = array[h];//paso la posicion mas alta, a la posicion mas baja del arreglo temporal.
                        array[h] = array[l];//paso la posicion mas baja, a la posicion mas alta del arreglo.
                        array[l] = temp[l]; //paso la posicion mas baja del arreglo temporal, a la posicion mas baja del arreglo a ordenar.
                    }
                }
            }
            //Llamo el metodo que imprime el arrelgo ordenado.
            PrintArrayElements(array);

        }
        public static void InvalidOption()//validaciones
        {
            Console.Write("Opcion invalidad.\nPresiona <Enter> para volver atras...");
            Console.Read();
            DisplayMenu();
        }
        public static void PrintArrayElements(int[] array)//Imprime el arreglo ordenado Decendentemente
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Orden Decendente del arreglo: {array[i]}");
            }          
        }
    }
}
