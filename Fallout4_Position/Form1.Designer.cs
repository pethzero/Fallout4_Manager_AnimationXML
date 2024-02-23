namespace Fallout4_Position
{
    partial class Fallout4TreeXML
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
            label1 = new Label();
            tbx_Head = new RichTextBox();
            rtbTagAG = new RichTextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblLogTree = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Headder";
            // 
            // tbx_Head
            // 
            tbx_Head.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_Head.Location = new Point(16, 32);
            tbx_Head.Name = "tbx_Head";
            tbx_Head.Size = new Size(756, 108);
            tbx_Head.TabIndex = 1;
            tbx_Head.Text = "";
            // 
            // rtbTagAG
            // 
            rtbTagAG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbTagAG.Location = new Point(14, 175);
            rtbTagAG.Name = "rtbTagAG";
            rtbTagAG.Size = new Size(760, 136);
            rtbTagAG.TabIndex = 3;
            rtbTagAG.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 143);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Detail";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(681, 331);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 4;
            button1.Text = "PROCESS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_process;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(489, 331);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 5;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 617);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(lblLogTree);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(rtbTagAG);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(tbx_Head);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 589);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Make_Tree";
            // 
            // lblLogTree
            // 
            lblLogTree.AutoSize = true;
            lblLogTree.Location = new Point(14, 340);
            lblLogTree.Name = "lblLogTree";
            lblLogTree.Size = new Size(30, 15);
            lblLogTree.TabIndex = 6;
            lblLogTree.Text = "Log:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 589);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Make_Edge";
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 24);
            panel1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(111, 22);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(111, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 426);
            panel2.TabIndex = 8;
            // 
            // Fallout4TreeXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Fallout4TreeXML";
            Text = "Fallout4 Manager XML ";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RichTextBox tbx_Head;
        private RichTextBox rtbTagAG;
        private Label label2;
        private Button button1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        public Label lblLogTree;
    }
}
