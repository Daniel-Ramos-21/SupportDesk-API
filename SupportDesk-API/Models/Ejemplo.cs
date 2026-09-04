using Microsoft.EntityFrameworkCore.Design;
namespace SupportDesk_API.Models
{
    public class Ejemplo
    {
        public int Id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}
