namespace CreditCardApi.Dto
{
  public class MessageDto
  {

    public MessageDto(string message)
    {
      this.Message = message;
    }

    public string Message { get; set; }

  }
}