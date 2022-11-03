using Ardalis.GuardClauses;

using BlazorDemoApp.Core.Interfaces;

namespace BlazorDemoApp.Core.Entities.CartAggregate;
public class Cart : EntityBase, IAggregateRoot
{
    private readonly List<CartItem> _cartItems = new();
    public IEnumerable<CartItem> CartItems => _cartItems.AsReadOnly();

    public void AddProductToCart(int productId, int qty)
    {
        Guard.Against.NegativeOrZero(productId, nameof(productId));
        Guard.Against.NegativeOrZero(qty, nameof(qty));

        var cartItem = _cartItems.FirstOrDefault(x => x.ProductId == productId);
        if (cartItem != null)
        {
            cartItem.Qty = qty;
        }
        else
        {
            _cartItems.Add(new CartItem(productId, qty));
        }
    }

    public void RemoveProductFromCart(int productId)
    {
        Guard.Against.NegativeOrZero(productId, nameof(productId));

        var cartItem = _cartItems.FirstOrDefault(x => x.ProductId == productId);
        if (cartItem != null)
        {
            _cartItems.Remove(cartItem);
        }
    }
}
