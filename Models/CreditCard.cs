using System;
using System.ComponentModel.DataAnnotations;
using CreditCardApi.Services;

namespace CreditCardApi.Models
{
  public class CreditCard
  {
    protected CreditCard() { }

    public CreditCard(string email, string cardNumber)
    {
      this.CreatedAt = DateTime.Now;
      this.OwnerEmail = email;
      this.CardNumber = cardNumber;
    }


    [Key] // Define a PK
    public int Id { get; set; } // Identificação da nossa entidade

    [Required] // Campo obrigatório
    public string OwnerEmail { get; set; } // Email atribuido

    [Required]
    [MinLength(13)]
    [MaxLength(16)]
    public string CardNumber { get; set; } // Número do cartão

    [Required]
    public DateTime CreatedAt { get; set; } // Data da criação
  }
}