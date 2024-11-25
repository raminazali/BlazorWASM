using System;
using BlazorWasm.Entities.Contaters.Dtos;

namespace BlazorWasm.Entities.Contaters.Contracts;

public interface IContactersService
{
    Task Create(CreateContacterDto dto);
}
