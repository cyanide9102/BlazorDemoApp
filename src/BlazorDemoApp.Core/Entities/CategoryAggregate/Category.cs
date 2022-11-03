using Ardalis.GuardClauses;

using BlazorDemoApp.Core.Interfaces;

namespace BlazorDemoApp.Core.Entities.CategoryAggregate;
public class Category : EntityBase, IAggregateRoot
{
    public Category(string name) : base()
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
