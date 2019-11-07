using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Agregamos la libreria para el usar el Path

namespace Autenticacion
{
    public class Registro
    {
        Usuario U = new Usuario(); //Instanciando la Clase Usuario como "U"

        public void RegistrarUsuario(Usuario U, string Path) //Metodo para registrarnos
        {
            Console.WriteLine("Ingrese Nombre:");
            U.Nombre = Console.ReadLine(); //Le pedimos al Usuario que ingrese el Nombre

            Console.WriteLine("");

            Console.WriteLine("Ingrese Usuario:");
            U.Username = Console.ReadLine(); //Le pedimos al Usuario que ingrese su nombre de Usuario

            Console.WriteLine("");

            Console.WriteLine("Ingrese Contraseña:");
            U.Password = Console.ReadLine(); //Le pedimos al usuario que ingrese la contraseña que va a utilizar

            Console.Clear(); //Limpio la Consola

            string data = U.Nombre + "," + U.Username + "," + U.Password; //Le asignamos a la variable "data" nuestra cuenta
            var datos = ObtenerLineas(Path); //Le asignamos a la variable "datos" el metodo "ObtenerLineas(Path)"

            if (datos != null) //If para guardar las lineas que se vayan creando
            {
                datos.Add(data);
                File.WriteAllLines(Path, datos);
            }
            else
            {
                File.WriteAllText(Path, data);
            }
        }

        public List<string> ObtenerLineas(string ruta) //Metodo para obtener las listas dependiendo las lineas
        {
            string[] data = null;

            if (File.Exists(ruta)) //Condicion para saber si nuestra cuenta existe en el archivo
            {
                data = File.ReadAllLines(ruta);
            }
            else
            {
                Console.WriteLine("Archivo no Existente");

                return null;
            }

            List<string> datos = new List<string>(); //Metodo pra que las lienas sean las que ingrese el Usuario

            foreach (var item in data)
            {
                datos.Add(item);
            }

            return datos;
        }   
    }
}

