namespace Ophthalmology.Entity.Entites
{
    public abstract class EntityBase
    {
        public abstract string TableName { get; }

        public int Id { get; set; }
    }
}