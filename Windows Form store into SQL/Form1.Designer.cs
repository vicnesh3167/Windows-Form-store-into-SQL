namespace Windows_Form_store_into_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.connectToServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter phone number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter email: ";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(135, 68);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 3;
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(135, 118);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(100, 20);
            this.userPhone.TabIndex = 4;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(135, 169);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(100, 20);
            this.userEmail.TabIndex = 5;
            // 
            // connectToServer
            // 
            this.connectToServer.Location = new System.Drawing.Point(100, 12);
            this.connectToServer.Name = "connectToServer";
            this.connectToServer.Size = new System.Drawing.Size(75, 23);
            this.connectToServer.TabIndex = 6;
            this.connectToServer.Text = "Connect";
            this.connectToServer.UseVisualStyleBackColor = true;
            this.connectToServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 257);
            this.Controls.Add(this.connectToServer);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "User information form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Button connectToServer;
    }
}

