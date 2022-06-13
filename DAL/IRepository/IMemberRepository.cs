using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    /// <summary>
    ///Custom Repository
    ///This repository derives from our generic repository interface i.e.IRepository
    ///As it derives from IRepository, it inherits all the generic methods in IRepository
    ///Additionally it has two more operations which are GetTopSellingCourse, GetCourseWithAuthors
    /// </summary>
    public interface IMemberRepository : IRepository<Member>
    {
        //IEnumerable<Member> GetTopSellingCourse(int count);
        //IEnumerable<Member> GetCourseWithAuthors(int pageIndex, int pageSize);
    }
}
