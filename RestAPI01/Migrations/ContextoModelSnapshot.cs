﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using RestAPI01.Data;
using System;

namespace RestAPI01.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("RestAPI01.Models.Prato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<int>("idrestaurante");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnName("NOME")
                        .HasMaxLength(255);

                    b.HasKey("id")
                        .HasName("PK");

                    b.ToTable("Prato");
                });

            modelBuilder.Entity("RestAPI01.Models.Restaurante", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnName("NOME")
                        .HasMaxLength(255);

                    b.HasKey("id")
                        .HasName("PK");

                    b.ToTable("Restaurante");
                });
#pragma warning restore 612, 618
        }
    }
}