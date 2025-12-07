using System;

namespace Host
{
	/// <summary>
	/// Holds A static instance of global program shtuff
	/// </summary>
	public class Global
	{
		public Global(){} 
		
		public static Host.PluginServices Plugins = new PluginServices();

	}
}
