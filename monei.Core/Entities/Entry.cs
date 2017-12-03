using System;
using System.Collections.Generic;
using System.Linq;

namespace monei.Core.Entities 
{
    public class Entry : EntityBase<int>
    {
        public Account Account { get; set; }
            
        public DateTime Date { get; set; }            
            
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public EntryType EntryType { get; set; }
        public string Note { get; set; }
        public bool IsTaxDeductible { get; set; }
        public bool IsSpecialEvent { get; set; }
        public Category Category { get; set; }
        public Subcategory Subcategory { get; set; }

        public decimal CashFlowChange => EntryType == EntryType.Outcome ? -Amount :
                                         EntryType == EntryType.Income ? Amount :
                                         0;           
              
    }

}
