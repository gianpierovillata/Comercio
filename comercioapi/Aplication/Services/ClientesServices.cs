namespace Comercio.Aplication.Services;

using Comercio.Domain.Entities;
using Comercio.Domain.Repositories;

public class ClientesServices
{
    private readonly IClientes _clientesRepository;

    public ClientesServices(IClientes clientesRepository)
    {
        _clientesRepository = clientesRepository;
    }

    public async Task<List<Cliente>> GetClientesAsync()
    {
        return await _clientesRepository.GetClientesAsync();
    }

}