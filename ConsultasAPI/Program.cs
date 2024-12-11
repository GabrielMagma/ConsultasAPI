
using ConsultaAPI.Services.Data;
using ConsultaAPI.Services.Interfaces;
using ConsultaAPI.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder => builder
            .WithOrigins("http://127.0.0.1:5500") // Dirección de tu frontend
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddTransient<IMapsServices, MapsServices>();
builder.Services.AddTransient<IMachineServices, MachineServices>();
builder.Services.AddTransient<IPlannerServices, PlannerServices>();
builder.Services.AddTransient<ICriticalityServices, CriticalityServices>();
builder.Services.AddTransient<ISimulateServices, SimulateServices>();
builder.Services.AddTransient<IPublicServices, PublicServices>();

builder.Services.AddDbContext<DannteDevelopmentContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PgDbDevConnection")));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ConsultasAPI v1", Version = "v1" });
    var filePath = Path.Combine(System.AppContext.BaseDirectory, "ConsultasAPI.xml");
    c.IncludeXmlComments(filePath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("/Home/Error");    
    //app.UseHsts();
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ConsultasAPI v1"));
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ConsultasAPI v1"));
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors("AllowLocalhost");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
