namespace KatVozila
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.txtKotaci = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(27, 50);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(27, 94);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(100, 20);
            this.txtGod.TabIndex = 1;
            // 
            // txtKotaci
            // 
            this.txtKotaci.Location = new System.Drawing.Point(27, 142);
            this.txtKotaci.Name = "txtKotaci";
            this.txtKotaci.Size = new System.Drawing.Size(100, 20);
            this.txtKotaci.TabIndex = 2;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(27, 231);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(131, 231);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(75, 23);
            this.btnObrada.TabIndex = 5;
            this.btnObrada.Text = "Obradi";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(233, 231);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(233, 27);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(282, 153);
            this.txtIspis.TabIndex = 7;
            this.txtIspis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Broj kotaca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtKotaci);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.TextBox txtKotaci;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.RichTextBox txtIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

