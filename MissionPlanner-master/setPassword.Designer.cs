namespace MissionPlanner
{
    partial class setPassword
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.mylblSenha = new MissionPlanner.Controls.MyLabel();
            this.btnOK = new MissionPlanner.Controls.MyButton();
            this.mylblErroSenha = new MissionPlanner.Controls.MyLabel();
            this.btnCancelar = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(122, 12);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(221, 31);
            this.txtSenha.TabIndex = 0;
            // 
            // mylblSenha
            // 
            this.mylblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylblSenha.ForeColor = System.Drawing.Color.Black;
            this.mylblSenha.Location = new System.Drawing.Point(12, 15);
            this.mylblSenha.Name = "mylblSenha";
            this.mylblSenha.resize = false;
            this.mylblSenha.Size = new System.Drawing.Size(104, 23);
            this.mylblSenha.TabIndex = 1;
            this.mylblSenha.Text = "Password:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(191, 69);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mylblErroSenha
            // 
            this.mylblErroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylblErroSenha.ForeColor = System.Drawing.Color.Black;
            this.mylblErroSenha.Location = new System.Drawing.Point(5, 78);
            this.mylblErroSenha.Name = "mylblErroSenha";
            this.mylblErroSenha.resize = false;
            this.mylblErroSenha.Size = new System.Drawing.Size(130, 23);
            this.mylblErroSenha.TabIndex = 5;
            this.mylblErroSenha.Text = "Wrong Password!";
            this.mylblErroSenha.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCEL";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // setPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 129);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mylblErroSenha);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.mylblSenha);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "setPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private Controls.MyLabel mylblSenha;
        private Controls.MyButton btnOK;
        private Controls.MyLabel mylblErroSenha;
        private Controls.MyButton btnCancelar;
    }
}