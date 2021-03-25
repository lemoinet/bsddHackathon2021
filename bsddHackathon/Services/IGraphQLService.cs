using bsddHackathon.Models;
using GraphQL;
using System.Threading.Tasks;

namespace bsddHackathon.Services
{
    public interface IGraphQLService
    {
        Task<GraphQLResponse<DomainType>> GetClassification(string namespaceUri);
        Task<GraphQLResponse<CountryCollectionType>> GetCountries();
        Task<GraphQLResponse<DomainType>> GetDomain(string namespaceUri, string searchText = "");
        Task<GraphQLResponse<DomainCollectionType>> GetDomains();
        Task<GraphQLResponse<LanguageCollectionType>> GetLanguages();
        Task<GraphQLResponse<ReferenceDocumentCollectionType>> GetReferenceDocuments();
        Task<GraphQLResponse<UnitCollectionType>> GetUnits();
        Task<GraphQLResponse<DomainCollectionType>> SearchClassifications(string searchText);
    }
}