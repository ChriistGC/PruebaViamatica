using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaViamatica.Domain.Abstractions;
using PruebaViamatica.Domain.Persons.Events;

namespace PruebaViamatica.Domain.Persons;

public sealed class Person : Entity
{
    private Person(){}

    private Person(Guid id, Name name, DateOnly birthDate, Address address):base(id)
    {
        Name = name;
        BirthDate = birthDate;
        Address = address;
    }

    public Name Name { get; private set; }
    public DateOnly BirthDate { get; private set; }
    public Address Address { get; private set; }

    public static Result<Person> Create(Name name, DateOnly birthDate, Address address)
    {
        var person = new Person(Guid.NewGuid(), name, birthDate, address);

        person.RaiseDomainEvent(new PersonCreatedDomainEvent(person.Id));

        return person;
    }
}