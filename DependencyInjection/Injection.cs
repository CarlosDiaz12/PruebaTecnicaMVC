using Microsoft.Extensions.DependencyInjection;
using PruebaTecnica.BusinessLogic.Service;
using PruebaTecnica.DataAccess.Interface;
using PruebaTecnica.DataAccess.Model;
using PruebaTecnica.DataAccess.Repository;

namespace PruebaTecnicaMVC.DependencyInjection
{
    public static class Injection
    {
        public static IServiceCollection InjectServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Estudiante>, EstudianteRepository>();
            services.AddScoped<IRepository<Profesor>, ProfesorRepository>();
            services.AddScoped<IRepository<Aula>, AulaRepository>();
            services.AddScoped<IRepository<Asignatura>, AsignaturaRepository>();
            services.AddScoped<IRepository<Asignacion>, AsignacionRepository>();
            services.AddScoped<EstudianteService, EstudianteService>();
            return services;
        }

    }
}
