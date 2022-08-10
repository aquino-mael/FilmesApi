using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Repositories;

public class FilmeRepository
{
    private readonly FilmeContext _filmeDbContext;

    public FilmeRepository(FilmeContext filmeDbContext)
    {
        _filmeDbContext = filmeDbContext;
    }

    public async Task<Filme?> GetAsync(Guid id)
    {
        return await _filmeDbContext.Filmes.AsNoTracking().FirstOrDefaultAsync(f => f.Id.Equals(id));
    }

    public async Task<IEnumerable<Filme>> GetAllAsync()
    {
        return await _filmeDbContext.Filmes.AsNoTracking().ToListAsync();
    }

    public async Task<Filme> CreateFilmeAsync(Filme filme)
    {
        var savedFilme = await _filmeDbContext.AddAsync<Filme>(filme);
        await _filmeDbContext.SaveChangesAsync();

        return savedFilme.Entity;
    }
}