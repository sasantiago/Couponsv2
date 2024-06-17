// using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace YourNamespace.Models
// {
// public class Coupon
// {
//     [Key]
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Description { get; set; }
//     public DateTime StartDate { get; set; }
//     public DateTime EndDate { get; set; }
//     public string DiscountType { get; set; } // Should use enum
//     public bool IsLimited { get; set; }
//     public int UsageLimit { get; set; }
//     public int AmountUses { get; set; }
//     public decimal MinPurchaseAmount { get; set; }
//     public decimal MaxPurchaseAmount { get; set; }
//     public string Status { get; set; } // Should use enum

//     [ForeignKey("MarketingUser")]
//     public int MarketingUserId { get; set; }
//     public virtual MarketingUser MarketingUser { get; set; }
// }
// }
