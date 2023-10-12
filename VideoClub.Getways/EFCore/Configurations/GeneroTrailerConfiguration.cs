

namespace VideoClub.Repository.EFCore.Configurations
{
    public class GeneroTrailerConfiguration : IEntityTypeConfiguration<GeneroTrailer>
    {
        public void Configure(EntityTypeBuilder<GeneroTrailer> builder)
        {
            // Nombre de la tabla en la base de datos MySQL.
            builder.ToTable("generotrailer");

            // Configuración de la clave primaria compuesta.
            builder.HasKey(gt => new { gt.IdCatalogo, gt.IdGenero });

            // Configuración de la clave foránea a la tabla 'generos'.
            builder.HasOne(gt => gt.Genero)
                .WithMany(g => g.GeneroTrailers)
                .HasForeignKey(gt => gt.IdGenero);

            // Configuración de la clave foránea a la tabla 'catalogo'.
            builder.HasOne(gt => gt.Catalogo)
                .WithMany(c => c.GeneroTrailers)
                .HasForeignKey(gt => gt.IdCatalogo);
        }
    }

}
