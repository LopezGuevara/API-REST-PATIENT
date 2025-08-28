using PatientApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Configura los servicios necesarios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Aquí inyectas tu servicio de repositorio
builder.Services.AddSingleton<IPatientRepository, PatientRepository>();

var app = builder.Build();

// Configura los middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();