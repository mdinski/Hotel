﻿namespace OTEL254
{
    partial class kayitlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSAciklama = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGvGirisK = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGvCikisK = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvGirisK)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvCikisK)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSAciklama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSAciklama
            // 
            this.tSAciklama.BackColor = System.Drawing.Color.Transparent;
            this.tSAciklama.Name = "tSAciklama";
            this.tSAciklama.Size = new System.Drawing.Size(323, 17);
            this.tSAciklama.Text = "Bu program www.projevekod.com tarafından tasarlanmıştır.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGvGirisK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 355);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş kayıtları listeleniyor.";
            // 
            // dGvGirisK
            // 
            this.dGvGirisK.AllowUserToAddRows = false;
            this.dGvGirisK.AllowUserToDeleteRows = false;
            this.dGvGirisK.AllowUserToResizeColumns = false;
            this.dGvGirisK.AllowUserToResizeRows = false;
            this.dGvGirisK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvGirisK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvGirisK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvGirisK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGvGirisK.EnableHeadersVisualStyles = false;
            this.dGvGirisK.Location = new System.Drawing.Point(3, 22);
            this.dGvGirisK.Name = "dGvGirisK";
            this.dGvGirisK.ReadOnly = true;
            this.dGvGirisK.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGvGirisK.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGvGirisK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvGirisK.ShowCellErrors = false;
            this.dGvGirisK.ShowCellToolTips = false;
            this.dGvGirisK.ShowEditingIcon = false;
            this.dGvGirisK.ShowRowErrors = false;
            this.dGvGirisK.Size = new System.Drawing.Size(1002, 330);
            this.dGvGirisK.StandardTab = true;
            this.dGvGirisK.TabIndex = 12;
            this.dGvGirisK.VirtualMode = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGvCikisK);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(0, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1008, 350);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çıkış kayıtları listeleniyor.";
            // 
            // dGvCikisK
            // 
            this.dGvCikisK.AllowUserToAddRows = false;
            this.dGvCikisK.AllowUserToDeleteRows = false;
            this.dGvCikisK.AllowUserToResizeColumns = false;
            this.dGvCikisK.AllowUserToResizeRows = false;
            this.dGvCikisK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvCikisK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGvCikisK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvCikisK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGvCikisK.EnableHeadersVisualStyles = false;
            this.dGvCikisK.Location = new System.Drawing.Point(3, 22);
            this.dGvCikisK.Name = "dGvCikisK";
            this.dGvCikisK.ReadOnly = true;
            this.dGvCikisK.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dGvCikisK.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGvCikisK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvCikisK.ShowCellErrors = false;
            this.dGvCikisK.ShowCellToolTips = false;
            this.dGvCikisK.ShowEditingIcon = false;
            this.dGvCikisK.ShowRowErrors = false;
            this.dGvCikisK.Size = new System.Drawing.Size(1002, 325);
            this.dGvCikisK.StandardTab = true;
            this.dGvCikisK.TabIndex = 12;
            this.dGvCikisK.VirtualMode = true;
            // 
            // kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "kayitlar";
            this.Text = "kayitlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kayitlar_FormClosing);
            this.Load += new System.EventHandler(this.kayitlar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvGirisK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvCikisK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSAciklama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dGvGirisK;
        public System.Windows.Forms.DataGridView dGvCikisK;
    }
}