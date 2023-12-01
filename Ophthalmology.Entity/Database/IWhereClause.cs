using Ophthalmology.Entity.Enums;

namespace Ophthalmology.Entity.Database
{
    public interface IWhereClause : IFieldValue
    {
        #region ~( Properties )~

        /// <summary>
        /// عملگر منطقی ای که این شرط را با شرط دیگری ارتباط میدهد
        /// </summary>
        LogicalOperatorType LogicalOperator { get; set; }

        #endregion
    }
}