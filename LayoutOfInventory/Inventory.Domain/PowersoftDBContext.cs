using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain
{
   public class PowersoftDBContext : DbContext
   {
      public PowersoftDBContext(DbContextOptions<PowersoftDBContext> options) : base(options)
      {

      }
   }
}
