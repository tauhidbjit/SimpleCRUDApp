using DAL.IRepository;
using DAL.Repository;

namespace DAL
{
    //UnitOfWork class implementation

    public class UnitOfWork : IUnitOfWork
	{
        private readonly AppEntities _context;

        public UnitOfWork()
        {
            _context = new AppEntities();
            Members = new MemberRepository(_context);
        }

        public IMemberRepository Members { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
