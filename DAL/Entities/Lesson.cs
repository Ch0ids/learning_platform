using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities.Common;

namespace DAL.Entities
{
    public class Lesson : BaseEntity<Guid>
    {
        public required string Title { get; set; }
        public string? Description { get; set; }

        public virtual List<Word>? Word { get; set; }
    }
}
