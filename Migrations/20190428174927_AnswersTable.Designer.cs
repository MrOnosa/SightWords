﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SightwordsApi.DataModels;

namespace SightwordsApi.Migrations
{
    [DbContext(typeof(SightwordContext))]
    [Migration("20190428174927_AnswersTable")]
    partial class AnswersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SightwordsApi.DataModels.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AnsweredCorrectly");

                    b.Property<DateTime>("Date");

                    b.Property<int>("SightwordId");

                    b.HasKey("Id");

                    b.HasIndex("SightwordId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("SightwordsApi.DataModels.Sightword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Word");

                    b.HasKey("Id");

                    b.ToTable("Sightwords");
                });

            modelBuilder.Entity("SightwordsApi.DataModels.Answer", b =>
                {
                    b.HasOne("SightwordsApi.DataModels.Sightword", "Sightword")
                        .WithMany("Answers")
                        .HasForeignKey("SightwordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
