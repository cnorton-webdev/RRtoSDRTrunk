using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RRtoSDRTrunk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            importBtn.Enabled = false;
            processImport(rrDataTxt.Text, playListPathTxt.Text);
            importBtn.Enabled = true;
        }

        private void processImport(string importText, string playlistFile)
        {
            // Make sure we have the playlist file and the input is not empty
            if (importText.Trim() != "" && System.IO.File.Exists(playlistFile + "\\default.xml"))
            {
                int addCount = 0;
                int dupCount = 0;
                XmlDocument doc = new XmlDocument();
                // Load the SDRTrunk XML playlist file
                doc.Load(playlistFile + "\\default.xml");
                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                // Get any current nodes for this list and group number
                string xPathString = "//alias[@list=" + listNum.Value + "][@group=" + groupNum.Value + "]";
                XmlNodeList xmlNodes = doc.DocumentElement.SelectNodes(xPathString, nsmgr);
                // Split the pasted data from RadioReference table by new lines
                string[] master = importText.Split('\n');
                foreach (string line in master)
                {
                    bool isDuplicate = false;
                    // Split the line by tabs from the copied RadioReference data
                    string[] parts = line.Split('\t');
                    // Check to see if we have a duplicate entry, if so don't process that entry
                    foreach (XmlNode node in xmlNodes)
                    {

                        string tgId = node.LastChild.Attributes.Item(1).Value;
                        string protocol = node.LastChild.Attributes.Item(2).Value;
                        if (tgId == parts.GetValue(0).ToString() && protocol == systemTypeCmb.SelectedItem.ToString())
                        {
                            isDuplicate = true;
                            dupCount++;
                            break;
                        }
                    }
                    if (isDuplicate == false)
                    {
                        // This is our new node to add to the XML
                        XmlElement newAliasNode = doc.CreateElement("alias", nsmgr.DefaultNamespace);
                        // Get the main playlist node and the first channel node
                        XmlNode playlistNode = doc.DocumentElement.SelectSingleNode("//playlist", nsmgr);
                        XmlNode channelNode = doc.DocumentElement.SelectSingleNode("//channel", nsmgr);
                        // Create our new node using the input data
                        newAliasNode.SetAttribute("name", parts[3].ToString());
                        newAliasNode.SetAttribute("color", "-1");
                        newAliasNode.SetAttribute("group", groupNum.Value.ToString());
                        newAliasNode.SetAttribute("iconName", "No Icon");
                        newAliasNode.SetAttribute("list", listNum.Value.ToString());
                        // This is a child node that holds the protocol and TG ID
                        XmlElement aliasIdNode = doc.CreateElement("id", nsmgr.DefaultNamespace);
                        aliasIdNode.SetAttribute("type", "talkgroup");
                        aliasIdNode.SetAttribute("value", parts[0].ToString());
                        aliasIdNode.SetAttribute("protocol", systemTypeCmb.SelectedItem.ToString());
                        newAliasNode.AppendChild(aliasIdNode);
                        // SDRTrunk reads the XML file in a very specific manner, any <alias> after the channel node will result in only those <alias> entries showing up
                        // So we have to insert it before the first <channel> tag
                        playlistNode.InsertBefore(newAliasNode, channelNode);
                        addCount++;
                    }
                }
                // If our backup folder does not exist create it
                if (System.IO.Directory.Exists(playListPathTxt + "\\RRtoSDRTrunk_Backups") == false)
                {
                    System.IO.Directory.CreateDirectory(playListPathTxt.Text + "\\RRtoSDRTrunk_Backups");
                }
                // See if we actually imported any new data before making backup and saving
                if (addCount > 0)
                {
                    // Save a backup of the default.xml every time we touch the file, just in case!
                    System.IO.File.Copy(playListPathTxt.Text + "\\default.xml", playListPathTxt.Text + "\\RRtoSDRTrunk_Backups\\default_backup_" + DateTime.Now.Ticks + ".xml");
                    // Write out the new XML document
                    doc.Save(playListPathTxt.Text + "\\default.xml");
                }
                MessageBox.Show("Finished adding " + addCount.ToString() + " record(s) out of " + master.Count().ToString() + " record(s) to SDRTrunk." + '\n' + "Duplicate entries: " + dupCount.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please verify default.xml exists in the folder selected and that the input to add to the file is not empty.", "Processing Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = playlistFolder.ShowDialog();
            if (dr == DialogResult.OK)
            {
                playListPathTxt.Text = playlistFolder.SelectedPath;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            systemTypeCmb.SelectedIndex = 0;
            if (Properties.Settings.Default.playListPath != "")
            {
                playListPathTxt.Text = Properties.Settings.Default.playListPath;
            }
            // Display Information regarding RR Premium and that tool is to be used at own risk
            MessageBox.Show("This tool is not a replacement for RadioReference Premium." + '\n' + "I still HIGHLY recommend it, but it is rather a tool to make importing into SDRTrunk easier if you do not have premium." + '\n' + '\n' + "I AM NOT RESPONSIBLE FOR ANY DAMAGE TO YOUR FILES OR TO SDRTRUNK PROGRAM THIS PROGRAM MAY CAUSE!" + '\n' + '\n' + "YOU AGREE TO USE THIS TOOL AT YOUR OWN RISK!", "Important Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void playListPathTxt_TextChanged(object sender, EventArgs e)
        {
            if (playListPathTxt.Text != Properties.Settings.Default.playListPath)
            {
                Properties.Settings.Default.playListPath = playListPathTxt.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rrDataTxt.SelectedText = Clipboard.GetText();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rrDataTxt.SelectedText);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rrDataTxt.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rrDataTxt.Clear();
        }
    }
}
