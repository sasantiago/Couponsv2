// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using coupons2.Models;
// using Microsoft.EntityFrameworkCore;

// namespace coupons2.Data
// {
//     public class Coupons2Context : DbContext
//     {
//         public Coupons2Context(DbContextOptions<Coupons2Context> options): base(options)
//         {
     
//         }
//         public DbSet<Categories>Categories{ get; set; }

//         public DbSet<CouponHistory>CouponHistories{ get; set; }

//         public DbSet<Coupon> Coupon{ get; set; }

//         public DbSet<CouponUsages>CouponUsages{ get; set; }

//         public DbSet<MarketingUser>MarketingUser { get; set; }

//         public DbSet<MarketplaceUser>MarketplaceUser { get; set; }

//         public DbSet<Products>Products{ get; set; }

//         public DbSet<PurchaseCoupon>PurchaseCoupon { get; set; }

//         public DbSet<Purchases>Purchases { get; set; }

//         public DbSet<Roles>Roles { get; set; }

//         public DbSet<UserRoles>UserRoles { get; set; }

//     }
// }