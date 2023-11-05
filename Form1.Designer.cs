namespace Lab2ClientServer
{
    partial class Form1
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
            updateRecording = new Button();
            removeRecording = new Button();
            addRecording = new Button();
            tableData = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            modelName3 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            modelName2 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            modelName1 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            modelName = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            modelValue1Input = new TextBox();
            modelValue2Input = new TextBox();
            modelValue3Input = new TextBox();
            modelValue4Input = new TextBox();
            modelValue5Input = new TextBox();
            modelValue6Input = new TextBox();
            modelValue7Input = new TextBox();
            modelValue8Input = new TextBox();
            modelDate1Input = new DateTimePicker();

            label1 = new Label();
            tabs = new TabControl();
            ((System.ComponentModel.ISupportInitialize)tableData).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            modelName3.SuspendLayout();
            modelName2.SuspendLayout();
            modelName1.SuspendLayout();
            modelName.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabs.SuspendLayout();
            SuspendLayout();
            
            // 
            // updateRecording
            // 
            updateRecording.Dock = DockStyle.Fill;
            updateRecording.Location = new Point(3, 30);
            updateRecording.Margin = new Padding(3, 2, 3, 2);
            updateRecording.Name = "updateRecording";
            updateRecording.Size = new Size(332, 24);
            updateRecording.TabIndex = 1;
            updateRecording.Text = "UPDATE";
            updateRecording.UseVisualStyleBackColor = true;
            updateRecording.Click += UpdateInformation;
            // 
            // removeRecording
            // 
            removeRecording.Dock = DockStyle.Fill;
            removeRecording.Location = new Point(3, 58);
            removeRecording.Margin = new Padding(3, 2, 3, 2);
            removeRecording.Name = "removeRecording";
            removeRecording.Size = new Size(332, 26);
            removeRecording.TabIndex = 2;
            removeRecording.Text = "REMOVE";
            removeRecording.UseVisualStyleBackColor = true;
            removeRecording.Click += RemoveInformation;
            // 
            // addRecording
            // 
            addRecording.Dock = DockStyle.Fill;
            addRecording.Location = new Point(3, 2);
            addRecording.Margin = new Padding(3, 2, 3, 2);
            addRecording.Name = "addRecording";
            addRecording.Size = new Size(332, 24);
            addRecording.TabIndex = 0;
            addRecording.Text = "ADD";
            addRecording.UseVisualStyleBackColor = true;
            addRecording.Click += AddInformation;
            // 
            // tableData
            // 
            tableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableData.Dock = DockStyle.Fill;
            tableData.Location = new Point(353, 2);
            tableData.Margin = new Padding(3, 2, 3, 2);
            tableData.Name = "tableData";
            tableData.ReadOnly = true;
            tableData.RowHeadersWidth = 51;
            tableData.RowTemplate.Height = 29;
            tableData.Size = new Size(344, 456);
            tableData.TabIndex = 1;
            tableData.CellClick += GetRowIndex;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableData, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(700, 460);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tabs, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.Size = new Size(344, 456);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(updateRecording, 0, 1);
            tableLayoutPanel5.Controls.Add(removeRecording, 0, 2);
            tableLayoutPanel5.Controls.Add(addRecording, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 368);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(338, 86);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 42);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 1;
            label5.Text = "Name";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 40);
            label6.Name = "label6";
            label6.Size = new Size(94, 40);
            label6.TabIndex = 2;
            label6.Text = "Country parent";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // modelName3
            // 
            modelName3.Controls.Add(tableLayoutPanel8);
            modelName3.Location = new Point(4, 24);
            modelName3.Margin = new Padding(3, 2, 3, 2);
            modelName3.Name = "modelName3";
            modelName3.Padding = new Padding(3, 2, 3, 2);
            modelName3.Size = new Size(330, 334);
            modelName3.TabIndex = 3;
            modelName3.Text = "ModelName3";
            modelName3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 2);
            tableLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Size = new Size(324, 330);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // modelName2
            // 
            modelName2.Controls.Add(tableLayoutPanel7);
            modelName2.Location = new Point(4, 24);
            modelName2.Margin = new Padding(3, 2, 3, 2);
            modelName2.Name = "modelName2";
            modelName2.Padding = new Padding(3, 2, 3, 2);
            modelName2.Size = new Size(330, 334);
            modelName2.TabIndex = 2;
            modelName2.Text = "ModelName2";
            modelName2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 2);
            tableLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(324, 330);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // modelName1
            // 
            modelName1.Controls.Add(tableLayoutPanel4);
            modelName1.Location = new Point(4, 24);
            modelName1.Margin = new Padding(3, 2, 3, 2);
            modelName1.Name = "modelName1";
            modelName1.Padding = new Padding(3, 2, 3, 2);
            modelName1.Size = new Size(330, 334);
            modelName1.TabIndex = 1;
            modelName1.Text = "ModelName1";
            modelName1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 2);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(324, 330);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // modelName
            // 
            modelName.Controls.Add(tableLayoutPanel1);
            modelName.Location = new Point(4, 24);
            modelName.Margin = new Padding(3, 2, 3, 2);
            modelName.Name = "modelName";
            modelName.Padding = new Padding(3, 2, 3, 2);
            modelName.Size = new Size(330, 334);
            modelName.TabIndex = 0;
            modelName.Text = "ModelName";
            modelName.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(modelValue1Input, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(324, 330);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // modelValue1Input
            // 
            modelValue1Input.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            modelValue1Input.Location = new Point(165, 71);
            modelValue1Input.Margin = new Padding(3, 2, 3, 2);
            modelValue1Input.Name = "modelValue1Input";
            modelValue1Input.Size = new Size(156, 23);
            modelValue1Input.TabIndex = 3;
            // 
            // modelValue2Input
            // 
            modelValue2Input.Location = new Point(0, 0);
            modelValue2Input.Name = "modelValue2Input";
            modelValue2Input.Size = new Size(100, 23);
            modelValue2Input.TabIndex = 0;
            // 
            // modelValue3Input
            // 
            modelValue3Input.Location = new Point(0, 0);
            modelValue3Input.Name = "modelValue3Input";
            modelValue3Input.Size = new Size(100, 23);
            modelValue3Input.TabIndex = 0;
            // 
            // modelValue4Input
            // 
            modelValue4Input.Location = new Point(0, 0);
            modelValue4Input.Name = "modelValue4Input";
            modelValue4Input.Size = new Size(100, 23);
            modelValue4Input.TabIndex = 0;
            // 
            // modelValue5Input
            // 
            modelValue5Input.Location = new Point(0, 0);
            modelValue5Input.Name = "modelValue5Input";
            modelValue5Input.Size = new Size(100, 23);
            modelValue5Input.TabIndex = 0;
            // 
            // modelValue6Input
            // 
            modelValue6Input.Location = new Point(0, 0);
            modelValue6Input.Name = "modelValue6Input";
            modelValue6Input.Size = new Size(100, 23);
            modelValue6Input.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 75);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 1;
            label1.Text = "Value1";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabs
            // 
            tabs.Controls.Add(modelName);
            tabs.Controls.Add(modelName1);
            tabs.Controls.Add(modelName2);
            tabs.Controls.Add(modelName3);
            tabs.Dock = DockStyle.Fill;
            tabs.Location = new Point(3, 2);
            tabs.Margin = new Padding(3, 2, 3, 2);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(338, 362);
            tabs.TabIndex = 0;
            tabs.TabIndexChanged += ChangeTable;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 460);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Airflights";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tableData).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            modelName3.ResumeLayout(false);
            modelName2.ResumeLayout(false);
            modelName1.ResumeLayout(false);
            modelName.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView tableData;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addRecording;
        private Button updateRecording;
        private Button removeRecording;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel6;
        private TabControl tabs;
        private TabPage modelName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox modelValue1Input;
        private TextBox modelValue2Input;
        private TextBox modelValue3Input;
        private TextBox modelValue4Input;
        private TextBox modelValue5Input;
        private TextBox modelValue6Input;
        private TextBox modelValue7Input;
        private TextBox modelValue8Input;
        private DateTimePicker modelDate1Input;
        private TabPage modelName1;
        private TableLayoutPanel tableLayoutPanel4;
        private TabPage modelName2;
        private TableLayoutPanel tableLayoutPanel7;
        private TabPage modelName3;
        private TableLayoutPanel tableLayoutPanel8;
    }
}