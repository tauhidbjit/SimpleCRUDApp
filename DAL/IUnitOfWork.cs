using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	//IUnitOfWork interface
	//This interface inherits the IDisposable interface
	//This interface also exposes two repositories which are ICourseRepository and IAuthorRepository

	public interface IUnitOfWork : IDisposable
	{
        IMemberRepository Members { get; }
		int Complete();
	}
}
