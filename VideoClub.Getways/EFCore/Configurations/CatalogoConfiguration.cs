namespace VideoClub.Repository.EFCore.Configurations
{
    public class CatalogoConfiguration : IEntityTypeConfiguration<Catalogo>
    {
        public void Configure(EntityTypeBuilder<Catalogo> builder)
        {
            builder.ToTable("catalogo");

            builder.HasKey(c => c.Id); // Clave primaria.

            builder.Property(c => c.Id)
                .IsRequired()
                // Nombre de la columna en la base de datos MySQL.
                .HasColumnName("idcatalogo")
                //Indica el tipo de dato de la columna en MySql.
                .HasColumnType("int")
                // Indica que es una columna de identidad en MySQL.
                .UseMySQLAutoIncrementColumn("idcatalogo");

            builder.Property(c => c.Poster)
                .IsRequired()
                .HasColumnName("poster")
                .HasColumnType("varchar")
                .HasMaxLength(30);

            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasColumnName("titulo")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(c => c.IdCategoria)
                .IsRequired()
                .HasColumnName("idcategoria")
                .HasColumnType("int");

            builder.Property(c => c.Resumen)
                .IsRequired()
                .HasColumnName("resumen")
                .HasColumnType("longtext");

            builder.Property(c => c.Temporadas)
                .HasColumnName("temoradas")
                .HasColumnType("int");

            builder.Property(c => c.EnlaceTrailer)
                .HasColumnName("trailer")
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.HasOne(c => c.Categoria)
                .WithMany(cat => cat.Catalogos)
                .HasForeignKey(c => c.IdCategoria);

            builder.HasMany(c => c.GeneroTrailers)
                .WithOne(gt => gt.Catalogo)
                .HasForeignKey(gt => gt.IdCatalogo);

            builder.HasMany(c => c.Repartos)
                .WithOne(r => r.Catalogo)
                .HasForeignKey(r => r.IdTrailer);
        }
    }
}
