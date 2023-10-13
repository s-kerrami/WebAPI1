using Microsoft.EntityFrameworkCore;
using WebAPI.BLL.Services;
using WebAPI.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ButterContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dev"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UserService>();


builder.Services.AddCors(b =>
{
    b.AddDefaultPolicy(options =>
    {
        options.AllowAnyMethod();
        options.AllowAnyOrigin();
        options.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
