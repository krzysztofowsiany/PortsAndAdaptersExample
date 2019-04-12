namespace DomainBase.Model.ValueObjects
{
    using System;
    using DomainBase.Model.Contracts;

    public class Identity : IValueObject
    {
        public Guid Id { get; }

        private Identity() => Id = Guid.NewGuid();

        static public Identity Create() => new Identity();
    }
}