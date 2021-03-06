using Glass.Mapper.Configuration;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.IoC;
using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

namespace Ignition.Root.App_Start
{
	public static class GlassMapperScCustom
	{
		public static IDependencyResolver CreateResolver()
		{
			var config = new Config();
			return new DependencyResolver(config);
		}

		public static IConfigurationLoader[] GlassLoaders()
		{
			return new IConfigurationLoader[]
			{
				new SitecoreAttributeConfigurationLoader("Ignition.Core"),
				new SitecoreAttributeConfigurationLoader("Ignition.Data"),
				new SitecoreAttributeConfigurationLoader("Ignition.Sc")
			};
		}

		public static void PostLoad()
		{
		}

		public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
		{
			// Add maps here
			// mapsConfigFactory.Add(() => new SeoMap());
		}
	}
}
