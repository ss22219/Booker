using System;
using Nancy;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;
using Booker.Database.Interface;
using Booker.Database.iBoxDB;
using iBoxDB.LocalServer;
using Nancy.Conventions;
using System.IO;
using Booker.Database.Model;
using Booker.Database;
using System.Reflection;


namespace Booker
{
	public class Bootstraper : DefaultNancyBootstrapper
	{

		protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
		{
			base.ApplicationStartup(container, pipelines);
			StaticConfiguration.Caching.EnableRuntimeViewUpdates = true;
			StaticConfiguration.DisableErrorTraces = false;
		}

		protected override void ConfigureApplicationContainer(TinyIoCContainer container)
		{
			base.ConfigureApplicationContainer(container);
			//iboxdb
			container.Register<AutoBox>(this.BoxDatabase);

			//mongodb
			//container.Register(typeof(MongoDatabase), (cContainer, overloads) => Database);
			container.Register(typeof(IBookDb),typeof(BookDb));
		}

		protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
			base.ConfigureConventions(nancyConventions);
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("scripts"));
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("content"));
		}

		public DB.AutoBox BoxDatabase
		{
			get
			{
				var dbPath = Path.Combine(this.RootPathProvider.GetRootPath(), "App_Data", "ibox");
				if (!Directory.Exists(dbPath))
				{
					Directory.CreateDirectory(dbPath);
				}

				var server = new DB(dbPath);
				var config = server.GetConfig();
				config.EnsureTable<Book>(TableName.Books, "id");

				var db = server.Open();
				return db;
			}
		}


	}
}

