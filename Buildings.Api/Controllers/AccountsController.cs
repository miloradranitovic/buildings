using Buildings.Domain.Handlers;
using Buildings.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buildings.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsHandler _accountsHandler;
        public AccountsController(IAccountsHandler accountsHandler)
        {
            _accountsHandler = accountsHandler;
        }
        
        [HttpGet]
        public async Task<IEnumerable<AccountDto>> Get()
        {
            return await _accountsHandler.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<AccountDto> Get(string id)
        {
            var accountDto = await _accountsHandler.Get(new Guid(id));

            return accountDto;
        }

        [HttpPost]
        public async Task Post([FromBody] AccountDto dto)
        {
            await _accountsHandler.Save(dto);

        }
    }
}
