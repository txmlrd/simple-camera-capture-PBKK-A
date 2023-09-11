namespace cameraCaptureApp
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
            cameraList = new ComboBox();
            captureButton = new Button();
            saveButton = new Button();
            startButton = new Button();
            exitButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cameraBoxLeft = new PictureBox();
            cameraBoxRight = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cameraBoxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cameraBoxRight).BeginInit();
            SuspendLayout();
            // 
            // cameraList
            // 
            cameraList.FormattingEnabled = true;
            cameraList.Location = new Point(27, 404);
            cameraList.Name = "cameraList";
            cameraList.Size = new Size(132, 23);
            cameraList.TabIndex = 0;
            // 
            // captureButton
            // 
            captureButton.BackColor = Color.FromArgb(0, 192, 0);
            captureButton.Location = new Point(184, 396);
            captureButton.Name = "captureButton";
            captureButton.Size = new Size(100, 36);
            captureButton.TabIndex = 1;
            captureButton.Text = "Capture";
            captureButton.UseVisualStyleBackColor = false;
            captureButton.Click += captureButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ActiveCaption;
            saveButton.Location = new Point(305, 396);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 36);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Yellow;
            startButton.ForeColor = SystemColors.ActiveCaptionText;
            startButton.Location = new Point(432, 396);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 36);
            startButton.TabIndex = 3;
            startButton.Text = "Start Camera";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.ForeColor = SystemColors.HighlightText;
            exitButton.Location = new Point(709, 391);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(68, 47);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cameraBoxLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(cameraBoxRight, 1, 0);
            tableLayoutPanel1.Location = new Point(23, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(765, 363);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // cameraBoxLeft
            // 
            cameraBoxLeft.Dock = DockStyle.Fill;
            cameraBoxLeft.Location = new Point(3, 3);
            cameraBoxLeft.Name = "cameraBoxLeft";
            cameraBoxLeft.Size = new Size(376, 357);
            cameraBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
            cameraBoxLeft.TabIndex = 0;
            cameraBoxLeft.TabStop = false;
            // 
            // cameraBoxRight
            // 
            cameraBoxRight.Dock = DockStyle.Fill;
            cameraBoxRight.Location = new Point(385, 3);
            cameraBoxRight.Name = "cameraBoxRight";
            cameraBoxRight.Size = new Size(377, 357);
            cameraBoxRight.SizeMode = PictureBoxSizeMode.Zoom;
            cameraBoxRight.TabIndex = 1;
            cameraBoxRight.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(exitButton);
            Controls.Add(startButton);
            Controls.Add(saveButton);
            Controls.Add(captureButton);
            Controls.Add(cameraList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cameraBoxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)cameraBoxRight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cameraList;
        private Button captureButton;
        private Button saveButton;
        private Button startButton;
        private Button exitButton;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox cameraBoxLeft;
        private PictureBox cameraBoxRight;
    }
}