﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkerApp.Model;

#nullable disable

namespace WorkerApp.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240111090525_Requared")]
    partial class Requared
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WorkerApp.Model.Calisan", b =>
                {
                    b.Property<int>("CalisanNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Çalışan No");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalisanNo"));

                    b.Property<string>("CalisanAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Çalışan Adı");

                    b.Property<string>("CalisanSoyadi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Çalışan Soyadı");

                    b.Property<int?>("GecikenGorevSayisi")
                        .HasColumnType("int")
                        .HasColumnName("Geciken Görev Sayısı");

                    b.Property<int?>("TamamlananGorevSayisi")
                        .HasColumnType("int")
                        .HasColumnName("Tamamlanan Görev Sayısı");

                    b.HasKey("CalisanNo");

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("WorkerApp.Model.Gorev", b =>
                {
                    b.Property<int>("GorevNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Görev No");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GorevNo"));

                    b.Property<int>("AdamGunDegeri")
                        .HasColumnType("int")
                        .HasColumnName("Adam Gün Değeri");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("Başlangıç Tarihi");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("Bitiş Tarihi");

                    b.Property<int>("CalisanNo")
                        .HasColumnType("int")
                        .HasColumnName("Çalışan No");

                    b.Property<string>("Durum")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Durum");

                    b.Property<string>("GorevAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Görev Adı");

                    b.Property<int>("ProjeNo")
                        .HasColumnType("int")
                        .HasColumnName("Proje No");

                    b.HasKey("GorevNo");

                    b.HasIndex("ProjeNo");

                    b.ToTable("Gorevler");
                });

            modelBuilder.Entity("WorkerApp.Model.Proje", b =>
                {
                    b.Property<int>("ProjeNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Proje No");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjeNo"));

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("Başlangıç Tarihi");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2")
                        .HasColumnName("Bitiş Tarihi");

                    b.Property<int?>("GecikmeMiktari")
                        .HasColumnType("int")
                        .HasColumnName("Gecikme Miktarı");

                    b.Property<string>("ProjeAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Proje Adı");

                    b.HasKey("ProjeNo");

                    b.ToTable("Proje");
                });

            modelBuilder.Entity("WorkerApp.Model.ProjeCalisan", b =>
                {
                    b.Property<int>("ProjeNo")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("CalisanNo")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("ProjeNo", "CalisanNo");

                    b.HasIndex("CalisanNo");

                    b.ToTable("ProjeCalisan");
                });

            modelBuilder.Entity("WorkerApp.Model.Gorev", b =>
                {
                    b.HasOne("WorkerApp.Model.Proje", "Proje")
                        .WithMany("Gorevler")
                        .HasForeignKey("ProjeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proje");
                });

            modelBuilder.Entity("WorkerApp.Model.ProjeCalisan", b =>
                {
                    b.HasOne("WorkerApp.Model.Calisan", "Calisan")
                        .WithMany("ProjeCalisanlar")
                        .HasForeignKey("CalisanNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkerApp.Model.Proje", "Proje")
                        .WithMany("ProjeCalisanlar")
                        .HasForeignKey("ProjeNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Proje");
                });

            modelBuilder.Entity("WorkerApp.Model.Calisan", b =>
                {
                    b.Navigation("ProjeCalisanlar");
                });

            modelBuilder.Entity("WorkerApp.Model.Proje", b =>
                {
                    b.Navigation("Gorevler");

                    b.Navigation("ProjeCalisanlar");
                });
#pragma warning restore 612, 618
        }
    }
}
