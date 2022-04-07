
namespace TAPU1_ACT_FINAL_EXAMEN_YOHELCENICEROSCABRERA
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAcceso = new System.Windows.Forms.GroupBox();
            this.chInvitado = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcceso = new System.Windows.Forms.TextBox();
            this.gbAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAcceso
            // 
            this.gbAcceso.Controls.Add(this.chInvitado);
            this.gbAcceso.Controls.Add(this.btnSalir);
            this.gbAcceso.Controls.Add(this.btnIniciar);
            this.gbAcceso.Controls.Add(this.label1);
            this.gbAcceso.Controls.Add(this.txtAcceso);
            this.gbAcceso.Location = new System.Drawing.Point(12, 12);
            this.gbAcceso.Name = "gbAcceso";
            this.gbAcceso.Size = new System.Drawing.Size(491, 141);
            this.gbAcceso.TabIndex = 0;
            this.gbAcceso.TabStop = false;
            this.gbAcceso.Text = "Acceso";
            // 
            // chInvitado
            // 
            this.chInvitado.AutoSize = true;
            this.chInvitado.Location = new System.Drawing.Point(45, 112);
            this.chInvitado.Name = "chInvitado";
            this.chInvitado.Size = new System.Drawing.Size(64, 17);
            this.chInvitado.TabIndex = 4;
            this.chInvitado.Text = "Invitado";
            this.chInvitado.UseVisualStyleBackColor = true;
            this.chInvitado.CheckedChanged += new System.EventHandler(this.chInvitado_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(416, 112);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(317, 112);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Entrar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtAcceso
            // 
            this.txtAcceso.Location = new System.Drawing.Point(226, 59);
            this.txtAcceso.Name = "txtAcceso";
            this.txtAcceso.Size = new System.Drawing.Size(259, 20);
            this.txtAcceso.TabIndex = 0;
            this.txtAcceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcceso_KeyPress);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 165);
            this.ControlBox = false;
            this.Controls.Add(this.gbAcceso);
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.gbAcceso.ResumeLayout(false);
            this.gbAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcceso;
        private System.Windows.Forms.CheckBox chInvitado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcceso;
    }
}

