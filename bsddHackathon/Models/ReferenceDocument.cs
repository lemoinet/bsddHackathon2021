using System;

namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"ReferenceDocument")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class ReferenceDocument
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique identification of the ReferenceDocument
        /// </summary>
        public string Title { get; set; }
    }
}
