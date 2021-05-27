
using System.Collections.Generic;
using System.Linq;
using CreditCardApi.Dto;
using CreditCardApi.Models;
using CreditCardApi.Repository;
using CreditCardApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreditCardApi.Controllers
{

  [ApiController]
  [Route("api/v1/[controller]")]
  public class CreditCardController : ControllerBase
  {
    private readonly ICreditCardRepository _repository;
    private readonly ICreditCardGenerator _cardGenerator;
    public CreditCardController(ICreditCardRepository repository, ICreditCardGenerator cardGenerator)
    {
      _repository = repository;
      _cardGenerator = cardGenerator;
    }

    [HttpPost]
    public ActionResult<CardDto> CardGeneration(RequestDto request)
    {
      CreditCard card = new CreditCard(
        request.email,
        _cardGenerator.NumberCardGenerator(14)
      );
      _repository.StoreCard(card);

      CardDto response = Mapper.ModelToDto(card);

      return StatusCode(201, response);
    }

    [HttpGet]
    public ActionResult<List<CardDto>> GetCardsByEmail([FromQuery] RequestDto request)
    {
      List<CreditCard> cards = _repository.GetCardsByEmail(request.email);
      if (cards.Count != 0)
      {
        List<CardDto> cardsDto = new List<CardDto>();

        //Mapeamento de CreditCard para CardDto
        foreach (var card in cards)
          cardsDto.Add(Mapper.ModelToDto(card));

        return Ok(cardsDto);
      }

      return NotFound(new MessageDto("No credit card linked to this email was found"));
    }


  }

}