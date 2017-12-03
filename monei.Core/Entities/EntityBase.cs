using System;
using System.Collections.Generic;
using System.Linq;
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

        public TKey Id { get; set; }

        public DateTime CreationDate { get; set; } 
        public DateTime? LastModificationDate { get; set; }
        //public virtual Account CreationAccount { get; set; }
        //public virtual Account LastUpdateAccount { get; set; }
    }        
}
