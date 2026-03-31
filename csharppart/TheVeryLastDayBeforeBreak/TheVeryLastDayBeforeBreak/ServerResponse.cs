using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVeryLastDayBeforeBreak
{
    public class ServerResponse
    {
        public string Message { get; set; }
        public override string ToString()
        {
            return Message;
        }
    }
}
