namespace StudentManagement.Forms
{
    partial class Frm_Registration
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
            this.Txt_Save = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Save
            // 
            this.Txt_Save.Location = new System.Drawing.Point(143, 81);
            this.Txt_Save.Name = "Txt_Save";
            this.Txt_Save.Size = new System.Drawing.Size(356, 44);
            this.Txt_Save.TabIndex = 0;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(213, 187);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(186, 62);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Frm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 323);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Save);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.8F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Frm_Registration";
            this.Text = "Frm_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Save;
        private System.Windows.Forms.Button Btn_Save;
    }
}