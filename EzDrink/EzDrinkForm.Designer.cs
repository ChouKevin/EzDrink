namespace EzDrink
{
    partial class EzDrinkForm
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
            this._ezDrinkTabControl = new System.Windows.Forms.TabControl();
            this._orderSystemPage = new System.Windows.Forms.TabPage();
            this._orderSystemMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkDataView = new System.Windows.Forms.DataGridView();
            this._selectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._drinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderSystemMiddlePanel = new System.Windows.Forms.TableLayoutPanel();
            this._additionGroupBox = new System.Windows.Forms.GroupBox();
            this._drinkAdditionDataView = new System.Windows.Forms.DataGridView();
            this._drinkAdditionSelectButton = new EzDrink.NewDataGridViewButtonColumn();
            this._drinkAdditionalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkAdditionalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sugarIcePanel = new System.Windows.Forms.TableLayoutPanel();
            this._sugar = new System.Windows.Forms.GroupBox();
            this._sugarPanel = new System.Windows.Forms.TableLayoutPanel();
            this._normalSugarButton = new System.Windows.Forms.Button();
            this._halfSugarButton = new System.Windows.Forms.Button();
            this._lessSugarButton = new System.Windows.Forms.Button();
            this._noSugarButton = new System.Windows.Forms.Button();
            this._ice = new System.Windows.Forms.GroupBox();
            this._icePanel = new System.Windows.Forms.TableLayoutPanel();
            this._normalIceButton = new System.Windows.Forms.Button();
            this._hotButton = new System.Windows.Forms.Button();
            this._lessIceButton = new System.Windows.Forms.Button();
            this._noIceButton = new System.Windows.Forms.Button();
            this._orderSystemRightPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderGroupBox = new System.Windows.Forms.GroupBox();
            this._orderDataView = new System.Windows.Forms.DataGridView();
            this._orderDrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDrinkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDrinkSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDrinkIce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDrinkAdditional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._orderSystemTotalPricePanel = new System.Windows.Forms.TableLayoutPanel();
            this._checkOutButton = new System.Windows.Forms.Button();
            this._orderDrinkTotalPrice = new System.Windows.Forms.Label();
            this._backManage = new System.Windows.Forms.TabPage();
            this._backManageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._drinkListGroupBox = new System.Windows.Forms.GroupBox();
            this._manageDrinkListView = new System.Windows.Forms.DataGridView();
            this._deleteDrinkButton = new EzDrink.NewDataGridViewButtonColumn();
            this._drinkListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._drinkListPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionListGroupBox = new System.Windows.Forms.GroupBox();
            this._manageAdditionListView = new System.Windows.Forms.DataGridView();
            this._deleteAdditionButton = new EzDrink.NewDataGridViewButtonColumn();
            this._additionListNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._additionListPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._additionListManageGroupBox = new System.Windows.Forms.GroupBox();
            this._addAdditionListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._inputAdditionListFileButton = new System.Windows.Forms.Button();
            this._addAdditionListButton = new System.Windows.Forms.Button();
            this._addAdditionNameLabel = new System.Windows.Forms.Label();
            this._addAdditionNameTextBox = new System.Windows.Forms.TextBox();
            this._addAdditionPriceTextBox = new EzDrink.NumberOnlyTextBox();
            this._addAdditionPriceLabel = new System.Windows.Forms.Label();
            this._drinkListManageGroupBox = new System.Windows.Forms.GroupBox();
            this._addDrinkListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._inputDrinkListFileButton = new System.Windows.Forms.Button();
            this._addDrinkListButton = new System.Windows.Forms.Button();
            this._addDrinkNameLabel = new System.Windows.Forms.Label();
            this._addDrinkNameTextBox = new System.Windows.Forms.TextBox();
            this._addDrinkPriceTextBox = new EzDrink.NumberOnlyTextBox();
            this._addDrinkPriceLabel = new System.Windows.Forms.Label();
            this._historyTab = new System.Windows.Forms.TabPage();
            this._historyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._historyGroupBox = new System.Windows.Forms.GroupBox();
            this._historyDataGridView = new System.Windows.Forms.DataGridView();
            this._timeRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._priceRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recordTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._recordGroupBox = new System.Windows.Forms.GroupBox();
            this._recordDataGridView = new System.Windows.Forms.DataGridView();
            this._recordDrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recordPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recordSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recordTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recordAddition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._recordTotalPriceLabel = new System.Windows.Forms.Label();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._fileDialog = new System.Windows.Forms.OpenFileDialog();
            this._ezDrinkTabControl.SuspendLayout();
            this._orderSystemPage.SuspendLayout();
            this._orderSystemMainPanel.SuspendLayout();
            this._drinkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkDataView)).BeginInit();
            this._orderSystemMiddlePanel.SuspendLayout();
            this._additionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionDataView)).BeginInit();
            this._sugarIcePanel.SuspendLayout();
            this._sugar.SuspendLayout();
            this._sugarPanel.SuspendLayout();
            this._ice.SuspendLayout();
            this._icePanel.SuspendLayout();
            this._orderSystemRightPanel.SuspendLayout();
            this._orderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataView)).BeginInit();
            this._orderSystemTotalPricePanel.SuspendLayout();
            this._backManage.SuspendLayout();
            this._backManageTableLayoutPanel.SuspendLayout();
            this._drinkListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._manageDrinkListView)).BeginInit();
            this._additionListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._manageAdditionListView)).BeginInit();
            this._addItemTableLayoutPanel.SuspendLayout();
            this._additionListManageGroupBox.SuspendLayout();
            this._addAdditionListTableLayoutPanel.SuspendLayout();
            this._drinkListManageGroupBox.SuspendLayout();
            this._addDrinkListTableLayoutPanel.SuspendLayout();
            this._historyTab.SuspendLayout();
            this._historyTableLayoutPanel.SuspendLayout();
            this._historyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).BeginInit();
            this._recordTableLayoutPanel.SuspendLayout();
            this._recordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).BeginInit();
            this._menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ezDrinkTabControl
            // 
            this._ezDrinkTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ezDrinkTabControl.Controls.Add(this._orderSystemPage);
            this._ezDrinkTabControl.Controls.Add(this._backManage);
            this._ezDrinkTabControl.Controls.Add(this._historyTab);
            this._ezDrinkTabControl.Location = new System.Drawing.Point(0, 30);
            this._ezDrinkTabControl.Name = "_ezDrinkTabControl";
            this._ezDrinkTabControl.SelectedIndex = 0;
            this._ezDrinkTabControl.Size = new System.Drawing.Size(1112, 469);
            this._ezDrinkTabControl.TabIndex = 1;
            // 
            // _orderSystemPage
            // 
            this._orderSystemPage.Controls.Add(this._orderSystemMainPanel);
            this._orderSystemPage.Location = new System.Drawing.Point(4, 25);
            this._orderSystemPage.Name = "_orderSystemPage";
            this._orderSystemPage.Padding = new System.Windows.Forms.Padding(3);
            this._orderSystemPage.Size = new System.Drawing.Size(1104, 440);
            this._orderSystemPage.TabIndex = 0;
            this._orderSystemPage.Text = "點餐系統";
            this._orderSystemPage.UseVisualStyleBackColor = true;
            // 
            // _orderSystemMainPanel
            // 
            this._orderSystemMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderSystemMainPanel.AutoSize = true;
            this._orderSystemMainPanel.ColumnCount = 5;
            this._orderSystemMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._orderSystemMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this._orderSystemMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._orderSystemMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this._orderSystemMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this._orderSystemMainPanel.Controls.Add(this._drinkGroupBox, 0, 0);
            this._orderSystemMainPanel.Controls.Add(this._orderSystemMiddlePanel, 2, 0);
            this._orderSystemMainPanel.Controls.Add(this._orderSystemRightPanel, 4, 0);
            this._orderSystemMainPanel.Location = new System.Drawing.Point(0, 0);
            this._orderSystemMainPanel.Name = "_orderSystemMainPanel";
            this._orderSystemMainPanel.RowCount = 1;
            this._orderSystemMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._orderSystemMainPanel.Size = new System.Drawing.Size(1104, 440);
            this._orderSystemMainPanel.TabIndex = 0;
            // 
            // _drinkGroupBox
            // 
            this._drinkGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkGroupBox.Controls.Add(this._drinkDataView);
            this._drinkGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkGroupBox.Name = "_drinkGroupBox";
            this._drinkGroupBox.Size = new System.Drawing.Size(325, 434);
            this._drinkGroupBox.TabIndex = 0;
            this._drinkGroupBox.TabStop = false;
            this._drinkGroupBox.Text = "飲料";
            // 
            // _drinkDataView
            // 
            this._drinkDataView.AllowUserToAddRows = false;
            this._drinkDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._drinkDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this._drinkDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._selectButton,
            this._drinkName,
            this._drinkPrice});
            this._drinkDataView.Location = new System.Drawing.Point(3, 21);
            this._drinkDataView.Name = "_drinkDataView";
            this._drinkDataView.ReadOnly = true;
            this._drinkDataView.RowHeadersVisible = false;
            this._drinkDataView.RowTemplate.Height = 27;
            this._drinkDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._drinkDataView.Size = new System.Drawing.Size(317, 410);
            this._drinkDataView.TabIndex = 0;
            this._drinkDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkDataView);
            // 
            // _selectButton
            // 
            this._selectButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._selectButton.HeaderText = "";
            this._selectButton.Name = "_selectButton";
            this._selectButton.ReadOnly = true;
            this._selectButton.Text = "選擇";
            this._selectButton.UseColumnTextForButtonValue = true;
            this._selectButton.Width = 5;
            // 
            // _drinkName
            // 
            this._drinkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkName.HeaderText = "名稱";
            this._drinkName.Name = "_drinkName";
            this._drinkName.ReadOnly = true;
            // 
            // _drinkPrice
            // 
            this._drinkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkPrice.HeaderText = "價格";
            this._drinkPrice.Name = "_drinkPrice";
            this._drinkPrice.ReadOnly = true;
            // 
            // _orderSystemMiddlePanel
            // 
            this._orderSystemMiddlePanel.ColumnCount = 1;
            this._orderSystemMiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._orderSystemMiddlePanel.Controls.Add(this._additionGroupBox, 0, 0);
            this._orderSystemMiddlePanel.Controls.Add(this._sugarIcePanel, 0, 1);
            this._orderSystemMiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemMiddlePanel.Location = new System.Drawing.Point(345, 3);
            this._orderSystemMiddlePanel.Name = "_orderSystemMiddlePanel";
            this._orderSystemMiddlePanel.RowCount = 2;
            this._orderSystemMiddlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.99584F));
            this._orderSystemMiddlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.00416F));
            this._orderSystemMiddlePanel.Size = new System.Drawing.Size(325, 434);
            this._orderSystemMiddlePanel.TabIndex = 2;
            // 
            // _additionGroupBox
            // 
            this._additionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._additionGroupBox.Controls.Add(this._drinkAdditionDataView);
            this._additionGroupBox.Location = new System.Drawing.Point(3, 3);
            this._additionGroupBox.Name = "_additionGroupBox";
            this._additionGroupBox.Size = new System.Drawing.Size(319, 176);
            this._additionGroupBox.TabIndex = 2;
            this._additionGroupBox.TabStop = false;
            this._additionGroupBox.Text = "加料";
            // 
            // _drinkAdditionDataView
            // 
            this._drinkAdditionDataView.AllowUserToAddRows = false;
            this._drinkAdditionDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._drinkAdditionDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._drinkAdditionSelectButton,
            this._drinkAdditionalName,
            this._drinkAdditionalPrice});
            this._drinkAdditionDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkAdditionDataView.Location = new System.Drawing.Point(3, 21);
            this._drinkAdditionDataView.Name = "_drinkAdditionDataView";
            this._drinkAdditionDataView.ReadOnly = true;
            this._drinkAdditionDataView.RowHeadersVisible = false;
            this._drinkAdditionDataView.RowTemplate.Height = 27;
            this._drinkAdditionDataView.Size = new System.Drawing.Size(313, 152);
            this._drinkAdditionDataView.TabIndex = 0;
            this._drinkAdditionDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkDataView);
            // 
            // _drinkAdditionSelectButton
            // 
            this._drinkAdditionSelectButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._drinkAdditionSelectButton.HeaderText = "";
            this._drinkAdditionSelectButton.Name = "_drinkAdditionSelectButton";
            this._drinkAdditionSelectButton.ReadOnly = true;
            this._drinkAdditionSelectButton.Text = "選擇";
            this._drinkAdditionSelectButton.UseColumnTextForButtonValue = true;
            this._drinkAdditionSelectButton.Width = 5;
            // 
            // _drinkAdditionalName
            // 
            this._drinkAdditionalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkAdditionalName.HeaderText = "名稱";
            this._drinkAdditionalName.Name = "_drinkAdditionalName";
            this._drinkAdditionalName.ReadOnly = true;
            // 
            // _drinkAdditionalPrice
            // 
            this._drinkAdditionalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkAdditionalPrice.HeaderText = "價格";
            this._drinkAdditionalPrice.Name = "_drinkAdditionalPrice";
            this._drinkAdditionalPrice.ReadOnly = true;
            // 
            // _sugarIcePanel
            // 
            this._sugarIcePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sugarIcePanel.ColumnCount = 1;
            this._sugarIcePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarIcePanel.Controls.Add(this._sugar, 0, 0);
            this._sugarIcePanel.Controls.Add(this._ice, 0, 1);
            this._sugarIcePanel.Location = new System.Drawing.Point(3, 185);
            this._sugarIcePanel.Name = "_sugarIcePanel";
            this._sugarIcePanel.RowCount = 2;
            this._sugarIcePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarIcePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._sugarIcePanel.Size = new System.Drawing.Size(319, 246);
            this._sugarIcePanel.TabIndex = 3;
            // 
            // _sugar
            // 
            this._sugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sugar.Controls.Add(this._sugarPanel);
            this._sugar.Location = new System.Drawing.Point(3, 3);
            this._sugar.Name = "_sugar";
            this._sugar.Size = new System.Drawing.Size(313, 117);
            this._sugar.TabIndex = 0;
            this._sugar.TabStop = false;
            this._sugar.Text = "甜度";
            // 
            // _sugarPanel
            // 
            this._sugarPanel.ColumnCount = 3;
            this._sugarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this._sugarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._sugarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this._sugarPanel.Controls.Add(this._normalSugarButton, 0, 0);
            this._sugarPanel.Controls.Add(this._halfSugarButton, 2, 0);
            this._sugarPanel.Controls.Add(this._lessSugarButton, 0, 2);
            this._sugarPanel.Controls.Add(this._noSugarButton, 2, 2);
            this._sugarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sugarPanel.Location = new System.Drawing.Point(3, 21);
            this._sugarPanel.Name = "_sugarPanel";
            this._sugarPanel.RowCount = 3;
            this._sugarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this._sugarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._sugarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this._sugarPanel.Size = new System.Drawing.Size(307, 93);
            this._sugarPanel.TabIndex = 0;
            // 
            // _normalSugarButton
            // 
            this._normalSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._normalSugarButton.Location = new System.Drawing.Point(3, 3);
            this._normalSugarButton.Name = "_normalSugarButton";
            this._normalSugarButton.Size = new System.Drawing.Size(141, 34);
            this._normalSugarButton.TabIndex = 0;
            this._normalSugarButton.Text = "正常";
            this._normalSugarButton.UseVisualStyleBackColor = true;
            this._normalSugarButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _halfSugarButton
            // 
            this._halfSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._halfSugarButton.Location = new System.Drawing.Point(162, 3);
            this._halfSugarButton.Name = "_halfSugarButton";
            this._halfSugarButton.Size = new System.Drawing.Size(142, 34);
            this._halfSugarButton.TabIndex = 1;
            this._halfSugarButton.Text = "半糖";
            this._halfSugarButton.UseVisualStyleBackColor = true;
            this._halfSugarButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _lessSugarButton
            // 
            this._lessSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lessSugarButton.Location = new System.Drawing.Point(3, 54);
            this._lessSugarButton.Name = "_lessSugarButton";
            this._lessSugarButton.Size = new System.Drawing.Size(141, 36);
            this._lessSugarButton.TabIndex = 2;
            this._lessSugarButton.Text = "微糖";
            this._lessSugarButton.UseVisualStyleBackColor = true;
            this._lessSugarButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _noSugarButton
            // 
            this._noSugarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._noSugarButton.Location = new System.Drawing.Point(162, 54);
            this._noSugarButton.Name = "_noSugarButton";
            this._noSugarButton.Size = new System.Drawing.Size(142, 36);
            this._noSugarButton.TabIndex = 3;
            this._noSugarButton.Text = "無糖";
            this._noSugarButton.UseVisualStyleBackColor = true;
            this._noSugarButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _ice
            // 
            this._ice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ice.Controls.Add(this._icePanel);
            this._ice.Location = new System.Drawing.Point(3, 126);
            this._ice.Name = "_ice";
            this._ice.Size = new System.Drawing.Size(313, 117);
            this._ice.TabIndex = 1;
            this._ice.TabStop = false;
            this._ice.Text = "溫度";
            // 
            // _icePanel
            // 
            this._icePanel.ColumnCount = 3;
            this._icePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this._icePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this._icePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this._icePanel.Controls.Add(this._normalIceButton, 0, 0);
            this._icePanel.Controls.Add(this._hotButton, 2, 0);
            this._icePanel.Controls.Add(this._lessIceButton, 0, 2);
            this._icePanel.Controls.Add(this._noIceButton, 2, 2);
            this._icePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._icePanel.Location = new System.Drawing.Point(3, 21);
            this._icePanel.Name = "_icePanel";
            this._icePanel.RowCount = 3;
            this._icePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this._icePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this._icePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this._icePanel.Size = new System.Drawing.Size(307, 93);
            this._icePanel.TabIndex = 0;
            // 
            // _normalIceButton
            // 
            this._normalIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._normalIceButton.Location = new System.Drawing.Point(3, 3);
            this._normalIceButton.Name = "_normalIceButton";
            this._normalIceButton.Size = new System.Drawing.Size(141, 34);
            this._normalIceButton.TabIndex = 0;
            this._normalIceButton.Text = "正常";
            this._normalIceButton.UseVisualStyleBackColor = true;
            this._normalIceButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _hotButton
            // 
            this._hotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hotButton.Location = new System.Drawing.Point(162, 3);
            this._hotButton.Name = "_hotButton";
            this._hotButton.Size = new System.Drawing.Size(142, 34);
            this._hotButton.TabIndex = 1;
            this._hotButton.Text = "溫熱";
            this._hotButton.UseVisualStyleBackColor = true;
            this._hotButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _lessIceButton
            // 
            this._lessIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lessIceButton.Location = new System.Drawing.Point(3, 54);
            this._lessIceButton.Name = "_lessIceButton";
            this._lessIceButton.Size = new System.Drawing.Size(141, 36);
            this._lessIceButton.TabIndex = 2;
            this._lessIceButton.Text = "少冰";
            this._lessIceButton.UseVisualStyleBackColor = true;
            this._lessIceButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _noIceButton
            // 
            this._noIceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._noIceButton.Location = new System.Drawing.Point(162, 54);
            this._noIceButton.Name = "_noIceButton";
            this._noIceButton.Size = new System.Drawing.Size(142, 36);
            this._noIceButton.TabIndex = 3;
            this._noIceButton.Text = "去冰";
            this._noIceButton.UseVisualStyleBackColor = true;
            this._noIceButton.Click += new System.EventHandler(this.SetSugarIce);
            // 
            // _orderSystemRightPanel
            // 
            this._orderSystemRightPanel.ColumnCount = 1;
            this._orderSystemRightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._orderSystemRightPanel.Controls.Add(this._orderGroupBox, 0, 0);
            this._orderSystemRightPanel.Controls.Add(this._orderSystemTotalPricePanel, 0, 1);
            this._orderSystemRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemRightPanel.Location = new System.Drawing.Point(687, 3);
            this._orderSystemRightPanel.Name = "_orderSystemRightPanel";
            this._orderSystemRightPanel.RowCount = 2;
            this._orderSystemRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.50368F));
            this._orderSystemRightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49631F));
            this._orderSystemRightPanel.Size = new System.Drawing.Size(414, 434);
            this._orderSystemRightPanel.TabIndex = 3;
            // 
            // _orderGroupBox
            // 
            this._orderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderGroupBox.Controls.Add(this._orderDataView);
            this._orderGroupBox.Location = new System.Drawing.Point(3, 3);
            this._orderGroupBox.Name = "_orderGroupBox";
            this._orderGroupBox.Size = new System.Drawing.Size(408, 365);
            this._orderGroupBox.TabIndex = 1;
            this._orderGroupBox.TabStop = false;
            this._orderGroupBox.Text = "點單";
            // 
            // _orderDataView
            // 
            this._orderDataView.AllowUserToAddRows = false;
            this._orderDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._orderDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this._orderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._orderDrinkName,
            this._orderDrinkPrice,
            this._orderDrinkSugar,
            this._orderDrinkIce,
            this._orderDrinkAdditional,
            this._orderDeleteButton});
            this._orderDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderDataView.Location = new System.Drawing.Point(3, 21);
            this._orderDataView.Name = "_orderDataView";
            this._orderDataView.ReadOnly = true;
            this._orderDataView.RowHeadersVisible = false;
            this._orderDataView.RowTemplate.Height = 27;
            this._orderDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._orderDataView.Size = new System.Drawing.Size(402, 341);
            this._orderDataView.TabIndex = 0;
            this._orderDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataView);
            // 
            // _orderDrinkName
            // 
            this._orderDrinkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderDrinkName.HeaderText = "飲料名稱";
            this._orderDrinkName.Name = "_orderDrinkName";
            this._orderDrinkName.ReadOnly = true;
            this._orderDrinkName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderDrinkPrice
            // 
            this._orderDrinkPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderDrinkPrice.HeaderText = "價格";
            this._orderDrinkPrice.Name = "_orderDrinkPrice";
            this._orderDrinkPrice.ReadOnly = true;
            this._orderDrinkPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderDrinkSugar
            // 
            this._orderDrinkSugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderDrinkSugar.HeaderText = "甜度";
            this._orderDrinkSugar.Name = "_orderDrinkSugar";
            this._orderDrinkSugar.ReadOnly = true;
            this._orderDrinkSugar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderDrinkIce
            // 
            this._orderDrinkIce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderDrinkIce.HeaderText = "溫度";
            this._orderDrinkIce.Name = "_orderDrinkIce";
            this._orderDrinkIce.ReadOnly = true;
            this._orderDrinkIce.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderDrinkAdditional
            // 
            this._orderDrinkAdditional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._orderDrinkAdditional.HeaderText = "加料";
            this._orderDrinkAdditional.Name = "_orderDrinkAdditional";
            this._orderDrinkAdditional.ReadOnly = true;
            this._orderDrinkAdditional.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // _orderDeleteButton
            // 
            this._orderDeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._orderDeleteButton.HeaderText = "";
            this._orderDeleteButton.Name = "_orderDeleteButton";
            this._orderDeleteButton.ReadOnly = true;
            this._orderDeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._orderDeleteButton.Text = "刪除";
            this._orderDeleteButton.UseColumnTextForButtonValue = true;
            this._orderDeleteButton.Width = 5;
            // 
            // _orderSystemTotalPricePanel
            // 
            this._orderSystemTotalPricePanel.ColumnCount = 2;
            this._orderSystemTotalPricePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.98507F));
            this._orderSystemTotalPricePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.01493F));
            this._orderSystemTotalPricePanel.Controls.Add(this._checkOutButton, 1, 0);
            this._orderSystemTotalPricePanel.Controls.Add(this._orderDrinkTotalPrice, 0, 0);
            this._orderSystemTotalPricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderSystemTotalPricePanel.Location = new System.Drawing.Point(3, 374);
            this._orderSystemTotalPricePanel.Name = "_orderSystemTotalPricePanel";
            this._orderSystemTotalPricePanel.RowCount = 1;
            this._orderSystemTotalPricePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._orderSystemTotalPricePanel.Size = new System.Drawing.Size(408, 57);
            this._orderSystemTotalPricePanel.TabIndex = 2;
            // 
            // _checkOutButton
            // 
            this._checkOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._checkOutButton.Location = new System.Drawing.Point(259, 3);
            this._checkOutButton.Name = "_checkOutButton";
            this._checkOutButton.Size = new System.Drawing.Size(146, 51);
            this._checkOutButton.TabIndex = 0;
            this._checkOutButton.Text = "結帳";
            this._checkOutButton.UseVisualStyleBackColor = true;
            this._checkOutButton.Click += new System.EventHandler(this.CheckOut);
            // 
            // _orderDrinkTotalPrice
            // 
            this._orderDrinkTotalPrice.AutoSize = true;
            this._orderDrinkTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderDrinkTotalPrice.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderDrinkTotalPrice.Location = new System.Drawing.Point(3, 0);
            this._orderDrinkTotalPrice.Name = "_orderDrinkTotalPrice";
            this._orderDrinkTotalPrice.Size = new System.Drawing.Size(250, 57);
            this._orderDrinkTotalPrice.TabIndex = 1;
            this._orderDrinkTotalPrice.Text = "總價 : ";
            this._orderDrinkTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _backManage
            // 
            this._backManage.Controls.Add(this._backManageTableLayoutPanel);
            this._backManage.Location = new System.Drawing.Point(4, 25);
            this._backManage.Name = "_backManage";
            this._backManage.Padding = new System.Windows.Forms.Padding(3);
            this._backManage.Size = new System.Drawing.Size(1104, 440);
            this._backManage.TabIndex = 1;
            this._backManage.Text = "後台管理";
            this._backManage.UseVisualStyleBackColor = true;
            // 
            // _backManageTableLayoutPanel
            // 
            this._backManageTableLayoutPanel.ColumnCount = 5;
            this._backManageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this._backManageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.941748F));
            this._backManageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this._backManageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.941748F));
            this._backManageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this._backManageTableLayoutPanel.Controls.Add(this._drinkListGroupBox, 0, 0);
            this._backManageTableLayoutPanel.Controls.Add(this._additionListGroupBox, 4, 0);
            this._backManageTableLayoutPanel.Controls.Add(this._addItemTableLayoutPanel, 2, 0);
            this._backManageTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._backManageTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._backManageTableLayoutPanel.Name = "_backManageTableLayoutPanel";
            this._backManageTableLayoutPanel.RowCount = 1;
            this._backManageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._backManageTableLayoutPanel.Size = new System.Drawing.Size(1098, 434);
            this._backManageTableLayoutPanel.TabIndex = 0;
            // 
            // _drinkListGroupBox
            // 
            this._drinkListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._drinkListGroupBox.Controls.Add(this._manageDrinkListView);
            this._drinkListGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkListGroupBox.Name = "_drinkListGroupBox";
            this._drinkListGroupBox.Size = new System.Drawing.Size(345, 428);
            this._drinkListGroupBox.TabIndex = 1;
            this._drinkListGroupBox.TabStop = false;
            this._drinkListGroupBox.Text = "飲料清單";
            // 
            // _manageDrinkListView
            // 
            this._manageDrinkListView.AllowUserToAddRows = false;
            this._manageDrinkListView.AllowUserToDeleteRows = false;
            this._manageDrinkListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._manageDrinkListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._manageDrinkListView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this._manageDrinkListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._manageDrinkListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteDrinkButton,
            this._drinkListNameColumn,
            this._drinkListPriceColumn});
            this._manageDrinkListView.Location = new System.Drawing.Point(6, 18);
            this._manageDrinkListView.Name = "_manageDrinkListView";
            this._manageDrinkListView.RowHeadersVisible = false;
            this._manageDrinkListView.RowTemplate.Height = 27;
            this._manageDrinkListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._manageDrinkListView.Size = new System.Drawing.Size(337, 404);
            this._manageDrinkListView.TabIndex = 0;
            this._manageDrinkListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageListData);
            this._manageDrinkListView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifyListData);
            // 
            // _deleteDrinkButton
            // 
            this._deleteDrinkButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._deleteDrinkButton.HeaderText = "";
            this._deleteDrinkButton.Name = "_deleteDrinkButton";
            this._deleteDrinkButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._deleteDrinkButton.Text = "刪除";
            this._deleteDrinkButton.UseColumnTextForButtonValue = true;
            this._deleteDrinkButton.Width = 5;
            // 
            // _drinkListNameColumn
            // 
            this._drinkListNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkListNameColumn.HeaderText = "名稱";
            this._drinkListNameColumn.Name = "_drinkListNameColumn";
            // 
            // _drinkListPriceColumn
            // 
            this._drinkListPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._drinkListPriceColumn.HeaderText = "價格";
            this._drinkListPriceColumn.Name = "_drinkListPriceColumn";
            // 
            // _additionListGroupBox
            // 
            this._additionListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._additionListGroupBox.Controls.Add(this._manageAdditionListView);
            this._additionListGroupBox.Location = new System.Drawing.Point(747, 3);
            this._additionListGroupBox.Name = "_additionListGroupBox";
            this._additionListGroupBox.Size = new System.Drawing.Size(348, 428);
            this._additionListGroupBox.TabIndex = 3;
            this._additionListGroupBox.TabStop = false;
            this._additionListGroupBox.Text = "加料清單";
            // 
            // _manageAdditionListView
            // 
            this._manageAdditionListView.AllowUserToAddRows = false;
            this._manageAdditionListView.AllowUserToDeleteRows = false;
            this._manageAdditionListView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this._manageAdditionListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._manageAdditionListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteAdditionButton,
            this._additionListNameColumn,
            this._additionListPriceColumn});
            this._manageAdditionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._manageAdditionListView.Location = new System.Drawing.Point(3, 21);
            this._manageAdditionListView.Name = "_manageAdditionListView";
            this._manageAdditionListView.RowHeadersVisible = false;
            this._manageAdditionListView.RowTemplate.Height = 27;
            this._manageAdditionListView.Size = new System.Drawing.Size(342, 404);
            this._manageAdditionListView.TabIndex = 0;
            this._manageAdditionListView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageListData);
            this._manageAdditionListView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifyListData);
            // 
            // _deleteAdditionButton
            // 
            this._deleteAdditionButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._deleteAdditionButton.HeaderText = "";
            this._deleteAdditionButton.Name = "_deleteAdditionButton";
            this._deleteAdditionButton.Text = "刪除";
            this._deleteAdditionButton.UseColumnTextForButtonValue = true;
            this._deleteAdditionButton.Width = 5;
            // 
            // _additionListNameColumn
            // 
            this._additionListNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._additionListNameColumn.HeaderText = "名稱";
            this._additionListNameColumn.Name = "_additionListNameColumn";
            // 
            // _additionListPriceColumn
            // 
            this._additionListPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._additionListPriceColumn.HeaderText = "價格";
            this._additionListPriceColumn.Name = "_additionListPriceColumn";
            // 
            // _addItemTableLayoutPanel
            // 
            this._addItemTableLayoutPanel.ColumnCount = 1;
            this._addItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addItemTableLayoutPanel.Controls.Add(this._additionListManageGroupBox, 0, 1);
            this._addItemTableLayoutPanel.Controls.Add(this._drinkListManageGroupBox, 0, 0);
            this._addItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addItemTableLayoutPanel.Location = new System.Drawing.Point(375, 3);
            this._addItemTableLayoutPanel.Name = "_addItemTableLayoutPanel";
            this._addItemTableLayoutPanel.RowCount = 2;
            this._addItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addItemTableLayoutPanel.Size = new System.Drawing.Size(345, 428);
            this._addItemTableLayoutPanel.TabIndex = 4;
            // 
            // _additionListManageGroupBox
            // 
            this._additionListManageGroupBox.Controls.Add(this._addAdditionListTableLayoutPanel);
            this._additionListManageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._additionListManageGroupBox.Location = new System.Drawing.Point(3, 217);
            this._additionListManageGroupBox.Name = "_additionListManageGroupBox";
            this._additionListManageGroupBox.Size = new System.Drawing.Size(339, 208);
            this._additionListManageGroupBox.TabIndex = 1;
            this._additionListManageGroupBox.TabStop = false;
            this._additionListManageGroupBox.Text = "加料清單操作";
            // 
            // _addAdditionListTableLayoutPanel
            // 
            this._addAdditionListTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this._addAdditionListTableLayoutPanel.ColumnCount = 2;
            this._addAdditionListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addAdditionListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addAdditionListTableLayoutPanel.Controls.Add(this._inputAdditionListFileButton, 1, 0);
            this._addAdditionListTableLayoutPanel.Controls.Add(this._addAdditionListButton, 0, 0);
            this._addAdditionListTableLayoutPanel.Controls.Add(this._addAdditionNameLabel, 0, 2);
            this._addAdditionListTableLayoutPanel.Controls.Add(this._addAdditionNameTextBox, 1, 2);
            this._addAdditionListTableLayoutPanel.Controls.Add(this._addAdditionPriceTextBox, 1, 4);
            this._addAdditionListTableLayoutPanel.Controls.Add(this._addAdditionPriceLabel, 0, 4);
            this._addAdditionListTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addAdditionListTableLayoutPanel.Location = new System.Drawing.Point(3, 21);
            this._addAdditionListTableLayoutPanel.Name = "_addAdditionListTableLayoutPanel";
            this._addAdditionListTableLayoutPanel.RowCount = 5;
            this._addAdditionListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._addAdditionListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._addAdditionListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._addAdditionListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._addAdditionListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._addAdditionListTableLayoutPanel.Size = new System.Drawing.Size(333, 184);
            this._addAdditionListTableLayoutPanel.TabIndex = 1;
            // 
            // _inputAdditionListFileButton
            // 
            this._inputAdditionListFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._inputAdditionListFileButton.Location = new System.Drawing.Point(169, 3);
            this._inputAdditionListFileButton.Name = "_inputAdditionListFileButton";
            this._inputAdditionListFileButton.Size = new System.Drawing.Size(161, 49);
            this._inputAdditionListFileButton.TabIndex = 1;
            this._inputAdditionListFileButton.Text = "從檔案匯入";
            this._inputAdditionListFileButton.UseVisualStyleBackColor = true;
            this._inputAdditionListFileButton.Click += new System.EventHandler(this.InputFileData);
            // 
            // _addAdditionListButton
            // 
            this._addAdditionListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addAdditionListButton.Location = new System.Drawing.Point(3, 3);
            this._addAdditionListButton.Name = "_addAdditionListButton";
            this._addAdditionListButton.Size = new System.Drawing.Size(160, 49);
            this._addAdditionListButton.TabIndex = 0;
            this._addAdditionListButton.Text = "新增";
            this._addAdditionListButton.UseVisualStyleBackColor = true;
            this._addAdditionListButton.Click += new System.EventHandler(this.AddListButton);
            // 
            // _addAdditionNameLabel
            // 
            this._addAdditionNameLabel.AutoSize = true;
            this._addAdditionNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addAdditionNameLabel.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addAdditionNameLabel.Location = new System.Drawing.Point(3, 91);
            this._addAdditionNameLabel.Name = "_addAdditionNameLabel";
            this._addAdditionNameLabel.Size = new System.Drawing.Size(160, 36);
            this._addAdditionNameLabel.TabIndex = 2;
            this._addAdditionNameLabel.Text = "加料名稱 :";
            this._addAdditionNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _addAdditionNameTextBox
            // 
            this._addAdditionNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addAdditionNameTextBox.Location = new System.Drawing.Point(169, 94);
            this._addAdditionNameTextBox.Name = "_addAdditionNameTextBox";
            this._addAdditionNameTextBox.Size = new System.Drawing.Size(161, 25);
            this._addAdditionNameTextBox.TabIndex = 3;
            this._addAdditionNameTextBox.TextChanged += new System.EventHandler(this.InputItemName);
            // 
            // _addAdditionPriceTextBox
            // 
            this._addAdditionPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addAdditionPriceTextBox.Location = new System.Drawing.Point(169, 148);
            this._addAdditionPriceTextBox.Name = "_addAdditionPriceTextBox";
            this._addAdditionPriceTextBox.Size = new System.Drawing.Size(161, 25);
            this._addAdditionPriceTextBox.TabIndex = 4;
            this._addAdditionPriceTextBox.TextChanged += new System.EventHandler(this.InputItemPrice);
            // 
            // _addAdditionPriceLabel
            // 
            this._addAdditionPriceLabel.AutoSize = true;
            this._addAdditionPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addAdditionPriceLabel.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addAdditionPriceLabel.Location = new System.Drawing.Point(3, 145);
            this._addAdditionPriceLabel.Name = "_addAdditionPriceLabel";
            this._addAdditionPriceLabel.Size = new System.Drawing.Size(160, 39);
            this._addAdditionPriceLabel.TabIndex = 5;
            this._addAdditionPriceLabel.Text = "價格 :";
            this._addAdditionPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _drinkListManageGroupBox
            // 
            this._drinkListManageGroupBox.Controls.Add(this._addDrinkListTableLayoutPanel);
            this._drinkListManageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drinkListManageGroupBox.Location = new System.Drawing.Point(3, 3);
            this._drinkListManageGroupBox.Name = "_drinkListManageGroupBox";
            this._drinkListManageGroupBox.Size = new System.Drawing.Size(339, 208);
            this._drinkListManageGroupBox.TabIndex = 0;
            this._drinkListManageGroupBox.TabStop = false;
            this._drinkListManageGroupBox.Text = "飲料清單操作";
            // 
            // _addDrinkListTableLayoutPanel
            // 
            this._addDrinkListTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this._addDrinkListTableLayoutPanel.ColumnCount = 2;
            this._addDrinkListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addDrinkListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addDrinkListTableLayoutPanel.Controls.Add(this._inputDrinkListFileButton, 1, 0);
            this._addDrinkListTableLayoutPanel.Controls.Add(this._addDrinkListButton, 0, 0);
            this._addDrinkListTableLayoutPanel.Controls.Add(this._addDrinkNameLabel, 0, 2);
            this._addDrinkListTableLayoutPanel.Controls.Add(this._addDrinkNameTextBox, 1, 2);
            this._addDrinkListTableLayoutPanel.Controls.Add(this._addDrinkPriceTextBox, 1, 4);
            this._addDrinkListTableLayoutPanel.Controls.Add(this._addDrinkPriceLabel, 0, 4);
            this._addDrinkListTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addDrinkListTableLayoutPanel.Location = new System.Drawing.Point(3, 21);
            this._addDrinkListTableLayoutPanel.Name = "_addDrinkListTableLayoutPanel";
            this._addDrinkListTableLayoutPanel.RowCount = 5;
            this._addDrinkListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._addDrinkListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._addDrinkListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._addDrinkListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._addDrinkListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._addDrinkListTableLayoutPanel.Size = new System.Drawing.Size(333, 184);
            this._addDrinkListTableLayoutPanel.TabIndex = 0;
            // 
            // _inputDrinkListFileButton
            // 
            this._inputDrinkListFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._inputDrinkListFileButton.Location = new System.Drawing.Point(169, 3);
            this._inputDrinkListFileButton.Name = "_inputDrinkListFileButton";
            this._inputDrinkListFileButton.Size = new System.Drawing.Size(161, 49);
            this._inputDrinkListFileButton.TabIndex = 1;
            this._inputDrinkListFileButton.Text = "從檔案匯入";
            this._inputDrinkListFileButton.UseVisualStyleBackColor = true;
            this._inputDrinkListFileButton.Click += new System.EventHandler(this.InputFileData);
            // 
            // _addDrinkListButton
            // 
            this._addDrinkListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addDrinkListButton.Location = new System.Drawing.Point(3, 3);
            this._addDrinkListButton.Name = "_addDrinkListButton";
            this._addDrinkListButton.Size = new System.Drawing.Size(160, 49);
            this._addDrinkListButton.TabIndex = 0;
            this._addDrinkListButton.Text = "新增";
            this._addDrinkListButton.UseVisualStyleBackColor = true;
            this._addDrinkListButton.Click += new System.EventHandler(this.AddListButton);
            // 
            // _addDrinkNameLabel
            // 
            this._addDrinkNameLabel.AutoSize = true;
            this._addDrinkNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addDrinkNameLabel.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addDrinkNameLabel.Location = new System.Drawing.Point(3, 91);
            this._addDrinkNameLabel.Name = "_addDrinkNameLabel";
            this._addDrinkNameLabel.Size = new System.Drawing.Size(160, 36);
            this._addDrinkNameLabel.TabIndex = 2;
            this._addDrinkNameLabel.Text = "飲料名稱 :";
            this._addDrinkNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _addDrinkNameTextBox
            // 
            this._addDrinkNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addDrinkNameTextBox.Location = new System.Drawing.Point(169, 94);
            this._addDrinkNameTextBox.Name = "_addDrinkNameTextBox";
            this._addDrinkNameTextBox.Size = new System.Drawing.Size(161, 25);
            this._addDrinkNameTextBox.TabIndex = 3;
            this._addDrinkNameTextBox.TextChanged += new System.EventHandler(this.InputItemName);
            // 
            // _addDrinkPriceTextBox
            // 
            this._addDrinkPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addDrinkPriceTextBox.Location = new System.Drawing.Point(169, 148);
            this._addDrinkPriceTextBox.Name = "_addDrinkPriceTextBox";
            this._addDrinkPriceTextBox.Size = new System.Drawing.Size(161, 25);
            this._addDrinkPriceTextBox.TabIndex = 4;
            this._addDrinkPriceTextBox.TextChanged += new System.EventHandler(this.InputItemPrice);
            // 
            // _addDrinkPriceLabel
            // 
            this._addDrinkPriceLabel.AutoSize = true;
            this._addDrinkPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addDrinkPriceLabel.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addDrinkPriceLabel.Location = new System.Drawing.Point(3, 145);
            this._addDrinkPriceLabel.Name = "_addDrinkPriceLabel";
            this._addDrinkPriceLabel.Size = new System.Drawing.Size(160, 39);
            this._addDrinkPriceLabel.TabIndex = 5;
            this._addDrinkPriceLabel.Text = "價格 :";
            this._addDrinkPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _historyTab
            // 
            this._historyTab.Controls.Add(this._historyTableLayoutPanel);
            this._historyTab.Location = new System.Drawing.Point(4, 25);
            this._historyTab.Name = "_historyTab";
            this._historyTab.Padding = new System.Windows.Forms.Padding(3);
            this._historyTab.Size = new System.Drawing.Size(1104, 440);
            this._historyTab.TabIndex = 2;
            this._historyTab.Text = "歷史紀錄";
            this._historyTab.UseVisualStyleBackColor = true;
            // 
            // _historyTableLayoutPanel
            // 
            this._historyTableLayoutPanel.ColumnCount = 2;
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._historyTableLayoutPanel.Controls.Add(this._historyGroupBox, 0, 0);
            this._historyTableLayoutPanel.Controls.Add(this._recordTableLayoutPanel, 1, 0);
            this._historyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._historyTableLayoutPanel.Name = "_historyTableLayoutPanel";
            this._historyTableLayoutPanel.RowCount = 1;
            this._historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._historyTableLayoutPanel.Size = new System.Drawing.Size(1098, 434);
            this._historyTableLayoutPanel.TabIndex = 0;
            // 
            // _historyGroupBox
            // 
            this._historyGroupBox.Controls.Add(this._historyDataGridView);
            this._historyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyGroupBox.Location = new System.Drawing.Point(3, 3);
            this._historyGroupBox.Name = "_historyGroupBox";
            this._historyGroupBox.Size = new System.Drawing.Size(543, 428);
            this._historyGroupBox.TabIndex = 0;
            this._historyGroupBox.TabStop = false;
            this._historyGroupBox.Text = "歷史";
            // 
            // _historyDataGridView
            // 
            this._historyDataGridView.AllowUserToAddRows = false;
            this._historyDataGridView.AllowUserToDeleteRows = false;
            this._historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._timeRecord,
            this._priceRecord});
            this._historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._historyDataGridView.Location = new System.Drawing.Point(3, 21);
            this._historyDataGridView.Name = "_historyDataGridView";
            this._historyDataGridView.ReadOnly = true;
            this._historyDataGridView.RowHeadersVisible = false;
            this._historyDataGridView.RowTemplate.Height = 27;
            this._historyDataGridView.Size = new System.Drawing.Size(537, 404);
            this._historyDataGridView.TabIndex = 0;
            this._historyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(RecordUpData);
            // 
            // _timeRecord
            // 
            this._timeRecord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._timeRecord.HeaderText = "時間";
            this._timeRecord.Name = "_timeRecord";
            this._timeRecord.ReadOnly = true;
            // 
            // _priceRecord
            // 
            this._priceRecord.HeaderText = "總價";
            this._priceRecord.Name = "_priceRecord";
            this._priceRecord.ReadOnly = true;
            // 
            // _recordTableLayoutPanel
            // 
            this._recordTableLayoutPanel.ColumnCount = 1;
            this._recordTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._recordTableLayoutPanel.Controls.Add(this._recordGroupBox, 0, 0);
            this._recordTableLayoutPanel.Controls.Add(this._recordTotalPriceLabel, 0, 1);
            this._recordTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recordTableLayoutPanel.Location = new System.Drawing.Point(552, 3);
            this._recordTableLayoutPanel.Name = "_recordTableLayoutPanel";
            this._recordTableLayoutPanel.RowCount = 2;
            this._recordTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.17757F));
            this._recordTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.82243F));
            this._recordTableLayoutPanel.Size = new System.Drawing.Size(543, 428);
            this._recordTableLayoutPanel.TabIndex = 1;
            // 
            // _recordGroupBox
            // 
            this._recordGroupBox.Controls.Add(this._recordDataGridView);
            this._recordGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recordGroupBox.Location = new System.Drawing.Point(3, 3);
            this._recordGroupBox.Name = "_recordGroupBox";
            this._recordGroupBox.Size = new System.Drawing.Size(537, 349);
            this._recordGroupBox.TabIndex = 0;
            this._recordGroupBox.TabStop = false;
            this._recordGroupBox.Text = "詳細";
            // 
            // _recordDataGridView
            // 
            this._recordDataGridView.AllowUserToAddRows = false;
            this._recordDataGridView.AllowUserToDeleteRows = false;
            this._recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._recordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._recordDrinkName,
            this._recordPrice,
            this._recordSugar,
            this._recordTemperature,
            this._recordAddition});
            this._recordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recordDataGridView.Location = new System.Drawing.Point(3, 21);
            this._recordDataGridView.Name = "_recordDataGridView";
            this._recordDataGridView.ReadOnly = true;
            this._recordDataGridView.RowHeadersVisible = false;
            this._recordDataGridView.RowTemplate.Height = 27;
            this._recordDataGridView.Size = new System.Drawing.Size(531, 325);
            this._recordDataGridView.TabIndex = 0;
            // 
            // _recordDrinkName
            // 
            this._recordDrinkName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._recordDrinkName.HeaderText = "飲料名稱";
            this._recordDrinkName.Name = "_recordDrinkName";
            this._recordDrinkName.ReadOnly = true;
            // 
            // _recordPrice
            // 
            this._recordPrice.HeaderText = "價錢";
            this._recordPrice.Name = "_recordPrice";
            this._recordPrice.ReadOnly = true;
            // 
            // _recordSugar
            // 
            this._recordSugar.HeaderText = "甜度";
            this._recordSugar.Name = "_recordSugar";
            this._recordSugar.ReadOnly = true;
            // 
            // _recordTemperature
            // 
            this._recordTemperature.HeaderText = "溫度";
            this._recordTemperature.Name = "_recordTemperature";
            this._recordTemperature.ReadOnly = true;
            // 
            // _recordAddition
            // 
            this._recordAddition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._recordAddition.HeaderText = "加料";
            this._recordAddition.Name = "_recordAddition";
            this._recordAddition.ReadOnly = true;
            // 
            // _recordTotalPriceLabel
            // 
            this._recordTotalPriceLabel.AutoSize = true;
            this._recordTotalPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recordTotalPriceLabel.Font = new System.Drawing.Font("DFKai-SB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._recordTotalPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._recordTotalPriceLabel.Location = new System.Drawing.Point(3, 355);
            this._recordTotalPriceLabel.Name = "_recordTotalPriceLabel";
            this._recordTotalPriceLabel.Size = new System.Drawing.Size(537, 73);
            this._recordTotalPriceLabel.TabIndex = 1;
            this._recordTotalPriceLabel.Text = "總價:";
            this._recordTotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(1112, 27);
            this._menuStrip.TabIndex = 2;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this._exitToolStripMenuItem.Text = "Exit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ClickExitToolStripMenuItem);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this._helpToolStripMenuItem.Text = "Help";
            // 
            // _aboutToolStripMenuItem
            // 
            this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            this._aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this._aboutToolStripMenuItem.Text = "About";
            this._aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowMessage);
            // 
            // _fileDialog
            // 
            this._fileDialog.Filter = "txt files (*.txt)|*.txt";
            this._fileDialog.Title = "Select Txt";
            // 
            // EzDrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 498);
            this.Controls.Add(this._ezDrinkTabControl);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.MinimumSize = new System.Drawing.Size(1130, 545);
            this.Name = "EzDrinkForm";
            this.Text = "EzDrink";
            this._ezDrinkTabControl.ResumeLayout(false);
            this._orderSystemPage.ResumeLayout(false);
            this._orderSystemPage.PerformLayout();
            this._orderSystemMainPanel.ResumeLayout(false);
            this._drinkGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkDataView)).EndInit();
            this._orderSystemMiddlePanel.ResumeLayout(false);
            this._additionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._drinkAdditionDataView)).EndInit();
            this._sugarIcePanel.ResumeLayout(false);
            this._sugar.ResumeLayout(false);
            this._sugarPanel.ResumeLayout(false);
            this._ice.ResumeLayout(false);
            this._icePanel.ResumeLayout(false);
            this._orderSystemRightPanel.ResumeLayout(false);
            this._orderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._orderDataView)).EndInit();
            this._orderSystemTotalPricePanel.ResumeLayout(false);
            this._orderSystemTotalPricePanel.PerformLayout();
            this._backManage.ResumeLayout(false);
            this._backManageTableLayoutPanel.ResumeLayout(false);
            this._drinkListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._manageDrinkListView)).EndInit();
            this._additionListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._manageAdditionListView)).EndInit();
            this._addItemTableLayoutPanel.ResumeLayout(false);
            this._additionListManageGroupBox.ResumeLayout(false);
            this._addAdditionListTableLayoutPanel.ResumeLayout(false);
            this._addAdditionListTableLayoutPanel.PerformLayout();
            this._drinkListManageGroupBox.ResumeLayout(false);
            this._addDrinkListTableLayoutPanel.ResumeLayout(false);
            this._addDrinkListTableLayoutPanel.PerformLayout();
            this._historyTab.ResumeLayout(false);
            this._historyTableLayoutPanel.ResumeLayout(false);
            this._historyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._historyDataGridView)).EndInit();
            this._recordTableLayoutPanel.ResumeLayout(false);
            this._recordTableLayoutPanel.PerformLayout();
            this._recordGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).EndInit();
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// 讀取model中"飲料"和"加料"的種類，並顯示
        /// </summary>
        public void SetEzDrinkData()
        {
            _historyDataGridView.Rows.Clear();
            _manageAdditionListView.Rows.Clear();
            _manageDrinkListView.Rows.Clear();
            _drinkDataView.Rows.Clear();
            _drinkAdditionDataView.Rows.Clear();
            foreach (Drink drink in _drinkModel.GetDrinkData())
            {
                _manageDrinkListView.Rows.Add("", drink.Name, drink.Price);
                _drinkDataView.Rows.Add("", drink.Name, drink.Price);
            }
            foreach (DrinkAddition addition in _drinkModel.GetDrinkAddition())
            {
                _manageAdditionListView.Rows.Add("", addition.Name, addition.Price);
                _drinkAdditionDataView.Rows.Add("", addition.Name, addition.Price);
            }
            foreach (OrderList order in _drinkModel.GetHistoryList())
                _historyDataGridView.Rows.Add(order.Time, order.CountMoney());
            OrderUpData();
        }

        public void RecordDataUpData()
        {
            _recordDataGridView.Rows.Clear();
            foreach (OrderedDrink drink in _drinkModel.GetOrderList(_presentationModel.SelectedDrinkIndex).GetList())
                _recordDataGridView.Rows.Add(drink.GetDrinkName(), drink.GetTotalPrice(), drink.Sugar, drink.Temperature, drink.GetAdditionName());
        }

        private void SetTextBox()
        {
            this._addDrinkNameTextBox.Enabled = _presentationModel.InputDrink;
            this._addDrinkPriceTextBox.Enabled = _presentationModel.InputDrink;
            this._addAdditionPriceTextBox.Enabled = _presentationModel.InputAddition;
            this._addAdditionNameTextBox.Enabled = _presentationModel.InputAddition;
            if (!_presentationModel.InputAddition) this._addAdditionNameTextBox.Text = "";
            if (!_presentationModel.InputAddition) this._addAdditionPriceTextBox.Text = "0";
            if (!_presentationModel.InputDrink) this._addDrinkNameTextBox.Text = "";
            if (!_presentationModel.InputDrink) this._addDrinkPriceTextBox.Text = "0";
        }

        /// <summary>
        /// button的狀態
        /// </summary>
        private void SetButton()
        {
            this._normalSugarButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._halfSugarButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._lessSugarButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._noSugarButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._normalIceButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._hotButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._lessIceButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._noIceButton.Enabled = !_presentationModel.IsOrderedDrinkEmpty();
            this._checkOutButton.Enabled = _presentationModel.IsCheckOutOk();
            this._addDrinkListButton.Text = _presentationModel.ChangeButtonText(_addDrinkListButton.Text, _addDrinkListButton.Name);
            this._addAdditionListButton.Text = _presentationModel.ChangeButtonText(_addAdditionListButton.Text, _addAdditionListButton.Name);
            this._inputDrinkListFileButton.Text = _presentationModel.ChangeButtonText(_inputDrinkListFileButton.Text, _inputDrinkListFileButton.Name);
            this._inputAdditionListFileButton.Text = _presentationModel.ChangeButtonText(_inputAdditionListFileButton.Text, _inputAdditionListFileButton.Name);
            SetTextBox();
        }

        #endregion
        private System.Windows.Forms.TabControl _ezDrinkTabControl;
        private System.Windows.Forms.TabPage _orderSystemPage;
        private System.Windows.Forms.GroupBox _orderGroupBox;
        private System.Windows.Forms.DataGridView _orderDataView;
        private System.Windows.Forms.TableLayoutPanel _orderSystemMainPanel;
        private System.Windows.Forms.GroupBox _drinkGroupBox;
        private System.Windows.Forms.DataGridView _drinkDataView;
        private System.Windows.Forms.TableLayoutPanel _orderSystemMiddlePanel;
        private System.Windows.Forms.GroupBox _additionGroupBox;
        private System.Windows.Forms.DataGridView _drinkAdditionDataView;
        private System.Windows.Forms.TableLayoutPanel _sugarIcePanel;
        private System.Windows.Forms.GroupBox _sugar;
        private System.Windows.Forms.GroupBox _ice;
        private System.Windows.Forms.TableLayoutPanel _orderSystemRightPanel;
        private System.Windows.Forms.TableLayoutPanel _orderSystemTotalPricePanel;
        private System.Windows.Forms.TableLayoutPanel _sugarPanel;
        private System.Windows.Forms.TableLayoutPanel _icePanel;
        private System.Windows.Forms.Button _normalSugarButton;
        private System.Windows.Forms.Button _halfSugarButton;
        private System.Windows.Forms.Button _lessSugarButton;
        private System.Windows.Forms.Button _noSugarButton;
        private System.Windows.Forms.Button _normalIceButton;
        private System.Windows.Forms.Button _hotButton;
        private System.Windows.Forms.Button _lessIceButton;
        private System.Windows.Forms.Button _noIceButton;
        private System.Windows.Forms.Button _checkOutButton;
        private System.Windows.Forms.Label _orderDrinkTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderDrinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderDrinkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderDrinkSugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderDrinkIce;
        private System.Windows.Forms.DataGridViewTextBoxColumn _orderDrinkAdditional;
        private System.Windows.Forms.DataGridViewButtonColumn _orderDeleteButton;
        private System.Windows.Forms.DataGridViewButtonColumn _selectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkPrice;
        private NewDataGridViewButtonColumn _drinkAdditionSelectButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkAdditionalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkAdditionalPrice;
        private System.Windows.Forms.TabPage _backManage;
        private System.Windows.Forms.TableLayoutPanel _backManageTableLayoutPanel;
        private System.Windows.Forms.GroupBox _drinkListGroupBox;
        private System.Windows.Forms.DataGridView _manageDrinkListView;
        private System.Windows.Forms.GroupBox _additionListGroupBox;
        private System.Windows.Forms.DataGridView _manageAdditionListView;
        private System.Windows.Forms.TableLayoutPanel _addItemTableLayoutPanel;
        private System.Windows.Forms.GroupBox _additionListManageGroupBox;
        private System.Windows.Forms.GroupBox _drinkListManageGroupBox;
        private System.Windows.Forms.TableLayoutPanel _addDrinkListTableLayoutPanel;
        private System.Windows.Forms.Button _inputDrinkListFileButton;
        private System.Windows.Forms.Button _addDrinkListButton;
        private System.Windows.Forms.Label _addDrinkNameLabel;
        private System.Windows.Forms.TextBox _addDrinkNameTextBox;
        private NumberOnlyTextBox _addDrinkPriceTextBox;
        private System.Windows.Forms.Label _addDrinkPriceLabel;
        private System.Windows.Forms.TableLayoutPanel _addAdditionListTableLayoutPanel;
        private System.Windows.Forms.Button _inputAdditionListFileButton;
        private System.Windows.Forms.Button _addAdditionListButton;
        private System.Windows.Forms.Label _addAdditionNameLabel;
        private System.Windows.Forms.TextBox _addAdditionNameTextBox;
        private NumberOnlyTextBox _addAdditionPriceTextBox;
        private System.Windows.Forms.Label _addAdditionPriceLabel;
        private NewDataGridViewButtonColumn _deleteAdditionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionListNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _additionListPriceColumn;
        private NewDataGridViewButtonColumn _deleteDrinkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkListNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _drinkListPriceColumn;
        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog _fileDialog;
        private System.Windows.Forms.TabPage _historyTab;
        private System.Windows.Forms.TableLayoutPanel _historyTableLayoutPanel;
        private System.Windows.Forms.GroupBox _historyGroupBox;
        private System.Windows.Forms.DataGridView _historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timeRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn _priceRecord;
        private System.Windows.Forms.TableLayoutPanel _recordTableLayoutPanel;
        private System.Windows.Forms.GroupBox _recordGroupBox;
        private System.Windows.Forms.DataGridView _recordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recordDrinkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recordPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recordSugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recordTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn _recordAddition;
        private System.Windows.Forms.Label _recordTotalPriceLabel;
    }
}