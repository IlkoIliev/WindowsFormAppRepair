namespace UI
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(269, 20);
            label1.TabIndex = 1;
            label1.Text = "Дължината на страна от площадката ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 3;
            label2.Text = "Широчината на една плочка ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(294, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(294, 215);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 112);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 7;
            label3.Text = "Дължината на една плочка ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 166);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 8;
            label4.Text = "Широчината на пейката ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 222);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 9;
            label5.Text = "Дължината на пейката ";
            // 
            // button1
            // 
            button1.Location = new Point(24, 257);
            button1.Name = "button1";
            button1.Size = new Size(395, 94);
            button1.TabIndex = 10;
            button1.Text = "Изчисли";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(439, 54);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(326, 297);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 8);
            label6.Name = "label6";
            label6.Size = new Size(189, 20);
            label6.TabIndex = 12;
            label6.Text = "Резултат от изчисленията:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 367);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox6;
        private Label label6;
    }
}