﻿// <auto-generated />
using System;
using GamerMarketApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    [DbContext(typeof(GamerMarketDbContext))]
    partial class GamerMarketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GamerMarketApp.Data.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Description = "A competitive first-person shooter where players join terrorists or counter-terrorists in objective-based matches. It features a massive trading market for weapon skins.",
                            GenreId = 4,
                            ImageUrl = "https://cdn.akamai.steamstatic.com/steam/apps/730/header.jpg",
                            IsDeleted = false,
                            Title = "Counter-Strike: 2"
                        },
                        new
                        {
                            GameId = 2,
                            Description = "A team-based MOBA game where two teams of five players control heroes with unique abilities to destroy the enemy's base, featuring a robust economy for hero cosmetics.",
                            GenreId = 9,
                            ImageUrl = "https://cdn.akamai.steamstatic.com/steam/apps/570/header.jpg",
                            IsDeleted = false,
                            Title = "Dota 2"
                        },
                        new
                        {
                            GameId = 3,
                            Description = "A vibrant battle royale game with a unique building mechanic. Players compete to survive, featuring purchasable character skins, emotes, and accessories.",
                            GenreId = 14,
                            ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202410/2918/95953c3726f54fba5e6cf53f97b10bcf99e0d43581ae2c55.jpg",
                            IsDeleted = false,
                            Title = "Fortnite"
                        },
                        new
                        {
                            GameId = 4,
                            Description = "A genre-defining MMORPG where players explore Azeroth, completing quests and engaging in battles. Offers tradable mounts, pets, and unique cosmetic items.",
                            GenreId = 8,
                            ImageUrl = "https://bnetcmsus-a.akamaihd.net/cms/blog_header/h9/H9LLMU20DQFJ1725400142786.png",
                            IsDeleted = false,
                            Title = "World of Warcraft"
                        },
                        new
                        {
                            GameId = 5,
                            Description = "A classic team-based shooter featuring various character classes. Players trade cosmetic hats, weapons, and items to customize their experience.",
                            GenreId = 10,
                            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/440/header.jpg",
                            IsDeleted = false,
                            Title = "Team Fortress 2"
                        },
                        new
                        {
                            GameId = 6,
                            Description = "A fast-paced strategy game where two teams of champions compete to destroy each other's nexus. Players can purchase skins and accessories to personalize their gameplay.",
                            GenreId = 9,
                            ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg",
                            IsDeleted = false,
                            Title = "League of Legends"
                        },
                        new
                        {
                            GameId = 7,
                            Description = "A brutal survival game where players gather resources, build bases, and fend off others. Skins for tools and clothing can be bought and traded.",
                            GenreId = 7,
                            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/252490/header.jpg",
                            IsDeleted = false,
                            Title = "Rust"
                        },
                        new
                        {
                            GameId = 8,
                            Description = "A realistic battle royale game where players fight to survive in large, detailed maps. It features purchasable and tradable weapon skins and outfits.",
                            GenreId = 14,
                            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/578080/header.jpg",
                            IsDeleted = false,
                            Title = "PUBG: Battlegrounds"
                        },
                        new
                        {
                            GameId = 9,
                            Description = "A creative gaming platform where users can design and play games. Features an expansive marketplace for user-created items and skins.",
                            GenreId = 15,
                            ImageUrl = "https://assets-prd.ignimgs.com/2024/09/06/roblox-rdc2024-everythingannounced-blogroll-1725644096329.jpg",
                            IsDeleted = false,
                            Title = "Roblox"
                        },
                        new
                        {
                            GameId = 10,
                            Description = "A high-intensity battle royale with tactical gunfights and squad dynamics. Includes purchasable weapon blueprints, operator skins, and bundles.",
                            GenreId = 14,
                            ImageUrl = "https://shared.cloudflare.steamstatic.com/store_item_assets/steam/apps/1962663/header.jpg?t=1731603761",
                            IsDeleted = false,
                            Title = "Call of Duty: Warzone"
                        },
                        new
                        {
                            GameId = 11,
                            Description = "A space-based MMORPG where players engage in trading, exploration, and massive battles. Features a player-driven economy with tradable ships and skins.",
                            GenreId = 8,
                            ImageUrl = "https://cdn2.unrealengine.com/eve-online-1920x1080-63abdd7114f4.png",
                            IsDeleted = false,
                            Title = "EVE Online"
                        },
                        new
                        {
                            GameId = 12,
                            Description = "An MMORPG set in the rich Elder Scrolls universe, featuring expansive quests and dungeons. Players can buy mounts, costumes, and furnishings.",
                            GenreId = 8,
                            ImageUrl = "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/306130/header.jpg?t=1726169108",
                            IsDeleted = false,
                            Title = "The Elder Scrolls Online"
                        },
                        new
                        {
                            GameId = 13,
                            Description = "A fast-paced battle royale with unique hero abilities. Features a variety of skins and cosmetics available for purchase.",
                            GenreId = 14,
                            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/1172470/header.jpg",
                            IsDeleted = false,
                            Title = "Apex Legends"
                        },
                        new
                        {
                            GameId = 14,
                            Description = "A sandbox game where players can build, mine, and explore an infinite world. Offers a marketplace for skins, texture packs, and other in-game content.",
                            GenreId = 15,
                            ImageUrl = "https://i.ytimg.com/vi_webp/ztNoBI0m_P0/maxresdefault.webp",
                            IsDeleted = false,
                            Title = "Minecraft"
                        });
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Action"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            GenreId = 3,
                            Name = "Fighting"
                        },
                        new
                        {
                            GenreId = 4,
                            Name = "Sports"
                        },
                        new
                        {
                            GenreId = 5,
                            Name = "Racing"
                        },
                        new
                        {
                            GenreId = 6,
                            Name = "RPG"
                        },
                        new
                        {
                            GenreId = 7,
                            Name = "Survival"
                        },
                        new
                        {
                            GenreId = 8,
                            Name = "MMORPG"
                        },
                        new
                        {
                            GenreId = 9,
                            Name = "MOBA"
                        },
                        new
                        {
                            GenreId = 10,
                            Name = "FPS"
                        },
                        new
                        {
                            GenreId = 11,
                            Name = "Shooter"
                        },
                        new
                        {
                            GenreId = 12,
                            Name = "Strategy"
                        },
                        new
                        {
                            GenreId = 13,
                            Name = "Music video game"
                        },
                        new
                        {
                            GenreId = 14,
                            Name = "Battle royale"
                        },
                        new
                        {
                            GenreId = 15,
                            Name = "Sandbox"
                        });
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PublisherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SubtypeId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("GameId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("SubtypeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.ItemSubtype", b =>
                {
                    b.Property<int>("SubtypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubtypeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubtypeId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("ItemSubtypes");

                    b.HasData(
                        new
                        {
                            SubtypeId = 1,
                            Description = "Custom appearances for characters, weapons, or vehicles.",
                            ItemTypeId = 1,
                            Name = "Skins"
                        },
                        new
                        {
                            SubtypeId = 2,
                            Description = "Decorative headgear for characters.",
                            ItemTypeId = 1,
                            Name = "Hats/Helmets"
                        },
                        new
                        {
                            SubtypeId = 3,
                            Description = "Custom animations for characters, such as dances or gestures.",
                            ItemTypeId = 1,
                            Name = "Emotes/Dances"
                        },
                        new
                        {
                            SubtypeId = 4,
                            Description = "Customizable graffiti or tags used in-game.",
                            ItemTypeId = 1,
                            Name = "Sprays"
                        },
                        new
                        {
                            SubtypeId = 5,
                            Description = "Companion creatures that follow the player.",
                            ItemTypeId = 1,
                            Name = "Pets"
                        },
                        new
                        {
                            SubtypeId = 6,
                            Description = "Vehicles or creatures used for faster travel or aesthetics.",
                            ItemTypeId = 1,
                            Name = "Mounts"
                        },
                        new
                        {
                            SubtypeId = 7,
                            Description = "Guns, swords, or other items used in combat.",
                            ItemTypeId = 2,
                            Name = "Weapons"
                        },
                        new
                        {
                            SubtypeId = 8,
                            Description = "Gear providing protection or stat boosts.",
                            ItemTypeId = 2,
                            Name = "Armor"
                        },
                        new
                        {
                            SubtypeId = 9,
                            Description = "Transport or combat vehicles, often tradable.",
                            ItemTypeId = 2,
                            Name = "Vehicles"
                        },
                        new
                        {
                            SubtypeId = 10,
                            Description = "Items that restore health points (HP).",
                            ItemTypeId = 3,
                            Name = "Health Potions"
                        },
                        new
                        {
                            SubtypeId = 11,
                            Description = "Temporary stat-boosting consumables.",
                            ItemTypeId = 3,
                            Name = "Buffs"
                        },
                        new
                        {
                            SubtypeId = 12,
                            Description = "Items that resurrect players or allies.",
                            ItemTypeId = 3,
                            Name = "Revival Items"
                        },
                        new
                        {
                            SubtypeId = 13,
                            Description = "Materials used for crafting weapons or armor.",
                            ItemTypeId = 4,
                            Name = "Ores/Metals"
                        },
                        new
                        {
                            SubtypeId = 14,
                            Description = "Ingredients used for alchemy or potion-making.",
                            ItemTypeId = 4,
                            Name = "Herbs"
                        },
                        new
                        {
                            SubtypeId = 15,
                            Description = "Instructions for crafting specific items.",
                            ItemTypeId = 4,
                            Name = "Blueprints/Recipes"
                        },
                        new
                        {
                            SubtypeId = 16,
                            Description = "In-game standard currency for trading.",
                            ItemTypeId = 5,
                            Name = "Gold/Coins"
                        },
                        new
                        {
                            SubtypeId = 17,
                            Description = "Real-money currency for in-game purchases.",
                            ItemTypeId = 5,
                            Name = "Premium Currency"
                        },
                        new
                        {
                            SubtypeId = 18,
                            Description = "Containers with random rewards.",
                            ItemTypeId = 5,
                            Name = "Loot Boxes/Crates"
                        },
                        new
                        {
                            SubtypeId = 19,
                            Description = "Digital or physical cards collected by players.",
                            ItemTypeId = 6,
                            Name = "Trading Cards"
                        },
                        new
                        {
                            SubtypeId = 20,
                            Description = "Items that expand player inventory space.",
                            ItemTypeId = 7,
                            Name = "Bags/Inventory Space"
                        },
                        new
                        {
                            SubtypeId = 21,
                            Description = "Items for decorating player-owned spaces.",
                            ItemTypeId = 8,
                            Name = "Furniture"
                        },
                        new
                        {
                            SubtypeId = 22,
                            Description = "Customizable decorations for in-game housing.",
                            ItemTypeId = 8,
                            Name = "Wall Art"
                        },
                        new
                        {
                            SubtypeId = 23,
                            Description = "Limited-time skins available during events.",
                            ItemTypeId = 9,
                            Name = "Holiday-Themed Skins"
                        },
                        new
                        {
                            SubtypeId = 24,
                            Description = "Unique, tradable assets tied to blockchain technology.",
                            ItemTypeId = 10,
                            Name = "Blockchain-Based Assets"
                        });
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.ItemType", b =>
                {
                    b.Property<int>("ItemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ItemTypeId");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            ItemTypeId = 1,
                            Name = "Cosmetic Items"
                        },
                        new
                        {
                            ItemTypeId = 2,
                            Name = "Functional Equipment"
                        },
                        new
                        {
                            ItemTypeId = 3,
                            Name = "Consumables"
                        },
                        new
                        {
                            ItemTypeId = 4,
                            Name = "Crafting Materials"
                        },
                        new
                        {
                            ItemTypeId = 5,
                            Name = "Currency"
                        },
                        new
                        {
                            ItemTypeId = 6,
                            Name = "Collectibles"
                        },
                        new
                        {
                            ItemTypeId = 7,
                            Name = "Utility Items"
                        },
                        new
                        {
                            ItemTypeId = 8,
                            Name = "Housing and Decor Items"
                        },
                        new
                        {
                            ItemTypeId = 9,
                            Name = "Event-Specific Items"
                        },
                        new
                        {
                            ItemTypeId = 10,
                            Name = "NFTs (Non-Fungible Tokens)"
                        });
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.UserItem", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ItemId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.Game", b =>
                {
                    b.HasOne("GamerMarketApp.Data.Models.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.Item", b =>
                {
                    b.HasOne("GamerMarketApp.Data.Models.Game", "Game")
                        .WithMany("Items")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamerMarketApp.Data.Models.ItemSubtype", "Subtype")
                        .WithMany("Items")
                        .HasForeignKey("SubtypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Publisher");

                    b.Navigation("Subtype");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.ItemSubtype", b =>
                {
                    b.HasOne("GamerMarketApp.Data.Models.ItemType", "ItemType")
                        .WithMany("ItemSubtypes")
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.UserItem", b =>
                {
                    b.HasOne("GamerMarketApp.Data.Models.Item", "Item")
                        .WithMany("UserItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
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

            modelBuilder.Entity("GamerMarketApp.Data.Models.Game", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.Item", b =>
                {
                    b.Navigation("UserItems");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.ItemSubtype", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("GamerMarketApp.Data.Models.ItemType", b =>
                {
                    b.Navigation("ItemSubtypes");
                });
#pragma warning restore 612, 618
        }
    }
}
