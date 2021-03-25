namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"Unit")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Unique identification of the unit
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Symbol { get; set; }
    }
}
