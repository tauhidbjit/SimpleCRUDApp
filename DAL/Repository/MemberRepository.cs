using DAL.IRepository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.Repository
{
	public class MemberRepository : Repository<Member>, IMemberRepository
	{
        public MemberRepository(AppEntities context) : base(context)
        {
        }

        public AppContext appContext
        {
            get { return Context as AppContext; }
        }
    }
}
