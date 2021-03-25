namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"Country")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Unique identification of the country
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}