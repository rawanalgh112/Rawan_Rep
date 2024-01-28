﻿// <auto-generated />
using System;
using Interns_Gate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Interns_Gate.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231114093401_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Interns_Gate.Models.Clinical_case", b =>
                {
                    b.Property<int>("stuCase_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tooth_no")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("accept_date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("age_group")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("birth_date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("case_id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("citizenship")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("create_date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("depratment_id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("end_date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("evlaution_date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("health_category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("measurement_type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("patientcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("rot_id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("status_id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("stu_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sup_id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("tooth_num")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("stuCase_id");

                    b.ToTable("Clinical_case");
                });

            modelBuilder.Entity("Interns_Gate.Models.Clinical_status", b =>
                {
                    b.Property<string>("status_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("status_id");

                    b.ToTable("clinical_status");
                });

            modelBuilder.Entity("Interns_Gate.Models.Intern_cases", b =>
                {
                    b.Property<int>("Case_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Active")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AgeGroup")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Case_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Case_id");

                    b.ToTable("Intern_cases");
                });

            modelBuilder.Entity("Interns_Gate.Models.Quality", b =>
                {
                    b.Property<int>("Case_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("M_ID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Case_id");

                    b.ToTable("quality");
                });

            modelBuilder.Entity("Interns_Gate.Models.Quality_detials", b =>
                {
                    b.Property<int>("m_type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("M_ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("score")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("m_type", "M_ID");

                    b.ToTable("quality_detials");
                });

            modelBuilder.Entity("Interns_Gate.Models.Quantity", b =>
                {
                    b.Property<int>("Case_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("score")
                        .HasColumnType("TEXT");

                    b.HasKey("Case_id", "score");

                    b.ToTable("quantity");
                });

            modelBuilder.Entity("Interns_Gate.Models.Rotation", b =>
                {
                    b.Property<string>("rot_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("rot_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("rot_id");

                    b.ToTable("Rotation");
                });

            modelBuilder.Entity("Interns_Gate.Models.Supervisor_intern", b =>
                {
                    b.Property<string>("sup_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("sup_fullname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("sup_id");

                    b.ToTable("supervisor_intern");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
