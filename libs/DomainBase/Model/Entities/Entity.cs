namespace DomainBase.Model.Entities
{
    using DomainBase.Model.ValueObjects;

    internal class Entity
    {
        protected readonly Identity Identity;
        public Entity() => Identity = Identity.Create();
    }
}