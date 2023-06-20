namespace AttendanceManagementSystem
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
            label1 = new Label();
            timeRecordButton = new Button();
            manageEmployeeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 65);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(572, 46);
            label1.TabIndex = 0;
            label1.Text = "Employee TimeSheet Management";
            // 
            // timeRecordButton
            // 
            timeRecordButton.Location = new Point(320, 172);
            timeRecordButton.Margin = new Padding(0);
            timeRecordButton.Name = "timeRecordButton";
            timeRecordButton.Size = new Size(215, 46);
            timeRecordButton.TabIndex = 1;
            timeRecordButton.Text = "Time Record";
            timeRecordButton.UseVisualStyleBackColor = true;
            timeRecordButton.Click += timeRecordButton_Click;
            // 
            // manageEmployeeButton
            // 
            manageEmployeeButton.Location = new Point(320, 249);
            manageEmployeeButton.Margin = new Padding(0);
            manageEmployeeButton.Name = "manageEmployeeButton";
            manageEmployeeButton.Size = new Size(215, 46);
            manageEmployeeButton.TabIndex = 1;
            manageEmployeeButton.Text = "Manage Employee";
            manageEmployeeButton.UseVisualStyleBackColor = true;
            manageEmployeeButton.Click += manageEmployeeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 515);
            Controls.Add(manageEmployeeButton);
            Controls.Add(timeRecordButton);
            Controls.Add(label1);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0, 5, 0, 5);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButton;
        private Button manageEmployeeButton;
    }
}