using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS.Common
{
    public class ServiceResult<T>
    {
        public T Result { get; set; }

        public bool State { get; set; }

        public string Message { get; set; }

    }
}
