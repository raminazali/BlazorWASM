using System;
using System.Net.Http.Json;
using BlazorWasm.Data.WrapperRepository.Contracts;

namespace BlazorWasm.Data.WrapperRepository;

public class HttpClientWrapper : IHttpClientWrapper
{
    private readonly HttpClient _httpClient;

    public HttpClientWrapper(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T> GetAsync<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode(); // Throws an exception if the response is unsuccessful
        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task<bool> PostAsync<T>(string url, T payload)
    {
        var response = await _httpClient.PostAsJsonAsync(url, payload);
        if (response.IsSuccessStatusCode) return true;
        return false;
    }

    public async Task<bool> PutAsync<T>(string url, T payload)
    {
        var response = await _httpClient.PutAsJsonAsync(url, payload);
        if (response.IsSuccessStatusCode) return true;
        return false;
    }

    public async Task DeleteAsync(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
    }
}
