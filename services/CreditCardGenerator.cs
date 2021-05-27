using System;
using System.Text;

namespace CreditCardApi.Services
{
  public class CreditCardGenerator : ICreditCardGenerator
  {
    private static Random _random = new Random();
    private static string _prefix = "51"; // prefixo fixo

    public string NumberCardGenerator(int numberCardLength)
    {
      StringBuilder cardNumberBuilder = new StringBuilder();
      string cardNumber = string.Empty;
      cardNumberBuilder.Append(_prefix);
      int numbersToGenerate = numberCardLength - _prefix.Length;
      for (var i = 0; i < numbersToGenerate; i++)
      {
        int randomNumber = _random.Next(0, 9);
        cardNumberBuilder.Append(randomNumber);
      }

      cardNumber = cardNumberBuilder.ToString();

      return cardNumber;

    }
  }
}