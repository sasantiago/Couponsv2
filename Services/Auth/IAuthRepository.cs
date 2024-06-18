using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coupons2.Models;
using Microsoft.AspNetCore.Mvc;

namespace coupons2.Services.Auth
{
    public interface IAuthRepository
    {
        MarketingUsers Login(string Username, string Password);
        string GenerateToken (MarketingUsers User);
        void LogOutAsync();
        IEnumerable<MarketingUsers> GetAll();
    }

}