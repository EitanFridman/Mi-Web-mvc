using System.Collections.Generic;

namespace TP_Mi_Web_Personal_AGUSTIN_DE_MARCO.Models
{
    public static class Datos
    {
        public static string Nombre = "Eitán Fridman";
        public static string Titulo = "Programador Web Full Stack";
        public static string SobreMi = "Soy Eitán Fridman, estudiante de la escuela ORT en la especialidad de informática. Me encanta jugar al básquet y soy hincha fanático de Boca Juniors. Además de la tecnología, siempre me engancho en algún proyecto nuevo, y cuando no estoy en eso, seguro me encontrás en la cancha o hablando de la última jugada polémica del partido.";

        public static List<Proyecto> Proyectos = new List<Proyecto>
        {
            new Proyecto
            {
                Titulo = "Proyecto 1",
                Descripcion = "Un vistazo al último proyecto en el que elaboré junto a mi compañero una página web de turismo en Bulgaria para conocer todas sus atracciones e historia como para contactarse en busca de reservas de hoteles.",
                ImagenUrl = "img/bandera.png",
                Link = "https://turismoenbulgaria.netlify.app/"
            },
            new Proyecto
            {
                Titulo = "Proyecto 2",
                Descripcion = "Proximamente",
                ImagenUrl = "img/signoDeRecarga.jpg",
                Link = ""
            },
            new Proyecto
            {
                Titulo = "Proyecto 3",
                Descripcion = "Proximamente",
                ImagenUrl = "img/signoDeRecarga.jpg",
                Link = ""
            }
        };

        public static List<Certificado> Certificados = new List<Certificado>
        {
            new Certificado
            {
                Titulo = "HTML Y CSS",
                Institucion = "Openbootcamp"
            },
            new Certificado
            {
                Titulo = "Javascript",
                Institucion = "Soy Dalto Youtube"
            },
            new Certificado
            {
                Titulo = "Php y MySQL",
                Institucion = "Bluuweb Youtube"
            }
        };

        public static List<Idioma> Idiomas = new List<Idioma>
        {
            new Idioma
            {
                Nombre = "Español",
                Nivel = "Nivel Nativo"
            },
            new Idioma
            {
                Nombre = "Inglés",
                Nivel = "Nivel B2"
            },
            new Idioma
            {
                Nombre = "Hebreo",
                Nivel = "Nivel Básico"
            }
        };
    }

    public class Proyecto
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public string Link { get; set; }
    }

    public class Certificado
    {
        public string Titulo { get; set; }
        public string Institucion { get; set; }
    }

    public class Idioma
    {
        public string Nombre { get; set; }
        public string Nivel { get; set; }
    }
}