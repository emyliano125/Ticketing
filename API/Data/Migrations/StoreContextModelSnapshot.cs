﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("API.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descriere")
                        .HasColumnType("TEXT");

                    b.Property<int>("MyProperty")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Valid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataDeschidereTicket")
                        .HasColumnType("TEXT");

                    b.Property<string>("emailSolicitant")
                        .HasColumnType("TEXT");

                    b.Property<int>("idLucratorAsignat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idServiciuAsignat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idTipSolicitare")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idUnitateExpeditoare")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idUserExpeditor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tlfMobilSolicitant")
                        .HasColumnType("TEXT");

                    b.Property<string>("tlfnInteriorSolicitant")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}