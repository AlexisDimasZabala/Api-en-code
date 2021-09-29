using Api_en_code.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonaServices.Services
{
    public static class PersonaServices
    {
        static List<Persona> personas { get; }
        static int nextId = 10;
        static PersonaServices()
        {
            personas = new List<Persona>
            {
                new Persona {
                    Id = 1,
                    Nombre = "Juan pedro",
                    Email = "Juan@gmail.com",
                    Domicilio = "J.Pedro 7569",
                    Telefono = "0000000001",
                    Activo = true
                    },

                new Persona {
                    Id = 2,
                    Nombre = "Maria Tulin",
                    Email = "Maria@gmail.com",
                    Domicilio = "Gaich 1151",
                    Telefono = "0000000002",
                    Activo = true
                    },

                new Persona {
                    Id = 3,
                    Nombre = "Fede Garcia",
                    Email = "Fede@gmail.com",
                    Domicilio = "Moreno 849",
                    Telefono = "0000000003",
                    Activo = true
                    },

                new Persona{
                    Id = 4,
                    Nombre = "Mario Huck",
                    Email = "Huck@gmail.com",
                    Domicilio = "Gonzales 4555",
                    Telefono = "0000000004",
                    Activo = true
                    },

                new Persona{
                    Id = 5,
                    Nombre = "Daiana Fordi",
                    Email = "Dai@gmail.com",
                    Domicilio = "Gonzales 2560",
                    Telefono = "0000000005",
                    Activo = true
                    },

                new Persona{
                    Id = 6,
                    Nombre = "Lucas Older",
                    Email = "LucOld@gmail.com",
                    Domicilio = "Huncal 455",
                    Telefono = "0000000006",
                    Activo = true
                    },

                new Persona{
                    Id = 7,
                    Nombre = "Gaston Muchit",
                    Email = "Gasti@gmail.com",
                    Domicilio = "Torres 878",
                    Telefono = "0000000007",
                    Activo = true
                },
                new Persona { 
                    Id = 8,
                    Nombre = "diams",
                    Email = "diams@gmail.com",
                    Domicilio = "ljuan 7569",
                    Telefono = "0000000008",
                    Activo = true
                    },
                new Persona { 
                    Id = 9,
                    Nombre = "Juan pedro",
                    Email = "Juan@gmail.com",
                    Domicilio = "J.Pedro 7569",
                    Telefono = "0000000009",
                    Activo = true
                    }
            };
        }

        public static List<Persona> GetAll() => personas;

        public static Persona Get(int id) => personas.FirstOrDefault(p => p.Id == id);

        public static void Add(Persona persona)
        {
            persona.Id = nextId++;
            personas.Add(persona);
        }

        public static void Delete(int id)
        {
            var persona = Get(id);
            if(persona is null)
                return;

            personas.Remove(persona);
        }

        public static void Update(Persona persona)
        {
            var index = personas.FindIndex(p => p.Id == persona.Id);
            if(index == -1)
                return;

            personas[index] = persona;
        }
    }
}