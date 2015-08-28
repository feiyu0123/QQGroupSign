using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQGroupSign
{
    public class QQGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            return GroupName;
        }
    }
}
