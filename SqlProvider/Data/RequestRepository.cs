using Microsoft.EntityFrameworkCore;
using SqlProvider.Context;
using SqlProvider.Entities;
using SqlProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlProvider.Data
{
    public class RequestRepository : IRequestRepository
    {
        private readonly TaskContext _context;
        public RequestRepository(TaskContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Request>> GetRequestsAsync()
        {
            return await _context.Requests.ToListAsync();
        }

        public async Task<Result> AddRequestAsync(Request request)
        {
            Request exisitingRequest = await _context.Requests.SingleOrDefaultAsync(P=>P.MobileNumber== request.MobileNumber);
            Result result = new Result();
            if (exisitingRequest !=null)
            {
                return result.Duplicate();
            }
            else
            {
                request.RequestDate = DateTime.Now;
                await _context.Requests.AddAsync(request);
                if (SaveChanges())
                {
                    return result.Success();
                }
                else
                {
                    return result.Failed();
                }
            }
            
        }
        private bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {

                return false;
            }
        }
    }
}
