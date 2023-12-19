namespace FormsApp.Models
{
    public class Repository
    {

        private static readonly List<Product> _prducts = new();
        private static readonly List<Category> _categories = new();

        static Repository(){

            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });
            _prducts.Add(new Product {ProductId=1,Name="IPhone 14",Price=40999,IsActive=true,Image="1.jpg", CategoryId = 1 });
            _prducts.Add(new Product { ProductId = 2, Name = "IPhone 15", Price = 50999, IsActive = true, Image = "2.jpg", CategoryId = 1 });
            _prducts.Add(new Product { ProductId = 3, Name = "IPhone 16", Price = 60999, IsActive = false, Image = "2.jpg", CategoryId = 1 });
            _prducts.Add(new Product { ProductId = 4, Name = "Samsung A53", Price = 100999, IsActive = false, Image = "4.jpg", CategoryId = 1 });

            _prducts.Add(new Product { ProductId = 5, Name = "Macbook Pro", Price = 120999, IsActive = true, Image = "8.jpg", CategoryId = 2 });
            _prducts.Add(new Product { ProductId = 6, Name = "Lenovo ThinkPad", Price = 20999, IsActive = true, Image = "9.jpg", CategoryId = 2 });



        }


        public static List<Product> Products {
            get {
                return _prducts;
            }
        }
        public static void CreateProduct(Product entity)
        {
            _prducts.Add(entity);
        }

        public static void EditProduct(Product updateProduct) {
            var entity = _prducts.FirstOrDefault(p => p.ProductId == updateProduct.ProductId);
            if (entity != null)
            {
                entity.Name = updateProduct.Name;
                entity.Price = updateProduct.Price;
                entity.Image = updateProduct.Image;
                entity.CategoryId = updateProduct.CategoryId;
                entity.IsActive = updateProduct.IsActive;

            }
        }


        public static void EditIsActive(Product updateProduct)
        {
            var entity = _prducts.FirstOrDefault(p => p.ProductId == updateProduct.ProductId);
            if (entity != null)
            {
              
                entity.IsActive = updateProduct.IsActive;

            }
        }


        public static void DeleteProduct(Product entity)
        {
            var entity1 = _prducts.FirstOrDefault(p => p.ProductId == entity.ProductId);

            if(entity1 != null)
            {
                _prducts.Remove(entity1);
            }


        }


        public static List<Category> Categories
        {
            get { return _categories;
            }
        }





    }
}
