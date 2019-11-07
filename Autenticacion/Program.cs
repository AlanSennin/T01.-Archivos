using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Agregamos la libreria para usar el Path

namespace Autenticacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario U = new Usuario(); //Instanciando la Clase Usuario como "U"
            Registro R = new Registro(); //Instanciando la Clase Registro como "R"
            LogIn L = new LogIn(); //Instanciando la Clase LogIn como "L"

            Menu(); //Mando a llamar el Menu...

            void Menu() //Menu para la seleccion de opciones
            {
                Console.WriteLine("Ingrese una Opcion...");
                Console.WriteLine("");
                Console.WriteLine("(1) Registrarse");
                Console.WriteLine("(2) Ingresar");
                Console.WriteLine("(3) Salir");
                Console.WriteLine("");

                switch (Console.ReadLine()) //Switch para mandar a llamar el metodo requerido...
                {
                    case "1":
                        Console.Clear(); //Limpio la Consola
                        R.RegistrarUsuario(U, "C:/Users/Alan García/Desktop/Archivo.txt"); //Mando a llamar el Metodo para Registrar el usuario de la clase Registro
                        Console.Clear(); //Limpio la Consola
                        Menu(); //Acabndo regresa al menu...
                        break;

                    case "2":
                        Console.Clear(); //Limpio la Consola
                        L.IngresarDatos(); //Mando a llamar el metodo para ingresar los datos del usuario de la clase Log In
                        Console.Clear(); //Limpio la Consola
                        Menu(); //Acabando regresa al menu...
                        break;

                    case "3":
                        System.Environment.Exit(-1); //Comando para cerrar el programa
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion valida..."); //Mensaje de que ingresaste un valor incorrecto
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
