using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class LogIn
    {
        Registro R = new Registro(); //Instanciando la Clase Registro como "R"

        Usuario U = new Usuario(); //Instanciando la Clase Usuario como "U"

        public void IngresarDatos() //Metodo para ingresar los datos de nuestra cuenta
        {
            Console.WriteLine("Ingrese Usuario:");
            U.Username = Console.ReadLine(); //Le pedimos al usuario que ingrese el Nombre

            Console.WriteLine("");

            Console.WriteLine("Ingrese Contraseña:");
            U.Password = Console.ReadLine(); //Le pedimos al usuario que ingrese la Contraseña

            string Ruta = "C:/Users/Alan García/Desktop/Archivo.txt"; //A la variable Ruta le asignamos donde se guardara el archivo
            List<string> datos = R.ObtenerLineas(Ruta); //A la lista que creamos le asignamos el metodo "ObtenerLineas(Ruta);" de la clase Registro

            ValidarDatos(U, datos); //Mandamos llamar el metodo "ValidarDatos" con los parametros de U y Datos...
        }

        public void ValidarDatos(Usuario U, List<string> Datos) //Metodo para comprobar si estamos en el sistema
        {
            List<Usuario> Usuarios = new List<Usuario>(); //Instanciamos la lista del Usuario como "Usuarios"

            foreach (var item in Datos) //Foreach para ver si los datos estan dentro del archivo
            {
                string[] info = item.Split(',');

                Usuarios.Add(new Usuario { Nombre = info[0], Username = info[1], Password = info[2] });
            }

            foreach (var us in Usuarios) //Foreach por si estamos dentro, decirnos si fue un ingreso exitoso
            {
                if (U.Username == us.Username && U.Password == us.Password)
                {
                    Console.WriteLine("¡Ingreso Exitoso!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Error, ingrese de nuevo...");
                }
            }
        }
    }
}
