namespace ADO.Net_Chat_app
{
    partial class Message_Window
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(859, 576);
            button1.Name = "button1";
            button1.Size = new Size(183, 66);
            button1.TabIndex = 0;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(845, 37);
            button2.Name = "button2";
            button2.Size = new Size(183, 66);
            button2.TabIndex = 1;
            button2.Text = "Show messages";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(78, 576);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(732, 66);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(78, 28);
            button3.Name = "button3";
            button3.Size = new Size(183, 66);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(87, 163);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(955, 375);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Message_Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 695);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Message_Window";
            Text = "Message_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}