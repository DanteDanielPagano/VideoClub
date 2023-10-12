namespace VideoClub.Repository.EFCore.Configurations
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("generos");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired()
                .UseMySQLAutoIncrementColumn("idgenero")
                .HasColumnName("idgenero")
                .HasColumnType("int");

            builder.Property(c => c.NombreGenero)
                .IsRequired()
                .HasColumnName("genero")
                .HasColumnType("varchar")
                .HasMaxLength(45);
        }
    }
}
