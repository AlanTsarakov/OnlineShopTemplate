using OnlineShopTemplate.Models;

namespace OnlineShopTemplate.Repositories
{
    public static class ProductsRepository
    {
        private static int _instanceCounter = 0;

        private static readonly List<Product> _products =
        [
            new Product(++_instanceCounter, "Товар 1", 1000.0M, "Описание товара 1"),
            new Product(++_instanceCounter, "Товар 2", 2000.0M, "Описание товара 2"),
            new Product(++_instanceCounter, "Товар 3", 3000.0M, "Описание товара 3"),
            new Product(++_instanceCounter, "Товар 4", 4000.0M, "Описание товара 4"),
            new Product(++_instanceCounter, "Товар 5", 5000.0M, "Описание товара 5")
        ];

        public static List<Product> GetAll() => _products;

        public static void Add(string name, decimal cost, string description)
        {
            var product = new Product(++_instanceCounter, name, cost, description);

            _products.Add(product);
        }

        internal static Product? TryGetById(int id)
        {
            return _products.FirstOrDefault(product => product.Id == id);
        }
    }
}
