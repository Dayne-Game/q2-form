namespace Question02_form
{
    partial class Form1
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
            this.PersonBtn = new System.Windows.Forms.Button();
            this.SupervisorBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // PersonBtn
            // 
            this.PersonBtn.Location = new System.Drawing.Point(175, 261);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(161, 99);
            this.PersonBtn.TabIndex = 0;
            this.PersonBtn.Text = "Person";
            this.PersonBtn.UseVisualStyleBackColor = true;
            this.PersonBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupervisorBtn
            // 
            this.SupervisorBtn.Location = new System.Drawing.Point(457, 261);
            this.SupervisorBtn.Name = "SupervisorBtn";
            this.SupervisorBtn.Size = new System.Drawing.Size(161, 99);
            this.SupervisorBtn.TabIndex = 1;
            this.SupervisorBtn.Text = "Supervisor";
            this.SupervisorBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupervisorBtn);
            this.Controls.Add(this.PersonBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PersonBtn;
        private System.Windows.Forms.Button SupervisorBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

