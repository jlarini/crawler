using Api.Dto.Query;

namespace Api.Services;

public interface IQueryService
{
    Task<IEnumerable<QueryResponse>> Search(string query);
}