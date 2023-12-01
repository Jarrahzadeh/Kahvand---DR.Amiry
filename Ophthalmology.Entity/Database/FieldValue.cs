namespace Ophthalmology.Entity.Database
{
    public class FieldValue : IFieldValue
    {
        #region ~( Constructors )~

        public FieldValue()
        {
            FiledName = string.Empty;
            Value = default;
        }

        public FieldValue(string filedName, object value)
        {
            FiledName = filedName;
            Value = value;
        }

        #endregion

        #region ~( Properties )~

        /// <summary>
        /// نام فیلدی که شرط روی آن اعمال می شود
        /// </summary>
        public string FiledName { get; set; }

        /// <summary>
        /// مقداری که شرط بر اساس آن اعمال می شود
        /// </summary>
        public object Value { get; set; }

        #endregion
    }
}