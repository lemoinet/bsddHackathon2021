namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"ClassificationRelation")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class ClassificationRelation
    {
        /// <summary>
        /// 
        /// </summary>
        public string RelationType { get; set; }

        /// <summary>
        /// The namespace uri of the related classification
        /// </summary>
        public string RelatedClassificationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RelatedClassificationName { get; set; }
    }
}