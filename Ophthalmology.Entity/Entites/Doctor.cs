namespace Ophthalmology.Entity.Entites
{
    public class Doctor : EntityBase
    {
        public Doctor()
        {
            Name = string.Empty;
        }

        public string Name { get; set; }
     
        public override string TableName => "Dr";
    }
}