using BloggingPlatformApi.Data;
using BloggingPlatformApi.Data.Seeders;
using BloggingPlatformApi.Repositories;
using BloggingPlatformApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();


builder.Services.AddDbContext<BlogDataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("BlogDataContext")); 
});

builder.Services.AddScoped<IUserRepository, UserRepository>(); 

builder.Services.AddTransient<DatabaseSeeder>(); 

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider; 
    var seeder = services.GetRequiredService<DatabaseSeeder>();
    await seeder.Seed();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blogging Platform API V1");
        c.RoutePrefix = string.Empty; // Makes Swagger UI open at the root URL
    });
}

app.UseHttpsRedirection();
app.MapControllers(); 
app.Run();


