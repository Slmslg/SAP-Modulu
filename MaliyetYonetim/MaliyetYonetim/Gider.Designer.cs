namespace MaliyetYonetim
{
    partial class Gider
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.richTxtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtGridGider = new System.Windows.Forms.DataGridView();
            this.btnGiderKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiderKaydet);
            this.groupBox1.Controls.Add(this.txtTur);
            this.groupBox1.Controls.Add(this.richTxtAciklama);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateTimeTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(156, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 307);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİDER EKLE";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(125, 21);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(160, 20);
            this.txtTur.TabIndex = 28;
            // 
            // richTxtAciklama
            // 
            this.richTxtAciklama.Location = new System.Drawing.Point(125, 74);
            this.richTxtAciklama.Name = "richTxtAciklama";
            this.richTxtAciklama.Size = new System.Drawing.Size(160, 139);
            this.richTxtAciklama.TabIndex = 27;
            this.richTxtAciklama.Text = "";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(125, 50);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(160, 20);
            this.txtTutar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "TUR :";
            // 
            // DateTimeTarih
            // 
            this.DateTimeTarih.Location = new System.Drawing.Point(125, 219);
            this.DateTimeTarih.Name = "DateTimeTarih";
            this.DateTimeTarih.Size = new System.Drawing.Size(160, 20);
            this.DateTimeTarih.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "TUTAR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Açıklama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "TL ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(534, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 307);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // dtGridGider
            // 
            this.dtGridGider.AllowUserToAddRows = false;
            this.dtGridGider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridGider.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGider.Location = new System.Drawing.Point(190, 375);
            this.dtGridGider.Name = "dtGridGider";
            this.dtGridGider.Size = new System.Drawing.Size(591, 150);
            this.dtGridGider.TabIndex = 20;
            this.dtGridGider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridGider_CellClick);
            // 
            // btnGiderKaydet
            // 
            this.btnGiderKaydet.Location = new System.Drawing.Point(125, 254);
            this.btnGiderKaydet.Name = "btnGiderKaydet";
            this.btnGiderKaydet.Size = new System.Drawing.Size(160, 23);
            this.btnGiderKaydet.TabIndex = 29;
            this.btnGiderKaydet.Text = "KAYDET";
            this.btnGiderKaydet.UseVisualStyleBackColor = true;
            this.btnGiderKaydet.Click += new System.EventHandler(this.btnGiderKaydet_Click);
            // 
            // Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 561);
            this.Controls.Add(this.dtGridGider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gider";
            this.Text = "Gider";
            this.Load += new System.EventHandler(this.Gider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTxtAciklama;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimeTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dtGridGider;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Button btnGiderKaydet;
    }
}