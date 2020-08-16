using Refit;
using System.Threading.Tasks;

namespace Generify.Contracts.Network.Api
{
	public interface ISpotifyApi
	{
		[Get("")]
		Task<string> Authenticate(
			string client_id,
			string response_type,
			string redirect_uri,
			string scope,
			string show_dialog
		);
	}
}
