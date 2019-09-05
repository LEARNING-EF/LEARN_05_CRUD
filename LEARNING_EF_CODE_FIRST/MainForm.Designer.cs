namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.registerButton = new System.Windows.Forms.Button();
			this.getUsersButton = new System.Windows.Forms.Button();
			this.usersListBox = new System.Windows.Forms.ListBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// registerButton
			// 
			this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.registerButton.Location = new System.Drawing.Point(12, 12);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(402, 23);
			this.registerButton.TabIndex = 0;
			this.registerButton.Text = "&Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// getUsersButton
			// 
			this.getUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.getUsersButton.Location = new System.Drawing.Point(12, 41);
			this.getUsersButton.Name = "getUsersButton";
			this.getUsersButton.Size = new System.Drawing.Size(402, 23);
			this.getUsersButton.TabIndex = 1;
			this.getUsersButton.Text = "&Get Users";
			this.getUsersButton.UseVisualStyleBackColor = true;
			this.getUsersButton.Click += new System.EventHandler(this.GetUsersButton_Click);
			// 
			// usersListBox
			// 
			this.usersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usersListBox.FormattingEnabled = true;
			this.usersListBox.ItemHeight = 16;
			this.usersListBox.Location = new System.Drawing.Point(12, 70);
			this.usersListBox.Name = "usersListBox";
			this.usersListBox.Size = new System.Drawing.Size(402, 84);
			this.usersListBox.TabIndex = 2;
			// 
			// loginButton
			// 
			this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButton.Location = new System.Drawing.Point(12, 160);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(402, 23);
			this.loginButton.TabIndex = 3;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.updateButton.Location = new System.Drawing.Point(12, 189);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(402, 23);
			this.updateButton.TabIndex = 4;
			this.updateButton.Text = "&Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.Location = new System.Drawing.Point(12, 218);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(402, 23);
			this.deleteButton.TabIndex = 5;
			this.deleteButton.Text = "&Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 322);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.usersListBox);
			this.Controls.Add(this.getUsersButton);
			this.Controls.Add(this.registerButton);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Button getUsersButton;
		private System.Windows.Forms.ListBox usersListBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
	}
}
