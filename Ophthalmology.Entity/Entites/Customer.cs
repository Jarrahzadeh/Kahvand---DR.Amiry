﻿namespace Ophthalmology.Entity.Entites
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }

        public string Family { get; set; }

        public string NameFather { get; set; }

        public string Address { get; set; }

        public string Reason { get; set; }

        public string Tel { get; set; }

        public string Dis { get; set; }

        public string Age { get; set; }

        public string EyeLeft { get; set; }

        public string EyeRight { get; set; }

        public string DateSave { get; set; }

        public int DrId { get; set; }
        
        public int IdTypePatient { get; set; }

        public override string TableName => "Customer";
    }
}