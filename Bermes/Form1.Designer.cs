using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;

namespace Bermes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelPosl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Polinom_CD = new System.Windows.Forms.TextBox();
            this.Per = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Posledo_vvod = new System.Windows.Forms.TextBox();
            this.Rasschit_algor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Kol_L = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sostoyan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dop_pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LabelPosl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Polinom_CD);
            this.panel2.Controls.Add(this.Per);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Kol_L);
            this.panel2.Location = new System.Drawing.Point(15, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 233);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Исходная последовательность:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(261, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "C(X):";
            // 
            // LabelPosl
            // 
            this.LabelPosl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPosl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPosl.Location = new System.Drawing.Point(326, 155);
            this.LabelPosl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPosl.Name = "LabelPosl";
            this.LabelPosl.Size = new System.Drawing.Size(286, 27);
            this.LabelPosl.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Период:";
            // 
            // Polinom_CD
            // 
            this.Polinom_CD.Location = new System.Drawing.Point(326, 89);
            this.Polinom_CD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Polinom_CD.Multiline = true;
            this.Polinom_CD.Name = "Polinom_CD";
            this.Polinom_CD.ReadOnly = true;
            this.Polinom_CD.Size = new System.Drawing.Size(287, 28);
            this.Polinom_CD.TabIndex = 3;
            // 
            // Per
            // 
            this.Per.Location = new System.Drawing.Point(80, 196);
            this.Per.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Per.Multiline = true;
            this.Per.Name = "Per";
            this.Per.ReadOnly = true;
            this.Per.Size = new System.Drawing.Size(104, 28);
            this.Per.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Posledo_vvod);
            this.panel1.Controls.Add(this.Rasschit_algor);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 80);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Двоичная последовательность";
            // 
            // Posledo_vvod
            // 
            this.Posledo_vvod.Location = new System.Drawing.Point(3, 50);
            this.Posledo_vvod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Posledo_vvod.Multiline = true;
            this.Posledo_vvod.Name = "Posledo_vvod";
            this.Posledo_vvod.Size = new System.Drawing.Size(595, 25);
            this.Posledo_vvod.TabIndex = 1;
            // 
            // Rasschit_algor
            // 
            this.Rasschit_algor.Location = new System.Drawing.Point(407, 2);
            this.Rasschit_algor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rasschit_algor.Name = "Rasschit_algor";
            this.Rasschit_algor.Size = new System.Drawing.Size(191, 46);
            this.Rasschit_algor.TabIndex = 2;
            this.Rasschit_algor.Text = "Алгоритм Берлекемпа-Месси";
            this.Rasschit_algor.UseVisualStyleBackColor = true;
            this.Rasschit_algor.Click += new System.EventHandler(this.Rasschit_algor_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сложность(L):";
            // 
            // Kol_L
            // 
            this.Kol_L.Location = new System.Drawing.Point(145, 89);
            this.Kol_L.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kol_L.Multiline = true;
            this.Kol_L.Name = "Kol_L";
            this.Kol_L.ReadOnly = true;
            this.Kol_L.Size = new System.Drawing.Size(110, 28);
            this.Kol_L.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sostoyan,
            this.delta,
            this.TX,
            this.CX,
            this.Col_L,
            this.number_pos,
            this.Dop_pol,
            this.step});
            this.dataGridView1.Location = new System.Drawing.Point(635, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(803, 538);
            this.dataGridView1.TabIndex = 19;
            // 
            // sostoyan
            // 
            this.sostoyan.HeaderText = "S[n]";
            this.sostoyan.MinimumWidth = 6;
            this.sostoyan.Name = "sostoyan";
            this.sostoyan.ReadOnly = true;
            this.sostoyan.Width = 35;
            // 
            // delta
            // 
            this.delta.HeaderText = "delta";
            this.delta.MinimumWidth = 6;
            this.delta.Name = "delta";
            this.delta.ReadOnly = true;
            this.delta.Width = 120;
            // 
            // TX
            // 
            this.TX.HeaderText = "T(x)";
            this.TX.MinimumWidth = 6;
            this.TX.Name = "TX";
            this.TX.ReadOnly = true;
            this.TX.Width = 120;
            // 
            // CX
            // 
            this.CX.HeaderText = "C(X)";
            this.CX.MinimumWidth = 6;
            this.CX.Name = "CX";
            this.CX.ReadOnly = true;
            this.CX.Width = 125;
            // 
            // Col_L
            // 
            this.Col_L.HeaderText = "L";
            this.Col_L.MinimumWidth = 6;
            this.Col_L.Name = "Col_L";
            this.Col_L.ReadOnly = true;
            this.Col_L.Width = 50;
            // 
            // number_pos
            // 
            this.number_pos.HeaderText = "m";
            this.number_pos.MinimumWidth = 6;
            this.number_pos.Name = "number_pos";
            this.number_pos.ReadOnly = true;
            this.number_pos.Width = 50;
            // 
            // Dop_pol
            // 
            this.Dop_pol.HeaderText = "B(x)";
            this.Dop_pol.MinimumWidth = 6;
            this.Dop_pol.Name = "Dop_pol";
            this.Dop_pol.ReadOnly = true;
            this.Dop_pol.Width = 125;
            // 
            // step
            // 
            this.step.HeaderText = "№ шага";
            this.step.MinimumWidth = 6;
            this.step.Name = "step";
            this.step.ReadOnly = true;
            this.step.Width = 125;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(3, 2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(615, 297);
            this.picture.TabIndex = 20;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.picture);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(15, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 302);
            this.panel3.TabIndex = 21;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 217);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(107, 56);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1441, 558);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Берлекемпа-Месси";
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Per;
        private System.Windows.Forms.TextBox Polinom_CD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Posledo_vvod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kol_L;
        private System.Windows.Forms.Button Rasschit_algor;
        //элементы
        byte[] c;
        byte[] bd;
        byte[] td;
        int count = 0;
        byte[] sost;
        int N, L, m;
        List<int> n = new List<int>();
        List<int> l = new List<int>();
        List<int> del = new List<int>();
        List<int> mas = new List<int>();
        string Key;
        int d = 0;
        int T = 0;
        int psi = 0;
        int per = 0;
        byte[] new_sost;
        int k30 = 0;
        dynamic plus1 = 0;
        Graphics gr = null;
        //элементы
        private System.Windows.Forms.Label LabelPosl;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostoyan;
        private System.Windows.Forms.DataGridViewTextBoxColumn delta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_L;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dop_pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn step;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

        public byte[] Sost { get { return sost; } set { sost = value; }  }
    }
}

