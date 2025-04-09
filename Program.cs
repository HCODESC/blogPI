using BloggingPlatformApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddOpenApi();


builder.Services.AddDbContext<BlogDataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("BlogDataContext")); 
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.Run();


