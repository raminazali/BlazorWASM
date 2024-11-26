using System;
using System.Net.Http.Json;
using System.Text.Json;
using BlazorWasm.Data.WrapperRepository.Contracts;
using BlazorWasm.Entities.Contaters.Contracts;
using BlazorWasm.Entities.Contaters.Dtos;

namespace BlazorWasm.Data.Services;

public class ContactersService : IContactersService
{
    private readonly IHttpClientWrapper _wrapper;
    private readonly JsonSerializerOptions _options;
    public ContactersService(IHttpClientWrapper wrapper)
    {
        _wrapper = wrapper;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }
    public async Task<bool> Create(CreateContacterDto dto)
    {
        return await _wrapper.PostAsync<CreateContacterDto>("contacters", dto);
    }
}
