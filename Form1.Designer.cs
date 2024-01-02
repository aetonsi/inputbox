namespace inputbox {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnOK = new Button();
            btnCancel = new Button();
            txtMain = new TextBox();
            lblCaption = new Label();
            lblInfo = new Label();
            chkPasswordCharToggle = new CheckBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Location = new Point(353, 102);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(253, 102);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMain
            // 
            txtMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMain.Location = new Point(12, 43);
            txtMain.Multiline = true;
            txtMain.Name = "txtMain";
            txtMain.Size = new Size(435, 35);
            txtMain.TabIndex = 0;
            txtMain.TextChanged += txtMain_TextChanged;
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Location = new Point(19, 11);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(0, 20);
            lblCaption.TabIndex = 999;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 7F);
            lblInfo.Location = new Point(14, 84);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(205, 15);
            lblInfo.TabIndex = 999;
            lblInfo.Text = "NB: use CTRL+Enter to add a new line";
            // 
            // chkPasswordCharToggle
            // 
            chkPasswordCharToggle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkPasswordCharToggle.AutoSize = true;
            chkPasswordCharToggle.Location = new Point(14, 105);
            chkPasswordCharToggle.Name = "chkPasswordCharToggle";
            chkPasswordCharToggle.Size = new Size(135, 24);
            chkPasswordCharToggle.TabIndex = 3;
            chkPasswordCharToggle.Text = "Password mode";
            chkPasswordCharToggle.UseVisualStyleBackColor = true;
            chkPasswordCharToggle.CheckedChanged += chkPasswordCharToggle_CheckedChanged;
            // 
            // frmMain
            // 
            AcceptButton = btnOK;
            AutoScaleMode = AutoScaleMode.None;
            CancelButton = btnCancel;
            ClientSize = new Size(462, 143);
            Controls.Add(chkPasswordCharToggle);
            Controls.Add(lblInfo);
            Controls.Add(lblCaption);
            Controls.Add(txtMain);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            MinimumSize = new Size(480, 190);
            Name = "frmMain";
            Text = "inputbox";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtMain;
        private Label lblCaption;
        private Label lblInfo;
        private CheckBox chkPasswordCharToggle;
    }
}
