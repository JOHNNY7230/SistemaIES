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
            txtNome = new TextBox();
            txtCargaHoraria = new TextBox();
            buttonGravar = new Button();
            dgvDisciplinas = new DataGridView();
            lblNome = new Label();
            lblCarga = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(20, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(240, 40);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(100, 23);
            txtCargaHoraria.TabIndex = 2;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(360, 39);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 25);
            buttonGravar.TabIndex = 1;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // dgvDisciplinas
            // 
            dgvDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisciplinas.Location = new Point(20, 80);
            dgvDisciplinas.Name = "dgvDisciplinas";
            dgvDisciplinas.Size = new Size(415, 250);
            dgvDisciplinas.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(113, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome da Disciplina:";
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Location = new Point(240, 20);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(83, 15);
            lblCarga.TabIndex = 3;
            lblCarga.Text = "Carga Horária:";
            // 
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 350);
            Controls.Add(dgvDisciplinas);
            Controls.Add(buttonGravar);
            Controls.Add(txtCargaHoraria);
            Controls.Add(lblCarga);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "DisciplinaForm";
            Text = "Cadastro de Disciplinas";
            ((System.ComponentModel.ISupportInitialize)dgvDisciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}