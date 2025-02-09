﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MudDb.Data;

#nullable disable

namespace MudDb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("A_ChestMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("B_SeatMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("C_WaistMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("D_TrouserMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("E_F_HalfBackMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("E_I_SleeveLengthTwoPieceMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("G_H_BackNeckToWaistMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("G_I_SyceDepthMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("I_L_SleeveLengthOnePieceMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("N_InsideLegMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("P_Q_BodyRiseMeasurement")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("R_CloseWristMeasurement")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
