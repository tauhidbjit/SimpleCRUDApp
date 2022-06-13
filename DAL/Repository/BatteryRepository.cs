using DAL.IRepository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository
{
	public class BatteryRepository : Repository<Battery>, IBatteryRepository
	{
        public BatteryRepository(InventoryDBEntities context) : base(context)
        {
        }

        public InventoryDBContext inventoryDBContext
        {
            get { return Context as InventoryDBContext; }
        }
    }
}
