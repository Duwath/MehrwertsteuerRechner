namespace MehrwertsteuerRechner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRechner = new Button();
            label1 = new Label();
            tbxSteuern = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxBrutto = new TextBox();
            tbxSteuern2 = new TextBox();
            tbxNetto = new TextBox();
            tbxNettoGes = new TextBox();
            tbxSteuernGes = new TextBox();
            tbxBruttoGes = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnRechner
            // 
            btnRechner.BackColor = SystemColors.ActiveCaption;
            btnRechner.Location = new Point(12, 408);
            btnRechner.Name = "btnRechner";
            btnRechner.Size = new Size(227, 32);
            btnRechner.TabIndex = 0;
            btnRechner.Text = "Rechne";
            btnRechner.UseVisualStyleBackColor = false;
            btnRechner.Click += btnRechner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Steuern";
            // 
            // tbxSteuern
            // 
            tbxSteuern.Location = new Point(77, 6);
            tbxSteuern.Name = "tbxSteuern";
            tbxSteuern.Size = new Size(20, 23);
            tbxSteuern.TabIndex = 2;
            tbxSteuern.Text = "19";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 9);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 3;
            label2.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 73);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Brutto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 167);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "Steuern:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 118);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "Netto:";
            // 
            // tbxBrutto
            // 
            tbxBrutto.Location = new Point(135, 74);
            tbxBrutto.Name = "tbxBrutto";
            tbxBrutto.Size = new Size(100, 23);
            tbxBrutto.TabIndex = 8;
            tbxBrutto.Text = "119";
            tbxBrutto.KeyDown += tbxBrutto_KeyDown;
            tbxBrutto.KeyUp += tbxBrutto_KeyUp;
            // 
            // tbxSteuern2
            // 
            tbxSteuern2.Location = new Point(135, 168);
            tbxSteuern2.Name = "tbxSteuern2";
            tbxSteuern2.Size = new Size(100, 23);
            tbxSteuern2.TabIndex = 9;
            // 
            // tbxNetto
            // 
            tbxNetto.Location = new Point(135, 119);
            tbxNetto.Name = "tbxNetto";
            tbxNetto.Size = new Size(100, 23);
            tbxNetto.TabIndex = 10;
            // 
            // tbxNettoGes
            // 
            tbxNettoGes.Location = new Point(138, 297);
            tbxNettoGes.Name = "tbxNettoGes";
            tbxNettoGes.Size = new Size(100, 23);
            tbxNettoGes.TabIndex = 16;
            tbxNettoGes.Text = "0";
            // 
            // tbxSteuernGes
            // 
            tbxSteuernGes.Location = new Point(138, 346);
            tbxSteuernGes.Name = "tbxSteuernGes";
            tbxSteuernGes.Size = new Size(100, 23);
            tbxSteuernGes.TabIndex = 15;
            tbxSteuernGes.Text = "0";
            // 
            // tbxBruttoGes
            // 
            tbxBruttoGes.Location = new Point(138, 252);
            tbxBruttoGes.Name = "tbxBruttoGes";
            tbxBruttoGes.Size = new Size(100, 23);
            tbxBruttoGes.TabIndex = 14;
            tbxBruttoGes.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 296);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 13;
            label6.Text = "Netto Gesamt:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 345);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 12;
            label7.Text = "Steuern Gesamt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 251);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 11;
            label8.Text = "Brutto Gesamt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 452);
            Controls.Add(tbxNettoGes);
            Controls.Add(tbxSteuernGes);
            Controls.Add(tbxBruttoGes);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(tbxNetto);
            Controls.Add(tbxSteuern2);
            Controls.Add(tbxBrutto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxSteuern);
            Controls.Add(label1);
            Controls.Add(btnRechner);
            Name = "Form1";
            Padding = new Padding(10, 0, 0, 0);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRechner;
        private Label label1;
        private TextBox tbxSteuern;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxBrutto;
        private TextBox tbxSteuern2;
        private TextBox tbxNetto;
        private TextBox tbxNettoGes;
        private TextBox tbxSteuernGes;
        private TextBox tbxBruttoGes;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}