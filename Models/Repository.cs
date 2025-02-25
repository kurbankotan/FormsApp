namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();

        public static List<Product> Products
        {
            get{
                return _products;
            }
        }



        private static readonly List<Category> _categories = new();
        public static List<Category> Categories
        {
            get{
                return _categories;
            }
        }


        //Static Contructor
        static Repository()
        {
            _categories.Add(new Category {CategoryId=1, Name="Telefon"});
            _categories.Add(new Category {CategoryId=2, Name="bilgisayar"});

            _products.Add(new Product{ProductId=1, Name = "Iphone 14", Price=4000, IsActive=true, Image="1.jpg", CategoryId=1 });
            _products.Add(new Product{ProductId=2, Name = "Iphone 15", Price=5000, IsActive=true, Image="2.jpg", CategoryId=1 });
            _products.Add(new Product{ProductId=3, Name = "Iphone 16", Price=6000, IsActive=false, Image="3.jpg", CategoryId=1 });
            _products.Add(new Product{ProductId=4, Name = "Iphone 17", Price=7000, IsActive=true, Image="4.jpg", CategoryId=1 });


            _products.Add(new Product{ProductId=5, Name = "Macbook Air", Price=8000, IsActive=true, Image="5.jpg", CategoryId=2 });
            _products.Add(new Product{ProductId=6, Name = "Macbook Pro", Price=9000, IsActive=true, Image="6.jpg", CategoryId=2 });
        }



        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        
        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p=>p.ProductId==updatedProduct.ProductId);

            if(entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }


        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p=>p.ProductId==updatedProduct.ProductId);

            if(entity != null)
            {
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        
        public static void DeleteProduct(Product productToBeDeleted)
        {
            var entity = _products.FirstOrDefault(p=>p.ProductId==productToBeDeleted.ProductId);
            
            if(entity != null)
            {
                _products.Remove(entity);
            }
        }

    }
}