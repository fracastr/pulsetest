using System;
namespace Test.Models
{
    public class Evento
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaEvento { get; set; }

        public string Descripcion { get; set; }
    }
}
