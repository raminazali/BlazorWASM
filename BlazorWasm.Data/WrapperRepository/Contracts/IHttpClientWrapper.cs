using System;

namespace BlazorWasm.Data.WrapperRepository.Contracts;

public interface IHttpClientWrapper
{
    Task<T> GetAsync<T>(string url);
    Task<bool> PostAsync<T>(string url, T payload);
    Task<bool> PutAsync<T>(string url, T payload);
    Task DeleteAsync(string url);
}

