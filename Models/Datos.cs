using System.Collections.Generic;

namespace Mi_Web_mvc.Models
{
    public static class Datos
    {
        public static string Nombre = "Eitán Fridman";
        public static string Titulo = "Programador Web Full Stack";
        public static string SobreMi = "Soy Eitán Fridman, estudiante de la escuela ORT en la especialidad de informática. Me encanta jugar al básquet y soy hincha fanático de Boca Juniors. Además de la tecnología, siempre me engancho en algún proyecto nuevo, y cuando no estoy en eso, seguro me encontrás en la cancha o hablando de la última jugada polémica del partido. Me gusta mucho viajar y conocer otros paises y culturas aunque mi pais favorito simpre va a ser Argentina. Una habilidad un poco inutil pero que aun asi me gusta es que me se todas las banderas de paises del mundo, tambien tengo otras como poder imitar el sonido de una gota o armar el cubo de rubik pero en mi opinion son menos divertidas.";

        public static List<Proyecto> Proyectos = new List<Proyecto>
        {
            new Proyecto
            {
                Titulo = "Proyecto 1",
                Descripcion = "Este es un proyecto que hice para facilitar la informacion de Bulgaria.",
                ImagenUrl = "/img/bandera.png",
                Link = "https://turismoenbulgaria.netlify.app/"
            },
            new Proyecto
            {
                Titulo = "Proyecto 2",
                Descripcion = "Este proyecto son 2 navbars que se pueden usar de base para cualquier trabajo",
                ImagenUrl = "/img/pc.png",
                Link = "https://navbars-eitan-fridman.netlify.app/"
            },
            new Proyecto
            {
                Titulo = "Proyecto 3",
                Descripcion = "Esta es mi pequeña marca de ropa que ultimamente se puso de moda",
                ImagenUrl = "/img/nike.jpg",
                Link = "https://www.nike.com.ar/"
            },
            new Proyecto
            {
                Titulo = "Proyecto 4",
                Descripcion = "Proximamente",
                ImagenUrl = "/img/signoDeRecarga.jpg",
                Link = ""
            },
            new Proyecto
            {
                Titulo = "Proyecto 5",
                Descripcion = "Proximamente",
                ImagenUrl = "/img/signoDeRecarga.jpg",
                Link = ""
            }
        };

        public static List<Certificado> Certificados = new List<Certificado>
        {
            new Certificado
            {
                Institucion = "Macabi",
                Titulo = "Madrij",
                Descripcion = "Curso de lideres."
            },
            new Certificado
            {
                Institucion = "Universidad de Cambridge",
                Titulo = "First Certificate",
                Descripcion = "Certificado de nivel B2 ingles."
            },
            new Certificado
            {
                Institucion = "Universidad de Cambridge",
                Titulo = "First Certificate",
                Descripcion = "Certificado de nivel B2 ingles."
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
        public string Descripcion { get; set; }
    }

    public class Idioma
    {
        public string Nombre { get; set; }
        public string Nivel { get; set; }
    }
}