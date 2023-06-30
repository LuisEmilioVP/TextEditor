namespace Editor_Texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RineTxtxContext = new RichTextBox();
            menuStrip1 = new MenuStrip();
            archivosToolStripMenuItem = new ToolStripMenuItem();
            NewFile = new ToolStripMenuItem();
            OpenFile = new ToolStripMenuItem();
            SaveFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            CloseEditor = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // RineTxtxContext
            // 
            RineTxtxContext.Dock = DockStyle.Fill;
            RineTxtxContext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RineTxtxContext.Location = new Point(0, 28);
            RineTxtxContext.Name = "RineTxtxContext";
            RineTxtxContext.Size = new Size(800, 491);
            RineTxtxContext.TabIndex = 0;
            RineTxtxContext.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            archivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewFile, OpenFile, SaveFile, toolStripSeparator1, CloseEditor });
            archivosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            archivosToolStripMenuItem.Image = (Image)resources.GetObject("archivosToolStripMenuItem.Image");
            archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            archivosToolStripMenuItem.Size = new Size(93, 24);
            archivosToolStripMenuItem.Text = "Archivos";
            // 
            // NewFile
            // 
            NewFile.Image = (Image)resources.GetObject("NewFile.Image");
            NewFile.Name = "NewFile";
            NewFile.Size = new Size(180, 24);
            NewFile.Text = "Nuevo";
            NewFile.Click += NewFile_Click;
            // 
            // OpenFile
            // 
            OpenFile.Image = (Image)resources.GetObject("OpenFile.Image");
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(180, 24);
            OpenFile.Text = "Abrir";
            OpenFile.Click += OpenFile_Click;
            // 
            // SaveFile
            // 
            SaveFile.Image = (Image)resources.GetObject("SaveFile.Image");
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(180, 24);
            SaveFile.Text = "Guardar";
            SaveFile.Click += SaveFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // CloseEditor
            // 
            CloseEditor.Image = (Image)resources.GetObject("CloseEditor.Image");
            CloseEditor.Name = "CloseEditor";
            CloseEditor.Size = new Size(180, 24);
            CloseEditor.Text = "Salir";
            CloseEditor.Click += CloseEditor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(RineTxtxContext);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Editor de Texto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RineTxtxContext;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivosToolStripMenuItem;
        private ToolStripMenuItem NewFile;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem SaveFile;
        private ToolStripMenuItem CloseEditor;
        private ToolStripSeparator toolStripSeparator1;
    }
}