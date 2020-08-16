using Autofac;
using System;
using System.Linq;
using System.Reflection;
using Module = Autofac.Module;

namespace Generify.Contracts
{
	public class DependencyManager
	{
		private const string AssemblyPrefix = "Generify";
		private static IContainer _container;

		public static T Resolve<T>()
		{
			if (_container == null)
				Init();

			return _container.Resolve<T>();
		}

		private static void Init()
		{
			var builder = new ContainerBuilder();

			builder.RegisterAssemblyModules(GetAssemblies());
			_container = builder.Build();
		}

		private static Assembly[] GetAssemblies()
		{
			return AppDomain.CurrentDomain.GetAssemblies()
				.Where(p => p.FullName.StartsWith(AssemblyPrefix))
				.ToArray();
		}
	}
}
