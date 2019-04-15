using FullstackDeveloperAssessment.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace FullstackDeveloperAssessment
{
	public class Startup
	{
		private IConfiguration _configuration;

		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsetting.json", optional: true, reloadOnChange: true)
				.AddJsonFile("config.json", optional: true, reloadOnChange: true);

			_configuration = builder.Build();
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			var sqlConnection = _configuration.GetConnectionString("AppConnection");
			services.AddDbContext<AppDataContext>(options => options.UseSqlServer(sqlConnection, b => b.MigrationsAssembly("FullstackDeveloperAssessment.Data")));

			services.AddCors();
			services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:4200"));
			//app.UseStaticFiles();
			app.UseMvc();

			using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
			{
				var context = scope.ServiceProvider.GetService<AppDataContext>();
				context.Database.Migrate();
				context.EnsureDatabaseSeeded();
			}
		}


		public void ConfigureServicesUnit(IServiceCollection services)
		{
			//services.AddTransient<ILoginBLL, LoginBLL>();
			//services.AddTransient<IUsuarioBLL, UsuarioBLL>();
			//services.AddTransient<IPerfilBLL, PerfilBLL>();
			//services.AddTransient<IUsuarioService, UsuarioService>();
			//services.AddTransient<IPerfilService, PerfilService>();

		}

		public void ConfigureRepositoriesUnit(IServiceCollection services)
		{
			//services.AddScoped<IUsuarioRepository, UsuarioRepository>();
			//services.AddScoped<IPerfilRepository, PerfilRepository>();
		}
	}
}
