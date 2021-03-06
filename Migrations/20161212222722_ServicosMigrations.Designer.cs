﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ManagerSalon.Models;

namespace managersalon.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20161212222722_ServicosMigrations")]
    partial class ServicosMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("ManagerSalon.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Numero");

                    b.Property<string>("Rg");

                    b.Property<string>("Rua");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ManagerSalon.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("ManagerSalon.Models.Servico", b =>
                {
                    b.HasOne("ManagerSalon.Models.Cliente", "Cliente")
                        .WithMany("Servicos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
