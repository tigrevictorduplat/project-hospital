
namespace project_hospital
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnAppointment);
            this.panel.Controls.Add(this.btnRegisterClient);
            this.panel.Controls.Add(this.btnRegisterUser);
            this.panel.Controls.Add(this.lblTitle);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(398, 242);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(127, 194);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(144, 23);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "Agendar Serviço";
            this.btnAppointment.UseVisualStyleBackColor = true;
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterClient.Location = new System.Drawing.Point(32, 141);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(144, 23);
            this.btnRegisterClient.TabIndex = 2;
            this.btnRegisterClient.Text = "Cadastrar Cliente";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(226, 141);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(144, 23);
            this.btnRegisterUser.TabIndex = 1;
            this.btnRegisterUser.Text = "Cadastrar Usuário";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14.2F);
            this.lblTitle.Location = new System.Drawing.Point(16, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bem vindo ao Hospital Santo Arnaldo";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 242);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Início";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnRegisterClient;
        private System.Windows.Forms.Button btnAppointment;
    }
}

