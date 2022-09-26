namespace Pulse_setting
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_snd = new System.Windows.Forms.Button();
            this.btn_com = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(171, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "16000";
            // 
            // btn_snd
            // 
            this.btn_snd.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_snd.Location = new System.Drawing.Point(380, 79);
            this.btn_snd.Name = "btn_snd";
            this.btn_snd.Size = new System.Drawing.Size(120, 26);
            this.btn_snd.TabIndex = 3;
            this.btn_snd.Text = "send";
            this.btn_snd.UseVisualStyleBackColor = true;
            this.btn_snd.Click += new System.EventHandler(this.btn_snd_Click);
            // 
            // btn_com
            // 
            this.btn_com.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_com.Location = new System.Drawing.Point(380, 21);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(120, 28);
            this.btn_com.TabIndex = 3;
            this.btn_com.Text = "Open";
            this.btn_com.UseVisualStyleBackColor = true;
            this.btn_com.Click += new System.EventHandler(this.btn_com_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(322, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pulse Frequency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 162);
            this.Controls.Add(this.btn_com);
            this.Controls.Add(this.btn_snd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_snd;
        private System.Windows.Forms.Button btn_com;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

