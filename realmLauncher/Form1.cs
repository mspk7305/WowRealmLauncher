using System;
using System.Data;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.Diagnostics;

namespace realmLauncher
{
    public partial class realmLauncher : Form
    {
        DataTable realmTable { get; set; }
        DataTable clientTable { get; set; }
        string importURL = ConfigurationManager.AppSettings["importURL"].ToString();
        string clientConfigFile = ConfigurationManager.AppSettings["clientConfigFile"].ToString();
        string realmConfigFile = ConfigurationManager.AppSettings["realmConfigFile"].ToString();
        string importFile { get; set; }
        int realmRowSelected { get; set; }
        int clientRowSelected { get; set; }

        public realmLauncher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            realmTable = makeRealmTable();
            clientTable = makeClientTable();
            loadRealms(realmConfigFile, true);
            loadClients(clientConfigFile);
            txtImportURL.Text = importURL;
            chkAppend.Checked = true;
            drawGrids();
        }

        private void loadRealms(string xmlFile, bool isInternal)
        {
            try
            {
                XmlSerializer xread = new XmlSerializer(typeof(config));
                using (FileStream fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), xmlFile), FileMode.Open))
                {
                    config cfg = xread.Deserialize(fs) as config;
                    if (!chkAppend.Checked)
                    {
                        realmTable.Clear();
                        realmTable = makeRealmTable();
                    }
                    foreach (var r in cfg.realms)
                    {
                        DataRow realm = realmTable.NewRow();
                        realm["id"] = (realmTable.Rows.Count + 1).ToString();
                        realm["name"] = r.name;
                        realm["realmlist"] = r.realmlist;
                        realm["patchlist"] = r.patchlist;
                        realm["clientversion"] = r.clientversion;
                        realm["website"] = r.website;
                        realmTable.Rows.Add(realm);
                    }
                }
            }
            catch (Exception e)
            {
                //i should not leave this blank
                MessageBox.Show(e.ToString());
            }
        }

        private void loadClients(string xmlFile)
        {
            try
            {
                XmlSerializer xread = new XmlSerializer(typeof(config));
                using (FileStream fs = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), xmlFile), FileMode.Open))
                {
                    config cfg = xread.Deserialize(fs) as config;
                    clientTable = makeClientTable();
                    foreach (var c in cfg.clients)
                    {
                        DataRow client = clientTable.NewRow();
                        client["id"] = c.id;
                        client["clientversion"] = c.clientversion;
                        client["clientpath"] = c.clientpath;
                        clientTable.Rows.Add(client);
                    }
                }
            }
            catch (Exception e)
            {
                //i should not leave this blank
                MessageBox.Show(e.ToString());
            }
        }

        private void drawGrids()
        {
            reNumber(realmTable);
            reNumber(clientTable);
            lblSelectedRealm.Text = "(Select Realm)";
            chkAppend.Enabled = true;
            btnLaunchRealm.Enabled = false;
            btnRemoveRealm.Enabled = false;
            btnRemoveVersion.Enabled = false;
            Padding p = new Padding(0, 0, 0, 0);
            realmView.DataSource = realmTable;
            clientView.DataSource = clientTable;
            realmView.RowHeadersVisible = false;
            realmView.RowTemplate.DefaultCellStyle.Padding = p;
            clientView.RowHeadersVisible = false;
            clientView.RowTemplate.DefaultCellStyle.Padding = p;
            realmView.Columns[0].Width = 25;
            realmView.Columns[1].Width = 90;
            realmView.Columns[2].Width = 40;
            realmView.Columns[3].Width = 180;
            realmView.Columns[4].Width = 180;
            realmView.Columns[5].Width = 180;
            realmView.Columns[0].HeaderText = "Id";
            realmView.Columns[1].HeaderText = "Name";
            realmView.Columns[2].HeaderText = "Patch";
            realmView.Columns[3].HeaderText = "WWW";
            realmView.Columns[4].HeaderText = "Realmlist";
            realmView.Columns[5].HeaderText = "Patchlist (optional)";
            clientView.Columns[0].Width = 25;
            clientView.Columns[1].Width = 40;
            clientView.Columns[2].Width = 630;
            clientView.Columns[0].HeaderText = "Id";
            clientView.Columns[1].HeaderText = "Patch";
            clientView.Columns[2].HeaderText = "Path";
        }

        private void reNumber(DataTable dt)
        {
            int i=1;
            foreach(DataRow r in dt.Rows)
            {
                r[0] = i++;
            }
        }

        private DataTable makeClientTable()
        {
            DataTable client = new DataTable();
            client.TableName = "client";
            client.Columns.Add("id");
            client.Columns.Add("clientversion");
            client.Columns.Add("clientpath");
            return client;
        }

        private DataTable makeRealmTable()
        {
            DataTable realm = new DataTable();
            realm.TableName = "realm";
            realm.Columns.Add("id");
            realm.Columns.Add("name");
            realm.Columns.Add("clientversion");
            realm.Columns.Add("website");
            realm.Columns.Add("realmlist");
            realm.Columns.Add("patchlist");
            return realm;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                importURL = txtImportURL.Text.ToString();
                getFileFromGoogle();
                loadRealms(importFile,false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            drawGrids();
        }

        private void getFileFromGoogle()
        {
            try {
                importFile = DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xml";
                using (var client = new WebClient())
                {
                    client.DownloadFile(importURL, importFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void writeXML(string configFile, DataTable ds, string which)
        {
            try
            {
                //because changing the parent node is impossible without using a dataset
                DataSet pn = new DataSet();
                pn.DataSetName = which;
                pn.Tables.Add(ds);
                File.Move(configFile, "backup_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xml");
                using (FileStream fs = File.Open(configFile, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("<config>");//and this is ugly too
                        ds.WriteXml(sw);
                        sw.WriteLine("</config>");//and this is ugly too
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRemoveRealm_Click(object sender, EventArgs e)
        {
            DataRow selected = realmTable.Rows[realmRowSelected];
            DialogResult doIt = MessageBox.Show("Really remove realm " + selected[1].ToString(),"Really?",MessageBoxButtons.YesNo);
            if (doIt==DialogResult.Yes)
            {
                realmTable.Rows.RemoveAt(realmRowSelected);
            }
            drawGrids();
        }

        private void btnRemoveVersion_Click(object sender, EventArgs e)
        {
            DataRow selected = clientTable.Rows[clientRowSelected];
            DialogResult doIt = MessageBox.Show("Really remove client " + selected[1].ToString(), "Really?", MessageBoxButtons.YesNo);
            if (doIt == DialogResult.Yes)
            {
                clientTable.Rows.RemoveAt(clientRowSelected);
            }
            drawGrids();
        }

        private void realmView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            realmRowSelected = e.RowIndex;
            lblSelectedRealm.Text = "Selected ID: " + realmView.Rows[e.RowIndex].Cells[0].Value.ToString();
            btnRemoveRealm.Enabled = true;
            btnLaunchRealm.Enabled = true;
        }

        private void clientView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientRowSelected = e.RowIndex;
            lblSelectedClient.Text = "Selected ID: " + clientView.Rows[e.RowIndex].Cells[0].Value.ToString();
            btnRemoveVersion.Enabled = true;
        }

        private void btnSaveClients_Click(object sender, EventArgs e)
        {
            writeXML(clientConfigFile,clientTable,"clients");
        }

        private void btnRealmSave_Click(object sender, EventArgs e)
        {
            writeXML(realmConfigFile,realmTable,"realms");
        }

        private void btnLaunchRealm_Click(object sender, EventArgs e)
        {
            int properRealm = checkForRealms();
            if (properRealm != -1)
            {
                if (writeRealmFile(properRealm))
                {
                    try
                    {
                        Process.Start(clientTable.Rows[properRealm][2].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Could not launch client. Check configuration for clients matching path:" + Environment.NewLine + clientTable.Rows[realmRowSelected][2].ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Could not launch client. Check configuration for clients matching version " + realmTable.Rows[realmRowSelected][2].ToString());
            }
        }

        private bool writeRealmFile(int properRealm)
        {
            bool isDone = false;
            string wtfPath = Path.GetDirectoryName(clientTable.Rows[properRealm][2].ToString());
            string realmFile = wtfPath + "\\realmlist.wtf";
            try
            {
                File.WriteAllText(realmFile, string.Empty);
                using (FileStream fs = new FileStream(realmFile, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("set realmlist " + realmTable.Rows[realmRowSelected][4].ToString());
                        sw.WriteLine("set pathchlist " + realmTable.Rows[realmRowSelected][5].ToString());
                        isDone = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update realm list in " + Environment.NewLine + wtfPath + Environment.NewLine + "Check to make sure directory exists & repair realm file if needed");
            }
            return isDone;
        }

        private int checkForRealms()
        {
            int i = -1;
            string clientNeeded = realmTable.Rows[realmRowSelected][2].ToString();
            foreach (DataRow r in clientTable.Rows)
            {
                if (r[1].ToString() == clientNeeded)
                {
                    i = clientTable.Rows.IndexOf(r);
                }
            }
            return i;
        }
    }
}
