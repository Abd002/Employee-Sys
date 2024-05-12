namespace Employee
{
    partial class Department
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
            this.components = new System.ComponentModel.Container();
            this.employeeDatabaseDataSet = new Employee.EmployeeDatabaseDataSet1();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Employee.EmployeeDatabaseDataSet1TableAdapters.departmentTableAdapter();
            this.tableAdapterManager = new Employee.EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.departmentTextBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.departmentComboBox = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDatabaseDataSet
            // 
            this.employeeDatabaseDataSet.DataSetName = "EmployeeDatabaseDataSet";
            this.employeeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.employeeDatabaseDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.emplyeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Employee.EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(33, 104);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(73, 36);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(33, 277);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(64, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // departmentTextBox1
            // 
            this.departmentTextBox1.AnimateReadOnly = false;
            this.departmentTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.departmentTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.departmentTextBox1.Depth = 0;
            this.departmentTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.departmentTextBox1.HideSelection = true;
            this.departmentTextBox1.LeadingIcon = null;
            this.departmentTextBox1.Location = new System.Drawing.Point(240, 277);
            this.departmentTextBox1.MaxLength = 32767;
            this.departmentTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.departmentTextBox1.Name = "departmentTextBox1";
            this.departmentTextBox1.PasswordChar = '\0';
            this.departmentTextBox1.PrefixSuffixText = null;
            this.departmentTextBox1.ReadOnly = false;
            this.departmentTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.departmentTextBox1.SelectedText = "";
            this.departmentTextBox1.SelectionLength = 0;
            this.departmentTextBox1.SelectionStart = 0;
            this.departmentTextBox1.ShortcutsEnabled = true;
            this.departmentTextBox1.Size = new System.Drawing.Size(250, 48);
            this.departmentTextBox1.TabIndex = 4;
            this.departmentTextBox1.TabStop = false;
            this.departmentTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departmentTextBox1.TrailingIcon = null;
            this.departmentTextBox1.UseSystemPasswordChar = false;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.AutoResize = false;
            this.departmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.departmentComboBox.Depth = 0;
            this.departmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.departmentComboBox.DropDownHeight = 174;
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.DropDownWidth = 121;
            this.departmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.IntegralHeight = false;
            this.departmentComboBox.ItemHeight = 43;
            this.departmentComboBox.Location = new System.Drawing.Point(240, 104);
            this.departmentComboBox.MaxDropDownItems = 4;
            this.departmentComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(250, 49);
            this.departmentComboBox.StartIndex = 0;
            this.departmentComboBox.TabIndex = 5;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 568);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.departmentTextBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeDatabaseDataSet1 employeeDatabaseDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private EmployeeDatabaseDataSet1TableAdapters.departmentTableAdapter departmentTableAdapter;
        private EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialComboBox departmentTextBox;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialTextBox2 departmentTextBox1;
        private MaterialSkin.Controls.MaterialComboBox departmentComboBox;
    }
}