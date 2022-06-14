using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConfigurationMgr;

namespace mook_CarInfo
{
	public partial class ApplicationRootForm : Form
	{
		protected ConfigurationMgr configurationMgr;
		public ApplicationRootForm()
		{
			InitializeComponent();

			if (LicenseManager.UsageMode == 
				LicenseUsageMode.Runtime)
			{
				configurationMgr = new ConfigurationMgr();
			}
		}
	}
}
