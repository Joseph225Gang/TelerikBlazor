using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Service
{
    public class ProductService
    {
        private readonly DemoDBContext _dbContext;

        private List<ProductDto> _products;

        public ProductService(DemoDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            return GetProductsInternal();
        }

        public void CreateProduct(ProductDto product)
        {
            if (!_products.Any())
            {
                product.ProductId = 1;
            }
            else
            {
                product.ProductId = _products.Max(p => p.ProductId) + 1;
            }

            _products.Insert(0, product);
        }

        public void UpdateProduct(ProductDto product)
        {
            var target = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (target != null)
            {
                target.ProductName = product.ProductName;
                target.SupplierId = product.SupplierId;
                target.CategoryId = product.CategoryId;
                target.CategoryName = product.CategoryName;
                target.QuantityPerUnit = product.QuantityPerUnit;
                target.UnitPrice = product.UnitPrice;
                target.UnitsInStock = product.UnitsInStock;
                target.UnitsOnOrder = product.UnitsOnOrder;
                target.ReorderLevel = product.ReorderLevel;
                target.Discontinued = product.Discontinued;
            }
        }

        public void DeleteProduct(ProductDto product)
        {
            var target = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (target != null)
            {
                _products.Remove(target);
            }
        }

        private IEnumerable<ProductDto> GetProductsInternal()
        {
            if (_products == null)
            {
                _products = _dbContext.Products.Include("Category").Select(ProductDto.ProductFunc).ToList();
            }

            return _products;
        }
    }
}
