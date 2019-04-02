namespace Example.Application.Domain.Model.ValueObjects {
    using System;
    using Example.Application.Domain.Model.Base;

    public class Identity : IValueObject {
        public Guid Id { get; }

        private Identity() => Id = Guid.NewGuid();

        static public Identity Create() => new Identity();
    }
}