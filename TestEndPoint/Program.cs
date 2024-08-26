using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
using TestApplication;
using TestEndPoint.Midlewares;
using TestPersistence;

var builder = WebApplication.CreateBuilder(args);
   
// Add services to the container.

builder.Services.AddControllers();



builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureApplicationServices(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy", b =>
    b.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
});
//Add Middelware Class That Implements IMiddleware Interface
builder.Services.AddScoped<SecureHeadersMiddleware>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseStaticFiles();
//With a Middleware Class by Convention
app.UseMyExceptionHandler();
//Use Middelware Class That Implements IMiddleware Interface
app.UseMiddleware<SecureHeadersMiddleware>();

app.UseCors("CorsPolicy");
app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

