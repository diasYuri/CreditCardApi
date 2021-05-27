using System.Collections.Generic;
using System.Linq;
using CreditCardApi.Data;
using CreditCardApi.Models;

namespace CreditCardApi.Repository
{

  public class CreditCardRepository : ICreditCardRepository
  {
    private readonly AppDbContext _dbcontext;
    public CreditCardRepository(AppDbContext dbcontext)
    {
      _dbcontext = dbcontext;
    }
    public void StoreCard(CreditCard card)
    {
      _dbcontext.Add(card);
      _dbcontext.SaveChanges();
    }

    public List<CreditCard> GetCardsByEmail(string email)
    {
      List<CreditCard> cards = _dbcontext.CreditCards
        .Where(c => c.OwnerEmail == email)
        .OrderBy(c => c.CreatedAt)
        .ToList();

      return cards;
    }
  }

}