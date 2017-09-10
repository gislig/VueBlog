﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using VueBlog.Models;

namespace VueBlog.Migrations
{
    [DbContext(typeof(VueBlogContext))]
    partial class VueBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VueBlog.Models.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Blog_Name")
                        .IsRequired();

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("VueBlog.Models.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogID");

                    b.Property<string>("Post_Content")
                        .IsRequired();

                    b.Property<string>("Post_Title")
                        .IsRequired();

                    b.HasKey("PostID");

                    b.HasIndex("BlogID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("VueBlog.Models.Post", b =>
                {
                    b.HasOne("VueBlog.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
