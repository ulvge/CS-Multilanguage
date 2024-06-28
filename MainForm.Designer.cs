namespace _23_Multilanguage
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_zh = new System.Windows.Forms.Button();
            this.button_en = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ContentPanel_label1 = new System.Windows.Forms.Label();
            this.newForm = new System.Windows.Forms.Button();
            this.button_showMsg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_zh
            // 
            this.button_zh.Location = new System.Drawing.Point(327, 75);
            this.button_zh.Name = "button_zh";
            this.button_zh.Size = new System.Drawing.Size(75, 23);
            this.button_zh.TabIndex = 0;
            this.button_zh.Text = "中文";
            this.button_zh.UseVisualStyleBackColor = true;
            this.button_zh.Click += new System.EventHandler(this.button_zh_Click);
            // 
            // button_en
            // 
            this.button_en.Location = new System.Drawing.Point(327, 129);
            this.button_en.Name = "button_en";
            this.button_en.Size = new System.Drawing.Size(75, 23);
            this.button_en.TabIndex = 0;
            this.button_en.Text = "English";
            this.button_en.UseVisualStyleBackColor = true;
            this.button_en.Click += new System.EventHandler(this.button_en_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(187, 95);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(187, 129);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(35, 12);
            this.state.TabIndex = 1;
            this.state.Text = "state";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(187, 167);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(23, 12);
            this.sex.TabIndex = 1;
            this.sex.Text = "sex";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_help
            // 
            this.ToolStripMenuItem_help.Name = "ToolStripMenuItem_help";
            this.ToolStripMenuItem_help.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_help.Text = "帮助";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ContentPanel_label1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(77, 312);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 48);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(77, 337);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ContentPanel_label1
            // 
            this.ContentPanel_label1.AutoSize = true;
            this.ContentPanel_label1.Location = new System.Drawing.Point(13, 35);
            this.ContentPanel_label1.Name = "ContentPanel_label1";
            this.ContentPanel_label1.Size = new System.Drawing.Size(41, 12);
            this.ContentPanel_label1.TabIndex = 0;
            this.ContentPanel_label1.Text = "label1";
            // 
            // newForm
            // 
            this.newForm.Location = new System.Drawing.Point(327, 188);
            this.newForm.Name = "newForm";
            this.newForm.Size = new System.Drawing.Size(75, 23);
            this.newForm.TabIndex = 4;
            this.newForm.Text = "newForm";
            this.newForm.UseVisualStyleBackColor = true;
            this.newForm.Click += new System.EventHandler(this.newForm_Click);
            // 
            // button_showMsg
            // 
            this.button_showMsg.Location = new System.Drawing.Point(327, 239);
            this.button_showMsg.Name = "button_showMsg";
            this.button_showMsg.Size = new System.Drawing.Size(75, 23);
            this.button_showMsg.TabIndex = 4;
            this.button_showMsg.Text = "showMsg";
            this.button_showMsg.UseVisualStyleBackColor = true;
            this.button_showMsg.Click += new System.EventHandler(this.button_showMsg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.button_showMsg);
            this.Controls.Add(this.newForm);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.state);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button_en);
            this.Controls.Add(this.button_zh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_zh;
        private System.Windows.Forms.Button button_en;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label ContentPanel_label1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help;
        private System.Windows.Forms.Button newForm;
        private System.Windows.Forms.Button button_showMsg;
    }
}

