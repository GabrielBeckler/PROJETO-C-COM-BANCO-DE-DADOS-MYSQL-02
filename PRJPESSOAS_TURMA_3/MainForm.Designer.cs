/*
 * Created by SharpDevelop.
 * User: Usuário
 * Date: 21/10/2026
 * Time: 11:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PRJPESSOAS_TURMA_3
{
	partial class frmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnAcessar;
		private System.Windows.Forms.CheckBox chkMostra;
		private System.Windows.Forms.PictureBox picUsuario;
		private System.Windows.Forms.PictureBox picSenha;
		private System.Windows.Forms.Button btnSair;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnAcessar = new System.Windows.Forms.Button();
			this.chkMostra = new System.Windows.Forms.CheckBox();
			this.picUsuario = new System.Windows.Forms.PictureBox();
			this.picSenha = new System.Windows.Forms.PictureBox();
			this.btnSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(216, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(216, 99);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(167, 20);
			this.txtUsuario.TabIndex = 2;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(216, 161);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(167, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// btnAcessar
			// 
			this.btnAcessar.Location = new System.Drawing.Point(76, 329);
			this.btnAcessar.Name = "btnAcessar";
			this.btnAcessar.Size = new System.Drawing.Size(150, 46);
			this.btnAcessar.TabIndex = 4;
			this.btnAcessar.Text = "Acessar";
			this.btnAcessar.UseVisualStyleBackColor = true;
			// 
			// chkMostra
			// 
			this.chkMostra.Location = new System.Drawing.Point(216, 226);
			this.chkMostra.Name = "chkMostra";
			this.chkMostra.Size = new System.Drawing.Size(119, 39);
			this.chkMostra.TabIndex = 6;
			this.chkMostra.Text = "Visualizar senha";
			this.chkMostra.UseVisualStyleBackColor = true;
			// 
			// picUsuario
			// 
			this.picUsuario.Location = new System.Drawing.Point(71, 44);
			this.picUsuario.Name = "picUsuario";
			this.picUsuario.Size = new System.Drawing.Size(80, 91);
			this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picUsuario.TabIndex = 7;
			this.picUsuario.TabStop = false;
			// 
			// picSenha
			// 
			this.picSenha.Location = new System.Drawing.Point(71, 174);
			this.picSenha.Name = "picSenha";
			this.picSenha.Size = new System.Drawing.Size(80, 91);
			this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picSenha.TabIndex = 8;
			this.picSenha.TabStop = false;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(265, 329);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(150, 46);
			this.btnSair.TabIndex = 9;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 471);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.picSenha);
			this.Controls.Add(this.picUsuario);
			this.Controls.Add(this.chkMostra);
			this.Controls.Add(this.btnAcessar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acesso ao sistema";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
