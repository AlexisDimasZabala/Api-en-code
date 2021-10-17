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
                    Nombre = "Juan_gomez",
                    Contra = "juan123"
                    },
                new Usuario {
                    Nombre = "Mario_hostinguer",
                    Contra = "mario123",
                    },
                new Usuario {
                    Nombre = "Lucas_longer",
                    Contra = "lucas123",
                    },
                new Usuario {
                    Nombre = "Sofia_zuler",
                    Contra = "sofia123",
                    },
                new Usuario {
                    Nombre = "Mirta_paez",
                    Contra = "mirta123",
                    },
                new Usuario {
                    Nombre = "Gillermina_alves",
                    Contra = "gillermina123",
                    },
                new Usuario {
                    Nombre = "Lautaro_torres",
                    Contra = "lautaro123",
                    },
                new Usuario {
                    Nombre = "Hugo_furres",
                    Contra = "hugo123",
                    },
                new Usuario {
                    Nombre = "Dimas_zabala",
                    Contra = "dimas123",
                    },
                new Usuario {
                    Nombre = "Soledad_ernandez",
                    Contra = "soledad123",
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