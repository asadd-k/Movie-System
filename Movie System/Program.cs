using Microsoft.EntityFrameworkCore;
using Movie_System.Data;
using Movie_System.Data.Services;

internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		//Db Context
		builder.Services.AddDbContext<AppDb>(options => options.UseSqlServer(
			builder.Configuration.GetConnectionString("DefaultConnection")
			)) ;

		// Add services to the container.
		builder.Services.AddScoped<IActorsService, ActorsService>(); 
		builder.Services.AddControllersWithViews();

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{controller=Home}/{action=Index}/{id?}");

		AppDbInitializer.Seed(app); 

		app.Run();
	}
}