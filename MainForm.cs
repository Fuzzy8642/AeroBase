namespace AeroBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dvgDrones.RowTemplate.Height = 45;
            dvgDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dvgDrones.ColumnHeadersHeight = 50;
            AddColoredRow("Учебный №1", "UAV-001", "Квадрокоптер", "Исправен");
            AddColoredRow("Учебный №2", "UAV-002", "Самолётный", "На ТО");
            AddColoredRow("Учебный №3", "UAV-003", "Квадрокоптер", "Исправен");
            dvgDrones.BorderStyle = BorderStyle.None;
            int totalHeight = dvgDrones.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dvgDrones.Rows)
            {
                totalHeight += row.Height;
            }
            dvgDrones.Height = totalHeight;
            dvgDrones.ClearSelection();
        }

        private void AddColoredRow(string name, string code, string type, string status)
        {
            int rowIndex = dvgDrones.Rows.Add(name, code, type, status);

            int lastCellIndex = dvgDrones.Columns.Count - 1;
            DataGridViewCell statusCell = dvgDrones.Rows[rowIndex].Cells[lastCellIndex];

            statusCell.Style.Font = new Font(dvgDrones.Font, FontStyle.Bold);

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
