using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using CaseAPI.Core.Extensions;
using CaseAPI.DataAccess.Concrete;
using CaseAPI.DataAccess.DataSeeding;
using CaseAPI.Entities.Dto.Product.Request;
using CaseAPI.Entities.Dto.Product.Response;
using CaseAPI.Entities.Entity;
using CaseAPI.Infrastructure.DependencyResolves.Autofac;
using CaseAPI.Infrastructure.Hubs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalRServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("https://localhost:44306", "http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    });
});



MapperConfiguration configuration = new MapperConfiguration(cfg =>
{   
    cfg.CreateMap<Product, ProductListResponse>().ReverseMap();
    cfg.CreateMap<Product, AddProductRequest>().ReverseMap();
    cfg.CreateMap<Product, UpdateProductRequest>().ReverseMap();
});

builder.Services.AutoMapperConfig(configuration);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Seed.Init(app);

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHubs();


app.Run();
