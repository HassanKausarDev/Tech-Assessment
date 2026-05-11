using CalculatorLibrary;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISimpleCalculator, SimpleCalculator>();

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins("http://localhost:4200");
        });
});

var app = builder.Build();

app.UseCors("AllowFrontend");

//app.UseHttpsRedirection(); // Removed this as was unable to make a call with it being HTTPS.

app.UseAuthorization();

app.MapControllers();

app.Run();

