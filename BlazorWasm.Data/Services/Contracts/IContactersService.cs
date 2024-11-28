using BlazorWasm.Data.Entities.Contaters.Dtos;

namespace BlazorWasm.Entities.Contaters.Contracts;

public interface IContactersService
{
    Task<bool> Create(CreateContacterDto dto);
}
