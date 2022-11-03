namespace BlazorDemoApp.Core.Entities.CartAggregate;
public class CartItem : EntityBase
{
    public CartItem(int productId, int qty)
    {
        ProductId = productId;
        Qty = qty;
    }

    public int ProductId { get; set; }
    public int Qty { get; set; }
}
