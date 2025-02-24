namespace FreeTable.Models
{
    public class Restaurante :  IUsuario
    {
        private string? Cif { get; set; }
        private string? Gestor { get; set; }
        private string? Nombre { get; set; }
        private string? Correo { get; set; }
        private string? Direccion { get; set; }
        private int? Telefono { get; set; }
        private string? Description { get; set; }
        private int? CapacidadMax { get; set; }
        private string? JsonName { get; set; }

        public Restaurante() { }

        public Restaurante(string? cif, string? gestor, string? nombre, string? correo, string? direccion, int? telefono, string? description, int? capacidadMax, string? jsonName)
        {
            Cif = cif;
            Gestor = gestor;
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;
            Description = description;
            CapacidadMax = capacidadMax;
            JsonName = jsonName;
        }
    }
}
