using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.NewFolder.Results;

namespace Core.Utilities.Results
{
    public class ErrorResult :Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult( string message) : base(false, message)
        {
        }
    }
}
