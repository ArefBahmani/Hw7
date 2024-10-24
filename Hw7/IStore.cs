
public interface IStore
{
    public List<Product> GetAllProducts();
    public void AddProductToCart(Product product, int count);
    public void ViewShoppingCart();
    public void Checkout();
    public void ShowFactor(int userId);
    public void Increase(int amount);



}

