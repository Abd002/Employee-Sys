namespace Employee
{
    partial class LogInForm
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
            this.logInButton = new MaterialSkin.Controls.MaterialButton();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.nationalIdTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.nationalIdLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.infoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.employeeDatabaseDataSet = new Employee.EmployeeDatabaseDataSet1();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Employee.EmployeeDatabaseDataSet1TableAdapters.departmentTableAdapter();
            this.tableAdapterManager = new Employee.EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.emplyeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emplyeeTableAdapter = new Employee.EmployeeDatabaseDataSet1TableAdapters.emplyeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplyeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logInButton.Depth = 0;
            this.logInButton.HighEmphasis = true;
            this.logInButton.Icon = null;
            this.logInButton.Location = new System.Drawing.Point(375, 290);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logInButton.Name = "logInButton";
            this.logInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logInButton.Size = new System.Drawing.Size(64, 36);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "LogIn";
            this.logInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logInButton.UseAccentColor = false;
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(362, 388);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerButton.Size = new System.Drawing.Size(89, 36);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "register";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
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
            this.nationalIdTextBox.Location = new System.Drawing.Point(282, 112);
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
            this.nationalIdTextBox.TabIndex = 2;
            this.nationalIdTextBox.TabStop = false;
            this.nationalIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nationalIdTextBox.TrailingIcon = null;
            this.nationalIdTextBox.UseSystemPasswordChar = false;
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
            this.passwordTextBox.Location = new System.Drawing.Point(282, 210);
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
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TrailingIcon = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // nationalIdLabel
            // 
            this.nationalIdLabel.AutoSize = true;
            this.nationalIdLabel.Depth = 0;
            this.nationalIdLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nationalIdLabel.Location = new System.Drawing.Point(170, 124);
            this.nationalIdLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nationalIdLabel.Name = "nationalIdLabel";
            this.nationalIdLabel.Size = new System.Drawing.Size(92, 19);
            this.nationalIdLabel.TabIndex = 4;
            this.nationalIdLabel.Text = "National ID : ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordLabel.Location = new System.Drawing.Point(170, 224);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 19);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password : ";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Depth = 0;
            this.infoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel.Location = new System.Drawing.Point(312, 343);
            this.infoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(194, 19);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "New Employee ? ... Register";
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
            // emplyeeBindingSource
            // 
            this.emplyeeBindingSource.DataMember = "emplyee";
            this.emplyeeBindingSource.DataSource = this.employeeDatabaseDataSet;
            // 
            // emplyeeTableAdapter
            // 
            this.emplyeeTableAdapter.ClearBeforeFill = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nationalIdLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nationalIdTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.logInButton);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplyeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton logInButton;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialTextBox2 nationalIdTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 passwordTextBox;
        private MaterialSkin.Controls.MaterialLabel nationalIdLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel infoLabel;
        private EmployeeDatabaseDataSet1 employeeDatabaseDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private EmployeeDatabaseDataSet1TableAdapters.departmentTableAdapter departmentTableAdapter;
        private EmployeeDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource emplyeeBindingSource;
        private EmployeeDatabaseDataSet1TableAdapters.emplyeeTableAdapter emplyeeTableAdapter;
    }
}

