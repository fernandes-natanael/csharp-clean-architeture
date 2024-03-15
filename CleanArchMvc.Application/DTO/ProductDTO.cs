using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTO;
public class ProductDTO
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = ("Name is required"))]
    [MinLength(3)]
    [MaxLength(180)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = ("Description is required"))]
    [MinLength(3)]
    [MaxLength(180)]
    [DisplayName ("Description")]
    public string Description { get; set; }

    [Required(ErrorMessage = ("Price is required"))]
    [Column(TypeName = "decimal(12,2)")]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    [DataType(DataType.Currency)]
    [DisplayName("Price")]
    public decimal Price { get; private set; }

    [Required(ErrorMessage = ("Stock is required"))]
    [Range(0,9999)]
    public int Stock { get; private set; }

    [MaxLength(250)]
    public string Image { get; private set; }

    [DisplayName("Categories")]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
