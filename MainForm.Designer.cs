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
            btnTestConnection = new Button();
            panel6 = new Panel();
            btnSearch = new Button();
            btnEditDrone = new Button();
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
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(184, 527);
            panelSidebar.TabIndex = 1;
            // 
            // btnRules
            // 
            btnRules.FlatAppearance.BorderSize = 0;
            btnRules.FlatStyle = FlatStyle.Flat;
            btnRules.ForeColor = SystemColors.InactiveCaption;
            btnRules.Location = new Point(18, 214);
            btnRules.Margin = new Padding(3, 2, 3, 2);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(82, 32);
            btnRules.TabIndex = 5;
            btnRules.Text = "Правила";
            btnRules.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.ForeColor = SystemColors.InactiveCaption;
            btnMaintenance.Location = new Point(22, 178);
            btnMaintenance.Margin = new Padding(3, 2, 3, 2);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(109, 32);
            btnMaintenance.TabIndex = 4;
            btnMaintenance.Text = "Обслуживание";
            btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnParts
            // 
            btnParts.FlatAppearance.BorderSize = 0;
            btnParts.FlatStyle = FlatStyle.Flat;
            btnParts.ForeColor = SystemColors.InactiveCaption;
            btnParts.Location = new Point(18, 142);
            btnParts.Margin = new Padding(3, 2, 3, 2);
            btnParts.Name = "btnParts";
            btnParts.Size = new Size(114, 32);
            btnParts.TabIndex = 3;
            btnParts.Text = "Комлекутющие";
            btnParts.UseVisualStyleBackColor = true;
            // 
            // btnDrones
            // 
            btnDrones.FlatAppearance.BorderSize = 0;
            btnDrones.FlatStyle = FlatStyle.Flat;
            btnDrones.ForeColor = SystemColors.InactiveCaption;
            btnDrones.Location = new Point(22, 106);
            btnDrones.Margin = new Padding(3, 2, 3, 2);
            btnDrones.Name = "btnDrones";
            btnDrones.Size = new Size(96, 32);
            btnDrones.TabIndex = 2;
            btnDrones.Text = "Реестр БПЛА";
            btnDrones.UseVisualStyleBackColor = true;
            // 
            // btnOverview
            // 
            btnOverview.FlatAppearance.BorderSize = 0;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.ForeColor = SystemColors.InactiveCaption;
            btnOverview.Location = new Point(10, 70);
            btnOverview.Margin = new Padding(3, 2, 3, 2);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(82, 32);
            btnOverview.TabIndex = 1;
            btnOverview.Text = "Обзор";
            btnOverview.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lblLogo.ForeColor = SystemColors.ButtonHighlight;
            lblLogo.Location = new Point(58, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(95, 23);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "AeroBase";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(244, 247, 251);
            panelMain.Controls.Add(btnTestConnection);
            panelMain.Controls.Add(panel6);
            panelMain.Controls.Add(panelMaintenance);
            panelMain.Controls.Add(panelReady);
            panelMain.Controls.Add(panelTotal);
            panelMain.Controls.Add(btnAddDrone);
            panelMain.Controls.Add(lblDescription);
            panelMain.Controls.Add(lblPageTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(184, 0);
            panelMain.Margin = new Padding(18, 16, 19, 17);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(850, 527);
            panelMain.TabIndex = 2;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(348, 34);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(124, 23);
            btnTestConnection.TabIndex = 7;
            btnTestConnection.Text = "Проверить БД";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(btnSearch);
            panel6.Controls.Add(btnEditDrone);
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
            panel6.Location = new Point(49, 193);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(753, 326);
            panel6.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(472, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += buttonSearch_Click;
            // 
            // btnEditDrone
            // 
            btnEditDrone.BackColor = Color.FromArgb(192, 224, 255);
            btnEditDrone.FlatAppearance.BorderSize = 0;
            btnEditDrone.FlatStyle = FlatStyle.Flat;
            btnEditDrone.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEditDrone.ForeColor = Color.Blue;
            btnEditDrone.Location = new Point(535, 292);
            btnEditDrone.Name = "btnEditDrone";
            btnEditDrone.Size = new Size(102, 33);
            btnEditDrone.TabIndex = 18;
            btnEditDrone.Text = "Изменить";
            btnEditDrone.UseVisualStyleBackColor = false;
            btnEditDrone.Click += btnEditDrone_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(604, 274);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 17;
            label6.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 274);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 16;
            label5.Text = "Инвентарный номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 271);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 15;
            label4.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 271);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 14;
            label3.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 271);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 13;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 271);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(604, 248);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(110, 21);
            txtStatus.TabIndex = 11;
            // 
            // txtInventoryNumber
            // 
            txtInventoryNumber.Location = new Point(488, 248);
            txtInventoryNumber.Margin = new Padding(3, 2, 3, 2);
            txtInventoryNumber.Name = "txtInventoryNumber";
            txtInventoryNumber.Size = new Size(110, 21);
            txtInventoryNumber.TabIndex = 10;
            // 
            // txtType
            // 
            txtType.Location = new Point(372, 248);
            txtType.Margin = new Padding(3, 2, 3, 2);
            txtType.Name = "txtType";
            txtType.Size = new Size(110, 21);
            txtType.TabIndex = 9;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(256, 248);
            txtModel.Margin = new Padding(3, 2, 3, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(110, 21);
            txtModel.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 248);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 21);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 248);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 21);
            txtId.TabIndex = 6;
            // 
            // btnDeleteDrone
            // 
            btnDeleteDrone.BackColor = Color.FromArgb(255, 192, 192);
            btnDeleteDrone.FlatAppearance.BorderSize = 0;
            btnDeleteDrone.FlatStyle = FlatStyle.Flat;
            btnDeleteDrone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteDrone.ForeColor = Color.Red;
            btnDeleteDrone.Location = new Point(648, 290);
            btnDeleteDrone.Margin = new Padding(3, 2, 3, 2);
            btnDeleteDrone.Name = "btnDeleteDrone";
            btnDeleteDrone.Size = new Size(102, 33);
            btnDeleteDrone.TabIndex = 5;
            btnDeleteDrone.Text = "Удалить";
            btnDeleteDrone.UseVisualStyleBackColor = false;
            btnDeleteDrone.Click += btnDeleteDrone_Click;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.ForeColor = SystemColors.ControlDarkDark;
            lblChoose.Location = new Point(24, 215);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(399, 15);
            lblChoose.TabIndex = 3;
            lblChoose.Text = "Выберите строку, чтобы редактировать или удалить запись.";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(581, 20);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по названию";
            txtSearch.Size = new Size(151, 22);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblList.Location = new Point(33, 18);
            lblList.Name = "lblList";
            lblList.Size = new Size(168, 18);
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
            dgvDrones.Location = new Point(29, 59);
            dgvDrones.Margin = new Padding(3, 2, 3, 2);
            dgvDrones.Name = "dgvDrones";
            dgvDrones.ReadOnly = true;
            dgvDrones.RowHeadersVisible = false;
            dgvDrones.RowHeadersWidth = 51;
            dgvDrones.RowTemplate.Height = 40;
            dgvDrones.ScrollBars = ScrollBars.Vertical;
            dgvDrones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrones.Size = new Size(703, 154);
            dgvDrones.TabIndex = 0;
            dgvDrones.SelectionChanged += dgvDrones_SelectionChanged;
            // 
            // panelMaintenance
            // 
            panelMaintenance.BackColor = SystemColors.ButtonHighlight;
            panelMaintenance.Controls.Add(lblCountMaintenance);
            panelMaintenance.Controls.Add(lblMaintenanceDrones);
            panelMaintenance.Location = new Point(584, 80);
            panelMaintenance.Margin = new Padding(3, 2, 3, 2);
            panelMaintenance.Name = "panelMaintenance";
            panelMaintenance.Size = new Size(219, 94);
            panelMaintenance.TabIndex = 5;
            // 
            // lblCountMaintenance
            // 
            lblCountMaintenance.AutoSize = true;
            lblCountMaintenance.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCountMaintenance.ForeColor = Color.FromArgb(255, 192, 128);
            lblCountMaintenance.Location = new Point(15, 46);
            lblCountMaintenance.Name = "lblCountMaintenance";
            lblCountMaintenance.Size = new Size(34, 36);
            lblCountMaintenance.TabIndex = 1;
            lblCountMaintenance.Text = "2";
            // 
            // lblMaintenanceDrones
            // 
            lblMaintenanceDrones.AutoSize = true;
            lblMaintenanceDrones.ForeColor = SystemColors.ControlDarkDark;
            lblMaintenanceDrones.Location = new Point(15, 12);
            lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            lblMaintenanceDrones.Size = new Size(112, 15);
            lblMaintenanceDrones.TabIndex = 0;
            lblMaintenanceDrones.Text = "На обслуживании";
            // 
            // panelReady
            // 
            panelReady.BackColor = SystemColors.ButtonHighlight;
            panelReady.Controls.Add(lblCountReady);
            panelReady.Controls.Add(lblReadyDrones);
            panelReady.Location = new Point(312, 80);
            panelReady.Margin = new Padding(3, 2, 3, 2);
            panelReady.Name = "panelReady";
            panelReady.Size = new Size(219, 94);
            panelReady.TabIndex = 4;
            // 
            // lblCountReady
            // 
            lblCountReady.AutoSize = true;
            lblCountReady.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCountReady.ForeColor = Color.ForestGreen;
            lblCountReady.Location = new Point(18, 46);
            lblCountReady.Name = "lblCountReady";
            lblCountReady.Size = new Size(34, 36);
            lblCountReady.TabIndex = 1;
            lblCountReady.Text = "3";
            // 
            // lblReadyDrones
            // 
            lblReadyDrones.AutoSize = true;
            lblReadyDrones.ForeColor = SystemColors.ControlDarkDark;
            lblReadyDrones.Location = new Point(18, 17);
            lblReadyDrones.Name = "lblReadyDrones";
            lblReadyDrones.Size = new Size(70, 15);
            lblReadyDrones.TabIndex = 0;
            lblReadyDrones.Text = "Исправные";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = SystemColors.ButtonHighlight;
            panelTotal.Controls.Add(lblCountTotal);
            panelTotal.Controls.Add(lblTotalDrones);
            panelTotal.Location = new Point(49, 80);
            panelTotal.Margin = new Padding(3, 2, 3, 2);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(219, 94);
            panelTotal.TabIndex = 3;
            // 
            // lblCountTotal
            // 
            lblCountTotal.AutoSize = true;
            lblCountTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCountTotal.Location = new Point(23, 46);
            lblCountTotal.Name = "lblCountTotal";
            lblCountTotal.Size = new Size(34, 36);
            lblCountTotal.TabIndex = 1;
            lblCountTotal.Text = "5";
            // 
            // lblTotalDrones
            // 
            lblTotalDrones.AutoSize = true;
            lblTotalDrones.ForeColor = SystemColors.ControlDarkDark;
            lblTotalDrones.Location = new Point(14, 18);
            lblTotalDrones.Name = "lblTotalDrones";
            lblTotalDrones.Size = new Size(77, 15);
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
            btnAddDrone.Location = new Point(672, 23);
            btnAddDrone.Margin = new Padding(3, 2, 3, 2);
            btnAddDrone.Name = "btnAddDrone";
            btnAddDrone.Size = new Size(149, 30);
            btnAddDrone.TabIndex = 2;
            btnAddDrone.Text = "+ Добавить БПЛА";
            btnAddDrone.UseVisualStyleBackColor = false;
            btnAddDrone.Click += btnAddDrone_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.ControlDarkDark;
            lblDescription.Location = new Point(32, 46);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(231, 15);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Оборудование учебной лаборатории";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Arial Black", 14F);
            lblPageTitle.Location = new Point(32, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(155, 27);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Реестр БПЛА";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1034, 527);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(877, 497);
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
        private Button btnEditDrone;
        private Button btnTestConnection;
        private Button btnSearch;
    }
}
