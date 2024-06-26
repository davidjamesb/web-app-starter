﻿namespace TodoApi.Models;

using System;
using System.ComponentModel.DataAnnotations;

public record ToDo
{
    [Required]
    public int Id { get; set; }

    [Required]
    public Guid Owner { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;
}