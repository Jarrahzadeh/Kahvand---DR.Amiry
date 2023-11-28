namespace Ophthalmology.Entity.Entites
{
    /// <summary>
    /// نوع بیمه
    /// </summary>
    public class TypePatient : EntityBase
    {
        public TypePatient()
        {
            Name = string.Empty;
            Price = string.Empty;
        }

        public string Name { get; set; }

        public string Price { get; set; }

        public override string TableName => "TypePatient";
    }
}