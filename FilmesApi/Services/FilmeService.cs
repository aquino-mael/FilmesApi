using FilmesApi.Models;
using FilmesApi.Repositories;

namespace FilmesApi.Services;

public class FilmeService
{
    private readonly FilmeRepository _filmeRepository;

    public FilmeService(FilmeRepository filmeRepository)
    {
        _filmeRepository = filmeRepository;
    }

    public async Task<Filme> CreateFilmeAsync(Filme filme)
    {
        return await _filmeRepository.CreateFilmeAsync(filme);
    }

    public async Task<Filme?> GetAsync(Guid id)
    {
        return await _filmeRepository.GetAsync(id);
    }

    public async Task<IEnumerable<Filme>> GetAsync()
    {
        return await _filmeRepository.GetAllAsync();
    }
}