using System.ComponentModel.Design.Serialization;
using Npgsql;

namespace AeroBase
{
    public partial class MainForm : Form
    {
        private List<Drone> drones = new();
        private readonly List<Part> parts = new();
        private DroneRepository repository;
        private string connectionString =
        "Host=localhost;" +
        "Port=5432;" +
        "Database=aerobase;" +
        "Username=postgres;" +
        "Password=80085";
        public MainForm()
        {
            InitializeComponent();

            repository = new DroneRepository(connectionString);
            RefreshTable();
        }



        private void RefreshTable()
        {
            try
            {
                drones = repository.GetAll();

                dgvDrones.DataSource = null;
                dgvDrones.DataSource = drones;

                if (dgvDrones.Columns["Id"] != null)
                    dgvDrones.Columns["Id"].Visible = false;

                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        private void UpdateStatistics()
        {
            lblCountTotal.Text = drones.Count.ToString();
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

            Drone newDrone = new()
            {
                Name = txtName.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Type = txtType.Text.Trim(),
                InventoryNumber = txtInventoryNumber.Text.Trim(),
                Status = txtStatus.Text.Trim(),
            };

            try
            {
                repository.Add(newDrone);
                RefreshTable();
                txtId.Clear(); txtName.Clear(); txtModel.Clear(); txtType.Clear(); txtInventoryNumber.Clear(); txtStatus.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message);
            }
        }

        private void btnDeleteDrone_Click(object sender, EventArgs e)
        {
            if (dgvDrones.CurrentRow == null)
            {
                MessageBox.Show("Выберите дрон!");
                return;
            }

            Drone selectedDrone =
                dgvDrones.CurrentRow.DataBoundItem as Drone;

            if (selectedDrone == null)
            {
                MessageBox.Show("Выберите дрон!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Удалить дрон «" + selectedDrone.Name + "»?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                bool deleted = repository.Delete(selectedDrone.Id);

                if (!deleted)
                    MessageBox.Show("Дрон уже отсутствует в базе.");

                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
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

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection =
                    new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Подключение успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text.Trim();
            List<Drone> found = new List<Drone>();

            foreach (Drone drone in drones)
            {
                if (drone.Name.IndexOf(
                    text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    found.Add(drone);
                }
            }

            dgvDrones.DataSource = null;
            dgvDrones.DataSource = found;
        }
    }
}
