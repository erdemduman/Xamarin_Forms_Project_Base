using Generify.Contracts.Network.Api;
using Generify.Network.Service.Base;
using System.Threading.Tasks;

namespace Generify.Network.Service
{
	public class MyApi : BaseApi<IMyApi>
	{
		public static async Task<string> MyApiCall(Parameter parameter)
		{
			var p = parameter as MyApiCallParameter;
			return await Api.MyApiCall(
				param: p.Param
			);
		}

		public class MyApiCallParameter : Parameter
		{
			public string Param { get; set; }
		}
	}
}
