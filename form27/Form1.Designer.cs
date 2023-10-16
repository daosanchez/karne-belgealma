namespace form27
{
    partial class Form1
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
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblZayif = new System.Windows.Forms.Label();
            this.lblDevamsizlik = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.btnDurumGoster = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrtalama.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOrtalama.Location = new System.Drawing.Point(20, 11);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(121, 21);
            this.lblOrtalama.TabIndex = 0;
            this.lblOrtalama.Text = "Not Ortalaması:";
            // 
            // lblZayif
            // 
            this.lblZayif.AutoSize = true;
            this.lblZayif.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZayif.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblZayif.Location = new System.Drawing.Point(39, 48);
            this.lblZayif.Name = "lblZayif";
            this.lblZayif.Size = new System.Drawing.Size(98, 21);
            this.lblZayif.TabIndex = 1;
            this.lblZayif.Text = "Zayıf Sayısı";
            // 
            // lblDevamsizlik
            // 
            this.lblDevamsizlik.AutoSize = true;
            this.lblDevamsizlik.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevamsizlik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDevamsizlik.Location = new System.Drawing.Point(3, 89);
            this.lblDevamsizlik.Name = "lblDevamsizlik";
            this.lblDevamsizlik.Size = new System.Drawing.Size(142, 21);
            this.lblDevamsizlik.TabIndex = 2;
            this.lblDevamsizlik.Text = "Devamsızlık Sayısı:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(151, 11);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(120, 20);
            this.txtOrtalama.TabIndex = 3;
            // 
            // txtZayif
            // 
            this.txtZayif.Location = new System.Drawing.Point(151, 49);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(120, 20);
            this.txtZayif.TabIndex = 4;
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Location = new System.Drawing.Point(151, 89);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(120, 20);
            this.txtDevamsizlik.TabIndex = 5;
            // 
            // btnDurumGoster
            // 
            this.btnDurumGoster.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDurumGoster.Location = new System.Drawing.Point(121, 145);
            this.btnDurumGoster.Name = "btnDurumGoster";
            this.btnDurumGoster.Size = new System.Drawing.Size(182, 41);
            this.btnDurumGoster.TabIndex = 6;
            this.btnDurumGoster.Text = "Belge Durum Göster:";
            this.btnDurumGoster.UseVisualStyleBackColor = true;
            this.btnDurumGoster.Click += new System.EventHandler(this.btnDurumGöster_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDurum.Location = new System.Drawing.Point(24, 218);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(57, 21);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(315, 279);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnDurumGoster);
            this.Controls.Add(this.txtDevamsizlik);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.lblDevamsizlik);
            this.Controls.Add(this.lblZayif);
            this.Controls.Add(this.lblOrtalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblZayif;
        private System.Windows.Forms.Label lblDevamsizlik;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.Button btnDurumGoster;
        private System.Windows.Forms.Label lblDurum;
    }
}

