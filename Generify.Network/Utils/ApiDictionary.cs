using Generify.Contracts.Network.Api;
using Generify.Network.Service;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Generify.Network.Utils
{
	public class ApiDictionary
	{
		private static Dictionary<Type, string> _apiDictionary = new Dictionary<Type, string>
		{
			{typeof(ISpotifyApi), "https://accounts.spotify.com"}
		};

		public static string GetBaseUrl(Type type)
		{
			_apiDictionary.TryGetValue(type, out string value);
			return value;
		}
	}
}
