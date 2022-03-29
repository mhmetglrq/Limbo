using Limbo.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Entities.Concrete
{
    public class Department:EntityBase,IEntity
    {
        public string Name { get; set; }
        public int UniversityId { get; set; }
        public int CommentCount { get; set; }
        public int NegativeCount { get; set; }
        public int PositiveCount { get; set; }
        public University University { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}
