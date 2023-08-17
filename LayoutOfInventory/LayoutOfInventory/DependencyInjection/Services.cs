using Inventory.Service.Contracts;
using Inventory.Service.Implementations;

namespace LayoutOfInventory.DependencyInjection
{
   public static class Services
   {
      public static IFacadeRegistration Service { get; set; } = new FacadeRegistration();

      public static void RegisterDependencies(IServiceCollection services, string conStr)
      {
         Service.AddInfrastucture(services, conStr);
      }
   }
}
