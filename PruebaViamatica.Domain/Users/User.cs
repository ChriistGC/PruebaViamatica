using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaViamatica.Domain.Abstractions;

namespace PruebaViamatica.Domain.Users;

public sealed class User:Entity
{
    private User(Guid id, DataSession dataSession, Guid personId) : base(id)
    {

    }

    public DataSession DataSession { get; private set; }
    public Guid PersonId { get; private set;}

    public static Result<User> Create(DataSession dataSession, Guid personId)
    {
        var user = new User(Guid.NewGuid(), dataSession, personId);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }


}