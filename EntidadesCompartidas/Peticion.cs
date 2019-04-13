using Newtonsoft.Json;
using System.Collections.Generic;

namespace EntidadesCompartidas
{
    public class Peticion
    {
        [JsonProperty("peticion")]
        public string peticion { get; set; }

        [JsonProperty("usuario")]
        public string usuario { get; set; }

        [JsonProperty("clave")]
        public string clave { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("datos")]
        public Dictionary<string, string> datos { get; set; }

    }
}
