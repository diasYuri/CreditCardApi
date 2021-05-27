
using CreditCardApi.Models;

namespace CreditCardApi.Dto
{
  public class CardDto
  {
    public string numberCard { get; set; }
    public string creationDate { get; set; }
  }

  public static class Mapper
  {
    public static CardDto ModelToDto(CreditCard model)
    {
      CardDto dto = new CardDto();
      dto.numberCard = model.CardNumber;
      dto.creationDate = model.CreatedAt.ToString("MM/dd/yyyy HH:mm");
      return dto;
    }
  }
}