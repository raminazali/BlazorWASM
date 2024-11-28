using System;
using BlazorWasm.Entities.Contaters.Dtos;

namespace BlazorWasm.Entities.Contaters.Contracts;

public interface IContactersService
{
    Task<bool> Create(CreateContacterDto dto);
}
