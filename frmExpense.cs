using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class frmExpense : Form
    {
        private readonly Expense expense;
        public frmExpense(Expense? existing = null)
        {
            InitializeComponent();

            datePicker.MaxDate = DateTime.Today;
            CategoryList.Items.AddRange(new String[]
            {
                "Food", "Transportation", "Bills", "School", "Entertainment", "Others"
            });

            if (existing == null)
            {
                expense = new Expense();
                this.Text = "Add Expense";
                datePicker.Value = DateTime.Today;
                CategoryList.SelectedIndex = 0;
                cashRBtn.Checked = true;
            }
            else
            {
                expense = existing;
                this.Text = "Edit Expense";
                datePicker.Value = existing.Date > datePicker.MaxDate ? datePicker.MaxDate : existing.Date;
                txtDesc.Text = existing.Description;
                CategoryList.SelectedItem = existing.Category;
                amountUpDown.Value = existing.Amount;

                if (existing.PaymentMethod == "GCash") gcashRBtn.Checked = true;
                else if (existing.PaymentMethod == "Card") cardRBtn.Checked = true;
                else cashRBtn.Checked = true;

                recurringCheck.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;

            }
        }

        public Expense GetExpense() => expense;

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider1.Clear();
            

            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                errorProvider1.SetError(txtDesc, "Description cannot be empty.");
                isValid = false;
            }

            if (amountUpDown.Value <= 0)
            {
                errorProvider1.SetError(amountUpDown, "Amount must be greater than zero.");
                isValid = false;
            }

            return isValid;
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            expense.Date = datePicker.Value.Date;
            expense.Description = txtDesc.Text.Trim();
            expense.Category = CategoryList.Text;
            expense.Amount = amountUpDown.Value;

            if (gcashRBtn.Checked)
            {
                expense.PaymentMethod = "GCash";
            }
            else if (cardRBtn.Checked)
            {
                expense.PaymentMethod = "Card";
            }
            else
            {
                expense.PaymentMethod = "Cash";
            }

            expense.IsRecurring = recurringCheck.Checked;
            expense.Notes = txtNotes.Text.Trim();

            this.DialogResult = DialogResult.OK;
        }
    }
}
