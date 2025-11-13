namespace MicroRabbit.Wasm.WebUI.Models
{
    public class TransferLogModel
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
