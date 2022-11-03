using Ardalis.Specification;

namespace BlazorDemoApp.Core.Interfaces;
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
