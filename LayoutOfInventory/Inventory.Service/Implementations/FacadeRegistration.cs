using Microsoft.Extensions.DependencyInjection;
using Inventory.Repository.Contracts;
using Inventory.Repository.Implementations;
using Inventory.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Inventory.Service.Implementations
{
    public class FacadeRegistration : IFacadeRegistration
    {
        public static IRepositoryRegistration Registration { get; set; } = new RepositoryRegistration();

        public void AddInfrastucture(IServiceCollection services, string conStr)
        {
            Registration.AddInfrastucture(services, conStr);

            //services.AddTransient<IUserFacade, UserFacade>();
            //services.AddTransient<ICompanyFacade, CompanyFacade>();
            //services.AddTransient<IAttributeFacade, AttributeFacade>();
            //services.AddTransient<IMachineFacade, MachineFacade>();
            //services.AddTransient<IMeasurementUnitFacade, MeasurementUnitFacade>();
            //services.AddTransient<IProjectFacade, ProjectFacade>();
            //services.AddTransient<ICustomerFacade, CustomerFacade>();
            //services.AddTransient<ICurrencyFacade, CurrencyFacade>();
            //services.AddTransient<IProducerFacade, ProducerFacade>();
            //services.AddTransient<IPaymentMethodFacade, PaymentMethodFacade>();
            //services.AddTransient<ISampleTypeFacade, SampleTypeFacade>();
            //services.AddTransient<ISpecificationHeadFacade, SpecificationHeadFacade>();
            //services.AddTransient<IAttributeTypeFacade, AttributeTypeFacade>();

            

        }
    }
}
