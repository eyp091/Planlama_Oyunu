namespace PlanlamaOyunu.PlanlamaOyunu
{
    partial class PlanOlustur
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
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.txbTip = new System.Windows.Forms.TextBox();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.BackColor = System.Drawing.Color.SlateBlue;
            this.rtbAciklama.ForeColor = System.Drawing.Color.White;
            this.rtbAciklama.Location = new System.Drawing.Point(350, 146);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(125, 120);
            this.rtbAciklama.TabIndex = 4;
            this.rtbAciklama.Text = "";
            // 
            // txbTip
            // 
            this.txbTip.BackColor = System.Drawing.Color.SlateBlue;
            this.txbTip.ForeColor = System.Drawing.Color.White;
            this.txbTip.Location = new System.Drawing.Point(350, 110);
            this.txbTip.Name = "txbTip";
            this.txbTip.Size = new System.Drawing.Size(122, 27);
            this.txbTip.TabIndex = 3;
            // 
            // mtbBitis
            // 
            this.mtbBitis.BackColor = System.Drawing.Color.SlateBlue;
            this.mtbBitis.ForeColor = System.Drawing.Color.White;
            this.mtbBitis.Location = new System.Drawing.Point(126, 175);
            this.mtbBitis.Mask = "00:00";
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(71, 27);
            this.mtbBitis.TabIndex = 2;
            this.mtbBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbBitis.ValidatingType = typeof(System.DateTime);
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.BackColor = System.Drawing.Color.SlateBlue;
            this.mtbBaslangic.ForeColor = System.Drawing.Color.White;
            this.mtbBaslangic.Location = new System.Drawing.Point(126, 143);
            this.mtbBaslangic.Mask = "00:00";
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(71, 27);
            this.mtbBaslangic.TabIndex = 1;
            this.mtbBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(126, 113);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 20);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "İşlem Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Tarihi: ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(462, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yeni Plan Oluştur";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(43, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 38);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // PlanOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.txbTip);
            this.Controls.Add(this.mtbBitis);
            this.Controls.Add(this.mtbBaslangic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanOlustur";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private RichTextBox rtbAciklama;
        private TextBox txbTip;
        private MaskedTextBox mtbBitis;
        private MaskedTextBox mtbBaslangic;
        private Label lblTarih;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}