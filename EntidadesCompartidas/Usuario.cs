
using System.Collections.Generic;

namespace EntidadesCompartidas
{
    public class Usuario
    {
        //public string nombre { get; set; }
        //public string pass { get; set; }
        //public string token { get; set; }
        //public Dictionary<int, string> coleccion { get; set; }
        private string id;
        private string user;
        private string email;
        private string nombre;
        private string apellidos;
        private string credenciales;
        public Usuario() { }
        public Usuario(string id, string usuario, string email, string nombre, string apellidos, string credenciales)
        {
            this.id = id;
            this.user = usuario;
            this.email = email;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.credenciales = credenciales;
        }
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Credenciales
        {
            get
            {
                return credenciales;
            }

            set
            {
                credenciales = value;
            }
        }
    }
}
