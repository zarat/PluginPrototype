using System;
using PluginInterface;

namespace Plugin1Namespace
{
	/// <summary>
	/// Plugin2
	/// </summary>
	public class Plugin : IPlugin  // <-- See how we inherited the IPlugin interface?
	{
		public Plugin()
		{
			// constructor logic here
			// wont work, host is not initialized yet
			// this.Host.Feedback("Hello", this);
		}
		
		//Declarations of all our internal plugin variables
		string myName = "Plugin 1";
		string myDescription = "Beispiel eines Plugin";
		string myAuthor = "Manuel Zarat";
		string myVersion = "1.0.0";
		public IPluginHost myHost = null;
		public System.Windows.Forms.UserControl myMainInterface = new ctlMain();
		
		/// <summary>
		/// Description of the Plugin's purpose
		/// </summary>
		public string Description
		{
			get {return myDescription;}
		}

		/// <summary>
		/// Author of the plugin
		/// </summary>
		public string Author
		{
			get	{return myAuthor;}
		
		}

		/// <summary>
		/// Host of the plugin.
		/// </summary>
		public IPluginHost Host
		{
			get
			{
				return myHost;
			}
			set	
			{
				myHost = value;

                if (myMainInterface is ctlMain ui)
                {
                    ui.Host = myHost;
                    ui.PluginContext = this; 
                }

            }
		}

		public string Name
		{
			get {return myName;}
		}

		public System.Windows.Forms.UserControl MainInterface
		{
			get {return myMainInterface;}
		}

		public string Version
		{
			get	{return myVersion;}
		}
		
		public void Initialize()
		{
			//This is the first Function called by the host...
			//Put anything needed to start with here first
			//this.Host.Feedback("Plugin Custom Query opened", this);
		}
		
		public void Dispose()
		{
            //Put any cleanup code in here for when the program is stopped
            //this.Host.Feedback("Plugin Custom Query closed", this);
        }

	}
}