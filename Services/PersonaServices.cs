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
                new Persona{
                    Id=0,CodPaciente=6548,Nombre="Juan",Apellido="Gomez",Email = "Juan@gmail.com",
                    Edad=25,GrupoSanguineo="A+",Telefono="2954715682",Riesgo="Si",VacCovid="D1",
                    Domicilio="Jmarquez 412",Alcohol="Ocasional",Tabaco="Habitual",Drogas="Niega",
                    Infusiones="Ocasional",Respiratorio="Sin dato",Neurologico="sin dato",
                    Quirurgico="sin dato",Alergias="3 Alerg",Activo = true},
                new Persona {
                    Id = 1,CodPaciente = 6548,Nombre = "Mario",Apellido="Hostinguer",Email = "Mario@gmail.com",
                    Edad=28,GrupoSanguineo="AB+",Telefono="2954080201",Riesgo="No",VacCovid="D1",
                    Domicilio = "Huncal 962",Alcohol="Niega",Tabaco="Ocasional",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="1 Proc",Neurologico="1 Proc",
                    Quirurgico="2 Proc",Alergias="3 Alerg",Activo = true},
                new Persona {
                    Id = 2,CodPaciente = 6587,Nombre = "Lucas",Apellido="Longer",Email = "Lucas@gmail.com",
                    Edad=54,GrupoSanguineo="O-",Telefono="2954050701",Riesgo="Si",VacCovid="D1 D2",
                    Domicilio = "Robert 910",Alcohol="Ocasional",Tabaco="Niega",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="1 Proc",Neurologico="2 Proc",
                    Quirurgico="1 Proc",Alergias="3 Alerg",Activo = true},
                new Persona {
                    Id = 3,CodPaciente = 6598,Nombre = "Sofia",Apellido = "Zuler",Email = "Sofia@gmail.com",
                    Edad=42,GrupoSanguineo="A-",Telefono="2954030708",Riesgo="No",VacCovid="D1 D2",
                    Domicilio = "Vespert 276",Alcohol="Habitual",Tabaco="Niega",Drogas="Niega",
                    Infusiones="Ocasional",Respiratorio="sin dato",Neurologico="sin dato",
                    Quirurgico="1 Proc",Alergias="sin dato",Activo = true},
                new Persona{
                    Id = 4,CodPaciente = 6689,Nombre = "Mirta",Apellido="Paez" ,Email = "Mirta@gmail.com",
                    Edad=32,GrupoSanguineo="AB-",Telefono="2954508060",Riesgo="No",VacCovid="D1",
                    Domicilio = "Uruaguay 1054",Alcohol="Niega",Tabaco="Habitual",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="1 Proc",Neurologico="sin dato",
                    Quirurgico="sin dato",Alergias="2 Proc",Activo = true},
                new Persona{
                    Id = 5,CodPaciente = 6656,Nombre = "Gillermina",Apellido="Alvez" ,Email = "Gille@gmail.com",
                    Edad=19,GrupoSanguineo="B-",Telefono="2954817090",Riesgo="No",VacCovid="",
                    Domicilio = "Duar 25",Alcohol="Habitual",Tabaco="Habitual",Drogas="Ocasional",
                    Infusiones="Ocasional",Respiratorio="sin dato",Neurologico="sin dato",
                    Quirurgico="sin dato",Alergias="1 Alerg",Activo = true},
                new Persona{
                    Id = 6,CodPaciente = 6623,Nombre = "Lautaro", Apellido="Torres",Email = "Lau@gmail.com",
                    Edad=23,GrupoSanguineo="A+",Telefono="2954001133",Riesgo="Si",VacCovid="D1",
                    Domicilio = "LGan 73",Alcohol="Ocasional",Tabaco="Niega",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="sin dato",Neurologico="sin dato",
                    Quirurgico="sin dato",Alergias="4 Alerg",Activo = true},
                new Persona{
                    Id = 7,CodPaciente = 6521,Nombre = "Hugo", Apellido="Furres",Email = "hugo@gmail.com",
                    Edad=36,GrupoSanguineo="AB+",Telefono="2954889977",Riesgo="No",VacCovid="D1 D2",
                    Domicilio = "Bolivar 604",Alcohol="Habitual",Tabaco="Habitual",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="1 Proc",Neurologico="2 Proc",
                    Quirurgico="sin dato",Alergias="1 Alerg",Activo = true},
                new Persona { 
                    Id = 8,CodPaciente = 6512,Nombre = "dimas",Email = "dimas@gmail.com",
                    Edad=23,GrupoSanguineo="A+",Telefono="2954701325",Riesgo="No",VacCovid="D1 D2",
                    Domicilio = "Juana manso",Alcohol="Ocasional",Tabaco="Habitual",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="1 Proc",Neurologico="sin dato",
                    Quirurgico="sin dato",Alergias="1 Alerg",Activo = true},
                new Persona { 
                    Id = 9, CodPaciente = 6500,Nombre = "Soledad",Apellido="Ernandez",Email = "Juan@gmail.com",
                    Edad=35,GrupoSanguineo="B+",Telefono="2954010506",Riesgo="No",VacCovid="D1 D2",
                    Domicilio = "Huncal 962",Alcohol="Niega",Tabaco="Ocasional",Drogas="Niega",
                    Infusiones="Niega",Respiratorio="1 Proc",Neurologico="1 proc",
                    Quirurgico="sin dato",Alergias="sin dato",Activo = true}
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