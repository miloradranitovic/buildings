using Buildings.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildings.Domain.Handlers
{
    public interface IAccountsHandler
    {
        Task<AccountDto> Get(Guid id);
        Task Save(AccountDto dto);
        Task<IEnumerable<AccountDto>> GetAll();
    }
}
