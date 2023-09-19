using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using ASKProjekt.Server.Data;
using ASKProjekt.Server.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var glosorDbString = builder.Configuration.GetConnectionString("GlosorDbConnection") ?? throw new InvalidOperationException("Connection string 'GlosorDbConnection' not found.");
builder.Services.AddDbContext<GlosorDbContext>(options =>
	options.UseSqlServer(glosorDbString));

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IGlosorRepo, GlosorRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
