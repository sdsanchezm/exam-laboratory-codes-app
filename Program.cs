using exam_laboratory_codes_app.Data;
using exam_laboratory_codes_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<LabexamContext>("Data Source=KRAUSP52\\SQLEXPRESS;Initial Catalog=ExamsDb;Trusted_Connection=True;TrustServerCertificate=true;");
//builder.Services.AddSqlServer<LabexamContext>(builder.Configuration.GetConnectionString("connExamsdb"));
builder.Services.AddScoped<ILabexamService, LabexamService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
