namespace Ophthalmology.Entity.Enums
{
    /// <summary>
    /// انواع عملگرهای منطقی
    /// </summary>
    public enum LogicalOperatorType
    {
        /// <summary>
        /// بدون عملگر
        /// </summary>
        None,

        /// <summary>
        /// عملگر "و|باید" که بودن 2 عبارت را اجباری می کند
        /// </summary>
        And,

        /// <summary>
        /// عملگر "یا|شاید" که بودن یکی از 2 عبارت را بررسی می کند
        /// </summary>
        Or
    }
}
