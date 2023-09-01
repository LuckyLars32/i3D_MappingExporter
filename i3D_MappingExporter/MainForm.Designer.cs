namespace i3D_MappingExporter
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms_File = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutI3DMappingExporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.tBx_FilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cBx_shortenIDs = new System.Windows.Forms.CheckBox();
            this.btn_exportMappings = new System.Windows.Forms.Button();
            this.btn_copyToClipboard = new System.Windows.Forms.Button();
            this.tBx_ExportedMappings = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_File,
            this.ms_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms_File
            // 
            this.ms_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.ms_File.Name = "ms_File";
            this.ms_File.Size = new System.Drawing.Size(37, 20);
            this.ms_File.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // ms_Help
            // 
            this.ms_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutI3DMappingExporterToolStripMenuItem});
            this.ms_Help.Name = "ms_Help";
            this.ms_Help.Size = new System.Drawing.Size(44, 20);
            this.ms_Help.Text = "Help";
            // 
            // aboutI3DMappingExporterToolStripMenuItem
            // 
            this.aboutI3DMappingExporterToolStripMenuItem.Name = "aboutI3DMappingExporterToolStripMenuItem";
            this.aboutI3DMappingExporterToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.aboutI3DMappingExporterToolStripMenuItem.Text = "About i3D Mapping Exporter";
            this.aboutI3DMappingExporterToolStripMenuItem.Click += new System.EventHandler(this.aboutI3DMappingExporterToolStripMenuItem_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(497, 36);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(75, 23);
            this.btn_openFile.TabIndex = 2;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // tBx_FilePath
            // 
            this.tBx_FilePath.Location = new System.Drawing.Point(12, 38);
            this.tBx_FilePath.Name = "tBx_FilePath";
            this.tBx_FilePath.Size = new System.Drawing.Size(479, 20);
            this.tBx_FilePath.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cBx_shortenIDs
            // 
            this.cBx_shortenIDs.AutoSize = true;
            this.cBx_shortenIDs.Checked = true;
            this.cBx_shortenIDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBx_shortenIDs.Location = new System.Drawing.Point(373, 71);
            this.cBx_shortenIDs.Name = "cBx_shortenIDs";
            this.cBx_shortenIDs.Size = new System.Drawing.Size(82, 17);
            this.cBx_shortenIDs.TabIndex = 4;
            this.cBx_shortenIDs.Text = "Shorten IDs";
            this.cBx_shortenIDs.UseVisualStyleBackColor = true;
            // 
            // btn_exportMappings
            // 
            this.btn_exportMappings.Location = new System.Drawing.Point(461, 65);
            this.btn_exportMappings.Name = "btn_exportMappings";
            this.btn_exportMappings.Size = new System.Drawing.Size(111, 23);
            this.btn_exportMappings.TabIndex = 5;
            this.btn_exportMappings.Text = "Export Mappings";
            this.btn_exportMappings.UseVisualStyleBackColor = true;
            this.btn_exportMappings.Click += new System.EventHandler(this.btn_exportMappings_Click);
            // 
            // btn_copyToClipboard
            // 
            this.btn_copyToClipboard.Location = new System.Drawing.Point(236, 417);
            this.btn_copyToClipboard.Name = "btn_copyToClipboard";
            this.btn_copyToClipboard.Size = new System.Drawing.Size(111, 23);
            this.btn_copyToClipboard.TabIndex = 6;
            this.btn_copyToClipboard.Text = "Copy to Clipboard";
            this.btn_copyToClipboard.UseVisualStyleBackColor = true;
            this.btn_copyToClipboard.Click += new System.EventHandler(this.btn_copyToClipboard_Click);
            // 
            // tBx_ExportedMappings
            // 
            this.tBx_ExportedMappings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBx_ExportedMappings.Location = new System.Drawing.Point(12, 94);
            this.tBx_ExportedMappings.Multiline = true;
            this.tBx_ExportedMappings.Name = "tBx_ExportedMappings";
            this.tBx_ExportedMappings.ReadOnly = true;
            this.tBx_ExportedMappings.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBx_ExportedMappings.Size = new System.Drawing.Size(560, 317);
            this.tBx_ExportedMappings.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.tBx_ExportedMappings);
            this.Controls.Add(this.btn_copyToClipboard);
            this.Controls.Add(this.btn_exportMappings);
            this.Controls.Add(this.cBx_shortenIDs);
            this.Controls.Add(this.tBx_FilePath);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "MainForm";
            this.Text = "i3D_MappingExporter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms_File;
        private System.Windows.Forms.ToolStripMenuItem ms_Help;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TextBox tBx_FilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cBx_shortenIDs;
        private System.Windows.Forms.Button btn_exportMappings;
        private System.Windows.Forms.Button btn_copyToClipboard;
        private System.Windows.Forms.TextBox tBx_ExportedMappings;
        private System.Windows.Forms.ToolStripMenuItem aboutI3DMappingExporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

