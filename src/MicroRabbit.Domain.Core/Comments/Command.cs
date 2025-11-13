using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Comments
{
    public class Command:Message
    {
        public DateTime Timestamp { get; protected set; }
        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
