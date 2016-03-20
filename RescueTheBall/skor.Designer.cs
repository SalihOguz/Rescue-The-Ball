namespace RescueTheBall
{
    partial class skor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ısimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.scoreDataSet1 = new RescueTheBall.scoreDataSet1();
            this.scoreDataSet = new RescueTheBall.scoreDataSet();
            this.scoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skorTableAdapter = new RescueTheBall.scoreDataSetTableAdapters.SkorTableAdapter();
            this.skorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.skorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.skorTableAdapter1 = new RescueTheBall.scoreDataSet1TableAdapters.SkorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RescueTheBall.Properties.Resources.cubuk;
            this.pictureBox1.Location = new System.Drawing.Point(243, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Motorwerk", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yuksek Skorlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ısimDataGridViewTextBoxColumn,
            this.skorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.skorBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(144, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 234);
            this.dataGridView1.TabIndex = 7;
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            this.ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            this.ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            this.ısimDataGridViewTextBoxColumn.ReadOnly = true;
            this.ısimDataGridViewTextBoxColumn.Width = 200;
            // 
            // skorDataGridViewTextBoxColumn
            // 
            this.skorDataGridViewTextBoxColumn.DataPropertyName = "Skor";
            this.skorDataGridViewTextBoxColumn.HeaderText = "Skor";
            this.skorDataGridViewTextBoxColumn.Name = "skorDataGridViewTextBoxColumn";
            this.skorDataGridViewTextBoxColumn.ReadOnly = true;
            this.skorDataGridViewTextBoxColumn.Width = 200;
            // 
            // skorBindingSource4
            // 
            this.skorBindingSource4.DataMember = "Skor";
            this.skorBindingSource4.DataSource = this.scoreDataSet1;
            // 
            // scoreDataSet1
            // 
            this.scoreDataSet1.DataSetName = "scoreDataSet1";
            this.scoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreDataSet
            // 
            this.scoreDataSet.DataSetName = "scoreDataSet";
            this.scoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreDataSetBindingSource
            // 
            this.scoreDataSetBindingSource.DataSource = this.scoreDataSet;
            this.scoreDataSetBindingSource.Position = 0;
            // 
            // skorBindingSource
            // 
            this.skorBindingSource.DataMember = "Skor";
            this.skorBindingSource.DataSource = this.scoreDataSetBindingSource;
            // 
            // skorTableAdapter
            // 
            this.skorTableAdapter.ClearBeforeFill = true;
            // 
            // skorBindingSource1
            // 
            this.skorBindingSource1.DataMember = "Skor";
            this.skorBindingSource1.DataSource = this.scoreDataSetBindingSource;
            // 
            // skorBindingSource2
            // 
            this.skorBindingSource2.DataMember = "Skor";
            this.skorBindingSource2.DataSource = this.scoreDataSetBindingSource;
            // 
            // skorBindingSource3
            // 
            this.skorBindingSource3.DataMember = "Skor";
            this.skorBindingSource3.DataSource = this.scoreDataSetBindingSource;
            // 
            // skorTableAdapter1
            // 
            this.skorTableAdapter1.ClearBeforeFill = true;
            // 
            // skor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(156)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(772, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "skor";
            this.Text = "Rescue The Ball - High Score";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.skor_FormClosed);
            this.Load += new System.EventHandler(this.skor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource scoreDataSetBindingSource;
        private scoreDataSet scoreDataSet;
        private System.Windows.Forms.BindingSource skorBindingSource;
        private scoreDataSetTableAdapters.SkorTableAdapter skorTableAdapter;
        private System.Windows.Forms.BindingSource skorBindingSource1;
        private System.Windows.Forms.BindingSource skorBindingSource3;
        private System.Windows.Forms.BindingSource skorBindingSource2;
        private scoreDataSet1 scoreDataSet1;
        private System.Windows.Forms.BindingSource skorBindingSource4;
        private scoreDataSet1TableAdapters.SkorTableAdapter skorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skorDataGridViewTextBoxColumn;
    }
}