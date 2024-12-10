using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Flower.Models;

public partial class Bainhom1Context : DbContext
{
    public Bainhom1Context()
    {
    }

    public Bainhom1Context(DbContextOptions<Bainhom1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAccount> TbAccounts { get; set; }

    public virtual DbSet<TbBlog> TbBlogs { get; set; }

    public virtual DbSet<TbCategory> TbCategories { get; set; }

    public virtual DbSet<TbDiscount> TbDiscounts { get; set; }

    public virtual DbSet<TbMenu> TbMenu { get; set; }

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
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("AccountID");
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FullName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastLogin)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PaymentId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PaymentID");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ShippingId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ShippingID");
            entity.Property(e => e.Username)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Account).WithOne(p => p.TbAccount)
                .HasForeignKey<TbAccount>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Account_tb_Blog");
        });

        modelBuilder.Entity<TbBlog>(entity =>
        {
            entity.HasKey(e => e.BlogId);

            entity.ToTable("tb_Blog");

            entity.Property(e => e.BlogId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BlogID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("AccountID");
            entity.Property(e => e.Alias)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CategoryId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Detail)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SeoDescription)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SeoKeywords)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SeoTitle)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsFixedLength();

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
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CategoryID");
            
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image)
    .HasMaxLength(10)
    .IsFixedLength();
            entity.Property(e => e.IsActive)
    .HasMaxLength(10)
    .IsFixedLength();
        });

        modelBuilder.Entity<TbDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountId);

            entity.ToTable("tb_Discount");

            entity.Property(e => e.DiscountId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("DiscountID");
            entity.Property(e => e.DiscountAmount)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Discount_Amount");
            entity.Property(e => e.Quanlity)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Vat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VAT");
        });

        modelBuilder.Entity<TbMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("tb_Menu");

            entity.Property(e => e.Alias).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TbNews>(entity =>
        {
            entity.HasKey(e => e.NewsId);

            entity.ToTable("tb_News");

            entity.Property(e => e.NewsId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NewsID");
            entity.Property(e => e.Alias)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Detail)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SeoDescription)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SeoKeywords)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SeoTitle)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Title)
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
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderID");
            entity.Property(e => e.Address)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OrderStatusId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderStatusID");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Quanlity)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.WishListId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("WishListID");

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
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderDetailID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderID");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PaymentID");
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ProductID");
            entity.Property(e => e.Quantity)
                .HasMaxLength(10)
                .IsFixedLength();

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
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PaymentID");
            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DiscountId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("DiscountID");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Payment_method");
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Vat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VAT");

            entity.HasOne(d => d.Payment).WithOne(p => p.TbPaymentMethod)
                .HasForeignKey<TbPaymentMethod>(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_PaymentMethod_tb_Discount");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("tb_Product");

            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                 .HasMaxLength(10)
                 .IsFixedLength();
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsBestSeller)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UnitlnStock)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsSale)
               .HasMaxLength(10)
               .IsFixedLength();
            entity.Property(e => e.IsNew)
               .HasMaxLength(10)
               .IsFixedLength();
        });

        modelBuilder.Entity<TbProductCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryProductld);

            entity.ToTable("tb_ProductCategory");

            entity.Property(e => e.CategoryProductld)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Alias)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Icon)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.CategoryProductldNavigation).WithOne(p => p.TbProductCategory)
                .HasForeignKey<TbProductCategory>(d => d.CategoryProductld)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_ProductCategory_tb_Product");
        });

        modelBuilder.Entity<TbProductReview>(entity =>
        {
            entity.HasKey(e => e.ProductReviewld);

            entity.ToTable("tb_ProductReview");

            entity.Property(e => e.ProductReviewld)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Detail)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Productld)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Star)
                .HasMaxLength(10)
                .IsFixedLength();

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
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ShippingID");
            entity.Property(e => e.Adress)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OrderDetailId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderDetailID");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TbWishList>(entity =>
        {
            entity.HasKey(e => e.WishListId);

            entity.ToTable("tb_WishList");

            entity.Property(e => e.WishListId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("WishListID");
            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Quanlity)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblOrderStatus>(entity =>
        {
            entity.HasKey(e => e.OrderStatusId);

            entity.ToTable("tbl_OrderStatus");

            entity.Property(e => e.OrderStatusId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OrderStatusID");
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.OrderStatus).WithOne(p => p.TblOrderStatus)
                .HasForeignKey<TblOrderStatus>(d => d.OrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_OrderStatus_tb_Order");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
