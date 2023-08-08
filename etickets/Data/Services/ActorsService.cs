using etickets.Data.Base;
using etickets.Models;

namespace etickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
     
        public ActorsService (AppDbContext context)  : base(context) { }
       

        

        }
    }

