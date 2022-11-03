using Ardalis.GuardClauses;

using BlazorDemoApp.Core.Interfaces;

namespace BlazorDemoApp.Core.Entities.BrandAggregate;
public class Brand : EntityBase, IAggregateRoot
{
    public Brand(string name)
    {
        Guard.Against.NullOrEmpty(name, nameof(name));
        Name = name;
    }

    public string Name { get; private set; }

    public void Update(string name)
    {
        Guard.Against.NullOrEmpty(name, nameof(name));
        Name = name;
    }
}
