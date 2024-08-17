using System.ComponentModel.DataAnnotations;

namespace BaseUtils.Models;

public class BaseInput
{
    [Required]
    public string Model { get; set; } = null!;

    [Required]
    public string Template { get; set; } = null!;
}
