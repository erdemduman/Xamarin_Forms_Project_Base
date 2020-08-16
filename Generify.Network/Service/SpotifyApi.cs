using Generify.Contracts.Network.Api;
using Generify.Network.Service.Base;
using System.Threading.Tasks;

namespace Generify.Network.Service
{
	public class SpotifyApi : BaseApi<ISpotifyApi>
	{
		public static async Task<string> Authenticate(Parameter parameter)
		{
			var p = parameter as AuthenticateParameter;
			return await Api.Authenticate(
				client_id: p.ClientId,
				response_type: p.ResponseType,
				redirect_uri: p.RedirectUri,
				scope: p.Scope,
				show_dialog: p.ShowDialog.ToString().ToLower()
			);
		}

		public class AuthenticateParameter : Parameter
		{
			public string ClientId { get; set; }

			public string ResponseType { get; set; }

			public string RedirectUri { get; set; }

			public string Scope { get; set; }

			public bool ShowDialog { get; set; }
		}
	}
}
