using SqlProvider.Data;
using SqlProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlProvider.Interfaces
{
    public interface IRequestRepository
    {
        Task<IReadOnlyList<Request>> GetRequestsAsync();
        Task<Result> AddRequestAsync(Request request);
    }
}
