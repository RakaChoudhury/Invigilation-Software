namespace Inviligation
{
    partial class Home_Faculty
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
            this.ll_InvSch = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ll_LeaApp = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ll_PerSet = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "u";
            // 
            // ll_InvSch
            // 
            this.ll_InvSch.AutoSize = true;
            this.ll_InvSch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_InvSch.Location = new System.Drawing.Point(50, 158);
            this.ll_InvSch.Name = "ll_InvSch";
            this.ll_InvSch.Size = new System.Drawing.Size(67, 16);
            this.ll_InvSch.TabIndex = 5;
            this.ll_InvSch.TabStop = true;
            this.ll_InvSch.Text = "Click here";
            this.ll_InvSch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_InvSch_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "to view your invigilation schedule";
            // 
            // ll_LeaApp
            // 
            this.ll_LeaApp.AutoSize = true;
            this.ll_LeaApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_LeaApp.Location = new System.Drawing.Point(50, 192);
            this.ll_LeaApp.Name = "ll_LeaApp";
            this.ll_LeaApp.Size = new System.Drawing.Size(67, 16);
            this.ll_LeaApp.TabIndex = 7;
            this.ll_LeaApp.TabStop = true;
            this.ll_LeaApp.Text = "Click here";
            this.ll_LeaApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_LeaApp_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "to view your leave application status";
            // 
            // ll_PerSet
            // 
            this.ll_PerSet.AutoSize = true;
            this.ll_PerSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_PerSet.Location = new System.Drawing.Point(50, 228);
            this.ll_PerSet.Name = "ll_PerSet";
            this.ll_PerSet.Size = new System.Drawing.Size(67, 16);
            this.ll_PerSet.TabIndex = 9;
            this.ll_PerSet.TabStop = true;
            this.ll_PerSet.Text = "Click here";
            this.ll_PerSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_PerSet_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "to change your personal settings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ll_PerSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ll_LeaApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ll_InvSch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home_Faculty";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Faculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ll_InvSch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ll_LeaApp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel ll_PerSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}