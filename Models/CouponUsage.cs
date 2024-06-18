using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class CouponUsage
{

    public int Id { get; set; }
    public int CouponId { get; set; }
    public ICollection<Coupon>coupons { get;set;}
    public int MarketPlaceUserId { get; set; }
    public ICollection <MarketPlaceUser>marketPlaceUsers { get; set; }
    public DateTime UserDate { get; set; }


    }
}
