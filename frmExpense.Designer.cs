namespace PersonalExpenseTracker
{
    partial class frmExpense
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
            datePicker = new DateTimePicker();
            label1 = new Label();
            txtDesc = new TextBox();
            label2 = new Label();
            CategoryList = new ComboBox();
            label3 = new Label();
            amountUpDown = new NumericUpDown();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cardRBtn = new RadioButton();
            gcashRBtn = new RadioButton();
            cashRBtn = new RadioButton();
            recurringCheck = new CheckBox();
            txtNotes = new TextBox();
            label5 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)amountUpDown).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(97, 34);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(129, 23);
            datePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Date:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(97, 75);
            txtDesc.MaxLength = 50;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(241, 23);
            txtDesc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // CategoryList
            // 
            CategoryList.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryList.FormattingEnabled = true;
            CategoryList.Location = new Point(97, 115);
            CategoryList.Name = "CategoryList";
            CategoryList.Size = new Size(152, 23);
            CategoryList.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 118);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // amountUpDown
            // 
            amountUpDown.DecimalPlaces = 2;
            amountUpDown.Location = new Point(98, 155);
            amountUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountUpDown.Name = "amountUpDown";
            amountUpDown.Size = new Size(120, 23);
            amountUpDown.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 157);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Amount:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cardRBtn);
            groupBox1.Controls.Add(gcashRBtn);
            groupBox1.Controls.Add(cashRBtn);
            groupBox1.Location = new Point(21, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 67);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment";
            // 
            // cardRBtn
            // 
            cardRBtn.AutoSize = true;
            cardRBtn.Location = new Point(178, 29);
            cardRBtn.Name = "cardRBtn";
            cardRBtn.Size = new Size(50, 19);
            cardRBtn.TabIndex = 2;
            cardRBtn.TabStop = true;
            cardRBtn.Text = "Card";
            cardRBtn.UseVisualStyleBackColor = true;
            // 
            // gcashRBtn
            // 
            gcashRBtn.AutoSize = true;
            gcashRBtn.Location = new Point(96, 29);
            gcashRBtn.Name = "gcashRBtn";
            gcashRBtn.Size = new Size(57, 19);
            gcashRBtn.TabIndex = 1;
            gcashRBtn.TabStop = true;
            gcashRBtn.Text = "Gcash";
            gcashRBtn.UseVisualStyleBackColor = true;
            // 
            // cashRBtn
            // 
            cashRBtn.AutoSize = true;
            cashRBtn.Location = new Point(19, 29);
            cashRBtn.Name = "cashRBtn";
            cashRBtn.Size = new Size(51, 19);
            cashRBtn.TabIndex = 0;
            cashRBtn.TabStop = true;
            cashRBtn.Text = "Cash";
            cashRBtn.UseVisualStyleBackColor = true;
            // 
            // recurringCheck
            // 
            recurringCheck.AutoSize = true;
            recurringCheck.Location = new Point(21, 290);
            recurringCheck.Name = "recurringCheck";
            recurringCheck.Size = new Size(125, 19);
            recurringCheck.TabIndex = 9;
            recurringCheck.Text = "Recurring Monthly";
            recurringCheck.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(98, 315);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(241, 57);
            txtNotes.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 315);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Notes:";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(174, 403);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click_1;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(264, 403);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(label5);
            Controls.Add(txtNotes);
            Controls.Add(recurringCheck);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(amountUpDown);
            Controls.Add(label3);
            Controls.Add(CategoryList);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(label1);
            Controls.Add(datePicker);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExpense";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmExpense";
            ((System.ComponentModel.ISupportInitialize)amountUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datePicker;
        private Label label1;
        private TextBox txtDesc;
        private Label label2;
        private ComboBox CategoryList;
        private Label label3;
        private NumericUpDown amountUpDown;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton cardRBtn;
        private RadioButton gcashRBtn;
        private RadioButton cashRBtn;
        private CheckBox recurringCheck;
        private TextBox txtNotes;
        private Label label5;
        private Button saveBtn;
        private Button cancelBtn;
        private ErrorProvider errorProvider1;
    }
}