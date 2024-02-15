﻿// <auto-generated />
using System;
using DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ProjeOdevContext))]
    partial class ProjeOdevContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Entities.Concrete.AdminOperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OperationClaimsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("OperationClaimsId");

                    b.ToTable("AdminOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnnouncementContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnnouncementTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.Property<Guid>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Entities.Concrete.BlogComment", b =>
                {
                    b.Property<Guid>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("BlogComments");
                });

            modelBuilder.Entity("Entities.Concrete.BlogLike", b =>
                {
                    b.Property<Guid>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BlogCommentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LikeDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LikeId");

                    b.HasIndex("BlogCommentId");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("BlogLikes");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entities.Concrete.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Entities.Concrete.Media", b =>
                {
                    b.Property<Guid>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BlogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MediaId");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserId");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OperationClaimsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimsId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.AdminOperationClaim", b =>
                {
                    b.HasOne("Entities.Concrete.Admin", "Admin")
                        .WithMany("AdminOperationClaims")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("AdminOperationClaims")
                        .HasForeignKey("OperationClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("OperationClaim");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.BlogComment", b =>
                {
                    b.HasOne("Entities.Concrete.Blog", "Blog")
                        .WithMany("BlogComments")
                        .HasForeignKey("BlogId")
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("BlogComments")
                        .HasForeignKey("UserId")
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.BlogLike", b =>
                {
                    b.HasOne("Entities.Concrete.BlogComment", "comment")
                        .WithMany("BlogLikes")
                        .HasForeignKey("BlogCommentId");

                    b.HasOne("Entities.Concrete.Blog", "blog")
                        .WithMany("BlogLikes")
                        .HasForeignKey("BlogId");

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("BlogLikes")
                        .HasForeignKey("UserId")
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("blog");

                    b.Navigation("comment");
                });

            modelBuilder.Entity("Entities.Concrete.District", b =>
                {
                    b.HasOne("Entities.Concrete.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("SehirId")
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Entities.Concrete.Media", b =>
                {
                    b.HasOne("Entities.Concrete.Blog", "blog")
                        .WithMany("Medias")
                        .HasForeignKey("BlogId");

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Medias")
                        .HasForeignKey("UserId");

                    b.Navigation("User");

                    b.Navigation("blog");
                });

            modelBuilder.Entity("Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Admin", b =>
                {
                    b.Navigation("AdminOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.Navigation("BlogComments");

                    b.Navigation("BlogLikes");

                    b.Navigation("Medias");
                });

            modelBuilder.Entity("Entities.Concrete.BlogComment", b =>
                {
                    b.Navigation("BlogLikes");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("AdminOperationClaims");

                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("BlogComments");

                    b.Navigation("BlogLikes");

                    b.Navigation("Blogs");

                    b.Navigation("Medias");

                    b.Navigation("UserOperationClaims");
                });
#pragma warning restore 612, 618
        }
    }
}
