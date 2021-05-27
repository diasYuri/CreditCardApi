using System.ComponentModel.DataAnnotations;

namespace CreditCardApi.Dto
{
  public class RequestDto
  {
    [Required]
    [EmailAddress]
    public string email { get; set; }

  }
}