using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class Categories
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MarketingUserId { get; set; }
    // public  MarketingUser MarketingUser { get; set; }
}
}
