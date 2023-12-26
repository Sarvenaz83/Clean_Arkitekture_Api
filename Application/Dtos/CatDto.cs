﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Application.Dtos
{
    public class CatDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public bool LikesToPlay { get; set; }
        [Required]
        [StringLength(50)]
        public string Breed { get; set; } = string.Empty;
        [Required]
        [AllowNull]
        public int Weight { get; set; }
    }
}
