
using System.Collections.Generic;

namespace EntidadesCompartidas
{
    class Usuario
    {
        public string nombre { get; set; }
        public string pass { get; set; }
        public string token { get; set; }
        public Dictionary<int, string> coleccion { get; set; }
    }
}
