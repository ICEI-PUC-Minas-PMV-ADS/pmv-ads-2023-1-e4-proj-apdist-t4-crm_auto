using CRMobil;
using CRMobil.Entities;
using CRMobil.Services;
using CRMobil.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<CnnStoreDatabaseSettings>(builder.Configuration.GetSection("ConnStoreDatabase"));

builder.Services.AddSingleton<ClientesService>();
builder.Services.AddSingleton<FuncionariosServices>();
builder.Services.AddSingleton<OficinasServices>();
builder.Services.AddSingleton<UsuariosService>();
builder.Services.AddSingleton<VeiculosServices>();

// Add services to the container.

builder.Services.AddControllers();

var key = Encoding.UTF8.GetBytes(Settings.Secret);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(o =>
    {
        o.RequireHttpsMetadata = false;
        o.SaveToken = true;
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = false,
            ValidateAudience = false,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "CRMobilAPI", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer'[space] and then your token in the text input below. \r\n\r\nExample: \"Bearer 1234abcdef\""
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
ConfigureConfiguration(configurationBuilder);
IConfiguration configuration = configurationBuilder.Build();

builder.Services.AddServices(configuration);
builder.Services.AddApplicationServices(configuration);
//builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(7000));

var app = builder.Build();
static void ConfigureConfiguration(IConfigurationBuilder configuration)
{
    var tipoDepuracao = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    var diretorio = Path.Combine(Directory.GetCurrentDirectory(), !string.IsNullOrEmpty(tipoDepuracao) ? $"appsettings.{tipoDepuracao}.json" : "appsettings.json");

    configuration.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile(diretorio, optional: true, reloadOnChange: true);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();




