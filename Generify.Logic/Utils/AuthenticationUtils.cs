using Xamarin.Forms.Internals;
using ScopeConstants = Generify.Logic.Constants.AppConstants.ScopeConstants;

namespace Generify.Logic.Utils
{
	public class AuthenticationUtils
	{
		public static string BuildScope(params string[] scopes)
		{
			string scopeString = "";
			scopes.ForEach(p => scopeString += p + " ");
			scopeString.Remove(scopeString.Length - 1);

			return scopeString;
		}
	}
}
