namespace VideoClub.Repository.EFCore.Configurations
{
    public class CateroriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categorias"); // Nombre de la tabla en la base de datos.

            builder.HasKey(c => c.Id); // Configuración de la clave primaria.

            // Configuración de la propiedad IdCategoria como clave primaria e identidad.
            builder.Property(c => c.Id)
                .IsRequired()
                .HasColumnName("idcategoria")
                .HasColumnType("int")
                .UseMySQLAutoIncrementColumn("idcategoria");

            // Configuración de la propiedad NombreCategoria.
            builder.Property(c => c.NombreCategoria)
                .IsRequired()
                .HasColumnName("categoria")
                .HasColumnType("varchar")
                .HasMaxLength(45);

            // Configuración de la relación con la entidad Catalogo (uno a muchos).
            builder.HasMany(c => c.Catalogos)
                .WithOne(cat => cat.Categoria)
                .HasForeignKey(cat => cat.IdCategoria);
        }
    }
}
