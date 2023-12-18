using DAL.Entities;
using DAL.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface ILessonRepository : IBaseRepo<Lesson, Guid>
    {
    }
}
