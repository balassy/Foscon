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
			this.lblCameraInfo.Text = "Connecting...";

			Camera c = new Camera( this.txtHostName.Text, Int32.Parse(this.txtPort.Text), this.txtUserName.Text, this.txtPassword.Text );
			GetIPInfoResult ipInfo = await c.GetIPInfo();
			GetProductModelNameResult productModelName = await c.GetProductModelName();
			this.lblCameraInfo.Text = String.Format( CultureInfo.InvariantCulture, "Model {0} on {1}", productModelName.ModelName, ipInfo.IPAddress);

			GetDeviceInfoResult deviceInfo = await c.GetDeviceInfo();
			this.lblProductName.Text = deviceInfo.ProductName;
			this.lblDeviceName.Text = deviceInfo.DeviceName;
			this.lblSerialNo.Text = deviceInfo.SerialNumber;
			this.lblMac.Text = deviceInfo.MacAddress;
			this.lblCurrentDate.Text = deviceInfo.CurrentDate.ToString(CultureInfo.CurrentCulture);
			this.lblTimeZone.Text = deviceInfo.TimeZone;
			this.lblFirmwareVersion.Text = deviceInfo.FirmwareVersion;
			this.lblHardwareVersion.Text = deviceInfo.HardwareVersion;
		}

		private void MainForm_Shown( object sender, EventArgs e )
		{
			this.txtPassword.Focus();
		}
	}
}
