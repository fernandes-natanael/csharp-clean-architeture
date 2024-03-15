﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTO;
public class CategoryDTO
{

    public Guid Id { get; set; }

    [Required(ErrorMessage =("Name is required"))]
    [MinLength(3)]
    [MaxLength(180)]
    public string Name { get; set; }
}
