namespace FreeTable.Models
{
    public class Restaurante :  IUsuario
    {
        public string? Cif;
        public Gestor? Gestor;
        public string? Nombre;
        public string? Correo;
        public string? Direccion;
        public int? Telefono;
        public string? Description;
        public int? CapacidadMax;

        public Restaurante() { }
    }
}
