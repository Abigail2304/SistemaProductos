using System.ComponentModel.DataAnnotations;
namespace SistemaProductos.Models
{ 
    public class Producto { public int Id { get; set; } 
        [Required][StringLength(100)] public string Nombre { get; set; } = ""; 
        [StringLength(250)] public string? Descripcion { get; set; }
        [Required][Range(0.01, 999999)] public decimal Precio { get; set; } 
        [Required][Range(0, 1000000)] public int Stock { get; set; } } }
