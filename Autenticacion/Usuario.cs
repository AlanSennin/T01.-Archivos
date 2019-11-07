using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    public class Usuario
    {
        public string Nombre { get; set; } //Encapsulando el atributo para el Nombre
        public string Username { get; set; } //Encapsulando el atributo para el Usuario
        public string Password { get; set; } //Encapsulando el atributo para la contraseña
    }
}
