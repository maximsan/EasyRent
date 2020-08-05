﻿// <auto-generated />
using System;
using EasyRent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EasyRent.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200712184056_ChangeRelationAdImage")]
    partial class ChangeRelationAdImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EasyRent.Data.Entities.Ad", b =>
                {
                    b.Property<int>("AdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("IsGift")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MaxDays")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("AdId");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AdditionalInformation")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("City")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Country")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("AddressId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.BookmarkAd", b =>
                {
                    b.Property<int>("BookmarkAdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdId")
                        .HasColumnType("integer");

                    b.Property<int>("BookmarkListId")
                        .HasColumnType("integer");

                    b.HasKey("BookmarkAdId");

                    b.HasIndex("AdId");

                    b.HasIndex("BookmarkListId");

                    b.ToTable("BookmarkAds");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.BookmarkList", b =>
                {
                    b.Property<int>("BookmarkListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("BookmarkListId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("BookmarkLists");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Детские товары"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Техника и электроника"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Хобби и отдых"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Свадьба и праздники"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Автотовары"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Сад и огород"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Здоровье"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Спорт, туризм и активный отдых"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Ремонт и стройка"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Другое"
                        });
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("ImageId");

                    b.HasIndex("AdId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Subcategory", b =>
                {
                    b.Property<int>("SubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.HasKey("SubcategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            SubcategoryId = 1,
                            CategoryId = 1,
                            Name = "Мужская одежда"
                        },
                        new
                        {
                            SubcategoryId = 2,
                            CategoryId = 1,
                            Name = "Женская одежда"
                        },
                        new
                        {
                            SubcategoryId = 3,
                            CategoryId = 1,
                            Name = "Обувь"
                        },
                        new
                        {
                            SubcategoryId = 4,
                            CategoryId = 1,
                            Name = "Для мероприятий"
                        },
                        new
                        {
                            SubcategoryId = 5,
                            CategoryId = 1,
                            Name = "Аксессуары"
                        },
                        new
                        {
                            SubcategoryId = 6,
                            CategoryId = 1,
                            Name = "Другое"
                        },
                        new
                        {
                            SubcategoryId = 7,
                            CategoryId = 2,
                            Name = "Одежда"
                        },
                        new
                        {
                            SubcategoryId = 8,
                            CategoryId = 2,
                            Name = "Игрушки"
                        },
                        new
                        {
                            SubcategoryId = 9,
                            CategoryId = 2,
                            Name = "Транспорт и коляски"
                        },
                        new
                        {
                            SubcategoryId = 10,
                            CategoryId = 2,
                            Name = "Другое"
                        },
                        new
                        {
                            SubcategoryId = 11,
                            CategoryId = 3,
                            Name = "Бытовая техника"
                        },
                        new
                        {
                            SubcategoryId = 12,
                            CategoryId = 3,
                            Name = "Телефоны, планшеты, гаджеты"
                        },
                        new
                        {
                            SubcategoryId = 13,
                            CategoryId = 3,
                            Name = "Компьютерная техника"
                        },
                        new
                        {
                            SubcategoryId = 14,
                            CategoryId = 3,
                            Name = "Консоли"
                        },
                        new
                        {
                            SubcategoryId = 15,
                            CategoryId = 3,
                            Name = "Другое"
                        },
                        new
                        {
                            SubcategoryId = 16,
                            CategoryId = 3,
                            Name = "Компьютерные игры"
                        },
                        new
                        {
                            SubcategoryId = 17,
                            CategoryId = 3,
                            Name = "Настольные игры"
                        },
                        new
                        {
                            SubcategoryId = 18,
                            CategoryId = 3,
                            Name = "Музыкальные инструменты"
                        },
                        new
                        {
                            SubcategoryId = 19,
                            CategoryId = 3,
                            Name = "Книги и журналы"
                        },
                        new
                        {
                            SubcategoryId = 20,
                            CategoryId = 3,
                            Name = "Охота и рыбалка"
                        },
                        new
                        {
                            SubcategoryId = 21,
                            CategoryId = 3,
                            Name = "Другое"
                        },
                        new
                        {
                            SubcategoryId = 22,
                            CategoryId = 4,
                            Name = "Мебель"
                        },
                        new
                        {
                            SubcategoryId = 23,
                            CategoryId = 4,
                            Name = "Автомобили"
                        },
                        new
                        {
                            SubcategoryId = 24,
                            CategoryId = 4,
                            Name = "Мотоциклы, квадроциклы"
                        },
                        new
                        {
                            SubcategoryId = 25,
                            CategoryId = 4,
                            Name = "Инструмент"
                        },
                        new
                        {
                            SubcategoryId = 26,
                            CategoryId = 4,
                            Name = "Другое"
                        },
                        new
                        {
                            SubcategoryId = 27,
                            CategoryId = 5,
                            Name = "Тренажеры"
                        },
                        new
                        {
                            SubcategoryId = 28,
                            CategoryId = 5,
                            Name = "Другое"
                        },
                        new
                        {
                            SubcategoryId = 29,
                            CategoryId = 6,
                            Name = "Зимние спорттовары"
                        },
                        new
                        {
                            SubcategoryId = 30,
                            CategoryId = 6,
                            Name = "Летние спорттовары"
                        },
                        new
                        {
                            SubcategoryId = 31,
                            CategoryId = 6,
                            Name = "Всесезонные спорттовары"
                        },
                        new
                        {
                            SubcategoryId = 32,
                            CategoryId = 6,
                            Name = "Туристические товары"
                        },
                        new
                        {
                            SubcategoryId = 33,
                            CategoryId = 6,
                            Name = "Велотовары"
                        },
                        new
                        {
                            SubcategoryId = 34,
                            CategoryId = 6,
                            Name = "Туристические услуги"
                        },
                        new
                        {
                            SubcategoryId = 35,
                            CategoryId = 6,
                            Name = "Другое"
                        });
                });

            modelBuilder.Entity("EasyRent.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.UserAd", b =>
                {
                    b.Property<int>("UserAdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserAdId");

                    b.HasIndex("AdId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAds");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.UserContact", b =>
                {
                    b.Property<int>("UserContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContactId")
                        .HasColumnType("integer");

                    b.Property<string>("ContactValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserContactId");

                    b.HasIndex("ContactId");

                    b.HasIndex("UserId");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Address", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("EasyRent.Data.Entities.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRent.Data.Entities.BookmarkAd", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Ad", "Ad")
                        .WithMany()
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRent.Data.Entities.BookmarkList", "BookmarkList")
                        .WithMany("BookmarkAds")
                        .HasForeignKey("BookmarkListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRent.Data.Entities.BookmarkList", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.User", "User")
                        .WithOne("BookmarkList")
                        .HasForeignKey("EasyRent.Data.Entities.BookmarkList", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Image", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Ad", "Ad")
                        .WithMany("Images")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRent.Data.Entities.Subcategory", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRent.Data.Entities.UserAd", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Ad", "Ad")
                        .WithMany("UserAds")
                        .HasForeignKey("AdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRent.Data.Entities.User", "User")
                        .WithMany("UserAds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EasyRent.Data.Entities.UserContact", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Contact", "Contact")
                        .WithMany("UserContacts")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRent.Data.Entities.User", "User")
                        .WithMany("UserContacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyRent.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EasyRent.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}