using System.Text;
using coupons2.Data;
using coupons2.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//registra los controladores en el contenedor de dependencias
builder.Services.AddControllers(); 


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Conexion base de datos
builder.Services.AddDbContext<Coupons2Context>(
    option => option.UseMySql(
    builder.Configuration.GetConnectionString("MyConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.2")));

//Cors
builder.Services.AddCors(options => 
    options.AddPolicy("AllowAnyOrigin",
    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()));

//Jwt
builder.Services.AddAuthentication(item =>
    {
        item.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        item.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(item =>
    {
    item.RequireHttpsMetadata = true;
    item.SaveToken = true;
    item.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("9Y9+JKvPyNR0qmUGeCT1oHfCwK2E4EK9YiUCRLXL9D8=")),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew=TimeSpan.Zero
    };
});
var _jwtsettings = builder.Configuration.GetSection("JwtSettings");
builder.Services.Configure<JwtSettings>(_jwtsettings);


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

//cors
app.UseCors("AllowAnyOrigin");
//Map
app.MapControllers(); 


app.Run();

