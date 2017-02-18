namespace Inviligation
{
    partial class Reset_1_a
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
            this.ll_1y = new System.Windows.Forms.LinkLabel();
            this.ll_2y = new System.Windows.Forms.LinkLabel();
            this.ll_3y = new System.Windows.Forms.LinkLabel();
            this.ll_4y = new System.Windows.Forms.LinkLabel();
            this.bt_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEMESTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ll_1y
            // 
            this.ll_1y.AutoSize = true;
            this.ll_1y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_1y.Location = new System.Drawing.Point(128, 109);
            this.ll_1y.Name = "ll_1y";
            this.ll_1y.Size = new System.Drawing.Size(51, 16);
            this.ll_1y.TabIndex = 1;
            this.ll_1y.TabStop = true;
            this.ll_1y.Text = "I YEAR";
            this.ll_1y.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_1y_LinkClicked);
            // 
            // ll_2y
            // 
            this.ll_2y.AutoSize = true;
            this.ll_2y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_2y.Location = new System.Drawing.Point(128, 144);
            this.ll_2y.Name = "ll_2y";
            this.ll_2y.Size = new System.Drawing.Size(54, 16);
            this.ll_2y.TabIndex = 2;
            this.ll_2y.TabStop = true;
            this.ll_2y.Text = "II YEAR";
            this.ll_2y.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_2y_LinkClicked);
            // 
            // ll_3y
            // 
            this.ll_3y.AutoSize = true;
            this.ll_3y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_3y.Location = new System.Drawing.Point(128, 175);
            this.ll_3y.Name = "ll_3y";
            this.ll_3y.Size = new System.Drawing.Size(57, 16);
            this.ll_3y.TabIndex = 3;
            this.ll_3y.TabStop = true;
            this.ll_3y.Text = "III YEAR";
            this.ll_3y.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_3y_LinkClicked);
            // 
            // ll_4y
            // 
            this.ll_4y.AutoSize = true;
            this.ll_4y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_4y.Location = new System.Drawing.Point(128, 213);
            this.ll_4y.Name = "ll_4y";
            this.ll_4y.Size = new System.Drawing.Size(60, 16);
            this.ll_4y.TabIndex = 4;
            this.ll_4y.TabStop = true;
            this.ll_4y.Text = "IV YEAR";
            this.ll_4y.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_4y_LinkClicked);
            // 
            // bt_home
            // 
            this.bt_home.Image = global::Inviligation.Properties.Resources.home_nav;
            this.bt_home.Location = new System.Drawing.Point(263, 12);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(40, 27);
            this.bt_home.TabIndex = 14;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // Reset_1_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 271);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.ll_4y);
            this.Controls.Add(this.ll_3y);
            this.Controls.Add(this.ll_2y);
            this.Controls.Add(this.ll_1y);
            this.Controls.Add(this.label1);
            this.Name = "Reset_1_a";
            this.Text = "Reset time table";
            this.Load += new System.EventHandler(this.Reset_1_a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ll_1y;
        private System.Windows.Forms.LinkLabel ll_2y;
        private System.Windows.Forms.LinkLabel ll_3y;
        private System.Windows.Forms.LinkLabel ll_4y;
        private System.Windows.Forms.Button bt_home;
    }
}