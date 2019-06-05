
namespace EntidadesCompartidas
{

    public class Enlaces
    {
        private string Id;
        private string Link;
        private string Titulo;
        private string Descripcion;
        private string Valoracion;
        private string Imagen;
        private string Tipo;
        private string Tema;
        private string Uploader;
        private string Activo;
        private bool Like;
        private bool DontLike;
        private int ReportarFallo;
        private string Asignatura;

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
        public string id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string link
        {
            get
            {
                return Link;
            }

            set
            {
                Link = value;
            }
        }

        public string titulo
        {
            get
            {
                return Titulo;
            }

            set
            {
                Titulo = value;
            }
        }

        public string descripcion
        {
            get
            {
                return Descripcion;
            }

            set
            {
                Descripcion = value;
            }
        }

        public string valoracion
        {
            get
            {
                return Valoracion;
            }

            set
            {
                Valoracion = value;
            }
        }

        public string imagen
        {
            get
            {
                return Imagen;
            }

            set
            {
                Imagen = value;
            }
        }

        public string tipo
        {
            get
            {
                return Tipo;
            }

            set
            {
                Tipo = value;
            }
        }

        public string tema
        {
            get
            {
                return Tema;
            }

            set
            {
                Tema = value;
            }
        }

        public string uploader
        {
            get
            {
                return Uploader;
            }

            set
            {
                Uploader = value;
            }
        }

        public string activo
        {
            get
            {
                return Activo;
            }

            set
            {
                Activo = value;
            }
        }

        public bool like
        {
            get
            {
                return Like;
            }

            set
            {
                Like = value;
            }
        }

        public bool dontLike
        {
            get
            {
                return DontLike;
            }

            set
            {
                DontLike = value;
            }
        }

        public int reportarFallo
        {
            get
            {
                return ReportarFallo;
            }

            set
            {
                ReportarFallo = value;
            }
        }

        public string asignatura
        {
            get
            {
                return Asignatura;
            }

            set
            {
                Asignatura = value;
            }
        }
    }
}
