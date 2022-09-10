using Integrasjon_person.backend;
using Integrasjon_person.Services;
var builder = WebApplication.CreateBuilder(args);

// IOC: eksponer  domene-tjenester.
builder.Services.AddSingleton<AvtaleoversiktService>();
builder.Services.AddSingleton<AvtaleoversiktEndpoint>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();