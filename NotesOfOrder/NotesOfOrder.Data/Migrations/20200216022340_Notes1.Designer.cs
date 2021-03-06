﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotesOfOrder.Data;

namespace NotesOfOrder.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200216022340_Notes1")]
    partial class Notes1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotesOfOrder.Core.Entities.ExampleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExampleEntities");
                });

            modelBuilder.Entity("NotesOfOrder.Core.Entities.ExampleSubEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExampleEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExampleEntityId");

                    b.ToTable("ExampleSubEntities");
                });

            modelBuilder.Entity("NotesOfOrder.Core.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyGold")
                        .HasColumnType("int");

                    b.Property<int>("EndRatId")
                        .HasColumnType("int");

                    b.Property<int>("EndSeasonId")
                        .HasColumnType("int");

                    b.Property<int>("EndSunId")
                        .HasColumnType("int");

                    b.Property<int>("MapCoordinatesX")
                        .HasColumnType("int");

                    b.Property<int>("MapCoordinatesY")
                        .HasColumnType("int");

                    b.Property<string>("NoteText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartRatId")
                        .HasColumnType("int");

                    b.Property<int>("StartSeasonId")
                        .HasColumnType("int");

                    b.Property<int>("StartSunId")
                        .HasColumnType("int");

                    b.Property<string>("StorageLocale")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("NotesOfOrder.Core.Entities.ExampleSubEntity", b =>
                {
                    b.HasOne("NotesOfOrder.Core.Entities.ExampleEntity", "ExampleEntity")
                        .WithMany("ExampleSubEntities")
                        .HasForeignKey("ExampleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
