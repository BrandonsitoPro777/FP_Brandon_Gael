using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FPU3D_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar dos variables
            string nombreUsuario, primerApellidoUsuario, segundoApellidoUsuario, facebookUsuario, direccionUsuario, telefonoUsuario, contra, confirmContra;
            byte edadUsuario;
            int codigoAcceso;


            //Que el usuario ingrese por teclado los valores de las variabes
            Console.WriteLine("Ingresa solo tu nombre, despúes presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, despúes presiona ENTER");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //if
            if (edadUsuario > 18)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();

                Console.WriteLine("Ingresa tu primer apellido, despues presiona ENTER");
                primerApellidoUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu segundo apellido, despues presiona ENTER");
                segundoApellidoUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu direccion, despues presiona ENTER");
                direccionUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu número de telefono, despues presiona ENTER");
                telefonoUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu usuario de Facebook, despues presiona ENTER");
                facebookUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu contraseña, despues presiona ENTER");
                contra = Console.ReadLine();

                Console.WriteLine("Confirma tu contraseña, despues presiona ENTER");
                confirmContra = Console.ReadLine();

                if (contra == confirmContra)
                {//numero aleatorio


                    Random aleatorio = new Random();
                    codigoAcceso = aleatorio.Next(1000, 9999);
                    //codigoAcceso = aleatorio.ToString();

                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.SetWindowSize(120, 8);
                    Console.WriteLine("\t Información de registro");
                    Console.WriteLine("Nombre: {0}, Primer apellido: {1}, Segundo apellido: {2}, " +
                        "Facebook: {3}, Dirección: {4}, Telefono: {5}, Contraseña: {6}, " +
                        "Confirmación de la contraseña: {7}, Edad usuario: {8}, " +
                        "Código de acceso: {9}",
                        nombreUsuario, primerApellidoUsuario, segundoApellidoUsuario, facebookUsuario, direccionUsuario, telefonoUsuario,
                        contra, confirmContra, edadUsuario, codigoAcceso);
                    Console.ReadKey();
                }



                //Apellido, direccióm, telefono celular, perfil de facebook, usuario acceso, contraseña.
            }
            else
            {
                Console.WriteLine("No podemos validar tu acceso, debes ser mayor de edad");
            }




            // tarea :v imprimir los datos y el codigo de acceso (en otra consola)





            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(800);
            Console.WriteLine("Saliendo del sistema....");
            Thread.Sleep(800);

        }
    }
}