using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaViamatica.Domain.Abstractions;

namespace PruebaViamatica.Domain.Clients.Events;

public sealed record ClientCreatedDomainEvent(Guid ClientId):IDomainEvent;