﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projur.Infra.Contexts;

namespace Projur.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projur.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasMaxLength(160)
                        .HasColumnType("varchar(160)")
                        .HasColumnName("name");

                    b.Property<int>("Schooling")
                        .HasColumnType("int")
                        .HasColumnName("schooling");

                    b.Property<string>("Surname")
                        .HasMaxLength(160)
                        .HasColumnType("varchar(160)")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.ToTable("tb_user");
                });
#pragma warning restore 612, 618
        }
    }
}
