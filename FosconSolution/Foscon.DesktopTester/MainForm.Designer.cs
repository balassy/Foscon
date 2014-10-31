namespace Foscon.DesktopTester
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblHostName = new System.Windows.Forms.Label();
			this.txtHostName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.lblCameraInfo = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.grpDeviceInfo = new System.Windows.Forms.GroupBox();
			this.lblHardwareVersion = new System.Windows.Forms.Label();
			this.lblHardwareVersionPrompt = new System.Windows.Forms.Label();
			this.lblFirmwareVersion = new System.Windows.Forms.Label();
			this.lblFirmwareVersionPrompt = new System.Windows.Forms.Label();
			this.lblTimeZone = new System.Windows.Forms.Label();
			this.lblCurrentDate = new System.Windows.Forms.Label();
			this.lblCurrentDatePrompt = new System.Windows.Forms.Label();
			this.lblMac = new System.Windows.Forms.Label();
			this.lblMacPrompt = new System.Windows.Forms.Label();
			this.lblSerialNo = new System.Windows.Forms.Label();
			this.lblSerialNoPrompt = new System.Windows.Forms.Label();
			this.lblDeviceName = new System.Windows.Forms.Label();
			this.lblDeviceNamePrompt = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductNamePrompt = new System.Windows.Forms.Label();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblStatusSpacer = new System.Windows.Forms.ToolStripStatusLabel();
			this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pbSnapshot = new System.Windows.Forms.PictureBox();
			this.grpPortInfo = new System.Windows.Forms.GroupBox();
			this.lblHttpPortPrompt = new System.Windows.Forms.Label();
			this.lblHttpsPortPrompt = new System.Windows.Forms.Label();
			this.lblMediaPortPrompt = new System.Windows.Forms.Label();
			this.lblOnvifPortPrompt = new System.Windows.Forms.Label();
			this.lblHttpPort = new System.Windows.Forms.Label();
			this.lblHttpsPort = new System.Windows.Forms.Label();
			this.lblMediaPort = new System.Windows.Forms.Label();
			this.lblOnvifPort = new System.Windows.Forms.Label();
			this.grpDeviceInfo.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSnapshot)).BeginInit();
			this.grpPortInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHostName
			// 
			this.lblHostName.AutoSize = true;
			this.lblHostName.Location = new System.Drawing.Point(13, 13);
			this.lblHostName.Name = "lblHostName";
			this.lblHostName.Size = new System.Drawing.Size(61, 13);
			this.lblHostName.TabIndex = 0;
			this.lblHostName.Text = "Host name:";
			// 
			// txtHostName
			// 
			this.txtHostName.Location = new System.Drawing.Point(83, 10);
			this.txtHostName.Name = "txtHostName";
			this.txtHostName.Size = new System.Drawing.Size(119, 20);
			this.txtHostName.TabIndex = 1;
			this.txtHostName.Text = "192.168.0.104";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(13, 39);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(61, 13);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.Text = "User name:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(83, 36);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(119, 20);
			this.txtUserName.TabIndex = 3;
			this.txtUserName.Text = "admin";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(83, 62);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(119, 20);
			this.txtPassword.TabIndex = 4;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(13, 65);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 5;
			this.lblPassword.Text = "Password:";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(83, 89);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(119, 23);
			this.btnConnect.TabIndex = 6;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// lblCameraInfo
			// 
			this.lblCameraInfo.AutoSize = true;
			this.lblCameraInfo.Location = new System.Drawing.Point(82, 115);
			this.lblCameraInfo.Name = "lblCameraInfo";
			this.lblCameraInfo.Size = new System.Drawing.Size(113, 13);
			this.lblCameraInfo.TabIndex = 7;
			this.lblCameraInfo.Text = "(Please click Connect)";
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(208, 13);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 8;
			this.lblPort.Text = "Port:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(243, 10);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(46, 20);
			this.txtPort.TabIndex = 9;
			this.txtPort.Text = "88";
			// 
			// grpDeviceInfo
			// 
			this.grpDeviceInfo.Controls.Add(this.lblHardwareVersion);
			this.grpDeviceInfo.Controls.Add(this.lblHardwareVersionPrompt);
			this.grpDeviceInfo.Controls.Add(this.lblFirmwareVersion);
			this.grpDeviceInfo.Controls.Add(this.lblFirmwareVersionPrompt);
			this.grpDeviceInfo.Controls.Add(this.lblTimeZone);
			this.grpDeviceInfo.Controls.Add(this.lblCurrentDate);
			this.grpDeviceInfo.Controls.Add(this.lblCurrentDatePrompt);
			this.grpDeviceInfo.Controls.Add(this.lblMac);
			this.grpDeviceInfo.Controls.Add(this.lblMacPrompt);
			this.grpDeviceInfo.Controls.Add(this.lblSerialNo);
			this.grpDeviceInfo.Controls.Add(this.lblSerialNoPrompt);
			this.grpDeviceInfo.Controls.Add(this.lblDeviceName);
			this.grpDeviceInfo.Controls.Add(this.lblDeviceNamePrompt);
			this.grpDeviceInfo.Controls.Add(this.lblProductName);
			this.grpDeviceInfo.Controls.Add(this.lblProductNamePrompt);
			this.grpDeviceInfo.Location = new System.Drawing.Point(16, 141);
			this.grpDeviceInfo.Name = "grpDeviceInfo";
			this.grpDeviceInfo.Size = new System.Drawing.Size(355, 199);
			this.grpDeviceInfo.TabIndex = 10;
			this.grpDeviceInfo.TabStop = false;
			this.grpDeviceInfo.Text = "Device info";
			// 
			// lblHardwareVersion
			// 
			this.lblHardwareVersion.AutoSize = true;
			this.lblHardwareVersion.Location = new System.Drawing.Point(106, 172);
			this.lblHardwareVersion.Name = "lblHardwareVersion";
			this.lblHardwareVersion.Size = new System.Drawing.Size(113, 13);
			this.lblHardwareVersion.TabIndex = 16;
			this.lblHardwareVersion.Text = "(Please click Connect)";
			// 
			// lblHardwareVersionPrompt
			// 
			this.lblHardwareVersionPrompt.AutoSize = true;
			this.lblHardwareVersionPrompt.Location = new System.Drawing.Point(6, 172);
			this.lblHardwareVersionPrompt.Name = "lblHardwareVersionPrompt";
			this.lblHardwareVersionPrompt.Size = new System.Drawing.Size(93, 13);
			this.lblHardwareVersionPrompt.TabIndex = 15;
			this.lblHardwareVersionPrompt.Text = "Hardware version:";
			// 
			// lblFirmwareVersion
			// 
			this.lblFirmwareVersion.AutoSize = true;
			this.lblFirmwareVersion.Location = new System.Drawing.Point(106, 148);
			this.lblFirmwareVersion.Name = "lblFirmwareVersion";
			this.lblFirmwareVersion.Size = new System.Drawing.Size(113, 13);
			this.lblFirmwareVersion.TabIndex = 14;
			this.lblFirmwareVersion.Text = "(Please click Connect)";
			// 
			// lblFirmwareVersionPrompt
			// 
			this.lblFirmwareVersionPrompt.AutoSize = true;
			this.lblFirmwareVersionPrompt.Location = new System.Drawing.Point(6, 148);
			this.lblFirmwareVersionPrompt.Name = "lblFirmwareVersionPrompt";
			this.lblFirmwareVersionPrompt.Size = new System.Drawing.Size(89, 13);
			this.lblFirmwareVersionPrompt.TabIndex = 13;
			this.lblFirmwareVersionPrompt.Text = "Firmware version:";
			// 
			// lblTimeZone
			// 
			this.lblTimeZone.AutoSize = true;
			this.lblTimeZone.Location = new System.Drawing.Point(227, 124);
			this.lblTimeZone.Name = "lblTimeZone";
			this.lblTimeZone.Size = new System.Drawing.Size(113, 13);
			this.lblTimeZone.TabIndex = 12;
			this.lblTimeZone.Text = "(Please click Connect)";
			// 
			// lblCurrentDate
			// 
			this.lblCurrentDate.AutoSize = true;
			this.lblCurrentDate.Location = new System.Drawing.Point(106, 124);
			this.lblCurrentDate.Name = "lblCurrentDate";
			this.lblCurrentDate.Size = new System.Drawing.Size(113, 13);
			this.lblCurrentDate.TabIndex = 9;
			this.lblCurrentDate.Text = "(Please click Connect)";
			// 
			// lblCurrentDatePrompt
			// 
			this.lblCurrentDatePrompt.AutoSize = true;
			this.lblCurrentDatePrompt.Location = new System.Drawing.Point(6, 124);
			this.lblCurrentDatePrompt.Name = "lblCurrentDatePrompt";
			this.lblCurrentDatePrompt.Size = new System.Drawing.Size(68, 13);
			this.lblCurrentDatePrompt.TabIndex = 8;
			this.lblCurrentDatePrompt.Text = "Current date:";
			// 
			// lblMac
			// 
			this.lblMac.AutoSize = true;
			this.lblMac.Location = new System.Drawing.Point(106, 100);
			this.lblMac.Name = "lblMac";
			this.lblMac.Size = new System.Drawing.Size(113, 13);
			this.lblMac.TabIndex = 7;
			this.lblMac.Text = "(Please click Connect)";
			// 
			// lblMacPrompt
			// 
			this.lblMacPrompt.AutoSize = true;
			this.lblMacPrompt.Location = new System.Drawing.Point(6, 100);
			this.lblMacPrompt.Name = "lblMacPrompt";
			this.lblMacPrompt.Size = new System.Drawing.Size(73, 13);
			this.lblMacPrompt.TabIndex = 6;
			this.lblMacPrompt.Text = "MAC address:";
			// 
			// lblSerialNo
			// 
			this.lblSerialNo.AutoSize = true;
			this.lblSerialNo.Location = new System.Drawing.Point(106, 76);
			this.lblSerialNo.Name = "lblSerialNo";
			this.lblSerialNo.Size = new System.Drawing.Size(113, 13);
			this.lblSerialNo.TabIndex = 5;
			this.lblSerialNo.Text = "(Please click Connect)";
			// 
			// lblSerialNoPrompt
			// 
			this.lblSerialNoPrompt.AutoSize = true;
			this.lblSerialNoPrompt.Location = new System.Drawing.Point(6, 76);
			this.lblSerialNoPrompt.Name = "lblSerialNoPrompt";
			this.lblSerialNoPrompt.Size = new System.Drawing.Size(53, 13);
			this.lblSerialNoPrompt.TabIndex = 4;
			this.lblSerialNoPrompt.Text = "Serial No:";
			// 
			// lblDeviceName
			// 
			this.lblDeviceName.AutoSize = true;
			this.lblDeviceName.Location = new System.Drawing.Point(106, 52);
			this.lblDeviceName.Name = "lblDeviceName";
			this.lblDeviceName.Size = new System.Drawing.Size(113, 13);
			this.lblDeviceName.TabIndex = 3;
			this.lblDeviceName.Text = "(Please click Connect)";
			// 
			// lblDeviceNamePrompt
			// 
			this.lblDeviceNamePrompt.AutoSize = true;
			this.lblDeviceNamePrompt.Location = new System.Drawing.Point(6, 52);
			this.lblDeviceNamePrompt.Name = "lblDeviceNamePrompt";
			this.lblDeviceNamePrompt.Size = new System.Drawing.Size(73, 13);
			this.lblDeviceNamePrompt.TabIndex = 2;
			this.lblDeviceNamePrompt.Text = "Device name:";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(106, 28);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(113, 13);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "(Please click Connect)";
			// 
			// lblProductNamePrompt
			// 
			this.lblProductNamePrompt.AutoSize = true;
			this.lblProductNamePrompt.Location = new System.Drawing.Point(6, 28);
			this.lblProductNamePrompt.Name = "lblProductNamePrompt";
			this.lblProductNamePrompt.Size = new System.Drawing.Size(76, 13);
			this.lblProductNamePrompt.TabIndex = 0;
			this.lblProductNamePrompt.Text = "Product name:";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblStatusSpacer,
            this.pbStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 506);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(715, 22);
			this.statusStrip.TabIndex = 11;
			this.statusStrip.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(42, 17);
			this.lblStatus.Text = "Ready.";
			// 
			// lblStatusSpacer
			// 
			this.lblStatusSpacer.Name = "lblStatusSpacer";
			this.lblStatusSpacer.Size = new System.Drawing.Size(658, 17);
			this.lblStatusSpacer.Spring = true;
			// 
			// pbStatus
			// 
			this.pbStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(100, 16);
			this.pbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pbStatus.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(211, 89);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(119, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pbSnapshot
			// 
			this.pbSnapshot.Location = new System.Drawing.Point(377, 146);
			this.pbSnapshot.Name = "pbSnapshot";
			this.pbSnapshot.Size = new System.Drawing.Size(320, 180);
			this.pbSnapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbSnapshot.TabIndex = 13;
			this.pbSnapshot.TabStop = false;
			// 
			// grpPortInfo
			// 
			this.grpPortInfo.Controls.Add(this.lblOnvifPort);
			this.grpPortInfo.Controls.Add(this.lblMediaPort);
			this.grpPortInfo.Controls.Add(this.lblHttpsPort);
			this.grpPortInfo.Controls.Add(this.lblHttpPort);
			this.grpPortInfo.Controls.Add(this.lblOnvifPortPrompt);
			this.grpPortInfo.Controls.Add(this.lblMediaPortPrompt);
			this.grpPortInfo.Controls.Add(this.lblHttpsPortPrompt);
			this.grpPortInfo.Controls.Add(this.lblHttpPortPrompt);
			this.grpPortInfo.Location = new System.Drawing.Point(16, 347);
			this.grpPortInfo.Name = "grpPortInfo";
			this.grpPortInfo.Size = new System.Drawing.Size(355, 125);
			this.grpPortInfo.TabIndex = 14;
			this.grpPortInfo.TabStop = false;
			this.grpPortInfo.Text = "Port information";
			// 
			// lblHttpPortPrompt
			// 
			this.lblHttpPortPrompt.AutoSize = true;
			this.lblHttpPortPrompt.Location = new System.Drawing.Point(6, 25);
			this.lblHttpPortPrompt.Name = "lblHttpPortPrompt";
			this.lblHttpPortPrompt.Size = new System.Drawing.Size(39, 13);
			this.lblHttpPortPrompt.TabIndex = 0;
			this.lblHttpPortPrompt.Text = "HTTP:";
			// 
			// lblHttpsPortPrompt
			// 
			this.lblHttpsPortPrompt.AutoSize = true;
			this.lblHttpsPortPrompt.Location = new System.Drawing.Point(6, 49);
			this.lblHttpsPortPrompt.Name = "lblHttpsPortPrompt";
			this.lblHttpsPortPrompt.Size = new System.Drawing.Size(46, 13);
			this.lblHttpsPortPrompt.TabIndex = 1;
			this.lblHttpsPortPrompt.Text = "HTTPS:";
			// 
			// lblMediaPortPrompt
			// 
			this.lblMediaPortPrompt.AutoSize = true;
			this.lblMediaPortPrompt.Location = new System.Drawing.Point(6, 73);
			this.lblMediaPortPrompt.Name = "lblMediaPortPrompt";
			this.lblMediaPortPrompt.Size = new System.Drawing.Size(39, 13);
			this.lblMediaPortPrompt.TabIndex = 2;
			this.lblMediaPortPrompt.Text = "Media:";
			// 
			// lblOnvifPortPrompt
			// 
			this.lblOnvifPortPrompt.AutoSize = true;
			this.lblOnvifPortPrompt.Location = new System.Drawing.Point(6, 97);
			this.lblOnvifPortPrompt.Name = "lblOnvifPortPrompt";
			this.lblOnvifPortPrompt.Size = new System.Drawing.Size(35, 13);
			this.lblOnvifPortPrompt.TabIndex = 3;
			this.lblOnvifPortPrompt.Text = "Onvif:";
			// 
			// lblHttpPort
			// 
			this.lblHttpPort.AutoSize = true;
			this.lblHttpPort.Location = new System.Drawing.Point(106, 25);
			this.lblHttpPort.Name = "lblHttpPort";
			this.lblHttpPort.Size = new System.Drawing.Size(113, 13);
			this.lblHttpPort.TabIndex = 4;
			this.lblHttpPort.Text = "(Please click Connect)";
			// 
			// lblHttpsPort
			// 
			this.lblHttpsPort.AutoSize = true;
			this.lblHttpsPort.Location = new System.Drawing.Point(106, 49);
			this.lblHttpsPort.Name = "lblHttpsPort";
			this.lblHttpsPort.Size = new System.Drawing.Size(113, 13);
			this.lblHttpsPort.TabIndex = 5;
			this.lblHttpsPort.Text = "(Please click Connect)";
			// 
			// lblMediaPort
			// 
			this.lblMediaPort.AutoSize = true;
			this.lblMediaPort.Location = new System.Drawing.Point(106, 73);
			this.lblMediaPort.Name = "lblMediaPort";
			this.lblMediaPort.Size = new System.Drawing.Size(113, 13);
			this.lblMediaPort.TabIndex = 6;
			this.lblMediaPort.Text = "(Please click Connect)";
			// 
			// lblOnvifPort
			// 
			this.lblOnvifPort.AutoSize = true;
			this.lblOnvifPort.Location = new System.Drawing.Point(106, 97);
			this.lblOnvifPort.Name = "lblOnvifPort";
			this.lblOnvifPort.Size = new System.Drawing.Size(113, 13);
			this.lblOnvifPort.TabIndex = 7;
			this.lblOnvifPort.Text = "(Please click Connect)";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 528);
			this.Controls.Add(this.grpPortInfo);
			this.Controls.Add(this.pbSnapshot);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.grpDeviceInfo);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.lblCameraInfo);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtHostName);
			this.Controls.Add(this.lblHostName);
			this.Name = "MainForm";
			this.Text = "Foscon Desktop Tester";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.grpDeviceInfo.ResumeLayout(false);
			this.grpDeviceInfo.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSnapshot)).EndInit();
			this.grpPortInfo.ResumeLayout(false);
			this.grpPortInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHostName;
		private System.Windows.Forms.TextBox txtHostName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label lblCameraInfo;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.GroupBox grpDeviceInfo;
		private System.Windows.Forms.Label lblProductNamePrompt;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblTimeZone;
		private System.Windows.Forms.Label lblCurrentDate;
		private System.Windows.Forms.Label lblCurrentDatePrompt;
		private System.Windows.Forms.Label lblMac;
		private System.Windows.Forms.Label lblMacPrompt;
		private System.Windows.Forms.Label lblSerialNo;
		private System.Windows.Forms.Label lblSerialNoPrompt;
		private System.Windows.Forms.Label lblDeviceName;
		private System.Windows.Forms.Label lblDeviceNamePrompt;
		private System.Windows.Forms.Label lblHardwareVersion;
		private System.Windows.Forms.Label lblHardwareVersionPrompt;
		private System.Windows.Forms.Label lblFirmwareVersion;
		private System.Windows.Forms.Label lblFirmwareVersionPrompt;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripStatusLabel lblStatusSpacer;
		private System.Windows.Forms.ToolStripProgressBar pbStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox pbSnapshot;
		private System.Windows.Forms.GroupBox grpPortInfo;
		private System.Windows.Forms.Label lblOnvifPortPrompt;
		private System.Windows.Forms.Label lblMediaPortPrompt;
		private System.Windows.Forms.Label lblHttpsPortPrompt;
		private System.Windows.Forms.Label lblHttpPortPrompt;
		private System.Windows.Forms.Label lblOnvifPort;
		private System.Windows.Forms.Label lblMediaPort;
		private System.Windows.Forms.Label lblHttpsPort;
		private System.Windows.Forms.Label lblHttpPort;
	}
}

