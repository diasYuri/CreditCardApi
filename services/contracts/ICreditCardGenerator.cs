namespace CreditCardApi.Services
{
  public interface ICreditCardGenerator
  {
    string NumberCardGenerator(int numberCardLength);
  }
}