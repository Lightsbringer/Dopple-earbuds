using Microsoft.OpenApi.Models;
using System.Reflection;
using MySqlConnector;
using FluentAssertions.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Services.AddTransient<AppDb>(_ => new AppDb(Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ToDo API",
        Description = "An ASP.NET Core Web API for managing ToDo items",
    });
    var fileName = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
    var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
    options.IncludeXmlComments(filePath);
});


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
