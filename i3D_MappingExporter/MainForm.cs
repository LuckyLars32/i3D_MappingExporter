using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace i3D_MappingExporter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            DialogResult dlg_result = openFileDialog1.ShowDialog();
            if (dlg_result == DialogResult.OK)
            {
                tBx_FilePath.Text = openFileDialog1.FileName;
            }
        }

        private async void btn_exportMappings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBx_FilePath.Text))
            {
                MessageBox.Show("Please select a i3D file before exporting", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                XDocument doc = XDocument.Load(tBx_FilePath.Text);
                Task<XDocument> task = ExportMappings(doc);
                btn_exportMappings.Enabled = false;
                tBx_ExportedMappings.Text = "Please wait, exporting mappings.";
                var mappings = await task;
                btn_exportMappings.Enabled = true;
                tBx_ExportedMappings.Text = mappings.ToString().Replace("&gt;", ">");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<XDocument> ExportMappings(XDocument doc)
        {
            return await Task.Factory.StartNew(() =>
            {
                var mapper = new i3D_MappingExporter.Mapper(doc);
                mapper.Map(cBx_shortenIDs.Checked);
                return mapper.Mappings;
            }).ConfigureAwait(continueOnCapturedContext: false);
        }

        private void btn_copyToClipboard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBx_ExportedMappings.Text) || tBx_ExportedMappings.Text == "Please wait, exporting mappings.")
            {
                MessageBox.Show("Please export mappings first", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Clipboard.SetText(tBx_ExportedMappings.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutI3DMappingExporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var var_AboutBox1 = new AboutBox1();
            var_AboutBox1.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg_result = openFileDialog1.ShowDialog();
            if (dlg_result == DialogResult.OK)
            {
                tBx_FilePath.Text = openFileDialog1.FileName;
            }
        }
    }
}
