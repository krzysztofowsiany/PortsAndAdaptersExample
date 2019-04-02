namespace Example.Application.Domain.Model.Base {
    using System;
    using Example.Application.Domain.Model.ValueObjects;

    internal class Entity {
        protected readonly Identity Identity;
        public Entity() => Identity = Identity.Create();
    }
}