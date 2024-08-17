using System.ComponentModel.DataAnnotations;

namespace BaseUtils.Models;

public class BaseOutInput
{
    public string? Output { get; set; } = null;

    public string? ErrorOutput { get; set; } = null;
}
