using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface IMarvelAPIConnector
    {
        Task<IRestResponse> ObterGetResponse(string url, CancellationToken cancellationToken);
    }
}
