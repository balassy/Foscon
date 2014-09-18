using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foscon.Client;

namespace Foscon.DesktopTester
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private async void btnConnect_Click( object sender, EventArgs e )
		{
			this.lblCameraInfo.Text = "Connecting...";

			Camera c = new Camera( this.txtAddress.Text, this.txtUserName.Text, this.txtPassword.Text );
			GetIPInfoResult ipInfo = await c.GetIPInfo();
			GetProductModelNameResult productModelName = await c.GetProductModelName();

			this.lblCameraInfo.Text = String.Format( CultureInfo.InvariantCulture, "Model {0} on {1}", productModelName.ModelName, ipInfo.IPAddress );
		}

		private void MainForm_Shown( object sender, EventArgs e )
		{
			this.txtPassword.Focus();
		}
	}
}
