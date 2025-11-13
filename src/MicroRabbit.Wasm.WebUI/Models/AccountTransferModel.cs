namespace MicroRabbit.Wasm.WebUI.Models
{
    public class AccountTransferModel
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
