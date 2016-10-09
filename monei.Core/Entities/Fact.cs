using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei.Core.Entities 
{
    public class Fact : EntityBase<int>
    {
        public virtual Account Account { get; set; }
            
        public virtual DateTime Date { get; set; }            
            
        public virtual decimal Amount { get; set; }
        public FactType FactType { get; set; }
        public virtual string Note { get; set; }
        public virtual bool IsTaxDeductible { get; set; }
        public virtual bool IsSpecialEvent { get; set; }
        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public decimal CashFlowAmount {
            get {
                return FactType == FactType.Transfer ? 0 
                    : FactType == FactType.Income ? Amount 
                    : - Amount;
            }
        }      
    }

}
