
namespace ConroleAcesso.Forms
{
    partial class frmControleNaves
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
            this.txtNomeNave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePiloto = new System.Windows.Forms.TextBox();
            this.dgvNaves = new System.Windows.Forms.DataGridView();
            this.dgvPilotos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSaindo = new System.Windows.Forms.RadioButton();
            this.rdbChegando = new System.Windows.Forms.RadioButton();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnBuscarNave = new System.Windows.Forms.Button();
            this.btnBuscarPiloto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeNave
            // 
            this.txtNomeNave.Location = new System.Drawing.Point(56, 12);
            this.txtNomeNave.Name = "txtNomeNave";
            this.txtNomeNave.Size = new System.Drawing.Size(620, 23);
            this.txtNomeNave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piloto:";
            // 
            // txtNomePiloto
            // 
            this.txtNomePiloto.Location = new System.Drawing.Point(56, 218);
            this.txtNomePiloto.Name = "txtNomePiloto";
            this.txtNomePiloto.Size = new System.Drawing.Size(620, 23);
            this.txtNomePiloto.TabIndex = 2;
            // 
            // dgvNaves
            // 
            this.dgvNaves.AllowUserToAddRows = false;
            this.dgvNaves.AllowUserToDeleteRows = false;
            this.dgvNaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaves.Location = new System.Drawing.Point(56, 41);
            this.dgvNaves.Name = "dgvNaves";
            this.dgvNaves.RowTemplate.Height = 25;
            this.dgvNaves.Size = new System.Drawing.Size(693, 171);
            this.dgvNaves.TabIndex = 4;
            // 
            // dgvPilotos
            // 
            this.dgvPilotos.AllowUserToAddRows = false;
            this.dgvPilotos.AllowUserToDeleteRows = false;
            this.dgvPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilotos.Location = new System.Drawing.Point(56, 247);
            this.dgvPilotos.Name = "dgvPilotos";
            this.dgvPilotos.RowTemplate.Height = 25;
            this.dgvPilotos.Size = new System.Drawing.Size(693, 171);
            this.dgvPilotos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSaindo);
            this.groupBox1.Controls.Add(this.rdbChegando);
            this.groupBox1.Location = new System.Drawing.Point(56, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 37);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rdbSaindo
            // 
            this.rdbSaindo.AutoSize = true;
            this.rdbSaindo.Location = new System.Drawing.Point(171, 12);
            this.rdbSaindo.Name = "rdbSaindo";
            this.rdbSaindo.Size = new System.Drawing.Size(61, 19);
            this.rdbSaindo.TabIndex = 1;
            this.rdbSaindo.TabStop = true;
            this.rdbSaindo.Text = "Saindo";
            this.rdbSaindo.UseVisualStyleBackColor = true;
            // 
            // rdbChegando
            // 
            this.rdbChegando.AutoSize = true;
            this.rdbChegando.Location = new System.Drawing.Point(21, 12);
            this.rdbChegando.Name = "rdbChegando";
            this.rdbChegando.Size = new System.Drawing.Size(80, 19);
            this.rdbChegando.TabIndex = 0;
            this.rdbChegando.TabStop = true;
            this.rdbChegando.Text = "Chegando";
            this.rdbChegando.UseVisualStyleBackColor = true;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(651, 435);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 7;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnBuscarNave
            // 
            this.btnBuscarNave.Location = new System.Drawing.Point(682, 11);
            this.btnBuscarNave.Name = "btnBuscarNave";
            this.btnBuscarNave.Size = new System.Drawing.Size(67, 23);
            this.btnBuscarNave.TabIndex = 8;
            this.btnBuscarNave.Text = "Buscar";
            this.btnBuscarNave.UseVisualStyleBackColor = true;
            this.btnBuscarNave.Click += new System.EventHandler(this.btnBuscarNave_Click);
            // 
            // btnBuscarPiloto
            // 
            this.btnBuscarPiloto.Location = new System.Drawing.Point(682, 217);
            this.btnBuscarPiloto.Name = "btnBuscarPiloto";
            this.btnBuscarPiloto.Size = new System.Drawing.Size(67, 23);
            this.btnBuscarPiloto.TabIndex = 9;
            this.btnBuscarPiloto.Text = "Buscar";
            this.btnBuscarPiloto.UseVisualStyleBackColor = true;
            this.btnBuscarPiloto.Click += new System.EventHandler(this.btnBuscarPiloto_Click);
            // 
            // frmControleNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 474);
            this.Controls.Add(this.btnBuscarPiloto);
            this.Controls.Add(this.btnBuscarNave);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPilotos);
            this.Controls.Add(this.dgvNaves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePiloto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeNave);
            this.Name = "frmControleNaves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControleNaves_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilotos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeNave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePiloto;
        private System.Windows.Forms.DataGridView dgvNaves;
        private System.Windows.Forms.DataGridView dgvPilotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSaindo;
        private System.Windows.Forms.RadioButton rdbChegando;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnBuscarNave;
        private System.Windows.Forms.Button btnBuscarPiloto;
    }
}