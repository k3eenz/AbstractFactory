namespace AbstractFact
{
    partial class MainForm
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
            DrawPanel = new Panel();
            DrawBtn = new Button();
            ColorBox = new ComboBox();
            FigureBox = new ComboBox();
            SuspendLayout();
            // 
            // DrawPanel
            // 
            DrawPanel.Location = new Point(35, 100);
            DrawPanel.Name = "DrawPanel";
            DrawPanel.Size = new Size(171, 154);
            DrawPanel.TabIndex = 7;
            // 
            // DrawBtn
            // 
            DrawBtn.Location = new Point(68, 41);
            DrawBtn.Name = "DrawBtn";
            DrawBtn.Size = new Size(114, 23);
            DrawBtn.TabIndex = 6;
            DrawBtn.Text = "Нарисовать";
            DrawBtn.UseVisualStyleBackColor = true;
            DrawBtn.Click += DrawBtn_Click;
            // 
            // ColorBox
            // 
            ColorBox.FormattingEnabled = true;
            ColorBox.Items.AddRange(new object[] { "Красный", "Синий" });
            ColorBox.Location = new Point(129, 12);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(121, 23);
            ColorBox.TabIndex = 5;
            // 
            // FigureBox
            // 
            FigureBox.FormattingEnabled = true;
            FigureBox.Items.AddRange(new object[] { "Круг", "Квадрат", "Треугольник" });
            FigureBox.Location = new Point(2, 12);
            FigureBox.Name = "FigureBox";
            FigureBox.Size = new Size(121, 23);
            FigureBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 274);
            Controls.Add(DrawPanel);
            Controls.Add(DrawBtn);
            Controls.Add(ColorBox);
            Controls.Add(FigureBox);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel DrawPanel;
        private Button DrawBtn;
        private ComboBox ColorBox;
        private ComboBox FigureBox;
    }
}
