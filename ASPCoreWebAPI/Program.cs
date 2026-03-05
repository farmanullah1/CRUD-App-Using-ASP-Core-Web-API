var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 1. Add Swagger Generation services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // 2. Enable Swagger UI in Development mode
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = "swagger"; // This makes the UI available at /swagger
    });
}

// Commented out to prevent the SSL error you faced
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();