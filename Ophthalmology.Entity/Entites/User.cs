namespace Ophthalmology.Entity.Entites
{
    public class User : EntityBase
    {
        public override string TableName => "User1";

        public User() { }

        public string Name { get; set; }
        
        public string Pass { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}