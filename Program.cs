using Calculator.Interfaces;
using Calculator.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();  // Add this line to register controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Scientific Calculator API", Version = "v1" });
});

// Register the CalculatorService with the ICalculatorService interface
builder.Services.AddTransient<ICalculatorService<int>, CalculatorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Scientific Calculator API V1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

// Map the CalculatorController
app.MapControllers();  // Ensure that controllers are mapped

app.Run();
