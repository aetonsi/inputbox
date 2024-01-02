namespace inputbox {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Console.Write(txtMain.Text);
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void frmMain_Load(object sender, EventArgs e) {
            if (Environment.GetCommandLineArgs().Length > 1) {
                string[] a = Environment.GetCommandLineArgs().Skip(1).ToArray();
                for (int i = 0; i < a.Length; i++) {
                    if (a[i] == "--title" || a[i] == "-t") {
                        this.Text = a[i + 1];
                        i++;
                    }
                    if (a[i] == "--caption" || a[i] == "-c") {
                        lblCaption.Text = a[i + 1];
                        i++;
                    }
                    if (a[i] == "--password" || a[i] == "-p") {
                        chkPasswordCharToggle.Checked = true;
                    }
                }
            }
        }

        private void chkPasswordCharToggle_CheckedChanged(object sender, EventArgs e) {
            if (chkPasswordCharToggle.Checked) {
                txtMain.PasswordChar = '*';
            } else {
                txtMain.PasswordChar = '\0';
            }
            txtMain.Focus();
        }

        private void txtMain_TextChanged(object sender, EventArgs e) {
            if (txtMain.Lines.Length > 1) {
                int h = this.MinimumSize.Height + txtMain.PreferredSize.Height;
                if (this.Height < h) {
                    this.Height = h;
                }
            }
        }
    }
}
