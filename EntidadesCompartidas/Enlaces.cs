
namespace EntidadesCompartidas
{

    public class Enlaces
    {
        public string id;
        public string link;
        public string titulo;
        public string descripcion;
        public string valoracion;
        public string imagen;
        public string tipo;
        public string tema;
        public string uploader;
        public string activo;
        public bool like;
        public bool dontLike;
        public int reportarFallo;
        public string asignatura;

        public string Report { get; internal set; }

        public Enlaces()
        {
        }
        public Enlaces(string id, string link, string titulo, string descripcion, string valoracion, string imagen, string tipo, string tema, string uploader, string activo, string asignatura)
        {
            this.id = id;
            this.link = link;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.valoracion = valoracion;
            this.imagen = imagen;
            this.tipo = tipo;
            this.tema = tema;
            this.uploader = uploader;
            this.activo = activo;
            this.like = false;
            this.dontLike = false;
            this.asignatura = asignatura;
        }
    }
}
