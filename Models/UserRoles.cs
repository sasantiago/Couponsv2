using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coupons2.Models
{
public class UserRoles
{

    public int Id { get; set; }

    public string MarketPlaceUserId { get; set; }
    public ICollection <MarketingUsers>MarketingUsers { get; set; }
    public string RolesId { get; set; }
    public ICollection <Roles>Roles { get; set; }

    }
}