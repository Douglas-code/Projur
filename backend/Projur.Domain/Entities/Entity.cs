namespace Projur.Domain.Entities
{
    public abstract class Entity
    { 
        public Entity() { }

        public int Id { get; protected set; }
    }
}
