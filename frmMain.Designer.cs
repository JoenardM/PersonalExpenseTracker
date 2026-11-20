namespace PersonalExpenseTracker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            addTool = new ToolStripButton();
            editTool = new ToolStripButton();
            deleteTool = new ToolStripButton();
            saveTool = new ToolStripButton();
            filterPanel = new Panel();
            dateFilterTo = new DateTimePicker();
            label3 = new Label();
            dateFilterFrom = new DateTimePicker();
            dateCheck = new CheckBox();
            txtSearch = new TextBox();
            label2 = new Label();
            filterCategory = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            summaryPanel = new Panel();
            txtRemaining = new Label();
            numMonthBudget = new NumericUpDown();
            label5 = new Label();
            summaryTotal = new Label();
            statusStrip1 = new StatusStrip();
            statusDisplay = new ToolStripStatusLabel();
            statusRec = new ToolStripStatusLabel();
            statusClock = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMonthBudget).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem, exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeyDisplayString = "";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(146, 22);
            exitToolStripMenuItem1.Text = "E&xit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, toolStripMenuItem2, deleteToolStripMenuItem });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(61, 20);
            expenseToolStripMenuItem.Text = "&Expense";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(107, 22);
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(107, 22);
            toolStripMenuItem2.Text = "&Edit";
            toolStripMenuItem2.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { addTool, editTool, deleteTool, saveTool });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // addTool
            // 
            addTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addTool.Image = (Image)resources.GetObject("addTool.Image");
            addTool.ImageTransparentColor = Color.Magenta;
            addTool.Name = "addTool";
            addTool.Size = new Size(33, 22);
            addTool.Text = "Add";
            addTool.Click += addToolStripMenuItem_Click;
            // 
            // editTool
            // 
            editTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editTool.Image = (Image)resources.GetObject("editTool.Image");
            editTool.ImageTransparentColor = Color.Magenta;
            editTool.Name = "editTool";
            editTool.Size = new Size(31, 22);
            editTool.Text = "Edit";
            editTool.Click += editToolStripMenuItem_Click;
            // 
            // deleteTool
            // 
            deleteTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            deleteTool.Image = (Image)resources.GetObject("deleteTool.Image");
            deleteTool.ImageTransparentColor = Color.Magenta;
            deleteTool.Name = "deleteTool";
            deleteTool.Size = new Size(44, 22);
            deleteTool.Text = "Delete";
            deleteTool.Click += deleteToolStripMenuItem_Click;
            // 
            // saveTool
            // 
            saveTool.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveTool.Image = (Image)resources.GetObject("saveTool.Image");
            saveTool.ImageTransparentColor = Color.Magenta;
            saveTool.Name = "saveTool";
            saveTool.Size = new Size(35, 22);
            saveTool.Text = "Save";
            saveTool.Click += saveToolStripMenuItem_Click;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(dateFilterTo);
            filterPanel.Controls.Add(label3);
            filterPanel.Controls.Add(dateFilterFrom);
            filterPanel.Controls.Add(dateCheck);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(label2);
            filterPanel.Controls.Add(filterCategory);
            filterPanel.Controls.Add(label1);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 49);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(800, 82);
            filterPanel.TabIndex = 2;
            // 
            // dateFilterTo
            // 
            dateFilterTo.Enabled = false;
            dateFilterTo.Format = DateTimePickerFormat.Short;
            dateFilterTo.Location = new Point(331, 48);
            dateFilterTo.Name = "dateFilterTo";
            dateFilterTo.Size = new Size(200, 23);
            dateFilterTo.TabIndex = 7;
            dateFilterTo.ValueChanged += Filter_changed;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 52);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 6;
            label3.Text = "-";
            // 
            // dateFilterFrom
            // 
            dateFilterFrom.Enabled = false;
            dateFilterFrom.Format = DateTimePickerFormat.Short;
            dateFilterFrom.Location = new Point(107, 48);
            dateFilterFrom.Name = "dateFilterFrom";
            dateFilterFrom.Size = new Size(200, 23);
            dateFilterFrom.TabIndex = 5;
            dateFilterFrom.ValueChanged += Filter_changed;
            // 
            // dateCheck
            // 
            dateCheck.AutoSize = true;
            dateCheck.Location = new Point(12, 48);
            dateCheck.Name = "dateCheck";
            dateCheck.Size = new Size(89, 19);
            dateCheck.TabIndex = 4;
            dateCheck.Text = "Date Range:";
            dateCheck.UseVisualStyleBackColor = true;
            dateCheck.CheckedChanged += Filter_changed;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(266, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(167, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += Filter_changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 13);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Search:";
            // 
            // filterCategory
            // 
            filterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            filterCategory.FormattingEnabled = true;
            filterCategory.Location = new Point(76, 8);
            filterCategory.Name = "filterCategory";
            filterCategory.Size = new Size(121, 23);
            filterCategory.TabIndex = 1;
            filterCategory.SelectedIndexChanged += Filter_changed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Category:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 131);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 204);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // summaryPanel
            // 
            summaryPanel.Controls.Add(txtRemaining);
            summaryPanel.Controls.Add(numMonthBudget);
            summaryPanel.Controls.Add(label5);
            summaryPanel.Controls.Add(summaryTotal);
            summaryPanel.Dock = DockStyle.Bottom;
            summaryPanel.Location = new Point(0, 335);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(800, 93);
            summaryPanel.TabIndex = 5;
            // 
            // txtRemaining
            // 
            txtRemaining.AutoSize = true;
            txtRemaining.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemaining.Location = new Point(264, 45);
            txtRemaining.Name = "txtRemaining";
            txtRemaining.Size = new Size(209, 17);
            txtRemaining.TabIndex = 4;
            txtRemaining.Text = "Remaining this month: PHP 0.00";
            // 
            // numMonthBudget
            // 
            numMonthBudget.DecimalPlaces = 2;
            numMonthBudget.Location = new Point(116, 45);
            numMonthBudget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMonthBudget.Name = "numMonthBudget";
            numMonthBudget.Size = new Size(120, 23);
            numMonthBudget.TabIndex = 2;
            numMonthBudget.ValueChanged += numMonths_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 47);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 1;
            label5.Text = "Monthly Budget:";
            // 
            // summaryTotal
            // 
            summaryTotal.AutoSize = true;
            summaryTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryTotal.Location = new Point(10, 14);
            summaryTotal.Name = "summaryTotal";
            summaryTotal.Size = new Size(170, 17);
            summaryTotal.TabIndex = 0;
            summaryTotal.Text = "Shown: 0   Total: PHP 0.00";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusDisplay, statusRec, statusClock });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusDisplay
            // 
            statusDisplay.Name = "statusDisplay";
            statusDisplay.Size = new Size(659, 17);
            statusDisplay.Spring = true;
            statusDisplay.Text = "Ready.";
            statusDisplay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusRec
            // 
            statusRec.DisplayStyle = ToolStripItemDisplayStyle.Text;
            statusRec.Name = "statusRec";
            statusRec.Size = new Size(55, 17);
            statusRec.Text = "0 records";
            // 
            // statusClock
            // 
            statusClock.Name = "statusClock";
            statusClock.Size = new Size(71, 17);
            statusClock.Text = "00:00:00 AM";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(filterPanel);
            Controls.Add(summaryPanel);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMonthBudget).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton addTool;
        private ToolStripButton editTool;
        private ToolStripButton deleteTool;
        private ToolStripButton saveTool;
        private Panel filterPanel;
        private ComboBox filterCategory;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private DateTimePicker dateFilterFrom;
        private CheckBox dateCheck;
        private DateTimePicker dateFilterTo;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel summaryPanel;
        private StatusStrip statusStrip1;
        private Label summaryTotal;
        private Label txtRemaining;
        private Label label6;
        private NumericUpDown numMonthBudget;
        private Label label5;
        private ToolStripStatusLabel statusDisplay;
        private ToolStripStatusLabel statusRec;
        private ToolStripStatusLabel statusClock;
        private System.Windows.Forms.Timer timer1;
    }
}