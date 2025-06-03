partial class MasinaForm
{
    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.TextBox txtAn;
    private System.Windows.Forms.TextBox txtPret;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private void InitializeComponent()
    {
        this.txtMarca = new System.Windows.Forms.TextBox();
        this.txtModel = new System.Windows.Forms.TextBox();
        this.txtAn = new System.Windows.Forms.TextBox();
        this.txtPret = new System.Windows.Forms.TextBox();
        this.btnOK = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtMarca
        // 
        this.txtMarca.Location = new System.Drawing.Point(107, 91);
        this.txtMarca.Name = "txtMarca";
        this.txtMarca.Size = new System.Drawing.Size(118, 22);
        this.txtMarca.TabIndex = 0;
        // 
        // txtModel
        // 
        this.txtModel.Location = new System.Drawing.Point(107, 144);
        this.txtModel.Name = "txtModel";
        this.txtModel.Size = new System.Drawing.Size(118, 22);
        this.txtModel.TabIndex = 1;
        // 
        // txtAn
        // 
        this.txtAn.Location = new System.Drawing.Point(107, 191);
        this.txtAn.Name = "txtAn";
        this.txtAn.Size = new System.Drawing.Size(118, 22);
        this.txtAn.TabIndex = 2;
        // 
        // txtPret
        // 
        this.txtPret.Location = new System.Drawing.Point(107, 244);
        this.txtPret.Name = "txtPret";
        this.txtPret.Size = new System.Drawing.Size(118, 22);
        this.txtPret.TabIndex = 3;
        // 
        // btnOK
        // 
        this.btnOK.Location = new System.Drawing.Point(131, 299);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new System.Drawing.Size(75, 23);
        this.btnOK.TabIndex = 4;
        this.btnOK.Text = "OK";
        this.btnOK.UseVisualStyleBackColor = true;
        this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(52, 97);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(48, 16);
        this.label1.TabIndex = 5;
        this.label1.Text = "Marca:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(52, 152);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(48, 16);
        this.label2.TabIndex = 6;
        this.label2.Text = "Model:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(64, 197);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(26, 16);
        this.label3.TabIndex = 7;
        this.label3.Text = "An:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(53, 250);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(37, 16);
        this.label4.TabIndex = 8;
        this.label4.Text = "Pret :";
        // 
        // MasinaForm
        // 
        this.ClientSize = new System.Drawing.Size(780, 442);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btnOK);
        this.Controls.Add(this.txtPret);
        this.Controls.Add(this.txtAn);
        this.Controls.Add(this.txtModel);
        this.Controls.Add(this.txtMarca);
        this.Name = "MasinaForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
