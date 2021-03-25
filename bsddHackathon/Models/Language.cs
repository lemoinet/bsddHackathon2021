namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"Language")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Unique identification of the language
        /// </summary>
        public string IsoCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}
