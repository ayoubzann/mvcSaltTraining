using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvcSaltTraining.Models;

public class CreateNewDeveloperViewModel
{
  [DisplayName("Developer name")]
  [Required]
  public string? Name { get; set; }

  [DisplayName("Email address")]
  [Required]
  [EmailAddress]
  public string? Email { get; set; }
}