namespace Apresentacao
{
    partial class DisciplinaForm
    {
        private System.ComponentModel.IContainer components = null;

        // Declaração dos componentes que estavam faltando
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCarga;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.SuspendLayout();

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 15);
            this.lblNome.Text = "Nome da Disciplina:";

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(20, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 23);

            // lblCarga
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(240, 20);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(83, 15);
            this.lblCarga.Text = "Carga Horária:";

            // txtCargaHoraria
            this.txtCargaHoraria.Location = new System.Drawing.Point(240, 40);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(100, 23);

            // buttonGravar
            this.buttonGravar.Location = new System.Drawing.Point(360, 39);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 25);
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);

            // dgvDisciplinas
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Location = new System.Drawing.Point(20, 80);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.Size = new System.Drawing.Size(415, 250);

            // DisciplinaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 350);
            this.Controls.Add(this.dgvDisciplinas);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "DisciplinaForm";
            this.Text = "Cadastro de Disciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}