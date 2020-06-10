namespace TwilightReportingClient
{
    partial class ReportView
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
            this.components = new System.ComponentModel.Container();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lbl_sunriseSunsetInfo = new System.Windows.Forms.Label();
            this.errorProviderForLatitude = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderForLongitude = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLatLong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLatLong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(137, 94);
            this.lblLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(83, 26);
            this.lblLatitude.TabIndex = 0;
            this.lblLatitude.Text = "Latitude";
            this.lblLatitude.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(228, 97);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(132, 22);
            this.txtLatitude.TabIndex = 2;
            this.txtLatitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitude_KeyPress);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(679, 97);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(132, 22);
            this.txtLongitude.TabIndex = 3;
            this.txtLongitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongitude_KeyPress);
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(393, 193);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(212, 53);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_ClickAsync);
            // 
            // lbl_sunriseSunsetInfo
            // 
            this.lbl_sunriseSunsetInfo.AutoSize = true;
            this.lbl_sunriseSunsetInfo.Location = new System.Drawing.Point(137, 315);
            this.lbl_sunriseSunsetInfo.Name = "lbl_sunriseSunsetInfo";
            this.lbl_sunriseSunsetInfo.Size = new System.Drawing.Size(0, 17);
            this.lbl_sunriseSunsetInfo.TabIndex = 5;
            // 
            // errorProviderForLatitude
            // 
            this.errorProviderForLatitude.ContainerControl = this;
            // 
            // errorProviderForLongitude
            // 
            this.errorProviderForLongitude.ContainerControl = this;
            // 
            // errorProviderLatLong
            // 
            this.errorProviderLatLong.ContainerControl = this;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 498);
            this.Controls.Add(this.lbl_sunriseSunsetInfo);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLatitude);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLatLong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lbl_sunriseSunsetInfo;
        private System.Windows.Forms.ErrorProvider errorProviderForLatitude;
        private System.Windows.Forms.ErrorProvider errorProviderForLongitude;
        private System.Windows.Forms.ErrorProvider errorProviderLatLong;
    }
}

