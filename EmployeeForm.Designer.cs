namespace AttendanceManagementSystem
{
    partial class EmployeeForm
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
            label1 = new Label();
            addnewButton = new Button();
            identityTextBox = new TextBox();
            label2 = new Label();
            fullnameTextBox = new TextBox();
            label3 = new Label();
            positionTextBox = new TextBox();
            label4 = new Label();
            cardnoTextBox = new TextBox();
            saveButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(47, 120);
            label1.Name = "label1";
            label1.Size = new Size(115, 27);
            label1.TabIndex = 0;
            label1.Text = "Identity ID: ";
            // 
            // addnewButton
            // 
            addnewButton.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addnewButton.Location = new Point(47, 362);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(107, 39);
            addnewButton.TabIndex = 1;
            addnewButton.Text = "Add New";
            addnewButton.UseVisualStyleBackColor = true;
            addnewButton.Click += addnewButton_Click;
            // 
            // identityTextBox
            // 
            identityTextBox.Location = new Point(185, 117);
            identityTextBox.Name = "identityTextBox";
            identityTextBox.Size = new Size(308, 33);
            identityTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(47, 175);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 0;
            label2.Text = "Full Name:";
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(185, 172);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(308, 33);
            fullnameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(67, 228);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 0;
            label3.Text = "Position:";
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(185, 225);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(308, 33);
            positionTextBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(65, 287);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 0;
            label4.Text = "Card No:";
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(185, 284);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(308, 33);
            cardnoTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(160, 362);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(107, 39);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(273, 362);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(107, 39);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(945, 416);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(107, 39);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(503, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(549, 282);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Open Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(386, 26);
            label5.Name = "label5";
            label5.Size = new Size(240, 42);
            label5.TabIndex = 0;
            label5.Text = "Employee Form";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 544);
            Controls.Add(dataGridView1);
            Controls.Add(cardnoTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(label4);
            Controls.Add(fullnameTextBox);
            Controls.Add(label3);
            Controls.Add(identityTextBox);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addnewButton);
            Controls.Add(label5);
            Controls.Add(label1);
            Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 9, 7, 9);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addnewButton;
        private TextBox identityTextBox;
        private Label label2;
        private TextBox fullnameTextBox;
        private Label label3;
        private TextBox positionTextBox;
        private Label label4;
        private TextBox cardnoTextBox;
        private Button saveButton;
        private Button updateButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private Label label5;
    }
}