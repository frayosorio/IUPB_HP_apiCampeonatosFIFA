using CampeonatosFifa.Presentacion.DI;

var builder = WebApplication.CreateBuilder(args);

//***** Add services to the container.

//Agregar el Mapeador de objetos
var mapperConfig = new MapperConfiguration(cfg =>
{
    //cfg.AddProfile<MappingProfile>();
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("PoliticaCors", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

IMapper mapper=new Mapper(mapperConfig);
builder.Services.AddSingleton(mapper);

var configuration = builder.Configuration;

builder.Services.AgregarDependencias(configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.UseCors("PoliticaCors");

app.Run();
