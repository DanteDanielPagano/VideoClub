namespace VideoClub.Repository.EFCore.Configurations
{

    public class RepartoConfiguration : IEntityTypeConfiguration<Reparto>
    {
        public void Configure(EntityTypeBuilder<Reparto> builder)
        {
            builder.ToTable("reparto"); // Nombre de la tabla en la base de datos.

            // Configuración de la clave primaria compuesta.
            builder.HasKey(r => new { r.IdTrailer, r.IdActor });

            // Configuración de las propiedades.
            builder.Property(r => r.IdTrailer)
                .IsRequired()
                .HasColumnName("idtrailer")
                .HasColumnType("int");

            builder.Property(r => r.IdActor)
                .IsRequired()
                .HasColumnName("idactor")
                .HasColumnType("int");

            // Configuración de las claves foráneas.
            builder.HasOne(r => r.Catalogo)
                .WithMany(c => c.Repartos)
                .HasForeignKey(r => r.IdTrailer);

            builder.HasOne(r => r.Actor)
                .WithMany(a => a.Reparto)
                .HasForeignKey(r => r.IdActor);
        }
    }

}
