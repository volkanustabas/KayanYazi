﻿namespace KayanYazi
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kayanYaziLabel1 = new KayanYazi.KayanYaziLabel();
            this.kayanYaziLabel2 = new KayanYazi.KayanYaziLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.kayanYaziLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kayanYaziLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kayanYaziLabel1
            // 
            this.kayanYaziLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kayanYaziLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kayanYaziLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.kayanYaziLabel1.Location = new System.Drawing.Point(3, 3);
            this.kayanYaziLabel1.Name = "kayanYaziLabel1";
            this.kayanYaziLabel1.Size = new System.Drawing.Size(618, 34);
            this.kayanYaziLabel1.Slide = true;
            this.kayanYaziLabel1.SlideTime = 25;
            this.kayanYaziLabel1.TabIndex = 0;
            this.kayanYaziLabel1.Text = resources.GetString("kayanYaziLabel1.Text");
            // 
            // kayanYaziLabel2
            // 
            this.kayanYaziLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kayanYaziLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kayanYaziLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.kayanYaziLabel2.Location = new System.Drawing.Point(3, 404);
            this.kayanYaziLabel2.Name = "kayanYaziLabel2";
            this.kayanYaziLabel2.Size = new System.Drawing.Size(618, 34);
            this.kayanYaziLabel2.Slide = true;
            this.kayanYaziLabel2.SlideTime = 25;
            this.kayanYaziLabel2.TabIndex = 1;
            this.kayanYaziLabel2.Text = resources.GetString("kayanYaziLabel2.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(618, 355);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private KayanYaziLabel kayanYaziLabel1;
        private KayanYaziLabel kayanYaziLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

