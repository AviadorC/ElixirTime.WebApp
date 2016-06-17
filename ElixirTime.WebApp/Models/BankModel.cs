using System;
using System.Collections.Generic;

namespace ElixirTime.WebApp.Controllers
{
    public class BankModel : BankBaseModel
    {
        public List<DateTime> IncomeSessions { get; set; }

        public List<DateTime> OutcomeSessions { get; set; }
    }
}