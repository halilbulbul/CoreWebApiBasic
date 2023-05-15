using CoreWebApi.Business.Abstract;
using CoreWebApi.Business.Concrete;
using CoreWebApi.DataAccess.Abstract;
using CoreWebApi.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoryBs, CategoryBusiness>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepositoryEf>();

builder.Services.AddScoped<IProductBs, ProductBusiness>();
builder.Services.AddScoped<IProductRepository, ProductRepositoryEf>();

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
