using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaViamatica.Domain.Abstractions;

namespace PruebaViamatica.Domain.Users.Events;

public sealed class UserCreatedDomainEvent(Guid UserId):IDomainEvent;