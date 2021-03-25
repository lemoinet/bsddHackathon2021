using bsddHackathon.Models;
using GraphQL;
using GraphQL.Client.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace bsddHackathon.Services
{
    public class GraphQLService : IGraphQLService
    {
        private readonly GraphQLHttpClient _graphQLHttpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLService"/> class.
        /// </summary>
        /// <param name="graphQLHttpClient">The GraphQL client.</param>
        public GraphQLService(GraphQLHttpClient graphQLHttpClient)
        {
            _graphQLHttpClient = graphQLHttpClient;
        }

        /// <summary>
        /// Gets all the domains within bsDD.
        /// </summary>
        /// <returns></returns>
        public async Task<GraphQLResponse<DomainCollectionType>> GetDomains()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                  domains {
                    name
                    namespaceUri
                    version
                    }
                }"
            };

            return await _graphQLHttpClient.SendQueryAsync<DomainCollectionType>(request).ConfigureAwait(false);
        }

        /// <summary>Gets the domain by NamespaceUri.</summary>
        /// <param name="namespaceUri">The namespaceUri of the domain.</param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<GraphQLResponse<DomainType>> GetDomain(string namespaceUri, string searchText = "")
        {
            var request = new GraphQLRequest
            {
                Query = @"
                query ($namespaceUri: String!, $searchText: String!) {
                  domain(namespaceUri: $namespaceUri) {
                    namespaceUri
                    name
                    version
                    license
                    licenseUrl
                    languageCode
                    classificationSearch(searchText: $searchText) {
                      name
                      namespaceUri
                    }
                  }
                }",
                Variables = new { namespaceUri = namespaceUri, searchText = searchText }
            };

            return await _graphQLHttpClient.SendQueryAsync<DomainType>(request).ConfigureAwait(false);
        }

        /// <summary>Search classifications across domains</summary>
        /// <param name="namespaceUri">The namespaceUri of the domain.</param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<GraphQLResponse<DomainCollectionType>> SearchClassifications(string searchText)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                query ($searchText: String!) {
                  domains {
                    namespaceUri
                    name
                    version
                    classificationSearch(searchText: $searchText) {
                      name
                      namespaceUri
                    }
                  }
                }",
                Variables = new { searchText = searchText }
            };

            return await _graphQLHttpClient.SendQueryAsync<DomainCollectionType>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the languages within bsDD.
        /// </summary>
        /// <returns></returns>
        public async Task<GraphQLResponse<LanguageCollectionType>> GetLanguages()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                  languages {
                    name
                    isocode                    
                    }
                }"
            };

            return await _graphQLHttpClient.SendQueryAsync<LanguageCollectionType>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the countries within bsDD.
        /// </summary>
        /// <returns></returns>
        public async Task<GraphQLResponse<CountryCollectionType>> GetCountries()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                  countries {
                    name
                    code                    
                    }
                }"
            };

            return await _graphQLHttpClient.SendQueryAsync<CountryCollectionType>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the reference documents within bsDD.
        /// </summary>
        /// <returns></returns>
        public async Task<GraphQLResponse<ReferenceDocumentCollectionType>> GetReferenceDocuments()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                  referenceDocuments {
                    name
                    title
                    date
                    }
                }"
            };

            return await _graphQLHttpClient.SendQueryAsync<ReferenceDocumentCollectionType>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all the units within bsDD.
        /// </summary>
        /// <returns></returns>
        public async Task<GraphQLResponse<UnitCollectionType>> GetUnits()
        {
            var request = new GraphQLRequest
            {
                Query = @"
                {
                  units {
                    name
                    code                    
                    }
                }"
            };

            return await _graphQLHttpClient.SendQueryAsync<UnitCollectionType>(request).ConfigureAwait(false);
        }

        /// <summary>Gets the classification.</summary>
        /// <param name="namespaceUri"></param>
        /// <param name="includeChilds"></param>
        /// <returns></returns>
        public async Task<GraphQLResponse<DomainType>> GetClassification(string namespaceUri)
        {
            var request = new GraphQLRequest
            {
                Query = @"
                query ($domainNamespaceUri: String!, $namespaceUri: String!) {
                    domain(namespaceUri: $domainNamespaceUri) {
                        name
                        namespaceUri
                        classification (namespaceUri: $namespaceUri, includeChilds: true) {
                            name
                            namespaceUri
                            classificationType
                            uid
                            definition
                            status
                            activationDateUtc
                            revisionDateUtc
                            versionDateUtc
                            versionNumber
                            creatorLanguageCode
                            visualRepresentationUri
                            countriesOfUse
                            countryOfOrigin
                            documentReference
                            synonyms
                            relatedIfcEntityNames
                        }
                    }
                }",
                Variables = new { domainNamespaceUri = GetDomainNamespaceUri(namespaceUri), namespaceUri = namespaceUri }
            };

            return await _graphQLHttpClient.SendQueryAsync<DomainType>(request).ConfigureAwait(false);
        }

        private static string GetDomainNamespaceUri(string namespaceUri)
        {
            var uri = new Uri(namespaceUri);

            var domainNamespaceUri = uri.Scheme + "://" + uri.Host + string.Join("", uri.Segments.Take(uri.Segments.Length - 2));

            return domainNamespaceUri.Substring(0, domainNamespaceUri.LastIndexOf('/'));
        }
    }
}
