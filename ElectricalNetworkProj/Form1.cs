using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ElectricalNetworkProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Database.Initialize();
                LoadBills();
                PopulateBillComboBox();
                PopulateMeterComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not initialize the database: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadBills(int? prioritizedMeterID = null)
        {
            DataTable table = new DataTable();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    if (prioritizedMeterID.HasValue)
                    {
                        command.CommandText = @"
                            SELECT BillID, MeterID, Rate, IssueDate, DueDate, KilowattHours, AmountOwed, AmountPaid
                            FROM Bills
                            ORDER BY CASE WHEN MeterID = @SelectedMeterID THEN 0 ELSE 1 END, BillID;";
                        command.Parameters.AddWithValue("@SelectedMeterID", prioritizedMeterID.Value);
                    }
                    else
                    {
                        command.CommandText = @"
                            SELECT BillID, MeterID, Rate, IssueDate, DueDate, KilowattHours, AmountOwed, AmountPaid
                            FROM Bills
                            ORDER BY BillID;";
                    }

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }

                dataGridViewBills.DataSource = table;
                ApplyBillRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message);
            }
        }

        private void ApplyBillRowColors()
        {
            foreach (DataGridViewRow row in dataGridViewBills.Rows)
            {
                double amountOwed;
                double amountPaid;
                DateTime dueDate;

                bool hasAmountOwed = double.TryParse(
                    Convert.ToString(row.Cells[amountOwedDataGridViewTextBoxColumn.Index].Value),
                    out amountOwed);
                bool hasAmountPaid = double.TryParse(
                    Convert.ToString(row.Cells[amountPaidDataGridViewTextBoxColumn.Index].Value),
                    out amountPaid);
                bool hasDueDate = DateTime.TryParse(
                    Convert.ToString(row.Cells[dueDateDataGridViewTextBoxColumn.Index].Value),
                    out dueDate);

                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
                row.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                row.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

                if (hasAmountOwed && hasAmountPaid && amountPaid >= amountOwed)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (hasAmountOwed && hasAmountPaid && hasDueDate &&
                         dueDate.Date < DateTime.Today && amountPaid < amountOwed)
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightCoral;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void PopulateBillComboBox()
        {
            object previousSelection = cmbBillIDs.SelectedItem;
            cmbBillIDs.Items.Clear();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(
                    "SELECT BillID FROM Bills ORDER BY BillID;",
                    connection))
                {
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbBillIDs.Items.Add(Convert.ToInt32(reader["BillID"]));
                        }
                    }
                }

                if (previousSelection != null && cmbBillIDs.Items.Contains(previousSelection))
                {
                    cmbBillIDs.SelectedItem = previousSelection;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating bill IDs: " + ex.Message);
            }
        }

        private void PopulateMeterComboBox()
        {
            object previousSelection = cmbMeterIDs.SelectedItem;
            cmbMeterIDs.Items.Clear();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(
                    "SELECT DISTINCT MeterID FROM Bills ORDER BY MeterID;",
                    connection))
                {
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMeterIDs.Items.Add(Convert.ToInt32(reader["MeterID"]));
                        }
                    }
                }

                if (previousSelection != null && cmbMeterIDs.Items.Contains(previousSelection))
                {
                    cmbMeterIDs.SelectedItem = previousSelection;
                }
                else
                {
                    lblOutstandingBalance.Text = "Outstanding balance: -";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating meter IDs: " + ex.Message);
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            int meterID;
            double kilowattHours;
            double rate;

            if (!int.TryParse(txtMeterID.Text, out meterID))
            {
                MessageBox.Show("Please enter an integer Meter ID.");
                return;
            }

            if (!double.TryParse(txtKilowattHours.Text, out kilowattHours))
            {
                MessageBox.Show("Enter valid kilowatt hours.");
                return;
            }

            if (!double.TryParse(txtRate.Text, out rate) || rate < 0)
            {
                MessageBox.Show("Enter a valid non-negative rate.");
                return;
            }

            double amountOwed = rate * kilowattHours;

            const string sql = @"
                INSERT INTO Bills
                    (MeterID, Rate, IssueDate, DueDate, KilowattHours, AmountOwed, AmountPaid)
                VALUES
                    (@MeterID, @Rate, @IssueDate, @DueDate, @KilowattHours, @AmountOwed, @AmountPaid);";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MeterID", meterID);
                    command.Parameters.AddWithValue("@Rate", rate);
                    command.Parameters.AddWithValue("@IssueDate", dtpIssueDate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@DueDate", dtpDueDate.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@KilowattHours", kilowattHours);
                    command.Parameters.AddWithValue("@AmountOwed", amountOwed);
                    command.Parameters.AddWithValue("@AmountPaid", 0.0);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) inserted.");
                }

                LoadBills();
                PopulateBillComboBox();
                PopulateMeterComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBillIDs.SelectedItem == null)
            {
                MessageBox.Show("Please select a BillID.");
                return;
            }

            double amountPaid;
            if (!double.TryParse(txtAmountPaid.Text, out amountPaid))
            {
                MessageBox.Show("Enter a valid amount paid.");
                return;
            }

            int selectedBillID = Convert.ToInt32(cmbBillIDs.SelectedItem);
            const string sql = "UPDATE Bills SET AmountPaid = @AmountPaid WHERE BillID = @BillID;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@AmountPaid", amountPaid);
                    command.Parameters.AddWithValue("@BillID", selectedBillID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) updated.");
                }

                LoadBills();
                PopulateMeterComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cmbBillIDs.SelectedItem == null)
            {
                MessageBox.Show("Please select a BillID.");
                return;
            }

            int selectedBillID = Convert.ToInt32(cmbBillIDs.SelectedItem);
            const string sql = @"
                SELECT MeterID, Rate, IssueDate, DueDate, KilowattHours, AmountPaid
                FROM Bills
                WHERE BillID = @BillID;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BillID", selectedBillID);
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMeterID.Text = reader["MeterID"].ToString();
                            txtKilowattHours.Text = reader["KilowattHours"].ToString();
                            txtRate.Text = reader["Rate"].ToString();
                            txtAmountPaid.Text = reader["AmountPaid"].ToString();

                            DateTime issueDate;
                            if (DateTime.TryParse(reader["IssueDate"].ToString(), out issueDate))
                            {
                                dtpIssueDate.Value = issueDate;
                            }

                            DateTime dueDate;
                            if (DateTime.TryParse(reader["DueDate"].ToString(), out dueDate))
                            {
                                dtpDueDate.Value = dueDate;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bill not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data: " + ex.Message);
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (cmbBillIDs.SelectedItem == null)
            {
                MessageBox.Show("Please select a BillID.");
                return;
            }

            int selectedBillID = Convert.ToInt32(cmbBillIDs.SelectedItem);

            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete Bill " + selectedBillID + "?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            const string sql = "DELETE FROM Bills WHERE BillID = @BillID;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BillID", selectedBillID);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Bill not found.");
                        return;
                    }
                }

                LoadBills();
                PopulateBillComboBox();
                PopulateMeterComboBox();
                txtMeterID.Clear();
                txtKilowattHours.Clear();
                txtRate.Text = "0.15";
                txtAmountPaid.Clear();

                MessageBox.Show(
                    "Bill " + selectedBillID + " was deleted.",
                    "Bill Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting bill: " + ex.Message);
            }
        }

        private void btnCalculateAmountOwed_Click(object sender, EventArgs e)
        {
            if (cmbMeterIDs.SelectedItem == null)
            {
                MessageBox.Show("Please select a Meter ID.");
                return;
            }

            int selectedMeterID = Convert.ToInt32(cmbMeterIDs.SelectedItem);
            const string sql = @"
                SELECT COALESCE(SUM(AmountOwed - AmountPaid), 0)
                FROM Bills
                WHERE MeterID = @MeterID;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Database.ConnectionString))
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MeterID", selectedMeterID);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    double outstandingBalance = result == null || result == DBNull.Value
                        ? 0.0
                        : Convert.ToDouble(result);

                    lblOutstandingBalance.Text =
                        "Outstanding balance: " + outstandingBalance.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating amount owed: " + ex.Message);
            }
        }

        private void btnShowMeterBills_Click(object sender, EventArgs e)
        {
            if (cmbMeterIDs.SelectedItem == null)
            {
                MessageBox.Show("Please select a Meter ID.");
                return;
            }

            int selectedMeterID = Convert.ToInt32(cmbMeterIDs.SelectedItem);
            LoadBills(selectedMeterID);
        }
    }
}
