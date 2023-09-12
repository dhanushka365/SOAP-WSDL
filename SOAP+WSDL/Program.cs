using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using REST_Practise.Data;
using SOAP_WSDL.Services;
using SoapCore;
using Swashbuckle.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSoapCore();
// Add services to the container.
builder.Services.TryAddSingleton<IAccelerationService, AccelerationService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IProfileService, ProfileService>();


// Register DbContextOptions with Scoped lifetime
builder.Services.AddDbContext<ERPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpConnectionString")),
    ServiceLifetime.Scoped);

// Register ERPContext with Scoped lifetime
builder.Services.AddScoped<ERPContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API Name", Version = "v1" });

    // Include comments from XML documentation if available
    // options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "YourApiName.xml"));
});
// Configure Swashbuckle.AspNetCore.Soap for SOAP documentation
//builder.Services.AddSoapDocumentation();
//---------------------------------------------
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name V1");
        options.RoutePrefix = "swagger";
    });
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IAccelerationService>("/ServicePath.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<IDepartmentService>("/DepartmentServicePath.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<IEmployeeService>("/EmployeeServicePath.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<IRoleService>("/RoleServicePath.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
    endpoints.UseSoapEndpoint<IProfileService>("/ProfileServicePath.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();