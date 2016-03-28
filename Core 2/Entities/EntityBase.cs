using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei.Core.Entities
{
    public abstract class EntityBase<TKey>
    {
        public EntityBase()
        {
            CreationDate = DateTime.UtcNow;
            LastModificationDate = null;
        }

        public virtual TKey Id { get; set; }

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime? LastModificationDate { get; set; }
        //public virtual Account CreationAccount { get; set; }
        //public virtual Account LastUpdateAccount { get; set; }
    }

}
