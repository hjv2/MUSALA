namespace REST.FORMS
{
    partial class frmDSpleGateway
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
            System.Windows.Forms.Label iPv4Label;
            System.Windows.Forms.Label humanReadableLabel;
            System.Windows.Forms.Label uniqueSerialNumLabel;
            this.iPv4TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.humanReadableTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.uniqueSerialNumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            iPv4Label = new System.Windows.Forms.Label();
            humanReadableLabel = new System.Windows.Forms.Label();
            uniqueSerialNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iPv4TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanReadableTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueSerialNumTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iPv4Label
            // 
            iPv4Label.AutoSize = true;
            iPv4Label.Location = new System.Drawing.Point(121, 85);
            iPv4Label.Name = "iPv4Label";
            iPv4Label.Size = new System.Drawing.Size(33, 13);
            iPv4Label.TabIndex = 16;
            iPv4Label.Text = "IPv4:";
            // 
            // humanReadableLabel
            // 
            humanReadableLabel.AutoSize = true;
            humanReadableLabel.Location = new System.Drawing.Point(62, 59);
            humanReadableLabel.Name = "humanReadableLabel";
            humanReadableLabel.Size = new System.Drawing.Size(92, 13);
            humanReadableLabel.TabIndex = 14;
            humanReadableLabel.Text = "Human Readable:";
            // 
            // uniqueSerialNumLabel
            // 
            uniqueSerialNumLabel.AutoSize = true;
            uniqueSerialNumLabel.Location = new System.Drawing.Point(41, 33);
            uniqueSerialNumLabel.Name = "uniqueSerialNumLabel";
            uniqueSerialNumLabel.Size = new System.Drawing.Size(113, 13);
            uniqueSerialNumLabel.TabIndex = 13;
            uniqueSerialNumLabel.Text = "Unique Serial Number:";
            // 
            // iPv4TextEdit
            // 
            this.iPv4TextEdit.Enabled = false;
            this.iPv4TextEdit.Location = new System.Drawing.Point(160, 82);
            this.iPv4TextEdit.Name = "iPv4TextEdit";
            this.iPv4TextEdit.Size = new System.Drawing.Size(100, 20);
            this.iPv4TextEdit.TabIndex = 18;
            // 
            // humanReadableTextEdit
            // 
            this.humanReadableTextEdit.Enabled = false;
            this.humanReadableTextEdit.Location = new System.Drawing.Point(160, 56);
            this.humanReadableTextEdit.Name = "humanReadableTextEdit";
            this.humanReadableTextEdit.Size = new System.Drawing.Size(100, 20);
            this.humanReadableTextEdit.TabIndex = 17;
            // 
            // uniqueSerialNumTextEdit
            // 
            this.uniqueSerialNumTextEdit.Enabled = false;
            this.uniqueSerialNumTextEdit.Location = new System.Drawing.Point(160, 30);
            this.uniqueSerialNumTextEdit.Name = "uniqueSerialNumTextEdit";
            this.uniqueSerialNumTextEdit.Size = new System.Drawing.Size(100, 20);
            this.uniqueSerialNumTextEdit.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(193, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(67, 23);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDSpleGateway
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 169);
            this.Controls.Add(iPv4Label);
            this.Controls.Add(this.iPv4TextEdit);
            this.Controls.Add(humanReadableLabel);
            this.Controls.Add(this.humanReadableTextEdit);
            this.Controls.Add(uniqueSerialNumLabel);
            this.Controls.Add(this.uniqueSerialNumTextEdit);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmDSpleGateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details simple Gateway";
            ((System.ComponentModel.ISupportInitialize)(this.iPv4TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanReadableTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueSerialNumTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit iPv4TextEdit;
        private DevExpress.XtraEditors.TextEdit humanReadableTextEdit;
        private DevExpress.XtraEditors.TextEdit uniqueSerialNumTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}