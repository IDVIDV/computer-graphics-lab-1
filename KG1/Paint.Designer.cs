namespace KG1
{
    partial class Paint
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
            pickColorButton = new Button();
            pencilButton = new Button();
            fillerButton = new Button();
            pictureBox = new PictureBox();
            colorDialog = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pickColorButton
            // 
            pickColorButton.BackColor = Color.Black;
            pickColorButton.Location = new Point(12, 12);
            pickColorButton.Name = "pickColorButton";
            pickColorButton.Size = new Size(30, 30);
            pickColorButton.TabIndex = 0;
            pickColorButton.UseVisualStyleBackColor = false;
            pickColorButton.Click += pickColorButton_Click;
            // 
            // pencilButton
            // 
            pencilButton.Location = new Point(12, 48);
            pencilButton.Name = "pencilButton";
            pencilButton.Size = new Size(30, 30);
            pencilButton.TabIndex = 1;
            pencilButton.Text = "К";
            pencilButton.UseVisualStyleBackColor = true;
            pencilButton.Click += pencilButton_Click;
            // 
            // fillerButton
            // 
            fillerButton.Location = new Point(12, 84);
            fillerButton.Name = "fillerButton";
            fillerButton.Size = new Size(30, 30);
            fillerButton.TabIndex = 2;
            fillerButton.Text = "З";
            fillerButton.UseVisualStyleBackColor = true;
            fillerButton.Click += fillerButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(48, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(559, 487);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 500);
            Controls.Add(pictureBox);
            Controls.Add(fillerButton);
            Controls.Add(pencilButton);
            Controls.Add(pickColorButton);
            Name = "Paint";
            Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button pickColorButton;
        private Button pencilButton;
        private Button fillerButton;
        private PictureBox pictureBox;
        private ColorDialog colorDialog;
    }
}