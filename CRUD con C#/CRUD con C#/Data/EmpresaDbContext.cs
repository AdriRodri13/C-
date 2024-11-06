using Microsoft.EntityFrameworkCore;
using CRUD_con_C_.Models;

namespace CRUD_con_C_.Data
{
    public class EmpresaDbContext : DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options) : base(options) { }

        
        public DbSet<Empleado> Empleados { get; set; }
    }
}
