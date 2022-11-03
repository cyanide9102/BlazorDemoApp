using Ardalis.Specification.EntityFrameworkCore;

using BlazorDemoApp.Core.Interfaces;

namespace BlazorDemoApp.Infrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IRepository<T>, IReadRepository<T> where T : class, IAggregateRoot
{
    private readonly AppDbContext _context;

    public EfRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}
