using System.Configuration;
using System.IO;
using System.Reflection;
using ServiceStack.ServiceInterface;

namespace Capistrano.Net.Web.Status
{
	public class StatusResourceService : RestServiceBase<StatusResource>
	{
		public override object OnGet(StatusResource request)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			request.LastDeployed = new FileInfo(executingAssembly.Location).LastWriteTime;
			request.Version = executingAssembly.GetName().Version.ToString();
			request.OK = true;
			request.Message = ConfigurationManager.AppSettings["Message"];
			return request;
		}
	}
}
