using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SqlProvider.Data;
using SqlProvider.Entities;
using SqlProvider.Interfaces;
using SqlProvider.ViewModels;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestRepository _repo;
        private readonly IMapper _mapper;
        public RequestController(IRequestRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Request>>> GetRequests()
        {
            var Requests = await _repo.GetRequestsAsync();
            return Ok(Requests);
        }
        [HttpPost]
        public async Task<ActionResult<Result>> AddRequest(IncomeRequestViewModel vmRequest)
        {
            Request request = _mapper.Map<Request>(vmRequest);
            var result = await _repo.AddRequestAsync(request);
            return Ok(result);
        }
    }
}