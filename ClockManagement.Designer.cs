namespace AttendanceManagementSystem
{
    partial class ClockManagement
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
            components = new System.ComponentModel.Container();
            text = new Label();
            currentTimeLabel = new Label();
            cardnoTextBox = new TextBox();
            label4 = new Label();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // text
            // 
            text.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            text.AutoSize = true;
            text.Font = new Font("Open Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            text.Location = new Point(268, 26);
            text.Name = "text";
            text.Size = new Size(179, 42);
            text.TabIndex = 1;
            text.Text = "Clock Form";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Font = new Font("Open Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            currentTimeLabel.Location = new Point(268, 98);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(65, 31);
            currentTimeLabel.TabIndex = 1;
            currentTimeLabel.Text = "Time";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(249, 173);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(267, 33);
            cardnoTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(129, 173);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 3;
            label4.Text = "Card No:";
            // 
            // clockinButton
            // 
            clockinButton.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clockinButton.Location = new Point(268, 249);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(121, 40);
            clockinButton.TabIndex = 5;
            clockinButton.Text = "Time-in";
            clockinButton.UseVisualStyleBackColor = true;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clockoutButton.Location = new Point(395, 249);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(121, 40);
            clockoutButton.TabIndex = 5;
            clockoutButton.Text = "Time-out";
            clockoutButton.UseVisualStyleBackColor = true;
            clockoutButton.Click += clockoutButton_Click_1;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick_1;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 464);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(label4);
            Controls.Add(currentTimeLabel);
            Controls.Add(text);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0, 5, 0, 5);
            Name = "ClockManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClockManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text;
        private Label currentTimeLabel;
        private TextBox cardnoTextBox;
        private Label label4;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer;
    }
}