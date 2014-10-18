using System;
using System.Globalization;
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
			this.pbStatus.Visible = true;

			Camera c = new Camera( this.txtHostName.Text, Int32.Parse(this.txtPort.Text), this.txtUserName.Text, this.txtPassword.Text );

			this.lblStatus.Text = "Getting IP information...";
			GetIPInfoResult ipInfo = await c.GetIPInfo();

			this.lblStatus.Text = "Getting model name...";
			GetProductModelNameResult productModelName = await c.GetProductModelName();
			this.lblCameraInfo.Text = String.Format( CultureInfo.InvariantCulture, "Model {0} on {1}", productModelName.ModelName, ipInfo.IPAddress);

			this.lblStatus.Text = "Getting device information...";
			GetDeviceInfoResult deviceInfo = await c.GetDeviceInfo();
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
		}

		private void MainForm_Shown( object sender, EventArgs e )
		{
			this.txtPassword.Focus();
		}
	}
}
