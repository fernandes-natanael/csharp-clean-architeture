using CleanArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Tests;

public class CategoryUnitTest
{
    [Fact]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(Guid.NewGuid(), "CateName");
        action.Should()
            .NotThrow<CleanArchMvc.Domain.Validations.DomainExceptionValidation>();
    }
}