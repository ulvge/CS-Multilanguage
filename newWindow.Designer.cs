namespace _23_Multilanguage
{
    partial class NewWindow
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
            this.sex = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button_showMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(103, 144);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(23, 12);
            this.sex.TabIndex = 2;
            this.sex.Text = "sex";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(103, 106);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(35, 12);
            this.state.TabIndex = 3;
            this.state.Text = "state";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(103, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 4;
            this.name.Text = "name";
            // 
            // button_showMsg
            // 
            this.button_showMsg.Location = new System.Drawing.Point(329, 122);
            this.button_showMsg.Name = "button_showMsg";
            this.button_showMsg.Size = new System.Drawing.Size(75, 23);
            this.button_showMsg.TabIndex = 5;
            this.button_showMsg.Text = "showMsg";
            this.button_showMsg.UseVisualStyleBackColor = true;
            this.button_showMsg.Click += new System.EventHandler(this.button_showMsg_Click);
            // 
            // NewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.button_showMsg);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.state);
            this.Controls.Add(this.name);
            this.Name = "NewWindow";
            this.Text = "newWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button button_showMsg;
    }
}