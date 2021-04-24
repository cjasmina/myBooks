using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AutoMapper;

using myBooks.API.Security;
using myBooks.API.Services;
using myBooks.API.Database;
using myBooks.Model.Requests;

namespace myBooks.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "myBooks API V1",
                    Version = "v1"
                });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id = "basic",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new string[] {}
                    }
                });
            });

            services.AddScoped<IBaseCrudService<Model.Autori, AutoriSearchRequest, AutoriUpsertRequest, AutoriUpsertRequest>, AutoriService>();
            services.AddScoped<IBaseCrudService<Model.Drzave, DrzaveSearchRequest, DrzaveUpsertRequest, DrzaveUpsertRequest>, DrzaveService>();
            services.AddScoped<IBaseCrudService<Model.Gradovi, GradoviSearchRequest, GradoviUpsertRequest, GradoviUpsertRequest>, GradoviService>();
            services.AddScoped<IBaseCrudService<Model.IzdavackeKuce, IzdavackeKuceSearchRequest, IzdavackeKuceInsertRequest, IzdavackeKuceInsertRequest>, IzdavackeKuceService>();
            services.AddScoped<IBaseCrudService<Model.Jezici, JeziciSearchRequest, JeziciUpsertRequest, JeziciUpsertRequest>, JeziciService>();
            services.AddScoped<IBaseCrudService<Model.Zanrovi, ZanroviSearchRequest, ZanroviInsertRequest, ZanroviInsertRequest>, ZanroviService>();
            services.AddScoped<IBaseCrudService<Model.Police, PoliceSearchRequest, PoliceInsertRequest, PoliceInsertRequest>, PoliceService>();
            services.AddScoped<IBaseCrudService<Model.PoliceKnjige, PoliceKnjigeSearchRequest, PoliceKnjigeUpsertRequest, PoliceKnjigeUpsertRequest>, PoliceKnjigeService>();
            services.AddScoped<IBaseCrudService<Model.Knjige, KnjigeSearchRequest, KnjigeUpsertRequest, KnjigeUpsertRequest>, KnjigeService>();
            services.AddScoped<IBaseCrudService<Model.KnjigeAutori, KnjigeAutoriSearchRequest, KnjigeAutoriInsertRequest, KnjigeAutoriInsertRequest>, KnjigeAutoriService>();
            services.AddScoped<IBaseCrudService<Model.Korisnici, KorisniciSearchRequest, KorisniciUpsertRequest, KorisniciUpsertRequest>, KorisniciService>();
            services.AddScoped<IBaseCrudService<Model.Ocjene, OcjeneSearchRequest, OcjeneInsertRequest, OcjeneInsertRequest>, OcjeneService>();
            services.AddScoped<IBaseCrudService<Model.Recenzije, RecenzijeSearchRequest, RecenzijeInsertRequest, RecenzijeInsertRequest>, RecenzijeService>();
            services.AddScoped<IBaseCrudService<Model.Prijedlozi, PrijedloziSearchRequest, PrijedloziInsertRequest, PrijedloziInsertRequest>, PrijedloziService>();
            services.AddScoped<IPrijavaService, PrijavaService>();

            services.AddAuthentication("BasicAuthentication")
                    .AddScheme<AuthenticationSchemeOptions, DefaultAuthenticationHandler>("BasicAuthentication", null);

            var connection = Configuration.GetConnectionString("myBooks");
            services.AddDbContext<myBooksContext>(options => options.UseSqlServer(connection));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "myBooks API V1");
            });

            app.UseMvc();
        }
    }
}
