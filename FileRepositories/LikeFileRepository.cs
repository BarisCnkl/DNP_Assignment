using Entities;
using RepositoryContracts;

namespace FileRepositories;

public class LikeFileRepository : ILikeRepository
{
    public Task<Like> AddAsync(Like like)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Like like)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Like> GetSingleAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Like> GetMany()
    {
        throw new NotImplementedException();
    }
}