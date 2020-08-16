using Generify.Logic.Constants;
using Generify.Logic.Utils;
using Generify.Logic.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using static Generify.Logic.Constants.AppConstants;

namespace Generify.Logic.ViewModel
{
	public class LoginPageViewModel : BaseViewModel
	{
		private event Action<AuthenticateParameter> _authEvent;

		public LoginPageViewModel()
		{
		}

		public override void OnCreate(object navigationData)
		{
			_authEvent?.Invoke(new AuthenticateParameter
			{
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
			});
		}

		public class AuthenticateParameter
		{
			public string ClientId { get; set; }

			public string ResponseType { get; set; }

			public string RedirectUri { get; set; }

			public string Scope { get; set; }

			public bool ShowDialog { get; set; }
		}

		public class Parameter : BaseParameter
		{
		}
	}
}
