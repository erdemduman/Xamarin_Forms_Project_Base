using System;
using System.Threading.Tasks;
using Parameter = Generify.Network.Service.Base.BaseApi.Parameter;

namespace Generify.Network
{
	public class ApiExecuter
	{
		private IApiCallback _callback;

		public async Task ExecuteAsync<TOut>(Func<Parameter, Task<TOut>> apiMethod, Parameter parameter, IApiCallback callback)
		{
			_callback = callback;
			try
			{
				var response = await apiMethod.Invoke(parameter);
				_callback?.OnSuccess(response);
			}
			catch (Refit.ApiException exception)
			{
				_callback?.OnFail(exception);
			}
			finally
			{
				_callback?.OnFinal();
			}
		}

		public interface IApiCallback
		{
			void OnSuccess(object response);

			void OnFail(Refit.ApiException exception);

			void OnFinal();
		}
	}
}
