using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daren.Baker.Bjss.Assignment.Domain.Entities
{
    public abstract class BaseEntityGuidKey
    {
        public virtual Guid Id { get; set; }
    }
}
