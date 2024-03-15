using CleanArchMvc.Domain.Validations;

namespace CleanArchMvc.Domain.Entities;
public sealed class Category : Entity
{
    public string Name { get; private set; }
    public ICollection<Product> Products { get; set; }

    public Category(string name)
    {
        ValidateDomainName(name);
    }

    public Category(Guid id, string name)
    {
        DomainExceptionValidation.When(id == Guid.Empty, "null Id");
        Id = id;
        ValidateDomainName(name);
    }

    public void Update(string name)
    {
        ValidateDomainName(name);
    }

    private void ValidateDomainName(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Null name");
        DomainExceptionValidation.When(name.Length < 3, "Name needs to be bigger than 3");
        Name = name;
    }

}
