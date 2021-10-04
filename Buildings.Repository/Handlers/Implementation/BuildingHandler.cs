using AutoMapper;
using Buildings.Domain.Data;
using Buildings.Domain.Data.Models;
using Buildings.Model.Dto;
using System;
using System.Threading.Tasks;

namespace Buildings.Domain.Handlers.Implementation
{
    public class BuildingHandler : BaseHandler, IBuildingHandler
    {
        private readonly IEntityRepository<Building> _buildingRepository;
        private readonly IMapper _mapper;
        public BuildingHandler(IEntityRepository<Building> buildingRepository, IMapper mapper)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
        }
        public async Task<BuildingDto> Get(Guid id)
        {
            var entity = await _buildingRepository.GetByIdAsync(id);

            var dto = _mapper.Map<BuildingDto>(entity);

            return dto;
        }
        public async Task Save(BuildingDto dto)
        {
            var entity = _mapper.Map<Building>(dto);

            await _buildingRepository.InsertAsync(entity);
        }

    }
}
