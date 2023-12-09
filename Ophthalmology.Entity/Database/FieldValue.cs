namespace Ophthalmology.Entity.Database
{
    public class FieldValue : IFieldValue
    {
        #region ~( Constructors )~

        public FieldValue()
        {
            FiledName = string.Empty;
            Value = default;
            Alias = string.Empty;
        }

        public FieldValue(string filedName, object value, string alias)
        {
            FiledName = filedName;
            Value = value;
            Alias = alias;
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

        /// <summary>
        /// نام مستعار فیلد
        /// </summary>
        public string Alias { get; set; }
        #endregion
    }
}