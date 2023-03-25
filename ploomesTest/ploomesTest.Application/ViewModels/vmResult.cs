using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Application.ViewModels
{
    public class vmResult
    {
        public object data { get; set; }
        public string friendlyErrorMessage { get; set; }
        public string message { get; set; }
        public string stackTrace { get; set; }
    }
}
