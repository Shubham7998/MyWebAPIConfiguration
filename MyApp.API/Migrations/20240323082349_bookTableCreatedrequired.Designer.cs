﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Data;

#nullable disable

namespace MyApp.API.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20240323082349_bookTableCreatedrequired")]
    partial class bookTableCreatedrequired
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Model.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("AuthorId");

                    b.HasIndex("AuthorEmail")
                        .IsUnique();

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MyApp.Model.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("BookDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Booktitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MyApp.Model.Book", b =>
                {
                    b.HasOne("MyApp.Model.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("MyApp.Model.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
