namespace FreeTable.Models
{
    public class Restaurante :  IUsuario
    {
        public string? Cif { get; set; }
        public string? Gestor { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Description { get; set; }
        public int? CapacidadMax { get; set; }
        public string? JsonName { get; set; }

        public Restaurante() { }

        public Restaurante(string cif, string gestor, string nombre, string? correo, string? direccion, int? telefono, string? description, int? capacidadMax)
        {
            Cif = cif;
            Gestor = gestor;
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;
            Description = description;
            CapacidadMax = capacidadMax;
            AssingJsonName(nombre);
        }

        private void AssingJsonName(string jsonName)
        {
            this.JsonName = jsonName.ToLower().Trim();
        }
    }
}
