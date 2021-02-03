﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Models;

namespace backend.Migrations
{
    [DbContext(typeof(CardsContext))]
    [Migration("20210202181328_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("backend.Models.FlashCard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Answer")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Answer");

                    b.Property<string>("Question")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Question");

                    b.Property<int?>("TopicID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TopicID");

                    b.ToTable("FlashCards");
                });

            modelBuilder.Entity("backend.Models.LearningTopic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("TopicName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.HasKey("ID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("backend.Models.FlashCard", b =>
                {
                    b.HasOne("backend.Models.LearningTopic", "Topic")
                        .WithMany("kartice")
                        .HasForeignKey("TopicID");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("backend.Models.LearningTopic", b =>
                {
                    b.Navigation("kartice");
                });
#pragma warning restore 612, 618
        }
    }
}