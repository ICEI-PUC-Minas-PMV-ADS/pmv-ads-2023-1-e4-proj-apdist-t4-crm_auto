using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using CRMobil.Entities.Clientes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMobil.DATA.Entity.ModelConfiguration;

public class ClienteConfiguration : IEntityTypeConfiguration<Clientes>
{
    public void Configure(EntityTypeBuilder<Clientes> builder)
    {
        builder.ToTable("CLIENTE");
        builder.Property(c => c.IdCliente).HasColumnName("ID_CLIENTE").HasColumnType("int").IsRequired();
        builder.Property(c => c.CnpjCpf).HasColumnName("CNPJ_CPF").HasColumnType("varchar").IsRequired().HasMaxLength(14);
        builder.Property(c => c.CnpjOuCpf).HasColumnName("CNPJ_OU_CPF").HasColumnType("char").HasMaxLength(1);
        builder.Property(c => c.Apelido).HasColumnName("APELIDO").HasColumnType("varchar").HasMaxLength(15);
        builder.Property(c => c.DataNascimento).HasColumnName("DATA_NASCIMENTO").HasColumnType("date");
        builder.Property(c => c.DataCadastro).HasColumnName("DATA_CADASTRO").HasColumnType("datetime");
        builder.Property(c => c.IdUsuario).HasColumnName("ID_USUARIO_CAD").HasColumnType("int");
        builder.Property(c => c.EmailNf).HasColumnName("EMAIL_NF").HasColumnType("varchar").HasMaxLength(255);
        builder.Property(c => c.Cep).HasColumnName("CEP").HasColumnType("char").HasMaxLength(8);
        builder.Property(c => c.Logradouro).HasColumnName("LOGRADOURO").HasColumnType("varchar").HasMaxLength(80);
        builder.Property(c => c.Numero).HasColumnName("NUMERO").HasColumnType("varchar").HasMaxLength(6);
        builder.Property(c => c.Complemento).HasColumnName("COMPLEMENTO").HasColumnType("varchar").HasMaxLength(30);
        builder.Property(c => c.Bairro).HasColumnName("BAIRRO").HasColumnType("varchar").HasMaxLength(40);
        builder.Property(c => c.Cidade).HasColumnName("CIDADE").HasColumnType("varchar").HasMaxLength(50);
        builder.Property(c => c.Telefone).HasColumnName("TELEFONE").HasColumnType("varchar").HasMaxLength(11);
        builder.Property(c => c.Celular).HasColumnName("CELULAR").HasColumnType("varchar").HasMaxLength(11);
        builder.Property(c => c.Estado).HasColumnName("ESTADO").HasColumnType("char").HasMaxLength(2);
        builder.Property(c => c.Excluido).HasColumnName("EXCLUIDO").HasColumnType("bit");
    }
}
