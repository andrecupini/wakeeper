namespace wakeeper
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.lblIdelTimeout = new System.Windows.Forms.Label();
            this.textBoxIdleTimeout = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdelTimeout
            // 
            this.lblIdelTimeout.AutoSize = true;
            this.lblIdelTimeout.Location = new System.Drawing.Point(12, 27);
            this.lblIdelTimeout.Name = "lblIdelTimeout";
            this.lblIdelTimeout.Size = new System.Drawing.Size(74, 15);
            this.lblIdelTimeout.TabIndex = 0;
            this.lblIdelTimeout.Text = "Idle timeout:";
            // 
            // textBoxIdleTimeout
            // 
            this.textBoxIdleTimeout.Location = new System.Drawing.Point(92, 24);
            this.textBoxIdleTimeout.Name = "textBoxIdleTimeout";
            this.textBoxIdleTimeout.Size = new System.Drawing.Size(48, 23);
            this.textBoxIdleTimeout.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(146, 24);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 77);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBoxIdleTimeout);
            this.Controls.Add(this.lblIdelTimeout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wakeeper";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Shown += new System.EventHandler(this.Frm_Main_Shown);
            this.Resize += new System.EventHandler(this.Frm_Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdelTimeout;
        private TextBox textBoxIdleTimeout;
        private Button btnSalvar;
    }
}