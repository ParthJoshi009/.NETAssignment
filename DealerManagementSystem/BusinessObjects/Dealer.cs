using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Dealer
    {
        public int Id { get; set; }
        public string DealerName { get; set; }
        public int DealerNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
    }
}
