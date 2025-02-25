﻿// <auto-generated />
using CrudTripTravel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudTripTravel.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudTripTravel.Models.NovaPasta.TBClientes", b =>
                {
                    b.Property<int>("id_clientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_clientes");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("CrudTripTravel.Models.NovaPasta.TBDestinos", b =>
                {
                    b.Property<int>("id_destinos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("local_destino")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_destinos");

                    b.ToTable("destinos");
                });

            modelBuilder.Entity("CrudTripTravel.Models.NovaPasta.TBPromocoes", b =>
                {
                    b.Property<int>("id_promocoes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_clientes")
                        .HasColumnType("int");

                    b.Property<int>("id_destinos")
                        .HasColumnType("int");

                    b.Property<string>("promocao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_promocoes");

                    b.HasIndex("id_clientes");

                    b.HasIndex("id_destinos");

                    b.ToTable("promocoes");
                });

            modelBuilder.Entity("CrudTripTravel.Models.NovaPasta.TBPromocoes", b =>
                {
                    b.HasOne("CrudTripTravel.Models.NovaPasta.TBClientes", "TBClientes")
                        .WithMany()
                        .HasForeignKey("id_clientes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrudTripTravel.Models.NovaPasta.TBDestinos", "TBDestinos")
                        .WithMany()
                        .HasForeignKey("id_destinos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
