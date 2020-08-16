using Generify.Network.Utils;
using Refit;
using static Generify.Network.ApiExecuter;

namespace Generify.Network.Service.Base
{
	public abstract class BaseApi<T> : BaseApi
	{
		private static T _api;

		protected static T Api
		{
			get
			{
				if (_api == null)
					_api = RestService.For<T>(ApiDictionary.GetBaseUrl(typeof(T)));

				return _api;
			}
		}
	}

	public class BaseApi
	{
		public class Parameter
		{
			public IApiCallback Callback { get; set; }
		}
	}
}
