using Capistrano.Net.Web.Status;
using Funq;
using ServiceStack.WebHost.Endpoints;

namespace Capistrano.Net.Web
{
	public class AppHost : AppHostBase
	{
		public AppHost() : base("capistrano.net", typeof(StatusResourceService).Assembly) { }

		public override void Configure(Container container)
		{
			Routes.Add<StatusResource>("/status");
		}
	}
}
