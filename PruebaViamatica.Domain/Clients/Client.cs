using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaViamatica.Domain.Abstractions;
using PruebaViamatica.Domain.Clients.Events;

namespace PruebaViamatica.Domain.Clients;

public sealed class Client : Entity
{
    private Client(){}

    private Client(Guid id, Guid usersId, Identification identification) : base(id)
    {
        UsersId = usersId;
        Identification = identification;
    }

    public Guid UsersId { get; private set; }
    public Identification Identification { get; private set; }

    public static Result<Client> Create(Guid usersId, Identification identification)
    {
        var client = new Client(Guid.NewGuid(), usersId, identification);
        client.RaiseDomainEvent(new ClientCreatedDomainEvent(client.Id));

        return client;
    }

}
