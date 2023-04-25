using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusApi.EntityLayer.Concrete
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string SenderAccount { get; set; }
        public string ReceiverAccount { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
