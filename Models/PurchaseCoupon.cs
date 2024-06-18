using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class PurchaseCoupon
{

    public int Id { get; set; }

    public string PurchaseId { get; set; }
    public ICollection <Purchases>Purchase { get; set; }
    public string CouponId { get; set; }
    public ICollection <Coupon>coupons { get; set; }

    }
}