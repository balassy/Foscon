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
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.lblCameraInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(13, 13);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(48, 13);
			this.lblAddress.TabIndex = 0;
			this.lblAddress.Text = "Address:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(83, 10);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(119, 20);
			this.txtAddress.TabIndex = 1;
			this.txtAddress.Text = "192.168.1.101:88";
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
			this.txtPassword.Text = "Kamer.Amera!";
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
			this.lblCameraInfo.Location = new System.Drawing.Point(208, 94);
			this.lblCameraInfo.Name = "lblCameraInfo";
			this.lblCameraInfo.Size = new System.Drawing.Size(113, 13);
			this.lblCameraInfo.TabIndex = 7;
			this.lblCameraInfo.Text = "(Please click Connect)";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 363);
			this.Controls.Add(this.lblCameraInfo);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Name = "MainForm";
			this.Text = "Foscon Desktop Tester";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label lblCameraInfo;
	}
}

