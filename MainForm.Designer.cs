namespace AeroBase
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            btnRules = new Button();
            btnMaintenance = new Button();
            btnParts = new Button();
            btnDrones = new Button();
            btnOverview = new Button();
            lblLogo = new Label();
            panelMain = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtStatus = new TextBox();
            txtInventoryNumber = new TextBox();
            txtType = new TextBox();
            txtModel = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnDeleteDrone = new Button();
            lblChoose = new Label();
            txtSearch = new TextBox();
            lblList = new Label();
            dgvDrones = new DataGridView();
            panelMaintenance = new Panel();
            lblCountMaintenance = new Label();
            lblMaintenanceDrones = new Label();
            panelReady = new Panel();
            lblCountReady = new Label();
            lblReadyDrones = new Label();
            panelTotal = new Panel();
            lblCountTotal = new Label();
            lblTotalDrones = new Label();
            btnAddDrone = new Button();
            lblDescription = new Label();
            lblPageTitle = new Label();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).BeginInit();
            panelMaintenance.SuspendLayout();
            panelReady.SuspendLayout();
            panelTotal.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(24, 40, 64);
            panelSidebar.Controls.Add(btnRules);
            panelSidebar.Controls.Add(btnMaintenance);
            panelSidebar.Controls.Add(btnParts);
            panelSidebar.Controls.Add(btnDrones);
            panelSidebar.Controls.Add(btnOverview);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(210, 703);
            panelSidebar.TabIndex = 1;
            // 
            // btnRules
            // 
            btnRules.FlatAppearance.BorderSize = 0;
            btnRules.FlatStyle = FlatStyle.Flat;
            btnRules.ForeColor = SystemColors.InactiveCaption;
            btnRules.Location = new Point(20, 285);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(94, 42);
            btnRules.TabIndex = 5;
            btnRules.Text = "Правила";
            btnRules.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = SystemColors.InactiveCaption;
            btnMaintenance.Location = new Point(25, 237);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(125, 42);
            btnMaintenance.TabIndex = 4;
            btnMaintenance.Text = "Обслуживание";
            btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnParts
            // 
            btnParts.FlatAppearance.BorderSize = 0;
            btnParts.FlatStyle = FlatStyle.Flat;
            btnParts.ForeColor = SystemColors.InactiveCaption;
            btnParts.Location = new Point(20, 189);
            btnParts.Name = "btnParts";
            btnParts.Size = new Size(130, 42);
            btnParts.TabIndex = 3;
            btnParts.Text = "Комлекутющие";
            btnParts.UseVisualStyleBackColor = true;
            // 
            // btnDrones
            // 
            btnDrones.FlatAppearance.BorderSize = 0;
            btnDrones.FlatStyle = FlatStyle.Flat;
            btnDrones.ForeColor = SystemColors.InactiveCaption;
            btnDrones.Location = new Point(25, 141);
            btnDrones.Name = "btnDrones";
            btnDrones.Size = new Size(110, 42);
            btnDrones.TabIndex = 2;
            btnDrones.Text = "Реестр БПЛА";
            btnDrones.UseVisualStyleBackColor = true;
            // 
            // btnOverview
            // 
            btnOverview.FlatAppearance.BorderSize = 0;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.ForeColor = SystemColors.InactiveCaption;
            btnOverview.Location = new Point(12, 93);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(94, 42);
            btnOverview.TabIndex = 1;
            btnOverview.Text = "Обзор";
            btnOverview.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lblLogo.ForeColor = SystemColors.ButtonHighlight;
            lblLogo.Location = new Point(66, 19);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(117, 28);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "AeroBase";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 251);
            panelMain.Controls.Add(panel6);
            panelMain.Controls.Add(panelMaintenance);
            panelMain.Controls.Add(panelReady);
            panelMain.Controls.Add(panelTotal);
            panelMain.Controls.Add(btnAddDrone);
            panelMain.Controls.Add(lblDescription);
            panelMain.Controls.Add(lblPageTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(210, 0);
            panelMain.Margin = new Padding(20, 21, 22, 23);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(972, 703);
            panelMain.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(txtStatus);
            panel6.Controls.Add(txtInventoryNumber);
            panel6.Controls.Add(txtType);
            panel6.Controls.Add(txtModel);
            panel6.Controls.Add(txtName);
            panel6.Controls.Add(txtId);
            panel6.Controls.Add(btnDeleteDrone);
            panel6.Controls.Add(lblChoose);
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(lblList);
            panel6.Controls.Add(dgvDrones);
            panel6.Location = new Point(56, 257);
            panel6.Name = "panel6";
            panel6.Size = new Size(861, 434);
            panel6.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(712, 360);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 17;
            label6.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 360);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 16;
            label5.Text = "Инвентарный номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 353);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 15;
            label4.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 353);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 14;
            label3.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 353);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 13;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 353);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(712, 330);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 11;
            // 
            // txtInventoryNumber
            // 
            txtInventoryNumber.Location = new Point(571, 330);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(125, 27);
            txtInventoryNumber.TabIndex = 10;
            // 
            // txtType
            // 
            txtType.Location = new Point(451, 388);
            txtType.Name = "txtType";
            txtType.Size = new Size(125, 27);
            txtType.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(311, 388);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 388);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(16, 388);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // btnDeleteDrone
            // 
            btnDeleteDrone.BackColor = Color.FromArgb(255, 192, 192);
            btnDeleteDrone.FlatAppearance.BorderSize = 0;
            btnDeleteDrone.FlatStyle = FlatStyle.Flat;
            btnDeleteDrone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDrone.ForeColor = Color.Red;
            btnDeleteDrone.Location = new Point(741, 379);
            btnDeleteDrone.Name = "btnDeleteDrone";
            btnDeleteDrone.Size = new Size(117, 44);
            btnDeleteDrone.TabIndex = 5;
            btnDeleteDrone.Text = "Удалить";
            btnDeleteDrone.UseVisualStyleBackColor = false;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.ForeColor = SystemColors.ControlDarkDark;
            lblChoose.Location = new Point(33, 333);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(427, 20);
            lblChoose.TabIndex = 3;
            lblChoose.Text = "Выберите строку, чтобы редактировать или удалить запись.";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(664, 26);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по названию";
            txtSearch.Size = new Size(172, 28);
            txtSearch.TabIndex = 2;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblList.Location = new Point(38, 24);
            lblList.Name = "lblList";
            lblList.Size = new Size(193, 28);
            lblList.TabIndex = 1;
            lblList.Text = "Список Аппаратов";
            // 
            // dgvDrones
            // 
            dgvDrones.AllowUserToAddRows = false;
            dgvDrones.AllowUserToOrderColumns = true;
            dgvDrones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDrones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrones.EnableHeadersVisualStyles = false;
            dgvDrones.Location = new Point(33, 79);
            dgvDrones.Name = "dgvDrones";
            dgvDrones.ReadOnly = true;
            dgvDrones.RowHeadersVisible = false;
            dgvDrones.RowHeadersWidth = 51;
            dgvDrones.RowTemplate.Height = 40;
            dgvDrones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrones.Size = new Size(803, 206);
            dgvDrones.TabIndex = 0;
            // 
            // panelMaintenance
            // 
            panelMaintenance.BackColor = SystemColors.ButtonHighlight;
            panelMaintenance.Controls.Add(lblCountMaintenance);
            panelMaintenance.Controls.Add(lblMaintenanceDrones);
            panelMaintenance.Location = new Point(667, 106);
            panelMaintenance.Name = "panelMaintenance";
            panelMaintenance.Size = new Size(250, 125);
            panelMaintenance.TabIndex = 5;
            // 
            // lblCountMaintenance
            // 
            lblCountMaintenance.AutoSize = true;
            lblCountMaintenance.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCountMaintenance.ForeColor = Color.FromArgb(255, 192, 128);
            lblCountMaintenance.Location = new Point(17, 61);
            lblCountMaintenance.Name = "lblCountMaintenance";
            lblCountMaintenance.Size = new Size(46, 54);
            lblCountMaintenance.TabIndex = 1;
            lblCountMaintenance.Text = "2";
            // 
            // lblMaintenanceDrones
            // 
            lblMaintenanceDrones.AutoSize = true;
            lblMaintenanceDrones.ForeColor = SystemColors.ControlDarkDark;
            lblMaintenanceDrones.Location = new Point(17, 16);
            lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            lblMaintenanceDrones.Size = new Size(135, 20);
            lblMaintenanceDrones.TabIndex = 0;
            lblMaintenanceDrones.Text = "На обслуживании";
            // 
            // panelReady
            // 
            panelReady.BackColor = SystemColors.ButtonHighlight;
            panelReady.Controls.Add(lblCountReady);
            panelReady.Controls.Add(lblReadyDrones);
            panelReady.Location = new Point(357, 106);
            panelReady.Name = "panelReady";
            panelReady.Size = new Size(250, 125);
            panelReady.TabIndex = 4;
            // 
            // lblCountReady
            // 
            lblCountReady.AutoSize = true;
            lblCountReady.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCountReady.ForeColor = Color.ForestGreen;
            lblCountReady.Location = new Point(21, 61);
            lblCountReady.Name = "lblCountReady";
            lblCountReady.Size = new Size(46, 54);
            lblCountReady.TabIndex = 1;
            lblCountReady.Text = "3";
            // 
            // lblReadyDrones
            // 
            lblReadyDrones.AutoSize = true;
            lblReadyDrones.ForeColor = SystemColors.ControlDarkDark;
            lblReadyDrones.Location = new Point(21, 23);
            lblReadyDrones.Name = "lblReadyDrones";
            lblReadyDrones.Size = new Size(89, 20);
            lblReadyDrones.TabIndex = 0;
            lblReadyDrones.Text = "Исправные";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = SystemColors.ButtonHighlight;
            panelTotal.Controls.Add(lblCountTotal);
            panelTotal.Controls.Add(lblTotalDrones);
            panelTotal.Location = new Point(56, 106);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(250, 125);
            panelTotal.TabIndex = 3;
            // 
            // lblCountTotal
            // 
            lblCountTotal.AutoSize = true;
            lblCountTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCountTotal.Location = new Point(26, 61);
            lblCountTotal.Name = "lblCountTotal";
            lblCountTotal.Size = new Size(46, 54);
            lblCountTotal.TabIndex = 1;
            lblCountTotal.Text = "5";
            // 
            // lblTotalDrones
            // 
            lblTotalDrones.AutoSize = true;
            lblTotalDrones.ForeColor = SystemColors.ControlDarkDark;
            lblTotalDrones.Location = new Point(16, 24);
            lblTotalDrones.Name = "lblTotalDrones";
            lblTotalDrones.Size = new Size(92, 20);
            lblTotalDrones.TabIndex = 0;
            lblTotalDrones.Text = "Всего БПЛА";
            // 
            // btnAddDrone
            // 
            btnAddDrone.BackColor = Color.Blue;
            btnAddDrone.FlatAppearance.BorderSize = 0;
            btnAddDrone.FlatStyle = FlatStyle.Flat;
            btnAddDrone.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddDrone.ForeColor = SystemColors.ButtonHighlight;
            btnAddDrone.Location = new Point(768, 31);
            btnAddDrone.Name = "btnAddDrone";
            btnAddDrone.Size = new Size(170, 40);
            btnAddDrone.TabIndex = 2;
            btnAddDrone.Text = "+ Добавить БПЛА";
            btnAddDrone.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(36, 61);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(273, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Оборудование учебной лаборатории";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Arial Black", 14F);
            lblPageTitle.Location = new Point(36, 19);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(193, 33);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Реестр БПЛА";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1182, 703);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AeroBase - учёт БПЛА";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).EndInit();
            panelMaintenance.ResumeLayout(false);
            panelMaintenance.PerformLayout();
            panelReady.ResumeLayout(false);
            panelReady.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSidebar;
        private Panel panelMain;
        private Label lblLogo;
        private Button btnRules;
        private Button btnMaintenance;
        private Button btnParts;
        private Button btnDrones;
        private Button btnOverview;
        private Label lblDescription;
        private Label lblPageTitle;
        private Button btnAddDrone;
        private Panel panelMaintenance;
        private Panel panelReady;
        private Panel panelTotal;
        private Label lblTotalDrones;
        private Label lblMaintenanceDrones;
        private Label lblCountReady;
        private Label lblReadyDrones;
        private Label lblCountTotal;
        private Label lblCountMaintenance;
        private Panel panel6;
        private DataGridView dgvDrones;
        private TextBox txtSearch;
        private Label lblList;
        private Label lblChoose;
        private Button btnDeleteDrone;
        private TextBox txtStatus;
        private TextBox txtInventoryNumber;
        private TextBox txtType;
        private TextBox txtModel;
        private TextBox txtName;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
