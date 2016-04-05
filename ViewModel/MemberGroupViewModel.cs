using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MemberGroupViewModel
    {
        public int ID { get; set; }
        public Nullable<int> Member { get; set; }
        public Nullable<int> AssociatedMember { get; set; }
        public string AssociateUserName { get; set; }
        public string Password { get; set; }
    }
}
