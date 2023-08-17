using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Inventory.Repository.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Inventory.Domain;

namespace Inventory.Repository.Implementations
{
    public class RepositoryRegistration : IRepositoryRegistration
    {
        public void AddInfrastucture(IServiceCollection services, string conStr)
        {
            services.AddDbContext<PowersoftDBContext>(options =>
            {
                options.UseSqlServer(conStr);
            });
            //services.AddTransient<IUserRepository, UserRepository>();
            //services.AddTransient<ICompanyRepo, CompanyRepository>();
            //services.AddTransient<IAttributeRepo, AttributeRepository>();
            //services.AddTransient<IMachinRepo, MachineRepository>();
            //services.AddTransient<IMeasurementUnitRepo, MeasurementRepository>();
            //services.AddTransient<IProjectRepo, ProjectRepository>();
            //services.AddTransient<ICustomerRepo, CustomerRepository>();
            //services.AddTransient<IProducerRepository, ProducerRepository>();
            //services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            //services.AddTransient<IPaymentMethodRepo, PaymentMethodRepository>();
            //services.AddTransient<ISampleTypeRepository, SampleTypeRepository>();
            //services.AddTransient<ISpecificationHeadRepository, SpecificationHeadRepository>();
            //services.AddTransient<IAttributeTypeRepo, AttributeTypeRepository>();

        }

    }
}
