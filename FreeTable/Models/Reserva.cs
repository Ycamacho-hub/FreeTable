namespace FreeTable.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int NumPersonas { get; set; }
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int Status { get; set; }

        public Reserva() {
            
        }

    }
}
