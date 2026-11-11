using System.ComponentModel.Design.Serialization;

namespace AeroBase
{
    public partial class MainForm : Form
    {
        private readonly List<Drone> drones = new();
        private readonly List<Part> parts = new();
        public MainForm()
        {
            InitializeComponent();

            drones.Add(new Drone
            {
                Id = 1,
                Name = "Учебный №1",
                Model = "Мультироторный",
                Type = "Квадрокоптер",
                InventoryNumber = "UAV-001",
                Status = "Исправен"
            });
            drones.Add(new Drone
            {
                Id = 1,
                Name = "Учебный №2",
                Model = "Самолётный",
                Type = "Самолётный",
                InventoryNumber = "UAV-002",
                Status = "На ТО"
            });
            drones.Add(new Drone
            {
                Id = 1,
                Name = "Учебный №3",
                Model = "Мультироторный",
                Type = "Квадрокоптер",
                InventoryNumber = "UAV-003",
                Status = "Исправен"
            });
            drones.Add(new Drone
            {
                Id = 1,
                Name = "Учебный №4",
                Model = "Мультироторный",
                Type = "Квадрокоптер",
                InventoryNumber = "UAV-004",
                Status = "Исправен"
            });
            drones.Add(new Drone
            {
                Id = 1,
                Name = "Учебный №5",
                Model = "Мультироторный",
                Type = "Квадрокоптер",
                InventoryNumber = "UAV-005",
                Status = "Исправен"
            });
            RefreshTable();
        }



        private void RefreshTable()
        {
            dgvDrones.DataSource = null;
            dgvDrones.DataSource = drones;

            UpdateTotalDrones();
            UpdateReady();
            UpdateMaintenance();
        }

        private void UpdateTotalDrones()
        {
            lblCountTotal.Text =
                drones.Count.ToString();
        }

        private void UpdateReady()
        {
            lblCountReady.Text =
                drones.Where(drone => drone.Status == "Исправен").Count().ToString();
        }

        private void UpdateMaintenance()
        {
            lblCountMaintenance.Text =
                drones.Where(drone => drone.Status == "На ТО").Count().ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvDrones.RowTemplate.Height = 45;
            dgvDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDrones.ColumnHeadersHeight = 50;
            dgvDrones.BorderStyle = BorderStyle.None;
            int totalHeight = dgvDrones.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvDrones.Rows)
            {
                totalHeight += row.Height;
            }
            dgvDrones.Height = totalHeight;
            dgvDrones.ClearSelection();
        }

        private void btnAddDrone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtInventoryNumber.Text))
            {
                MessageBox.Show("Введите название и инвентарный номер!!");
                return;
            }
            if (!int.TryParse(txtId.Text, out int Id))
            {
                MessageBox.Show("Введите корректный айди!");
                return;
            }

            Drone newDrone = new()
            {
                Id = Id,
                Name = txtName.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Type = txtType.Text.Trim(),
                InventoryNumber = txtInventoryNumber.Text.Trim(),
                Status = txtStatus.Text.Trim(),
            };
            drones.Add(newDrone);
            RefreshTable();
            txtId.Clear(); txtName.Clear(); txtModel.Clear(); txtType.Clear(); txtInventoryNumber.Clear(); txtStatus.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Drone? selectedDrone =
        dgvDrones.CurrentRow?.DataBoundItem as Drone;

            if (selectedDrone == null)
            {
                MessageBox.Show("Выберите дрон!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Удалить выбранный дрон?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                drones.Remove(selectedDrone);
                RefreshTable();
            }
        }

        private void AddColoredRow(string name, string code, string type, string status)
        {
            int rowIndex = dgvDrones.Rows.Add(name, code, type, status);

            int lastCellIndex = dgvDrones.Columns.Count - 1;
            DataGridViewCell statusCell = dgvDrones.Rows[rowIndex].Cells[lastCellIndex];

            statusCell.Style.Font = new Font(dgvDrones.Font, FontStyle.Bold);

            string checkValue = status.ToLower();

            if (checkValue.Contains("исправен"))
            {
                statusCell.Style.ForeColor = Color.ForestGreen;
            }
            else if (checkValue.Contains("на то"))
            {
                statusCell.Style.ForeColor = Color.FromArgb(255, 192, 128);
            }
        }

        
    }
}
