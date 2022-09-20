namespace cousrse_design
{
    partial class PQF
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
            this.ENTER = new System.Windows.Forms.Button();
            this.SRK = new System.Windows.Forms.TextBox();
            this.CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ENTER
            // 
            this.ENTER.BackColor = System.Drawing.Color.White;
            this.ENTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENTER.ForeColor = System.Drawing.Color.Black;
            this.ENTER.Location = new System.Drawing.Point(363, 87);
            this.ENTER.Name = "ENTER";
            this.ENTER.Size = new System.Drawing.Size(75, 23);
            this.ENTER.TabIndex = 0;
            this.ENTER.Text = "确认";
            this.ENTER.UseVisualStyleBackColor = false;
            this.ENTER.Click += new System.EventHandler(this.ENTER_Click);
            // 
            // SRK
            // 
            this.SRK.Location = new System.Drawing.Point(65, 22);
            this.SRK.Multiline = true;
            this.SRK.Name = "SRK";
            this.SRK.Size = new System.Drawing.Size(318, 43);
            this.SRK.TabIndex = 1;
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.Color.White;
            this.CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CANCEL.ForeColor = System.Drawing.Color.Black;
            this.CANCEL.Location = new System.Drawing.Point(466, 87);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(75, 23);
            this.CANCEL.TabIndex = 2;
            this.CANCEL.Text = "取消";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // PQF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 122);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SRK);
            this.Controls.Add(this.ENTER);
            this.Name = "PQF";
            this.Text = "PQF";
            this.Load += new System.EventHandler(this.PQF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ENTER;
        private System.Windows.Forms.TextBox SRK;
        private System.Windows.Forms.Button CANCEL;
    }
}