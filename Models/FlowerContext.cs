using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Flower.Models;

public partial class FlowerContext : DbContext
{
    public FlowerContext()
    {
    }

    public FlowerContext(DbContextOptions<FlowerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAccount> TbAccounts { get; set; }

    public virtual DbSet<TbAdminMenu> TbAdminMenus { get; set; }

    public virtual DbSet<TbBlog> TbBlogs { get; set; }

    public virtual DbSet<TbCategory> TbCategories { get; set; }

    public virtual DbSet<TbDiscount> TbDiscounts { get; set; }

    public virtual DbSet<TbMenu> TbMenus { get; set; }

    public virtual DbSet<TbNews> TbNews { get; set; }

    public virtual DbSet<TbOrder> TbOrders { get; set; }

    public virtual DbSet<TbOrderDetail> TbOrderDetails { get; set; }

    public virtual DbSet<TbPaymentMethod> TbPaymentMethods { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    public virtual DbSet<TbProductCategory> TbProductCategories { get; set; }

    public virtual DbSet<TbProductReview> TbProductReviews { get; set; }

    public virtual DbSet<TbShip> TbShips { get; set; }

    public virtual DbSet<TbWishList> TbWishLists { get; set; }

    public virtual DbSet<TblOrderStatus> TblOrderStatuses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId);

            entity.ToTable("tb_Account");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountID");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

            entity.HasOne(d => d.Account).WithOne(p => p.TbAccount)
                .HasForeignKey<TbAccount>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Account_tb_Blog");
        });

        modelBuilder.Entity<TbAdminMenu>(entity =>
        {
            entity.HasKey(e => e.AdminMenuId);

            entity.ToTable("tb_AdminMenu");

            entity.Property(e => e.AdminMenuId).HasColumnName("AdminMenuID");
        });

        modelBuilder.Entity<TbBlog>(entity =>
        {
            entity.HasKey(e => e.BlogId);

            entity.ToTable("tb_Blog");

            entity.Property(e => e.BlogId)
                .ValueGeneratedNever()
                .HasColumnName("BlogID");
            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.HasOne(d => d.Blog).WithOne(p => p.TbBlog)
                .HasForeignKey<TbBlog>(d => d.BlogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Blog_tb_Category");
        });

        modelBuilder.Entity<TbCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("tb_Category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("CategoryID");
        });

        modelBuilder.Entity<TbDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountId);

            entity.ToTable("tb_Discount");

            entity.Property(e => e.DiscountId)
                .ValueGeneratedNever()
                .HasColumnName("DiscountID");
            entity.Property(e => e.DiscountAmount).HasColumnName("Discount_Amount");
            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<TbMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("tb_Menu");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbNews>(entity =>
        {
            entity.HasKey(e => e.NewsId);

            entity.ToTable("tb_News");

            entity.Property(e => e.NewsId)
                .ValueGeneratedNever()
                .HasColumnName("NewsID");
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.News).WithOne(p => p.TbNews)
                .HasForeignKey<TbNews>(d => d.NewsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_News_tb_Blog");
        });

        modelBuilder.Entity<TbOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("tb_Order");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");
            entity.Property(e => e.WishListId).HasColumnName("WishListID");

            entity.HasOne(d => d.Order).WithOne(p => p.TbOrder)
                .HasForeignKey<TbOrder>(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Order_tb_WishList");
        });

        modelBuilder.Entity<TbOrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId);

            entity.ToTable("tb_OrderDetail");

            entity.Property(e => e.OrderDetailId)
                .ValueGeneratedNever()
                .HasColumnName("OrderDetailID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.OrderDetail).WithOne(p => p.TbOrderDetail)
                .HasForeignKey<TbOrderDetail>(d => d.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_OrderDetail_tb_Order");

            entity.HasOne(d => d.OrderDetailNavigation).WithOne(p => p.TbOrderDetail)
                .HasForeignKey<TbOrderDetail>(d => d.OrderDetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_OrderDetail_tb_Ship");

            entity.HasOne(d => d.QuantityNavigation).WithMany(p => p.TbOrderDetails)
                .HasForeignKey(d => d.Quantity)
                .HasConstraintName("FK_tb_OrderDetail_tb_PaymentMethod");
        });

        modelBuilder.Entity<TbPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("tb_PaymentMethod");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("PaymentID");
            entity.Property(e => e.DiscountId).HasColumnName("DiscountID");
            entity.Property(e => e.PaymentMethod).HasColumnName("Payment_method");
            entity.Property(e => e.Vat).HasColumnName("VAT");

            entity.HasOne(d => d.Payment).WithOne(p => p.TbPaymentMethod)
                .HasForeignKey<TbPaymentMethod>(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_PaymentMethod_tb_Discount");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("tb_Product");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.IsNew).HasDefaultValue(false);
            entity.Property(e => e.IsSale).HasDefaultValue(false);
        });

        modelBuilder.Entity<TbProductCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryProductld);

            entity.ToTable("tb_ProductCategory");

            entity.Property(e => e.CategoryProductld).ValueGeneratedNever();

            entity.HasOne(d => d.CategoryProductldNavigation).WithOne(p => p.TbProductCategory)
                .HasForeignKey<TbProductCategory>(d => d.CategoryProductld)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_ProductCategory_tb_Product");
        });

        modelBuilder.Entity<TbProductReview>(entity =>
        {
            entity.HasKey(e => e.ProductReviewld);

            entity.ToTable("tb_ProductReview");

            entity.Property(e => e.ProductReviewld).ValueGeneratedNever();

            entity.HasOne(d => d.ProductReviewldNavigation).WithOne(p => p.TbProductReview)
                .HasForeignKey<TbProductReview>(d => d.ProductReviewld)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_ProductReview_tb_Product");
        });

        modelBuilder.Entity<TbShip>(entity =>
        {
            entity.HasKey(e => e.ShippingId);

            entity.ToTable("tb_Ship");

            entity.Property(e => e.ShippingId)
                .ValueGeneratedNever()
                .HasColumnName("ShippingID");
            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
        });

        modelBuilder.Entity<TbWishList>(entity =>
        {
            entity.HasKey(e => e.WishListId);

            entity.ToTable("tb_WishList");

            entity.Property(e => e.WishListId)
                .ValueGeneratedNever()
                .HasColumnName("WishListID");
        });

        modelBuilder.Entity<TblOrderStatus>(entity =>
        {
            entity.HasKey(e => e.OrderStatusId);

            entity.ToTable("tbl_OrderStatus");

            entity.Property(e => e.OrderStatusId)
                .ValueGeneratedNever()
                .HasColumnName("OrderStatusID");

            entity.HasOne(d => d.OrderStatus).WithOne(p => p.TblOrderStatus)
                .HasForeignKey<TblOrderStatus>(d => d.OrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderStatus_tb_Order");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
