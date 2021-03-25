using System;
using System.Collections.Generic;

namespace bsddHackathon.Models
{
    /// <summary>
    /// {
    ///     __type(name:"Domain")
    ///     {
    ///         fields {
    ///             name
    ///             description
    ///         }
    ///     }
    /// }
    /// </summary>
    public class Domain
    {
        /// <summary>
        /// The unique identification of the domain
        /// </summary>
        public Uri NamespaceUri { get; set; }

        /// <summary>
        /// The name of the domain
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The version of the domain
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The language the results will be returned in if no language specified or if specified language is not available
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// The type of license for using data of this domain
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// Url with more info about the license
        /// </summary>
        public Uri LicenseUrl { get; set; }

        /// <summary>
        /// Search for classifications in the domain. Results are limited to max 100 items.
        /// </summary>
        public IReadOnlyList<Classification> ClassificationSearch { get; set; }

        /// <summary>
        /// Select a classification
        /// </summary>
        public Classification Classification { get; set; }
    }
}
