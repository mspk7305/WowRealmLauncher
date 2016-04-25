namespace realmLauncher
{
    partial class realmLauncher
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.lblSelectedRealm = new System.Windows.Forms.Label();
            this.btnRealmSave = new System.Windows.Forms.Button();
            this.txtImportURL = new System.Windows.Forms.TextBox();
            this.btnImportRealm = new System.Windows.Forms.Button();
            this.btnRemoveRealm = new System.Windows.Forms.Button();
            this.btnLaunchRealm = new System.Windows.Forms.Button();
            this.realmView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSelectedClient = new System.Windows.Forms.Label();
            this.btnSaveClients = new System.Windows.Forms.Button();
            this.btnRemoveVersion = new System.Windows.Forms.Button();
            this.clientView = new System.Windows.Forms.DataGridView();
            this.chkClearWDB = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realmView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkClearWDB);
            this.tabPage1.Controls.Add(this.chkAppend);
            this.tabPage1.Controls.Add(this.lblSelectedRealm);
            this.tabPage1.Controls.Add(this.btnRealmSave);
            this.tabPage1.Controls.Add(this.txtImportURL);
            this.tabPage1.Controls.Add(this.btnImportRealm);
            this.tabPage1.Controls.Add(this.btnRemoveRealm);
            this.tabPage1.Controls.Add(this.btnLaunchRealm);
            this.tabPage1.Controls.Add(this.realmView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Realms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkAppend
            // 
            this.chkAppend.AutoSize = true;
            this.chkAppend.Location = new System.Drawing.Point(558, 308);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.Size = new System.Drawing.Size(142, 17);
            this.chkAppend.TabIndex = 7;
            this.chkAppend.Text = "Do Not Replace Existing";
            this.chkAppend.UseVisualStyleBackColor = true;
            // 
            // lblSelectedRealm
            // 
            this.lblSelectedRealm.AutoSize = true;
            this.lblSelectedRealm.Location = new System.Drawing.Point(154, 340);
            this.lblSelectedRealm.Name = "lblSelectedRealm";
            this.lblSelectedRealm.Size = new System.Drawing.Size(76, 13);
            this.lblSelectedRealm.TabIndex = 6;
            this.lblSelectedRealm.Text = "(Select Realm)";
            // 
            // btnRealmSave
            // 
            this.btnRealmSave.Location = new System.Drawing.Point(559, 335);
            this.btnRealmSave.Name = "btnRealmSave";
            this.btnRealmSave.Size = new System.Drawing.Size(141, 23);
            this.btnRealmSave.TabIndex = 5;
            this.btnRealmSave.Text = "Save Changes";
            this.btnRealmSave.UseVisualStyleBackColor = true;
            this.btnRealmSave.Click += new System.EventHandler(this.btnRealmSave_Click);
            // 
            // txtImportURL
            // 
            this.txtImportURL.Location = new System.Drawing.Point(6, 306);
            this.txtImportURL.Name = "txtImportURL";
            this.txtImportURL.Size = new System.Drawing.Size(404, 20);
            this.txtImportURL.TabIndex = 4;
            // 
            // btnImportRealm
            // 
            this.btnImportRealm.Location = new System.Drawing.Point(411, 305);
            this.btnImportRealm.Name = "btnImportRealm";
            this.btnImportRealm.Size = new System.Drawing.Size(142, 23);
            this.btnImportRealm.TabIndex = 3;
            this.btnImportRealm.Text = "Import Realms";
            this.btnImportRealm.UseVisualStyleBackColor = true;
            this.btnImportRealm.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRemoveRealm
            // 
            this.btnRemoveRealm.Location = new System.Drawing.Point(6, 335);
            this.btnRemoveRealm.Name = "btnRemoveRealm";
            this.btnRemoveRealm.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveRealm.TabIndex = 2;
            this.btnRemoveRealm.Text = "Remove Selected Realm";
            this.btnRemoveRealm.UseVisualStyleBackColor = true;
            this.btnRemoveRealm.Click += new System.EventHandler(this.btnRemoveRealm_Click);
            // 
            // btnLaunchRealm
            // 
            this.btnLaunchRealm.Location = new System.Drawing.Point(411, 335);
            this.btnLaunchRealm.Name = "btnLaunchRealm";
            this.btnLaunchRealm.Size = new System.Drawing.Size(142, 23);
            this.btnLaunchRealm.TabIndex = 1;
            this.btnLaunchRealm.Text = "Launch Selected Realm";
            this.btnLaunchRealm.UseVisualStyleBackColor = true;
            this.btnLaunchRealm.Click += new System.EventHandler(this.btnLaunchRealm_Click);
            // 
            // realmView
            // 
            this.realmView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.realmView.Location = new System.Drawing.Point(0, 0);
            this.realmView.Name = "realmView";
            this.realmView.Size = new System.Drawing.Size(700, 300);
            this.realmView.TabIndex = 0;
            this.realmView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.realmView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSelectedClient);
            this.tabPage2.Controls.Add(this.btnSaveClients);
            this.tabPage2.Controls.Add(this.btnRemoveVersion);
            this.tabPage2.Controls.Add(this.clientView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSelectedClient
            // 
            this.lblSelectedClient.AutoSize = true;
            this.lblSelectedClient.Location = new System.Drawing.Point(154, 340);
            this.lblSelectedClient.Name = "lblSelectedClient";
            this.lblSelectedClient.Size = new System.Drawing.Size(72, 13);
            this.lblSelectedClient.TabIndex = 8;
            this.lblSelectedClient.Text = "(Select Client)";
            // 
            // btnSaveClients
            // 
            this.btnSaveClients.Location = new System.Drawing.Point(559, 335);
            this.btnSaveClients.Name = "btnSaveClients";
            this.btnSaveClients.Size = new System.Drawing.Size(141, 23);
            this.btnSaveClients.TabIndex = 7;
            this.btnSaveClients.Text = "Save Changes";
            this.btnSaveClients.UseVisualStyleBackColor = true;
            this.btnSaveClients.Click += new System.EventHandler(this.btnSaveClients_Click);
            // 
            // btnRemoveVersion
            // 
            this.btnRemoveVersion.Location = new System.Drawing.Point(6, 335);
            this.btnRemoveVersion.Name = "btnRemoveVersion";
            this.btnRemoveVersion.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveVersion.TabIndex = 6;
            this.btnRemoveVersion.Text = "Remove Client Version";
            this.btnRemoveVersion.UseVisualStyleBackColor = true;
            this.btnRemoveVersion.Click += new System.EventHandler(this.btnRemoveVersion_Click);
            // 
            // clientView
            // 
            this.clientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientView.Location = new System.Drawing.Point(0, 0);
            this.clientView.Name = "clientView";
            this.clientView.Size = new System.Drawing.Size(700, 300);
            this.clientView.TabIndex = 0;
            this.clientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientView_CellContentClick);
            // 
            // chkClearWDB
            // 
            this.chkClearWDB.AutoSize = true;
            this.chkClearWDB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearWDB.Location = new System.Drawing.Point(274, 339);
            this.chkClearWDB.Name = "chkClearWDB";
            this.chkClearWDB.Size = new System.Drawing.Size(136, 17);
            this.chkClearWDB.TabIndex = 8;
            this.chkClearWDB.Text = "Clear WDB with launch";
            this.chkClearWDB.UseVisualStyleBackColor = true;
            // 
            // realmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "realmLauncher";
            this.Text = "Realm Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realmView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView realmView;
        private System.Windows.Forms.DataGridView clientView;
        private System.Windows.Forms.TextBox txtImportURL;
        private System.Windows.Forms.Button btnImportRealm;
        private System.Windows.Forms.Button btnRemoveRealm;
        private System.Windows.Forms.Button btnLaunchRealm;
        private System.Windows.Forms.Button btnRemoveVersion;
        private System.Windows.Forms.Button btnRealmSave;
        private System.Windows.Forms.Button btnSaveClients;
        private System.Windows.Forms.Label lblSelectedRealm;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.Windows.Forms.Label lblSelectedClient;
        private System.Windows.Forms.CheckBox chkClearWDB;
    }
}

