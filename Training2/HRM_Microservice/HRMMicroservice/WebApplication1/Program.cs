using Hrm.Recruiting.ApplicationLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationLayer.Contract.Services;
using Hrm.Recruiting.Infrastructure.Data;
using Hrm.Recruiting.Infrastructure.Repository;
using Hrm.Recruiting.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RecruitingDbContext>(options => {
    //options.UseSqlServer(builder.Configuration.GetConnectionString("RecruitmentDb"));
    options.UseSqlServer(Environment.GetEnvironmentVariable("RecruitmentDb"));
});

//Dependency Injection
builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();
builder.Services.AddScoped<ICandidateRepositoryAsync, CandidateRepositoryAsync>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();