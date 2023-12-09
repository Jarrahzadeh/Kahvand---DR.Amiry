namespace Ophthalmology.Entity.Database
{
    public interface IFieldValue
    {
        #region ~( Properties )~
        
        /// <summary>
        /// نام فیلدی که شرط روی آن اعمال می شود
        /// </summary>
        string FiledName { get; set; }

        /// <summary>
        /// مقداری که شرط بر اساس آن اعمال می شود
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// نام مستعار فیلد
        /// </summary>
        string Alias { get; set; }

        #endregion
    }
}