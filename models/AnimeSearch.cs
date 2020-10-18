using System.ComponentModel.DataAnnotations;

namespace AniFun.Models
{
  public class AnimeSearch
  {
    [Required(ErrorMessage = "Este campo é obrigatório.")]
    public string Name { get; set; }

  }
}