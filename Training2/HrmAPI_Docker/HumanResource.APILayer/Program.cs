using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;
using Hrm.Infrastructure.Service;
using HRM.ApplicationCore.Contract.Service;
using HRM.Infrastructure.Repository;
using HRM.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


//Configues endpoints for the API
builder.Services.AddEndpointsApiExplorer();
//Add API support (for Postman for example)
builder.Services.AddSwaggerGen();
//When working with WebAPIs, we need to specify that by:
builder.Services.AddControllers();

builder.Services.AddDbContext<HrmDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("HrmApiDb"));
});
builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();
builder.Services.AddScoped<IJobRequirementServiceAsync, JobRequirementServiceAsync>();


builder.Services.AddScoped<ICandidateRepositoryAsync, CandidateRepositoryAsync>();
builder.Services.AddScoped<IJobRequirementRepositoryAsync, JobRequirementRepositoryAsync>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Since we are using routing in the ValuesController, we need to specify here that we are using it.
//This is call Middleware
app.UseRouting();

//This will map the request to our controller
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.Run();

