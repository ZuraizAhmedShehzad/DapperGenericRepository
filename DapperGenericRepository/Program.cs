// See https://aka.ms/new-console-template for more information

using DapperGenericRepository.Model;
using DapperGenericRepository.Repository;
using DapperGenericRepository.Service;

ProductService productService = new ProductService();

//Product Add
Product productAdd = new Product
{
    Id = 1,
    Name = "Book",
    Description = "This is a book",
    Price = 10000
};

productService.Add(productAdd);

//Product GetAll
List<Product> productsGetAll = productService.GetAll();

//Product GetById
Product productGet = productService.Get(1);

//Product Update
Product productUpdate = new Product
{
    Id = 1,
    Name = "Book1",
    Description = "This is a book1",
    Price = 20000
};
productService.Update(productUpdate);

//Product Delete
Product productDelete = new Product
{
    Id = 1,
    Name = "Book1",
    Description = "This is a book1",
    Price = 20000
};
productService.Delete(productDelete);


