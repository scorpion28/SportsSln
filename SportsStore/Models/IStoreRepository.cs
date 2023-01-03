namespace SportsStore.Models;

public interface IStoreRepository
{
    public IQueryable<Product> Products { get; }

    void CreateProduct(Product p);
    void SaveProduct(Product p);
    void DeleteProduct(Product p);
}