using System;

namespace Capistrano.Net.Web.Status
{
	public class StatusResource
	{
		public bool OK { get; set; }
		public DateTime LastDeployed { get; set; }
		public string Version { get; set; }
		public string Message { get; set; }
	}
}
