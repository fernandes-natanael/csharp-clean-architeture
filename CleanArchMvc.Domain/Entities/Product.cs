using CleanArchMvc.Domain.Validations;

namespace CleanArchMvc.Domain.Entities;
public sealed class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Image { get; private set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Product(string name, string description, decimal price, int stock, string image)
    {
        ValidateDomain(name, description, price, stock, image);
    }

    public Product(Guid id, string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(id == Guid.Empty, "null Id");
        Id = id;
        ValidateDomain(name, description, price, stock, image);
    }

    public void Update(string name, string description, decimal price, int stock, string image, Guid categoryId)
    {
        ValidateDomain(name, description, price, stock, image);
        CategoryId = categoryId;
    }

    private void ValidateDomain(string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Null name");
        DomainExceptionValidation.When(name.Length < 3, "Name needs to be bigger than 3");

        DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description needs to be bigger than 3");

        DomainExceptionValidation.When(price < 0, "Price cannot be negative");

        DomainExceptionValidation.When(stock < 0, "Stock cannot be negative");

        DomainExceptionValidation.When(image?.Length > 255, "Image link is too long");

        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Image = image;
    }
}
