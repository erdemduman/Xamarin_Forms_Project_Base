using Generify.Logic.UseCase.Base;
using Generify.Network;
using Refit;
using static Generify.Network.ApiExecuter;

namespace Generify.Logic.UseCase
{
	public class MyUseCase : BaseUseCase, IApiCallback
	{
		private readonly ApiExecuter _apiExecuter;

		public MyUseCase()
		{
			_apiExecuter = new ApiExecuter();
		}

		public async void ExecuteAsync()
		{
			//Api call with ApiExecuter will be here.
		}

		void IApiCallback.OnSuccess(object response)
		{
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
