using System.Threading.Tasks;
using Liu.Domain.Core.Commands;
using Liu.Domain.Core.Events;


namespace Liu.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
