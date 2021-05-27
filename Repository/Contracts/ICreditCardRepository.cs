using System.Collections.Generic;
using CreditCardApi.Models;

namespace CreditCardApi.Repository
{

  public interface ICreditCardRepository
  {
    void StoreCard(CreditCard card);
    List<CreditCard> GetCardsByEmail(string email);

  }

}