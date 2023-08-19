using System.Net;

namespace WinFormsClSv
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(134, 401);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 5;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(154, 91);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(181, 34);
            textBox4.TabIndex = 0;
            textBox4.TabStop = false;
            textBox4.Text = "10.22.131.248";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 91);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 5;
            label4.Text = "LAN IP :";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(154, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 34);
            textBox3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 150);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 7;
            label3.Text = "Port :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(154, 254);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 34);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 257);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 1;
            label1.Text = "IP :";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(154, 301);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 34);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 304);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 3;
            label2.Text = "Port :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(61, 357);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Connect to local host";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(61, 42);
            label6.Name = "label6";
            label6.Size = new Size(304, 28);
            label6.TabIndex = 11;
            label6.Text = "Settings to connect to this end";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(61, 210);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 12;
            label7.Text = "Connect to:";
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 477);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConnectionForm";
            Text = "Connect - YTU Lagari";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private CheckBox checkBox1;
        private Label label6;
        private Label label7;
    }
}