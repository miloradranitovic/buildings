using Buildings.Model.Dto;
using System;
using System.Threading.Tasks;

namespace Buildings.Domain.Handlers
{
    public interface IBuildingHandler
    {
        Task<BuildingDto> Get(Guid id);
        Task Save(BuildingDto dto);
    }
}
