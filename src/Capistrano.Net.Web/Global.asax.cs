using System;
using System.Web;

namespace Capistrano.Net.Web
{
	public class Global : HttpApplication
	{
		protected void Application_Start(object src, EventArgs e)
		{
			new AppHost().Init();
		}
	}
}