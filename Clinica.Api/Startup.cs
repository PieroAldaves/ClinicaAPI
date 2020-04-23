using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Clinica.Repository;
using Clinica.Repository.context;
using Clinica.Repository.Implementation;
using Clinica.Service;
using Clinica.Service.implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;


namespace Clinica.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddEntityFrameworkNpgsql ().AddDbContext<ApplicationDbContext> (opt =>
            opt.UseNpgsql (Configuration.GetConnectionString ("DefaultConnection")));


            services.AddTransient<IEspecialidadRepository, EspecialidadRepository> ();
            services.AddTransient<IEspecialidadService, EspecialidadService> ();

            services.AddTransient<IHorarioRepository, HorarioRepository> ();
            services.AddTransient<IHorarioService, HorarioService> ();

            services.AddTransient<IHorarioSeguroRepository, HorarioSeguroRepository> ();
            services.AddTransient<IHorarioSeguroService, HorarioSeguroService> ();

            services.AddTransient<IMedicoRepository, MedicoRepository> ();
            services.AddTransient<IMedicoService, MedicoService> ();

            services.AddTransient<IMedicoEspecialidadRepository, MedicoEspecialidadRepository> ();
            services.AddTransient<IMedicoEspecialidadService, MedicoEspecialidadService> ();

            services.AddTransient<IPacienteRepository, PacienteRepository> ();
            services.AddTransient<IPacienteService, PacienteService> ();

            services.AddTransient<IReservaRepository, ReservaRepository> ();
            services.AddTransient<IReservaService, ReservaService> ();

            services.AddTransient<IRolRepository, RolRepository> ();
            services.AddTransient<IRolService, RolService> ();

            services.AddTransient<ISedeRepository, SedeRepository> ();
            services.AddTransient<ISedeService, SedeService> ();

            services.AddTransient<ISeguroRepository, Seguropository> ();
            services.AddTransient<ISeguroService, SeguroService> ();

            services.AddTransient<ISeguroRepository, Seguropository> ();
            services.AddTransient<ISeguroService, SeguroService> ();

            services.AddTransient<ITurnoRepository, TurnoRepository> ();
            services.AddTransient<ITurnoService, TurnoService> ();

            services.AddTransient<IUsuarioRepository, UsuarioRepository> ();
            services.AddTransient<IUsuarioService, UsuarioService> ();

            services.AddCors (options => {
                options.AddPolicy ("Todos",
                    builder => builder.WithOrigins ("*").WithHeaders ("*").WithMethods ("*"));
            });


            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Clinica", Version = "v1" });
            // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(SwaggerConfiguration.EndpointUrl, SwaggerConfiguration.EndpointDescription);
            });
            
            

        }
    }
}
