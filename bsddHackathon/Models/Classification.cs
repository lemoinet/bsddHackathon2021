using System;
using System.Collections.Generic;

namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"Classification")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class Classification
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Alternative (globally) unique identification
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Unique identification of the classification
        /// </summary>
        public string NamespaceUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ClassificationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ActivationDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? RevisionDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? VersionDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DeActivationDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? RevisionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ReplacedObjectCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ReplacingObjectCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeprecationExplanation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CreatorLanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VisualRepresentationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountriesOfUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubdivisionsOfUse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DocumentReference { get; set; }

        /// <summary>
        /// List of synonyms for the classification
        /// </summary>
        public List<string> Synonyms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> RelatedIfcEntityNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Classification ParentClassificationReference { get; set; }

        /// <summary>
        /// Include list of childs, with simple properties only. Only available when using the classification function with option 'includeChilds = true'.
        /// </summary>
        public List<Classification> Childs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ClassificationProperty> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<ClassificationRelation> Relations { get; set; }
    }
}
