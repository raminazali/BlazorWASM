using System;
using System.Net.Http.Json;
using System.Text.Json;
using BlazorWasm.Entities.Contaters.Contracts;
using BlazorWasm.Entities.Contaters.Dtos;

namespace BlazorWasm.Entities.Contaters.Services;

public class ContactersService : IContactersService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _options;
    public ContactersService(HttpClient client)
    {
        _client = client;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }
    public async Task Create(CreateContacterDto dto)
    {
        var response = await _client.PostAsJsonAsync("products");
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        var products = JsonSerializer.Deserialize<List<Product>>(content, _options);
        return products;
    }
}
