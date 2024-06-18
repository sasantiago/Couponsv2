using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class Products
{

    public int Id { get; set; }
    public string Name { get; set; }
    public Decimal Price { get; set; }
    public int CategoryId { get; set; }
    public ICollection <Categories>categories { get; set; }
    public string Status { get; set; }

    }
}