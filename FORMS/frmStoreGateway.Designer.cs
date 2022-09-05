namespace REST.FORMS
{
    partial class frmStoreGateway
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
            System.Windows.Forms.Label uniqueSerialNumLabel;
            System.Windows.Forms.Label humanReadableLabel;
            System.Windows.Forms.Label iPv4Label;
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.uniqueSerialNumTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.humanReadableTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iPv4TextEdit = new DevExpress.XtraEditors.TextEdit();
            uniqueSerialNumLabel = new System.Windows.Forms.Label();
            humanReadableLabel = new System.Windows.Forms.Label();
            iPv4Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueSerialNumTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanReadableTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPv4TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(119, 106);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(67, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(191, 106);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(67, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // uniqueSerialNumLabel
            // 
            uniqueSerialNumLabel.AutoSize = true;
            uniqueSerialNumLabel.Location = new System.Drawing.Point(39, 28);
            uniqueSerialNumLabel.Name = "uniqueSerialNumLabel";
            uniqueSerialNumLabel.Size = new System.Drawing.Size(113, 13);
            uniqueSerialNumLabel.TabIndex = 7;
            uniqueSerialNumLabel.Text = "Unique Serial Number:";
            // 
            // uniqueSerialNumTextEdit
            // 
            this.uniqueSerialNumTextEdit.Location = new System.Drawing.Point(158, 25);
            this.uniqueSerialNumTextEdit.Name = "uniqueSerialNumTextEdit";
            this.uniqueSerialNumTextEdit.Size = new System.Drawing.Size(100, 20);
            this.uniqueSerialNumTextEdit.TabIndex = 8;
            // 
            // humanReadableLabel
            // 
            humanReadableLabel.AutoSize = true;
            humanReadableLabel.Location = new System.Drawing.Point(60, 54);
            humanReadableLabel.Name = "humanReadableLabel";
            humanReadableLabel.Size = new System.Drawing.Size(92, 13);
            humanReadableLabel.TabIndex = 8;
            humanReadableLabel.Text = "Human Readable:";
            // 
            // humanReadableTextEdit
            // 
            this.humanReadableTextEdit.Location = new System.Drawing.Point(158, 51);
            this.humanReadableTextEdit.Name = "humanReadableTextEdit";
            this.humanReadableTextEdit.Size = new System.Drawing.Size(100, 20);
            this.humanReadableTextEdit.TabIndex = 9;
            // 
            // iPv4Label
            // 
            iPv4Label.AutoSize = true;
            iPv4Label.Location = new System.Drawing.Point(119, 80);
            iPv4Label.Name = "iPv4Label";
            iPv4Label.Size = new System.Drawing.Size(33, 13);
            iPv4Label.TabIndex = 9;
            iPv4Label.Text = "IPv4:";
            // 
            // iPv4TextEdit
            // 
            this.iPv4TextEdit.Location = new System.Drawing.Point(158, 77);
            this.iPv4TextEdit.Name = "iPv4TextEdit";
            this.iPv4TextEdit.Size = new System.Drawing.Size(100, 20);
            this.iPv4TextEdit.TabIndex = 10;
            // 
            // frmStoreGateway
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(332, 157);
            this.Controls.Add(iPv4Label);
            this.Controls.Add(this.iPv4TextEdit);
            this.Controls.Add(humanReadableLabel);
            this.Controls.Add(this.humanReadableTextEdit);
            this.Controls.Add(uniqueSerialNumLabel);
            this.Controls.Add(this.uniqueSerialNumTextEdit);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Name = "frmStoreGateway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store a Gateway";
            this.Load += new System.EventHandler(this.frmStoreGateway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uniqueSerialNumTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humanReadableTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPv4TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit uniqueSerialNumTextEdit;
        private DevExpress.XtraEditors.TextEdit humanReadableTextEdit;
        private DevExpress.XtraEditors.TextEdit iPv4TextEdit;
    }
}