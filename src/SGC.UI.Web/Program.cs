﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using SGC.Infra.Data;

namespace SGC.UI.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//CreateWebHostBuilder(args).Build().Run();
			var host = BuildWebHost(args);

			using(var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				try
				{
					var context = services.GetRequiredService<DataContext>();
					DbInitializer.Initialize(context);
				}
				catch (Exception ex)
				{
					var looger = services.GetRequiredService<ILogger<Program>>();
					looger.LogError(ex, "Um erro ocorreu no método seed do context");
				}
			}
			host.Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}
