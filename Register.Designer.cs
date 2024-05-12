namespace Employee
{
    partial class Register
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
            this.nationalIdLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fullNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.genderLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DOBLabel = new MaterialSkin.Controls.MaterialLabel();
            this.jobLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.salaryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nationalIdTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.fullNameTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.maleRadioBox = new MaterialSkin.Controls.MaterialRadioButton();
            this.femaleRadioBox = new MaterialSkin.Controls.MaterialRadioButton();
            this.DOBBicker = new System.Windows.Forms.DateTimePicker();
            this.jobComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.salaryUpDown = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.logInButton = new MaterialSkin.Controls.MaterialButton();
            this.employeeDatabaseDataSet = new Employee.EmployeeDatabaseDataSet1();
            this.emplyeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplyeeTableAdapter = new Employee.EmployeeDatabaseDataSet1TableAdapters.emplyeeTableAdapter();
            this.tableAdapterManager = new Employee.EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.salaryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplyeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nationalIdLabel
            // 
            this.nationalIdLabel.AutoSize = true;
            this.nationalIdLabel.Depth = 0;
            this.nationalIdLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nationalIdLabel.Location = new System.Drawing.Point(147, 115);
            this.nationalIdLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nationalIdLabel.Name = "nationalIdLabel";
            this.nationalIdLabel.Size = new System.Drawing.Size(84, 19);
            this.nationalIdLabel.TabIndex = 0;
            this.nationalIdLabel.Text = "National ID ";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Depth = 0;
            this.fullNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fullNameLabel.Location = new System.Drawing.Point(147, 177);
            this.fullNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(73, 19);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Depth = 0;
            this.genderLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.genderLabel.Location = new System.Drawing.Point(147, 243);
            this.genderLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(51, 19);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender";
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Depth = 0;
            this.DOBLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DOBLabel.Location = new System.Drawing.Point(147, 291);
            this.DOBLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(92, 19);
            this.DOBLabel.TabIndex = 3;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Depth = 0;
            this.jobLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.jobLabel.Location = new System.Drawing.Point(147, 347);
            this.jobLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(28, 19);
            this.jobLabel.TabIndex = 4;
            this.jobLabel.Text = "Job";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(147, 405);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 19);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Depth = 0;
            this.salaryLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.salaryLabel.Location = new System.Drawing.Point(147, 467);
            this.salaryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(46, 19);
            this.salaryLabel.TabIndex = 6;
            this.salaryLabel.Text = "Salary";
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.AnimateReadOnly = false;
            this.nationalIdTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nationalIdTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nationalIdTextBox.Depth = 0;
            this.nationalIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nationalIdTextBox.HideSelection = true;
            this.nationalIdTextBox.LeadingIcon = null;
            this.nationalIdTextBox.Location = new System.Drawing.Point(283, 99);
            this.nationalIdTextBox.MaxLength = 32767;
            this.nationalIdTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.PasswordChar = '\0';
            this.nationalIdTextBox.PrefixSuffixText = null;
            this.nationalIdTextBox.ReadOnly = false;
            this.nationalIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nationalIdTextBox.SelectedText = "";
            this.nationalIdTextBox.SelectionLength = 0;
            this.nationalIdTextBox.SelectionStart = 0;
            this.nationalIdTextBox.ShortcutsEnabled = true;
            this.nationalIdTextBox.Size = new System.Drawing.Size(250, 48);
            this.nationalIdTextBox.TabIndex = 7;
            this.nationalIdTextBox.TabStop = false;
            this.nationalIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nationalIdTextBox.TrailingIcon = null;
            this.nationalIdTextBox.UseSystemPasswordChar = false;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.AnimateReadOnly = false;
            this.fullNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fullNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fullNameTextBox.Depth = 0;
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fullNameTextBox.HideSelection = true;
            this.fullNameTextBox.LeadingIcon = null;
            this.fullNameTextBox.Location = new System.Drawing.Point(283, 162);
            this.fullNameTextBox.MaxLength = 32767;
            this.fullNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.PasswordChar = '\0';
            this.fullNameTextBox.PrefixSuffixText = null;
            this.fullNameTextBox.ReadOnly = false;
            this.fullNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fullNameTextBox.SelectedText = "";
            this.fullNameTextBox.SelectionLength = 0;
            this.fullNameTextBox.SelectionStart = 0;
            this.fullNameTextBox.ShortcutsEnabled = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(250, 48);
            this.fullNameTextBox.TabIndex = 8;
            this.fullNameTextBox.TabStop = false;
            this.fullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fullNameTextBox.TrailingIcon = null;
            this.fullNameTextBox.UseSystemPasswordChar = false;
            // 
            // maleRadioBox
            // 
            this.maleRadioBox.AutoSize = true;
            this.maleRadioBox.Depth = 0;
            this.maleRadioBox.Location = new System.Drawing.Point(283, 233);
            this.maleRadioBox.Margin = new System.Windows.Forms.Padding(0);
            this.maleRadioBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maleRadioBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.maleRadioBox.Name = "maleRadioBox";
            this.maleRadioBox.Ripple = true;
            this.maleRadioBox.Size = new System.Drawing.Size(70, 37);
            this.maleRadioBox.TabIndex = 9;
            this.maleRadioBox.TabStop = true;
            this.maleRadioBox.Text = "Male";
            this.maleRadioBox.UseVisualStyleBackColor = true;
            // 
            // femaleRadioBox
            // 
            this.femaleRadioBox.AutoSize = true;
            this.femaleRadioBox.Depth = 0;
            this.femaleRadioBox.Location = new System.Drawing.Point(446, 233);
            this.femaleRadioBox.Margin = new System.Windows.Forms.Padding(0);
            this.femaleRadioBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.femaleRadioBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.femaleRadioBox.Name = "femaleRadioBox";
            this.femaleRadioBox.Ripple = true;
            this.femaleRadioBox.Size = new System.Drawing.Size(87, 37);
            this.femaleRadioBox.TabIndex = 10;
            this.femaleRadioBox.TabStop = true;
            this.femaleRadioBox.Text = "Female";
            this.femaleRadioBox.UseVisualStyleBackColor = true;
            // 
            // DOBBicker
            // 
            this.DOBBicker.Location = new System.Drawing.Point(284, 291);
            this.DOBBicker.Name = "DOBBicker";
            this.DOBBicker.Size = new System.Drawing.Size(249, 20);
            this.DOBBicker.TabIndex = 11;
            // 
            // jobComboBox
            // 
            this.jobComboBox.AutoResize = false;
            this.jobComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.jobComboBox.Depth = 0;
            this.jobComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.jobComboBox.DropDownHeight = 174;
            this.jobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobComboBox.DropDownWidth = 121;
            this.jobComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.jobComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.IntegralHeight = false;
            this.jobComboBox.ItemHeight = 43;
            this.jobComboBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.jobComboBox.Location = new System.Drawing.Point(284, 331);
            this.jobComboBox.MaxDropDownItems = 4;
            this.jobComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(249, 49);
            this.jobComboBox.StartIndex = 0;
            this.jobComboBox.TabIndex = 12;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.HideSelection = true;
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(283, 396);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PrefixSuffixText = null;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(250, 48);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // salaryUpDown
            // 
            this.salaryUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryUpDown.Location = new System.Drawing.Point(284, 466);
            this.salaryUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.salaryUpDown.Name = "salaryUpDown";
            this.salaryUpDown.Size = new System.Drawing.Size(249, 20);
            this.salaryUpDown.TabIndex = 14;
            this.salaryUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // submitButton
            // 
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(150, 540);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(75, 36);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logInButton.Depth = 0;
            this.logInButton.HighEmphasis = true;
            this.logInButton.Icon = null;
            this.logInButton.Location = new System.Drawing.Point(375, 540);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInButton.Name = "logInButton";
            this.logInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logInButton.Size = new System.Drawing.Size(64, 36);
            this.logInButton.TabIndex = 16;
            this.logInButton.Text = "Login";
            this.logInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logInButton.UseAccentColor = false;
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // employeeDatabaseDataSet
            // 
            this.employeeDatabaseDataSet.DataSetName = "EmployeeDatabaseDataSet";
            this.employeeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emplyeeBindingSource
            // 
            this.emplyeeBindingSource.DataMember = "emplyee";
            this.emplyeeBindingSource.DataSource = this.employeeDatabaseDataSet;
            // 
            // emplyeeTableAdapter
            // 
            this.emplyeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.emplyeeTableAdapter = this.emplyeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Employee.EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 777);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.salaryUpDown);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.jobComboBox);
            this.Controls.Add(this.DOBBicker);
            this.Controls.Add(this.femaleRadioBox);
            this.Controls.Add(this.maleRadioBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.nationalIdTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.nationalIdLabel);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplyeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel nationalIdLabel;
        private MaterialSkin.Controls.MaterialLabel fullNameLabel;
        private MaterialSkin.Controls.MaterialLabel genderLabel;
        private MaterialSkin.Controls.MaterialLabel DOBLabel;
        private MaterialSkin.Controls.MaterialLabel jobLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel salaryLabel;
        private MaterialSkin.Controls.MaterialTextBox2 nationalIdTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 fullNameTextBox;
        private MaterialSkin.Controls.MaterialRadioButton maleRadioBox;
        private MaterialSkin.Controls.MaterialRadioButton femaleRadioBox;
        private System.Windows.Forms.DateTimePicker DOBBicker;
        private MaterialSkin.Controls.MaterialComboBox jobComboBox;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private System.Windows.Forms.NumericUpDown salaryUpDown;
        private MaterialSkin.Controls.MaterialButton submitButton;
        private MaterialSkin.Controls.MaterialButton logInButton;
        private EmployeeDatabaseDataSet1 employeeDatabaseDataSet;
        private System.Windows.Forms.BindingSource emplyeeBindingSource;
        private EmployeeDatabaseDataSet1TableAdapters.emplyeeTableAdapter emplyeeTableAdapter;
        private EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}