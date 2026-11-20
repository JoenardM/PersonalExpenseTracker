using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PersonalExpenseTracker
{
    public partial class frmMain : Form
    {
        private readonly BindingList<Expense> expenses = new BindingList<Expense>();
        private string currentFilePath = "";
        private bool isModified = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(600, 400);

            filterCategory.Items.AddRange(new string[]
            {
                "All", "Food", "Transportation", "Bills", "School", "Entertainment", "Others"
            });
            filterCategory.SelectedIndex = 0;

            dateFilterFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateFilterTo.Value = DateTime.Today;
            dateFilterFrom.Enabled = false;
            dateFilterTo.Enabled = false;

            ShowClock();
            timer1.Start();

            statusDisplay.Text = "Ready.";
            ApplyFilter();
            UpdateTitle();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PromptSaveChanges())
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowClock();
        }

        private void ShowClock()
        {
            statusClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Filter_changed(object sender, EventArgs e)
        {
            dateFilterFrom.Enabled = dateCheck.Checked;
            dateFilterTo.Enabled = dateCheck.Checked;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string search = txtSearch.Text.Trim().ToLower();

            List <Expense> expenselist = expenses.ToList();

            if (search == "")
            {
                expenselist = expenses.ToList();
            }
            else
            {
                expenselist = expenses.Where(x => x.Description.ToLower().Contains(search)).ToList();
            }

            if (filterCategory.Text != "All" && filterCategory.Text != "")
            {
                expenselist = expenselist.Where(x => x.Category == filterCategory.Text).ToList();
            }

            if (dateCheck.Checked)
            {
                DateTime fromDate = dateFilterFrom.Value.Date;
                DateTime toDate = dateFilterTo.Value.Date;
                expenselist = expenselist.Where(x => x.Date >= fromDate && x.Date <= toDate).ToList();
            }

            expenselist = expenselist.OrderByDescending(x => x.Date).ToList();
            dataGridView1.DataSource = expenselist;

            if (dataGridView1.Columns["Id"] != null)
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
            if (dataGridView1.Columns["Notes"] != null)
            {
                dataGridView1.Columns["Notes"].Visible = false;
            }

            decimal totalAmount = expenselist.Sum(x => x.Amount);
            summaryTotal.Text = $"Shown: {expenselist.Count}   Total: PHP {totalAmount:N2}";

            if (expenses.Count == 1)
            {
                statusRec.Text = "1 record";
            }
            else
            {
                statusRec.Text = $"{expenses.Count} records";
            }
            UpdateRemaining();
        }

        private void numMonths_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemaining();
        }

        private void UpdateRemaining()
        {
            DateTime today = DateTime.Today;

            decimal spentMonth = expenses.Where (x => x.Date.Year == today.Year && x.Date.Month == today.Month).Sum(x => x.Amount);

            decimal remaining = numMonthBudget.Value - spentMonth;
            
            txtRemaining.Text = $"Remaining this month: PHP {remaining:N2}";

            if (remaining < 0)
            {
                txtRemaining.ForeColor = Color.Red;
            }
            else if (remaining == 0)
            {
                txtRemaining.ForeColor = Color.Black;
            }
            else
            {
                txtRemaining.ForeColor = Color.Green;
            }
        }

        private void UpdateTitle()
        {
            string name = "Untitled";

            if (currentFilePath != "")
            {
                name = Path.GetFileName(currentFilePath);
            }

            if (isModified)
            {
                this.Text = "Expense Tracker - " + name + "*";
            }
            else
            {
                this.Text = "Expense Tracker - " + name;
            }
        }

        private void MarkAsModified()
        {
            isModified = true;
            UpdateTitle();
        }

        private bool PromptSaveChanges()
        {
            if (!isModified)
            {
                return true;
            }

            DialogResult result = MessageBox.Show("You have unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                return SaveFile();
            }
            else if (result == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveChanges())
            {
                return;
            }

            expenses.Clear();
            currentFilePath = "";
            isModified = false;
            UpdateTitle();
            ApplyFilter();
            statusDisplay.Text = "New file started.";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveChanges())
            {
                return;
            }

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);

                expenses.Clear();
                if (loaded != null)
                {
                    foreach (Expense x in loaded) expenses.Add(x);
                }

                currentFilePath = dialog.FileName;
                isModified = false;
                ApplyFilter();
                UpdateTitle();
                statusDisplay.Text = "File opened.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SaveFile()
        {
            if (currentFilePath == "")
            {
                using SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                dialog.FileName = "expenses.json";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                return WriteToFile(dialog.FileName);
            }

            return WriteToFile(currentFilePath);

        }
        
        private bool WriteToFile(string path)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(expenses, options);
                File.WriteAllText(path, json);

                currentFilePath = path;
                isModified = false;
                UpdateTitle();

                string name = Path.GetFileName(path);
                statusDisplay.Text = $"Saved {expenses.Count} expense(s) to {name}.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Expense newExpense = form.GetExpense();

                    newExpense.Id = expenses.Count > 0 ? expenses.Max(x => x.Id) + 1 : 1;

                    expenses.Add(newExpense);
                    MarkAsModified();
                    ApplyFilter();
                    statusDisplay.Text = "Expense added.";
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }


            Expense selectedExpense = (Expense)dataGridView1.CurrentRow.DataBoundItem;


            using (frmExpense form = new frmExpense(selectedExpense))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MarkAsModified();
                    ApplyFilter();
                    statusDisplay.Text = "Expense updated.";
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }

            Expense selectedExpense = (Expense)dataGridView1.CurrentRow.DataBoundItem;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the expense '{selectedExpense.Description}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if (result == DialogResult.Yes)
            {
                expenses.Remove(selectedExpense);
                MarkAsModified();
                ApplyFilter();
                statusDisplay.Text = "Expense deleted.";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editToolStripMenuItem_Click(sender, e);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Amount" &&
                e.CellStyle != null)
            {
                e.CellStyle.Format = "N2";
            }

            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Date" &&
                e.CellStyle != null)
            {
                e.CellStyle.Format = "MM/dd/yyyy";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personal Expense Tracker\nCreated by: Joenard Magpali", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
