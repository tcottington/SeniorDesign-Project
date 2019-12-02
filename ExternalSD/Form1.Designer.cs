namespace ExternalSD
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
            this.components = new System.ComponentModel.Container();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.SelectFolder_btn = new System.Windows.Forms.Button();
            this.tmrRecord = new System.Windows.Forms.Timer(this.components);
            this.UnityStart_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(520, 205);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(138, 56);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.Location = new System.Drawing.Point(520, 291);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(138, 56);
            this.Stop_btn.TabIndex = 1;
            this.Stop_btn.Text = "Stop";
            this.Stop_btn.UseVisualStyleBackColor = true;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // SelectFolder_btn
            // 
            this.SelectFolder_btn.Location = new System.Drawing.Point(520, 143);
            this.SelectFolder_btn.Name = "SelectFolder_btn";
            this.SelectFolder_btn.Size = new System.Drawing.Size(138, 56);
            this.SelectFolder_btn.TabIndex = 2;
            this.SelectFolder_btn.Text = "Select Folder";
            this.SelectFolder_btn.UseVisualStyleBackColor = true;
            this.SelectFolder_btn.Click += new System.EventHandler(this.SelectFolder_btn_Click);
            // 
            // tmrRecord
            // 
            this.tmrRecord.Interval = 15;
            this.tmrRecord.Tick += new System.EventHandler(this.tmrRecord_Tick);
            // 
            // UnityStart_btn
            // 
            this.UnityStart_btn.Location = new System.Drawing.Point(520, 81);
            this.UnityStart_btn.Name = "UnityStart_btn";
            this.UnityStart_btn.Size = new System.Drawing.Size(138, 56);
            this.UnityStart_btn.TabIndex = 3;
            this.UnityStart_btn.Text = "Start Unity";
            this.UnityStart_btn.UseVisualStyleBackColor = true;
            this.UnityStart_btn.Click += new System.EventHandler(this.UnityStart_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 359);
            this.Controls.Add(this.UnityStart_btn);
            this.Controls.Add(this.SelectFolder_btn);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "Form1";
            this.Text = "External";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Button SelectFolder_btn;
        private System.Windows.Forms.Timer tmrRecord;
        private System.Windows.Forms.Button UnityStart_btn;
    }
}

