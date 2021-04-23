namespace IMSAKIYE
{
    partial class frmbolge
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.illiste = new System.Windows.Forms.ComboBox();
            this.ilceliste = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pn = new System.Windows.Forms.TextBox();
            this.ililce = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "KAPAT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlçe";
            // 
            // illiste
            // 
            this.illiste.FormattingEnabled = true;
            this.illiste.Location = new System.Drawing.Point(92, 6);
            this.illiste.Name = "illiste";
            this.illiste.Size = new System.Drawing.Size(194, 21);
            this.illiste.TabIndex = 9;
            this.illiste.SelectedValueChanged += new System.EventHandler(this.illiste_SelectedValueChanged);
            // 
            // ilceliste
            // 
            this.ilceliste.FormattingEnabled = true;
            this.ilceliste.Location = new System.Drawing.Point(92, 36);
            this.ilceliste.Name = "ilceliste";
            this.ilceliste.Size = new System.Drawing.Size(194, 21);
            this.ilceliste.TabIndex = 10;
            this.ilceliste.SelectedIndexChanged += new System.EventHandler(this.ilceliste_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(499, 65);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(12, 90);
            this.pn.Name = "pn";
            this.pn.ReadOnly = true;
            this.pn.Size = new System.Drawing.Size(33, 21);
            this.pn.TabIndex = 12;
            // 
            // ililce
            // 
            this.ililce.Location = new System.Drawing.Point(15, 63);
            this.ililce.Name = "ililce";
            this.ililce.Size = new System.Drawing.Size(271, 21);
            this.ililce.TabIndex = 13;
            // 
            // frmbolge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(524, 140);
            this.ControlBox = false;
            this.Controls.Add(this.ilceliste);
            this.Controls.Add(this.illiste);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.ililce);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmbolge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÖLGE";
            this.Load += new System.EventHandler(this.frmbolge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox illiste;
        private System.Windows.Forms.ComboBox ilceliste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.TextBox ililce;
    }
}