﻿// <auto-generated />
using System;
using DabAflevering2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DabAflevering2.Migrations
{
    [DbContext(typeof(ResturentContext))]
    [Migration("20191111042108_shit")]
    partial class shit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DabAflevering2.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price");

                    b.Property<int>("ReviewId");

                    b.Property<string>("Type");

                    b.HasKey("DishId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Dish");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            Price = 44.0,
                            ReviewId = 1,
                            Type = "Spaghetti Carbonara"
                        },
                        new
                        {
                            DishId = 2,
                            Price = 75.0,
                            ReviewId = 2,
                            Type = "Pizza med rejer"
                        },
                        new
                        {
                            DishId = 3,
                            Price = 65.0,
                            ReviewId = 6,
                            Type = "Pizza Peperoni"
                        },
                        new
                        {
                            DishId = 4,
                            Price = 70.0,
                            ReviewId = 7,
                            Type = "Pizza Meatlover"
                        },
                        new
                        {
                            DishId = 5,
                            Price = 60.0,
                            ReviewId = 4,
                            Type = "Butter Chicken"
                        },
                        new
                        {
                            DishId = 6,
                            Price = 30.0,
                            ReviewId = 9,
                            Type = "Naan Broed med smoer"
                        },
                        new
                        {
                            DishId = 7,
                            Price = 40.0,
                            ReviewId = 10,
                            Type = "Tandoori Chicken - Spicy!"
                        },
                        new
                        {
                            DishId = 8,
                            Price = 20.0,
                            ReviewId = 11,
                            Type = "Smurt håndværker med pålæg"
                        },
                        new
                        {
                            DishId = 9,
                            Price = 5.0,
                            ReviewId = 12,
                            Type = "Sort kaffe uden mælk"
                        },
                        new
                        {
                            DishId = 10,
                            Price = 250.0,
                            ReviewId = 13,
                            Type = "Fri sushi"
                        },
                        new
                        {
                            DishId = 11,
                            Price = 120.0,
                            ReviewId = 14,
                            Type = "10 stk. valgfri sushi"
                        },
                        new
                        {
                            DishId = 12,
                            Price = 12.0,
                            ReviewId = 15,
                            Type = "fransk Hotdog"
                        },
                        new
                        {
                            DishId = 13,
                            Price = 25.0,
                            ReviewId = 16,
                            Type = "Flæskestegs Sandwich"
                        },
                        new
                        {
                            DishId = 14,
                            Price = 25.0,
                            ReviewId = 17,
                            Type = "Rugbrøds Sandwich"
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.GuestDishes", b =>
                {
                    b.Property<int>("DishId");

                    b.Property<int>("PersonId");

                    b.HasKey("DishId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("GuestDishes");
                });

            modelBuilder.Entity("DabAflevering2.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DabAflevering2.Models.Resturent", b =>
                {
                    b.Property<int>("ResturentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("ResturentId");

                    b.ToTable("Resturent");

                    b.HasData(
                        new
                        {
                            ResturentId = 1,
                            Address = "Fiskergade 2, 8000",
                            Name = "Jerrys",
                            Type = "Buffet"
                        },
                        new
                        {
                            ResturentId = 2,
                            Address = "Nørreallé 87, 8000",
                            Name = "South India",
                            Type = "Aftensmad"
                        },
                        new
                        {
                            ResturentId = 3,
                            Address = "Møllevangsallé 22, 8200",
                            Name = "Cafe Alberts",
                            Type = "Morgenmad"
                        },
                        new
                        {
                            ResturentId = 4,
                            Address = "Damvej 1, 6100",
                            Name = "Running Sushi",
                            Type = "Buffet"
                        },
                        new
                        {
                            ResturentId = 5,
                            Address = "Findlandsgade 142, 8200",
                            Name = "Føtex StorcenterNord",
                            Type = "Frokost"
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.ResturentDishes", b =>
                {
                    b.Property<int>("DishId");

                    b.Property<int>("ResturentId");

                    b.HasKey("DishId", "ResturentId");

                    b.HasIndex("ResturentId");

                    b.ToTable("ResturentDishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 2,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 3,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 4,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 5,
                            ResturentId = 2
                        },
                        new
                        {
                            DishId = 6,
                            ResturentId = 2
                        },
                        new
                        {
                            DishId = 7,
                            ResturentId = 2
                        },
                        new
                        {
                            DishId = 8,
                            ResturentId = 3
                        },
                        new
                        {
                            DishId = 9,
                            ResturentId = 3
                        },
                        new
                        {
                            DishId = 10,
                            ResturentId = 4
                        },
                        new
                        {
                            DishId = 11,
                            ResturentId = 4
                        },
                        new
                        {
                            DishId = 12,
                            ResturentId = 5
                        },
                        new
                        {
                            DishId = 13,
                            ResturentId = 5
                        },
                        new
                        {
                            DishId = 14,
                            ResturentId = 5
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ResturentId");

                    b.Property<int>("Stars");

                    b.Property<string>("Text");

                    b.HasKey("ReviewId");

                    b.HasIndex("ResturentId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            ResturentId = 1,
                            Stars = 2,
                            Text = "Godt sted"
                        },
                        new
                        {
                            ReviewId = 2,
                            ResturentId = 1,
                            Stars = 3,
                            Text = "Det er okay"
                        },
                        new
                        {
                            ReviewId = 3,
                            ResturentId = 1,
                            Stars = 2,
                            Text = "Kan bestemt ikke anbefale dette"
                        },
                        new
                        {
                            ReviewId = 4,
                            ResturentId = 2,
                            Stars = 2,
                            Text = "Okay, men ikke godt "
                        },
                        new
                        {
                            ReviewId = 5,
                            ResturentId = 2,
                            Stars = 1,
                            Text = "Kommer aldrig her igen"
                        },
                        new
                        {
                            ReviewId = 6,
                            ResturentId = 1,
                            Stars = 3,
                            Text = "Fint til pengene."
                        },
                        new
                        {
                            ReviewId = 7,
                            ResturentId = 1,
                            Stars = 4,
                            Text = "Mit lokale stamsted!"
                        },
                        new
                        {
                            ReviewId = 8,
                            ResturentId = 1,
                            Stars = 3,
                            Text = "Kommer her ofte!"
                        },
                        new
                        {
                            ReviewId = 9,
                            ResturentId = 2,
                            Stars = 1,
                            Text = "Nej nej nej"
                        },
                        new
                        {
                            ReviewId = 10,
                            ResturentId = 2,
                            Stars = 5,
                            Text = "Så lækkert!"
                        },
                        new
                        {
                            ReviewId = 11,
                            ResturentId = 3,
                            Stars = 3,
                            Text = "God smurt rundstyk, rigtig dejligt!"
                        },
                        new
                        {
                            ReviewId = 12,
                            ResturentId = 3,
                            Stars = 5,
                            Text = "Dårlig servering, kold kaffe 0 stjerner herfra"
                        },
                        new
                        {
                            ReviewId = 13,
                            ResturentId = 4,
                            Stars = 5,
                            Text = "Super lækkert med frisk fisk!"
                        },
                        new
                        {
                            ReviewId = 14,
                            ResturentId = 4,
                            Stars = 1,
                            Text = "Fik kolera, og vildt dårlig mave dagen efter et besøg. Anbefalder ikke dette sted til min væreste fjende.."
                        },
                        new
                        {
                            ReviewId = 15,
                            ResturentId = 5,
                            Stars = 5,
                            Text = "Den bedste franske hotdog i byen, perfekt frokost!"
                        },
                        new
                        {
                            ReviewId = 16,
                            ResturentId = 5,
                            Stars = 5,
                            Text = "Selvom niveauet er faldet efter flytningen, er det stadig super lækkert, og de har en god sandwich"
                        },
                        new
                        {
                            ReviewId = 17,
                            ResturentId = 5,
                            Stars = 5,
                            Text = "Ikke få deres karry sauce i jeres sandwich, den smager af bæ.."
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number");

                    b.Property<int>("ResturentId");

                    b.HasKey("TableId");

                    b.HasIndex("ResturentId");

                    b.ToTable("Table");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            Number = 1,
                            ResturentId = 1
                        },
                        new
                        {
                            TableId = 2,
                            Number = 2,
                            ResturentId = 1
                        },
                        new
                        {
                            TableId = 3,
                            Number = 1,
                            ResturentId = 2
                        },
                        new
                        {
                            TableId = 4,
                            Number = 3,
                            ResturentId = 1
                        },
                        new
                        {
                            TableId = 5,
                            Number = 2,
                            ResturentId = 2
                        },
                        new
                        {
                            TableId = 6,
                            Number = 5,
                            ResturentId = 3
                        },
                        new
                        {
                            TableId = 7,
                            Number = 3,
                            ResturentId = 3
                        },
                        new
                        {
                            TableId = 8,
                            Number = 1,
                            ResturentId = 4
                        },
                        new
                        {
                            TableId = 9,
                            Number = 10,
                            ResturentId = 4
                        },
                        new
                        {
                            TableId = 10,
                            Number = 8,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 11,
                            Number = 1,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 12,
                            Number = 2,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 13,
                            Number = 3,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 14,
                            Number = 5,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 15,
                            Number = 1,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 16,
                            Number = 3,
                            ResturentId = 5
                        },
                        new
                        {
                            TableId = 17,
                            Number = 2,
                            ResturentId = 5
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.TableWaiters", b =>
                {
                    b.Property<int>("TableId");

                    b.Property<int>("PersonId");

                    b.HasKey("TableId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("TableWaiters");
                });

            modelBuilder.Entity("DabAflevering2.Models.Guest", b =>
                {
                    b.HasBaseType("DabAflevering2.Models.Person");

                    b.Property<int?>("ReviewId");

                    b.Property<int>("TableId");

                    b.HasIndex("ReviewId");

                    b.HasIndex("TableId");

                    b.HasDiscriminator().HasValue("Guest");

                    b.HasData(
                        new
                        {
                            PersonId = 5,
                            Name = "Benjamin",
                            ReviewId = 1,
                            TableId = 1
                        },
                        new
                        {
                            PersonId = 6,
                            Name = "Martin",
                            ReviewId = 2,
                            TableId = 2
                        },
                        new
                        {
                            PersonId = 7,
                            Name = "Mathias",
                            ReviewId = 4,
                            TableId = 3
                        },
                        new
                        {
                            PersonId = 8,
                            Name = "Madsemand",
                            ReviewId = 3,
                            TableId = 4
                        },
                        new
                        {
                            PersonId = 9,
                            Name = "Mark",
                            ReviewId = 5,
                            TableId = 5
                        },
                        new
                        {
                            PersonId = 10,
                            Name = "Line",
                            ReviewId = 6,
                            TableId = 6
                        },
                        new
                        {
                            PersonId = 11,
                            Name = "Henrik",
                            ReviewId = 7,
                            TableId = 7
                        },
                        new
                        {
                            PersonId = 12,
                            Name = "Søren",
                            ReviewId = 8,
                            TableId = 8
                        },
                        new
                        {
                            PersonId = 13,
                            Name = "Laura",
                            ReviewId = 9,
                            TableId = 9
                        },
                        new
                        {
                            PersonId = 14,
                            Name = "Julie",
                            ReviewId = 10,
                            TableId = 10
                        },
                        new
                        {
                            PersonId = 15,
                            Name = "Frands",
                            ReviewId = 11,
                            TableId = 11
                        },
                        new
                        {
                            PersonId = 16,
                            Name = "Simon",
                            ReviewId = 12,
                            TableId = 12
                        },
                        new
                        {
                            PersonId = 17,
                            Name = "Thorsten",
                            ReviewId = 13,
                            TableId = 13
                        },
                        new
                        {
                            PersonId = 18,
                            Name = "Jørgen",
                            ReviewId = 14,
                            TableId = 14
                        },
                        new
                        {
                            PersonId = 19,
                            Name = "Ida",
                            ReviewId = 15,
                            TableId = 15
                        },
                        new
                        {
                            PersonId = 20,
                            Name = "Preben",
                            ReviewId = 16,
                            TableId = 16
                        },
                        new
                        {
                            PersonId = 21,
                            Name = "Jens",
                            ReviewId = 17,
                            TableId = 17
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Waiter", b =>
                {
                    b.HasBaseType("DabAflevering2.Models.Person");

                    b.Property<double>("Salery");

                    b.HasDiscriminator().HasValue("Waiter");
                });

            modelBuilder.Entity("DabAflevering2.Models.Dish", b =>
                {
                    b.HasOne("DabAflevering2.Models.Review", "Review")
                        .WithMany("Dishes")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.GuestDishes", b =>
                {
                    b.HasOne("DabAflevering2.Models.Dish", "Dish")
                        .WithMany("GuestDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DabAflevering2.Models.Guest", "Guest")
                        .WithMany("guestDishes")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DabAflevering2.Models.ResturentDishes", b =>
                {
                    b.HasOne("DabAflevering2.Models.Dish", "Dish")
                        .WithMany("ResturentDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DabAflevering2.Models.Resturent", "Resturent")
                        .WithMany("ResturentDishes")
                        .HasForeignKey("ResturentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DabAflevering2.Models.Review", b =>
                {
                    b.HasOne("DabAflevering2.Models.Resturent", "Resturent")
                        .WithMany("Reviews")
                        .HasForeignKey("ResturentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.Table", b =>
                {
                    b.HasOne("DabAflevering2.Models.Resturent", "Resturent")
                        .WithMany("Tables")
                        .HasForeignKey("ResturentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.TableWaiters", b =>
                {
                    b.HasOne("DabAflevering2.Models.Waiter", "Waiter")
                        .WithMany("TableWaiters")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DabAflevering2.Models.Table", "Table")
                        .WithMany("TableWaiters")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.Guest", b =>
                {
                    b.HasOne("DabAflevering2.Models.Review", "Review")
                        .WithMany("Guests")
                        .HasForeignKey("ReviewId");

                    b.HasOne("DabAflevering2.Models.Table", "Table")
                        .WithMany("Guests")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
