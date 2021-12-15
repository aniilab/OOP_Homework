
namespace TriangleType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sideAbox = new System.Windows.Forms.TextBox();
            this.sideBbox = new System.Windows.Forms.TextBox();
            this.angleCbox = new System.Windows.Forms.TextBox();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PerimetrLabel = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, enter triangle measurements:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "side A:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(24, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "side B:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(24, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "angle C:";
            this.label4.UseWaitCursor = true;
            // 
            // sideAbox
            // 
            this.sideAbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideAbox.Location = new System.Drawing.Point(178, 106);
            this.sideAbox.Name = "sideAbox";
            this.sideAbox.Size = new System.Drawing.Size(107, 39);
            this.sideAbox.TabIndex = 4;
            // 
            // sideBbox
            // 
            this.sideBbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBbox.Location = new System.Drawing.Point(178, 160);
            this.sideBbox.Name = "sideBbox";
            this.sideBbox.Size = new System.Drawing.Size(107, 39);
            this.sideBbox.TabIndex = 5;
            // 
            // angleCbox
            // 
            this.angleCbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleCbox.Location = new System.Drawing.Point(178, 221);
            this.angleCbox.Name = "angleCbox";
            this.angleCbox.Size = new System.Drawing.Size(107, 39);
            this.angleCbox.TabIndex = 6;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SuccessLabel.Location = new System.Drawing.Point(96, 378);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(0, 44);
            this.SuccessLabel.TabIndex = 7;
            this.SuccessLabel.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(82, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(404, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type:";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(523, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 44);
            this.label6.TabIndex = 10;
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(413, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 44);
            this.label7.TabIndex = 11;
            this.label7.Text = "Perimetr:";
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(413, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 44);
            this.label8.TabIndex = 12;
            this.label8.Text = "Square:";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(296, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(492, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "* perimetr and square only for right or isosceles triangles!";
            this.label9.UseWaitCursor = true;
            // 
            // PerimetrLabel
            // 
            this.PerimetrLabel.AutoSize = true;
            this.PerimetrLabel.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerimetrLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PerimetrLabel.Location = new System.Drawing.Point(548, 160);
            this.PerimetrLabel.Name = "PerimetrLabel";
            this.PerimetrLabel.Size = new System.Drawing.Size(0, 44);
            this.PerimetrLabel.TabIndex = 14;
            this.PerimetrLabel.UseWaitCursor = true;
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SquareLabel.Location = new System.Drawing.Point(540, 216);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(0, 44);
            this.SquareLabel.TabIndex = 15;
            this.SquareLabel.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(754, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(754, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(906, 460);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.PerimetrLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.angleCbox);
            this.Controls.Add(this.sideBbox);
            this.Controls.Add(this.sideAbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Triangle Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sideAbox;
        private System.Windows.Forms.TextBox sideBbox;
        private System.Windows.Forms.TextBox angleCbox;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PerimetrLabel;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

