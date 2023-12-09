using Ophthalmology.Entity.Enums;

namespace Ophthalmology.Entity.Database
{
    /// <summary>
    /// شئ نگهدارنده شروط دستورات اس کیو ال
    /// </summary>
    public class WhereClause : FieldValue, IWhereClause
    {
        #region ~( Constructors )~

        public WhereClause() : this(string.Empty, default, default) { }

        public WhereClause(string fieldName, object fieldValue, string alias, LogicalOperatorType logicalOperator = default) : 
            base(fieldName, fieldValue, alias)
        {
            LogicalOperator = logicalOperator;
        }

        #endregion

        #region ~( Fields )~

        /// <summary>
        /// عملگر منطقی ای که این شرط را با شرط دیگری ارتباط میدهد
        /// </summary>
        public LogicalOperatorType LogicalOperator { get; set; }
        
        #endregion
    }
}