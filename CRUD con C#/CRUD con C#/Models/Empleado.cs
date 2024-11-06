using System.ComponentModel.DataAnnotations;


namespace CRUD_con_C_.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre del empleado es necesario")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de email no válido.")]
        [StringLength(100, ErrorMessage = "El email no puede exceder los 100 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El puesto es obligatorio.")]
        [StringLength(50, ErrorMessage = "El puesto no puede exceder los 50 caracteres.")]
        public string Puesto { get; set; }

        [Required(ErrorMessage = "El sueldo es obligatorio.")]
        [Range(0, 999999.99, ErrorMessage = "El sueldo debe estar entre 0 y 999999.99.")]
        public decimal Sueldo { get; set; }
    }
}
