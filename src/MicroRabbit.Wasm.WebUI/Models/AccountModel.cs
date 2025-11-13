using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Wasm.WebUI.Models
{
    public class AccountModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The account type is required.")]
        [StringLength(50, ErrorMessage = "The account type must be between {2} and {1} characters long.", MinimumLength = 2)]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "The account balance is required.")]
        [Range(0, 999999999, ErrorMessage = "The account balance must be between {1} and {2}.")]
        public decimal AccountBalance { get; set; }
    }

}
