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
                Id = 2,
                Name = "Учебный №2",
                Model = "Самолётный",
                Type = "Самолётный",
                InventoryNumber = "UAV-002",
                Status = "На ТО"
            });
            drones.Add(new Drone
            {
                Id = 3,
                Name = "Учебный №3",
                Model = "Мультироторный",
                Type = "Квадрокоптер",
                InventoryNumber = "UAV-003",
                Status = "Исправен"
            });
            drones.Add(new Drone
            {
                Id = 4,
                Name = "Учебный №4",
                Model = "Мультироторный",
                Type = "Квадрокоптер",
                InventoryNumber = "UAV-004",
                Status = "Исправен"
            });
            drones.Add(new Drone
            {
                Id = 5,
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
            string searchText = txtSearch.Text.Trim().ToLower();

            var filteredDrones = string.IsNullOrEmpty(searchText)
                ? drones
                : drones.Where(d => d.Name.ToLower().Contains(searchText)).ToList();

            dgvDrones.DataSource = null;
            dgvDrones.DataSource = filteredDrones;

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
            dgvDrones.ScrollBars = ScrollBars.Vertical;

            // Считаем высоту: шапка + высота 3 строк + небольшой запас на рамку (2-4 пикселя)
            int headerHeight = dgvDrones.ColumnHeadersVisible ? dgvDrones.ColumnHeadersHeight : 0;
            int rowHeight = dgvDrones.RowTemplate.Height;

            dgvDrones.Height = headerHeight + (rowHeight * 3) + 3;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void dgvDrones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow?.DataBoundItem is Drone selectedDrone)
            {
                txtId.Text = selectedDrone.Id.ToString();
                txtName.Text = selectedDrone.Name;
                txtModel.Text = selectedDrone.Model;
                txtType.Text = selectedDrone.Type;
                txtInventoryNumber.Text = selectedDrone.InventoryNumber;
                txtStatus.Text = selectedDrone.Status;
            }
        }

        private void btnEditDrone_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow?.DataBoundItem is not Drone selectedDrone)
            {
                MessageBox.Show("Выберите дрон из таблицы для редактирования!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtInventoryNumber.Text))
            {
                MessageBox.Show("Введите название и инвентарный номер!");
                return;
            }

            if (!int.TryParse(txtId.Text, out int newId))
            {
                MessageBox.Show("Введите корректный Id!");
                return;
            }

            // Обновляем свойства выбранного объекта
            selectedDrone.Id = newId;
            selectedDrone.Name = txtName.Text.Trim();
            selectedDrone.Model = txtModel.Text.Trim();
            selectedDrone.Type = txtType.Text.Trim();
            selectedDrone.InventoryNumber = txtInventoryNumber.Text.Trim();
            selectedDrone.Status = txtStatus.Text.Trim();

            RefreshTable();
            MessageBox.Show("Данные успешно обновлены!");
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

        private void btnDeleteDrone_Click(object sender, EventArgs e)
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
