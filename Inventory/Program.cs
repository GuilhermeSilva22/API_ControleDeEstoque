using Inventory.Application.Interfaces;
using Inventory.Application.Services;
using Inventory.Data.Context;
using Inventory.Data.Interfaces;
using Inventory.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IItemService, ItemService>();
var serverVersion = new MySqlServerVersion(new Version (8, 0, 28));
builder.Services.AddDbContext<InventoryContext>(opt => 
opt.UseMySql(builder.Configuration.GetSection("ConnectionString").Value, serverVersion));

    
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
