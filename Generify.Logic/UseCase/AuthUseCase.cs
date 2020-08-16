using Generify.Logic.Constants;
using Generify.Logic.UseCase.Base;
using Generify.Network;
using Generify.Logic.Utils;
using Refit;
using static Generify.Network.ApiExecuter;
using static Generify.Network.Service.SpotifyApi;
using ScopeConstants = Generify.Logic.Constants.AppConstants.ScopeConstants;

namespace Generify.Logic.UseCase
{
	public class AuthUseCase : BaseUseCase, IApiCallback
	{
		private readonly ApiExecuter _apiExecuter;

		public AuthUseCase()
		{
			_apiExecuter = new ApiExecuter();
		}

		public async void ExecuteAsync()
		{
			await _apiExecuter.ExecuteAsync(Authenticate, new AuthenticateParameter {
				ClientId = AppSecrets.CLIENT_ID,
				ResponseType = "code",
				RedirectUri = AppSecrets.REDIRECT_URI,
				Scope = AuthenticationUtils.BuildScope(
					ScopeConstants.PlaylistModifyPrivate, 
					ScopeConstants.PlaylistModifyPublic, 
					ScopeConstants.PlaylistReadCollaborative,
					ScopeConstants.PlaylistReadPrivate, 
					ScopeConstants.UserLibraryModify, 
					ScopeConstants.UserLibraryRead, 
					ScopeConstants.UserReadCurrentlyPlaying, 
					ScopeConstants.UserReadPrivate, 
					ScopeConstants.UserReadRecentlyPlayed, 
					ScopeConstants.UserTopRead
				),
				ShowDialog = true
			}, this);
		}

		void IApiCallback.OnSuccess(object response)
		{
			var result = response as string;
		}

		void IApiCallback.OnFail(ApiException exception)
		{

		}

		void IApiCallback.OnFinal()
		{

		}

		public class Parameter : BaseParameter
		{

		}
	}
}
