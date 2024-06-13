namespace Caso_1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Pais { 
    
        public required int ID_Paises { get; set; }

        public required string Nombre_Pais { get; set; }
    }

    public class Pasajero
    {
        public int ID_Pasajero { get; set; }
        public required string Nombre_Pasajero { get; set; }
        public int ID_Pais { get; set; }
        public required string Pasaporte { get; set; }

    }

    
}
