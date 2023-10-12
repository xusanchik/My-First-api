using Microsoft.EntityFrameworkCore;
using favorite.Date;
using favorite.Interfacce;
using favorite.Repastory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepastory, UserRepastory>();
builder.Services.AddScoped<ICourseRepastory ,CourseRepastory>();
builder.Services.AddScoped<ILessonRepastory ,LessonRepastory>();
builder.Services.AddScoped<ITaskRepastory, TaskRepastory>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
