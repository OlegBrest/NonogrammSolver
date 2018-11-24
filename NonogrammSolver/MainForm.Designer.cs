namespace NonogrammSolver
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NonogrammSolverSplit = new System.Windows.Forms.SplitContainer();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.StartBttn = new System.Windows.Forms.Button();
            this.SendValuesBttn = new System.Windows.Forms.Button();
            this.CreateTabBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VerticalSize = new System.Windows.Forms.NumericUpDown();
            this.HorizontSize = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NonogrammSolverSplit)).BeginInit();
            this.NonogrammSolverSplit.Panel1.SuspendLayout();
            this.NonogrammSolverSplit.Panel2.SuspendLayout();
            this.NonogrammSolverSplit.SuspendLayout();
            this.TabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.ControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // NonogrammSolverSplit
            // 
            this.NonogrammSolverSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NonogrammSolverSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.NonogrammSolverSplit.IsSplitterFixed = true;
            this.NonogrammSolverSplit.Location = new System.Drawing.Point(0, 0);
            this.NonogrammSolverSplit.Name = "NonogrammSolverSplit";
            // 
            // NonogrammSolverSplit.Panel1
            // 
            this.NonogrammSolverSplit.Panel1.Controls.Add(this.TabPanel);
            // 
            // NonogrammSolverSplit.Panel2
            // 
            this.NonogrammSolverSplit.Panel2.Controls.Add(this.ControlsPanel);
            this.NonogrammSolverSplit.Size = new System.Drawing.Size(712, 516);
            this.NonogrammSolverSplit.SplitterDistance = 585;
            this.NonogrammSolverSplit.TabIndex = 0;
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.gridView);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Location = new System.Drawing.Point(0, 0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(585, 516);
            this.TabPanel.TabIndex = 0;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridView.Size = new System.Drawing.Size(585, 516);
            this.gridView.TabIndex = 0;
            this.gridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellValueChanged);
            this.gridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridView_ColumnHeaderMouseClick);
            this.gridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridView_RowHeaderMouseClick);
            this.gridView.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridView_RowHeaderCellChanged);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.DataTextBox);
            this.ControlsPanel.Controls.Add(this.StartBttn);
            this.ControlsPanel.Controls.Add(this.SendValuesBttn);
            this.ControlsPanel.Controls.Add(this.CreateTabBttn);
            this.ControlsPanel.Controls.Add(this.label2);
            this.ControlsPanel.Controls.Add(this.label1);
            this.ControlsPanel.Controls.Add(this.VerticalSize);
            this.ControlsPanel.Controls.Add(this.HorizontSize);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(123, 516);
            this.ControlsPanel.TabIndex = 0;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(3, 153);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(117, 124);
            this.DataTextBox.TabIndex = 5;
            this.DataTextBox.Visible = false;
            this.DataTextBox.VisibleChanged += new System.EventHandler(this.DataTextBox_VisibleChanged);
            // 
            // StartBttn
            // 
            this.StartBttn.Location = new System.Drawing.Point(4, 123);
            this.StartBttn.Name = "StartBttn";
            this.StartBttn.Size = new System.Drawing.Size(116, 23);
            this.StartBttn.TabIndex = 4;
            this.StartBttn.Text = "Solve this";
            this.StartBttn.UseVisualStyleBackColor = true;
            this.StartBttn.Click += new System.EventHandler(this.StartBttn_Click);
            // 
            // SendValuesBttn
            // 
            this.SendValuesBttn.Location = new System.Drawing.Point(4, 283);
            this.SendValuesBttn.Name = "SendValuesBttn";
            this.SendValuesBttn.Size = new System.Drawing.Size(116, 23);
            this.SendValuesBttn.TabIndex = 4;
            this.SendValuesBttn.Text = "Send Values";
            this.SendValuesBttn.UseVisualStyleBackColor = true;
            this.SendValuesBttn.Visible = false;
            this.SendValuesBttn.Click += new System.EventHandler(this.SendValuesBttn_Click);
            // 
            // CreateTabBttn
            // 
            this.CreateTabBttn.Location = new System.Drawing.Point(4, 94);
            this.CreateTabBttn.Name = "CreateTabBttn";
            this.CreateTabBttn.Size = new System.Drawing.Size(116, 23);
            this.CreateTabBttn.TabIndex = 4;
            this.CreateTabBttn.Text = "Create tab";
            this.CreateTabBttn.UseVisualStyleBackColor = true;
            this.CreateTabBttn.Click += new System.EventHandler(this.CreateTabBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows count";
            // 
            // VerticalSize
            // 
            this.VerticalSize.Location = new System.Drawing.Point(3, 67);
            this.VerticalSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VerticalSize.Name = "VerticalSize";
            this.VerticalSize.Size = new System.Drawing.Size(47, 20);
            this.VerticalSize.TabIndex = 2;
            this.VerticalSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VerticalSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HorizontSize
            // 
            this.HorizontSize.Location = new System.Drawing.Point(3, 25);
            this.HorizontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorizontSize.Name = "HorizontSize";
            this.HorizontSize.Size = new System.Drawing.Size(47, 20);
            this.HorizontSize.TabIndex = 2;
            this.HorizontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HorizontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 516);
            this.Controls.Add(this.NonogrammSolverSplit);
            this.Name = "MainForm";
            this.Text = "NonogrammSolver";
            this.NonogrammSolverSplit.Panel1.ResumeLayout(false);
            this.NonogrammSolverSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NonogrammSolverSplit)).EndInit();
            this.NonogrammSolverSplit.ResumeLayout(false);
            this.TabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer NonogrammSolverSplit;
        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Button StartBttn;
        private System.Windows.Forms.Button CreateTabBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown VerticalSize;
        private System.Windows.Forms.NumericUpDown HorizontSize;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Button SendValuesBttn;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

