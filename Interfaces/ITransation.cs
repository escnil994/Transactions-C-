using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions_DC
{
    internal interface ITransation
    {
        string amount { get; set; }
        string cardNumber { get; set; }
        string cardType { get; set; }
        string authorization { get; set; }
        string reference { get; set; }
        string date { get; set; }
        string time { get; set; }
        string responseMessage { get; set; }
        string mrc { get; set; }
        string trm { get; set; }
        string sequential { get; set; }


        string error { get; set; }

    }
}
