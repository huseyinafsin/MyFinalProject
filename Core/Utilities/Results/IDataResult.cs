using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.NewFolder.Results;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
