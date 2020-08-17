using Refit;
using System.Threading.Tasks;

namespace Generify.Contracts.Network.Api
{
	public interface IMyApi
	{
		[Get("")]
		Task<string> MyApiCall(string param);
	}
}
