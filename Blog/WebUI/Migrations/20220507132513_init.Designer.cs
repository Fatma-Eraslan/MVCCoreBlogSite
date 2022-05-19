﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebUI.Models.Entites;

namespace WebUI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220507132513_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticlesTopics", b =>
                {
                    b.Property<int>("ArticlesID")
                        .HasColumnType("int");

                    b.Property<int>("TopicsID")
                        .HasColumnType("int");

                    b.HasKey("ArticlesID", "TopicsID");

                    b.HasIndex("TopicsID");

                    b.ToTable("ArticlesTopics");
                });

            modelBuilder.Entity("TopicsUsers", b =>
                {
                    b.Property<int>("TopicsID")
                        .HasColumnType("int");

                    b.Property<int>("UsersID")
                        .HasColumnType("int");

                    b.HasKey("TopicsID", "UsersID");

                    b.HasIndex("UsersID");

                    b.ToTable("TopicsUsers");
                });

            modelBuilder.Entity("WebUI.Models.Entites.Articles", b =>
                {
                    b.Property<int>("ArticlesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ArticlesID");

                    b.HasIndex("UserID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("WebUI.Models.Entites.Topics", b =>
                {
                    b.Property<int>("TopicsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicsID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("WebUI.Models.Entites.UserDetail", b =>
                {
                    b.Property<int>("UserDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserDetailID");

                    b.HasIndex("UserID")
                        .IsUnique()
                        .HasFilter("[UserID] IS NOT NULL");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("WebUI.Models.Entites.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsersID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArticlesTopics", b =>
                {
                    b.HasOne("WebUI.Models.Entites.Articles", null)
                        .WithMany()
                        .HasForeignKey("ArticlesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebUI.Models.Entites.Topics", null)
                        .WithMany()
                        .HasForeignKey("TopicsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TopicsUsers", b =>
                {
                    b.HasOne("WebUI.Models.Entites.Topics", null)
                        .WithMany()
                        .HasForeignKey("TopicsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebUI.Models.Entites.Users", null)
                        .WithMany()
                        .HasForeignKey("UsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebUI.Models.Entites.Articles", b =>
                {
                    b.HasOne("WebUI.Models.Entites.Users", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebUI.Models.Entites.UserDetail", b =>
                {
                    b.HasOne("WebUI.Models.Entites.Users", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("WebUI.Models.Entites.UserDetail", "UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebUI.Models.Entites.Users", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("UserDetail");
                });
#pragma warning restore 612, 618
        }
    }
}