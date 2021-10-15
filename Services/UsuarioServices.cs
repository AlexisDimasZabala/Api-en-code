using Api_en_code.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api_en_code.Services
{
    public class UsuarioServices
    {
        static List<Usuario> usuarios { get; }
        static UsuarioServices()
        {
            usuarios = new List<Usuario>
            {
                new Usuario {
                    Nombre = "doctor",
                    Contra = "123456"
                    },
                new Usuario {
                    Nombre = "Juan_pedro",
                    Contra = "juan123"
                    },
                new Usuario {
                    Nombre = "Maria_Tulin",
                    Contra = "maria123",
                    },
                new Usuario {
                    Nombre = "Daiana_Fordi",
                    Contra = "daiana123",
                    },
                new Usuario {
                    Nombre = "admin",
                    Contra = "admin123",
                    }
            };
        }

        //public static List<Usuario> GetAll() => usuarios;  //devuelve los usuarios hacia el controller

        public static Usuario Get(string nombre, string contra ) 
        => usuarios.FirstOrDefault(p => p.Nombre == nombre && p.Contra == contra);
    }
}