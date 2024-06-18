using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class CouponHistory
{

    public int Id { get; set; }
    public string CouponId { get; set; }
    public ICollection <Coupon>coupons { get; set; }

    public DateTime ChangeDate { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }

    }
}