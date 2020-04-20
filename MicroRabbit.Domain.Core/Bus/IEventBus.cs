using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        // Generic type, can take any type but must be a command, restriction on the T type must be of type command
        Task SendCommand<T>(T command) where T : Command;

        // Must have an @ sign becuse event is a reserved keyword
        void publish<T> (T @event) where T : Event;

        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;
    }
}
