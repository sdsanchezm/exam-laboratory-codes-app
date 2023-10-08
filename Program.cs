using exam_laboratory_codes_app.Data;
using exam_laboratory_codes_app.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//builder.Services.AddSqlServer<LabexamContext>("Data Source=KRAUSP52\\SQLEXPRESS;Initial Catalog=ExamsDb;Trusted_Connection=True;TrustServerCertificate=true;");
//builder.Services.AddSqlServer<LabexamContext>(builder.Configuration.GetConnectionString("connExamsdb"));
builder.Services.AddScoped<ILabexamService, LabexamService>();

builder.Services.AddDbContext<LabexamContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("connExamsdb"));
}, ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS configuration here
// allowing requests from all origins
app.UseCors(builder => builder
    //.WithOrigins("http://localhost.com:5116") 
    .AllowAnyOrigin()
    //.WithHeaders("Content-Type", "Authorization")
    .AllowAnyHeader()
    //.WithMethods("GET", "POST")
    .AllowAnyMethod()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
