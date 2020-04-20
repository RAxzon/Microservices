using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        // Since it is an abstract class the setters och the properties will be protected
        public string MessageType { get; protected set; }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
