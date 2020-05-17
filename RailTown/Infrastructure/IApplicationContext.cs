using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailTown.Infrastructure
{
    public interface IApplicationContext
    {
        Task<string> MakeExternalCall(string functionName);
    }
}
