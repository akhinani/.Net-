using ProductMicroservice.Models;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        void DeleteProduct(int id);
        object GetProductByID(int id);
        object GetProducts();
        void InsertProduct(Product product);
        void UpdateProduct(Product product);

        public interface IProductRepository 
        {
            IEnumerable<Product> GetProducts();

            object GetById(int id);
            

            Product GetProductById(int Id);

            void InsertProduct(Product Product);

            void DeleteProduct(Product Product);

            void UpdateProduct(Product Product);

            void Save();
        }

    }
}
