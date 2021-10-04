using AutoMapper;
using Buildings.Domain.Data;
using Buildings.Domain.Data.Models;
using Buildings.Model.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Buildings.Domain.Handlers.Implementation
{
    public class AccountsHandler : BaseHandler, IAccountsHandler
    {
        private readonly IEntityRepository<Account> _buildingRepository;
        private readonly IMapper _mapper;
        public AccountsHandler(IEntityRepository<Account> accountsRepository, IMapper mapper)
        {
            _buildingRepository = accountsRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AccountDto>> GetAll()
        {
            var entities = await _buildingRepository.GetAllAsync();
            var accounts = new List<AccountDto>();
            foreach(var entity in entities)
            {
                var dto = _mapper.Map<AccountDto>(entity);
                accounts.Add(dto);
            }
            return accounts;
        }
        public async Task<AccountDto> Get(Guid id)
        {
            var entity = await _buildingRepository.GetByIdAsync(id);

            var dto = _mapper.Map<AccountDto>(entity);

            return dto;
        }
        public async Task Save(AccountDto dto)
        {
            var entity = _mapper.Map<Account>(dto);

            await _buildingRepository.InsertAsync(entity);
        }

    }
}
