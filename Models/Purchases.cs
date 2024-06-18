using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class Purchases
{

    public int Id { get; set; }

    public string MarketPlaceUserId { get; set; }
    public ICollection <MarketingUsers>MarketingUsers { get; set; }
    public string ProductId { get; set; }
    public ICollection <Products>products { get; set; }

    public DateTime Date { get; set; }
    public Decimal Amount { get; set; }
    public Decimal Discount { get; set; }

    public Decimal Total { get; set; }

    }
}