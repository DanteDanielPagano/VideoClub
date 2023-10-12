namespace VideoClub.Repository.EFCore.Configurations
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("actores");

            builder.HasKey(a => a.Id); // Clave primaria.

            builder.Property(a => a.Id)
                .IsRequired()
                .HasColumnName("idactor") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("idactor");// Indica que es una columna de identidad en MySQL.

            builder.Property(a => a.NombreActor)
                .HasColumnName("nombreactor") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") //Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
