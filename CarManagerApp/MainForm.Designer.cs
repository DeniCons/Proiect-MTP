namespace CarManagerApp
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnDetaliiDinamice = new System.Windows.Forms.Button();
            this.panelDetalii = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCauta
            // 
            this.txtCauta.Location = new System.Drawing.Point(137, 189);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(128, 22);
            this.txtCauta.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(40, 46);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(91, 29);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(40, 93);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(91, 26);
            this.btnModifica.TabIndex = 3;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(40, 137);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(91, 28);
            this.btnSterge.TabIndex = 4;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(40, 188);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(91, 25);
            this.btnCauta.TabIndex = 5;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnDetaliiDinamice
            // 
            this.btnDetaliiDinamice.Location = new System.Drawing.Point(57, 275);
            this.btnDetaliiDinamice.Name = "btnDetaliiDinamice";
            this.btnDetaliiDinamice.Size = new System.Drawing.Size(137, 23);
            this.btnDetaliiDinamice.TabIndex = 6;
            this.btnDetaliiDinamice.Text = "Afișează Detalii Dinamice";
            this.btnDetaliiDinamice.UseVisualStyleBackColor = true;
            this.btnDetaliiDinamice.Click += new System.EventHandler(this.btnDetaliiDinamice_Click);
            // 
            // panelDetalii
            // 
            this.panelDetalii.AutoScroll = true;
            this.panelDetalii.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalii.Location = new System.Drawing.Point(22, 304);
            this.panelDetalii.Name = "panelDetalii";
            this.panelDetalii.Size = new System.Drawing.Size(217, 117);
            this.panelDetalii.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.panelDetalii);
            this.Controls.Add(this.btnDetaliiDinamice);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnDetaliiDinamice;
        private System.Windows.Forms.Panel panelDetalii;
    }
}