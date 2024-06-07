namespace lab6
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
            txtCubeSide = new TextBox();
            txtRectHeight = new TextBox();
            txtRectLength = new TextBox();
            txtRectWidth = new TextBox();
            txtCubeVolume = new TextBox();
            txtRectVolume = new TextBox();
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtCubeSide
            // 
            txtCubeSide.Location = new Point(522, 66);
            txtCubeSide.Name = "txtCubeSide";
            txtCubeSide.Size = new Size(250, 47);
            txtCubeSide.TabIndex = 0;
            // 
            // txtRectHeight
            // 
            txtRectHeight.Location = new Point(522, 380);
            txtRectHeight.Name = "txtRectHeight";
            txtRectHeight.Size = new Size(250, 47);
            txtRectHeight.TabIndex = 1;
            // 
            // txtRectLength
            // 
            txtRectLength.Location = new Point(522, 162);
            txtRectLength.Name = "txtRectLength";
            txtRectLength.Size = new Size(250, 47);
            txtRectLength.TabIndex = 2;
            // 
            // txtRectWidth
            // 
            txtRectWidth.Location = new Point(522, 271);
            txtRectWidth.Name = "txtRectWidth";
            txtRectWidth.Size = new Size(250, 47);
            txtRectWidth.TabIndex = 3;
            // 
            // txtCubeVolume
            // 
            txtCubeVolume.Location = new Point(522, 651);
            txtCubeVolume.Name = "txtCubeVolume";
            txtCubeVolume.ReadOnly = true;
            txtCubeVolume.Size = new Size(250, 47);
            txtCubeVolume.TabIndex = 4;
            // 
            // txtRectVolume
            // 
            txtRectVolume.Location = new Point(522, 773);
            txtRectVolume.Name = "txtRectVolume";
            txtRectVolume.ReadOnly = true;
            txtRectVolume.Size = new Size(250, 47);
            txtRectVolume.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(305, 497);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(188, 58);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 72);
            label1.Name = "label1";
            label1.Size = new Size(313, 41);
            label1.TabIndex = 7;
            label1.Text = "Довжина ребра куба:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 386);
            label2.Name = "label2";
            label2.Size = new Size(118, 41);
            label2.TabIndex = 8;
            label2.Text = "Висота:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 274);
            label3.Name = "label3";
            label3.Size = new Size(245, 41);
            label3.TabIndex = 9;
            label3.Text = "Ширина основи:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 168);
            label4.Name = "label4";
            label4.Size = new Size(259, 41);
            label4.TabIndex = 10;
            label4.Text = "Довжина основи:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 657);
            label5.Name = "label5";
            label5.Size = new Size(177, 41);
            label5.TabIndex = 11;
            label5.Text = "Об'єм куба:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 779);
            label6.Name = "label6";
            label6.Size = new Size(332, 41);
            label6.TabIndex = 12;
            label6.Text = "Об'єм паралелепіпеда:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1970, 1050);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Controls.Add(txtRectVolume);
            Controls.Add(txtCubeVolume);
            Controls.Add(txtRectWidth);
            Controls.Add(txtRectLength);
            Controls.Add(txtRectHeight);
            Controls.Add(txtCubeSide);
            Margin = new Padding(6);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCubeSide;
        private TextBox txtRectHeight;
        private TextBox txtRectLength;
        private TextBox txtRectWidth;
        private TextBox txtCubeVolume;
        private TextBox txtRectVolume;
        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
