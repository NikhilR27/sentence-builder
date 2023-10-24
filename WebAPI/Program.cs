using Application.Words.Queries;
using Domain.Mapper;
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(GetWordTypesQuery)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddMediatR(config => { config.RegisterServicesFromAssemblyContaining<GetWordTypesQuery>(); });
builder.Services.AddDbContext<DbContext, SentenceBuilderDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<ISentenceBuilderRepository, SentenceBuilderRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
        policy => { policy.WithOrigins("*"); });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();