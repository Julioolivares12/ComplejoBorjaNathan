using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace ComplejoBorjaNathan.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [StringLength(40)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
       
        public virtual Publicaciones Publicaciones { set; get; }
        public virtual Inscripciones Inscripciones { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Publicaciones> Publicaciones { get; set; }
        public DbSet<TipoPublicacion> TipoPublicacion { get; set; }
        public DbSet<Aulas> Aulas { get; set; }
        public DbSet<Materias> Mateias { get; set; }
        public DbSet<Archivos> Archivos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //crea las relaciones
            modelBuilder.Entity<Publicaciones>().HasRequired(x=>x.ApplicationUser);
            modelBuilder.Entity<Aulas>().HasRequired(x=>x.archivios);
            modelBuilder.Entity<Inscripciones>().HasRequired(x=>x.ApliacionUsers);
            modelBuilder.Entity<Inscripciones>().HasRequired(x=>x.Materias);
           
            
            base.OnModelCreating(modelBuilder);
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}