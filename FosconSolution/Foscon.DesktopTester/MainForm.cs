using System;
using System.Globalization;
using System.Windows.Forms;
using Foscon.Client;
using System.Threading;

namespace Foscon.DesktopTester
{
	public partial class MainForm : Form
	{
		private CancellationTokenSource cts;

		public MainForm()
		{
			InitializeComponent();

			this.cts = new CancellationTokenSource();
		}

		private async void btnConnect_Click( object sender, EventArgs e )
		{
			this.btnConnect.Enabled = false;
			this.btnCancel.Enabled = true;
			this.pbStatus.Visible = true;

			Camera c = new Camera( this.txtHostName.Text, Int32.Parse(this.txtPort.Text), this.txtUserName.Text, this.txtPassword.Text );

			this.lblStatus.Text = "Getting IP information...";
			GetIPInfoResult ipInfo = await c.GetIPInfoAsync( this.cts.Token );

			this.lblStatus.Text = "Getting model name...";
			GetProductModelNameResult productModelName = await c.GetProductModelNameAsync( this.cts.Token );
			this.lblCameraInfo.Text = String.Format( CultureInfo.InvariantCulture, "Model {0} on {1}", productModelName.ModelName, ipInfo.IPAddress);

			this.lblStatus.Text = "Getting device information...";
			GetDeviceInfoResult deviceInfo = await c.GetDeviceInfoAsync( this.cts.Token );
			this.lblProductName.Text = deviceInfo.ProductName;
			this.lblDeviceName.Text = deviceInfo.DeviceName;
			this.lblSerialNo.Text = deviceInfo.SerialNumber;
			this.lblMac.Text = deviceInfo.MacAddress;
			this.lblCurrentDate.Text = deviceInfo.CurrentDate.ToString(CultureInfo.CurrentCulture);
			this.lblTimeZone.Text = deviceInfo.TimeZone;
			this.lblFirmwareVersion.Text = deviceInfo.FirmwareVersion;
			this.lblHardwareVersion.Text = deviceInfo.HardwareVersion;

			this.lblStatus.Text = "Ready.";
			this.pbStatus.Visible = false;
			this.btnConnect.Enabled = true;
			this.btnCancel.Enabled = false;
		}

		private void MainForm_Shown( object sender, EventArgs e )
		{
			this.txtPassword.Focus();
		}

		private void btnCancel_Click( object sender, EventArgs e )
		{
			this.cts.Cancel();
		}
	}
}
