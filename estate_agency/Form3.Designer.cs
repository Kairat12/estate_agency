
namespace estate_agency
{
    partial class Form3
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
            System.Windows.Forms.Label surNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label p_idLabel;
            System.Windows.Forms.Label sexLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.real_estate_agencyDataSet = new estate_agency.real_estate_agencyDataSet();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new estate_agency.real_estate_agencyDataSetTableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager();
            this.contractsTableAdapter = new estate_agency.real_estate_agencyDataSetTableAdapters.ContractsTableAdapter();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.p_idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.sexTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fKContractsWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            surNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            p_idLabel = new System.Windows.Forms.Label();
            sexLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_idNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContractsWorkersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // surNameLabel
            // 
            surNameLabel.AutoSize = true;
            surNameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surNameLabel.Location = new System.Drawing.Point(117, 82);
            surNameLabel.Name = "surNameLabel";
            surNameLabel.Size = new System.Drawing.Size(46, 21);
            surNameLabel.TabIndex = 1;
            surNameLabel.Text = "Тегі:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(116, 127);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(47, 21);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "Аты:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            patronymicLabel.Location = new System.Drawing.Point(59, 159);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(115, 21);
            patronymicLabel.TabIndex = 5;
            patronymicLabel.Text = "Әкесінің аты:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ageLabel.Location = new System.Drawing.Point(116, 233);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(60, 21);
            ageLabel.TabIndex = 9;
            ageLabel.Text = "Жасы:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            streetLabel.Location = new System.Drawing.Point(111, 319);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(69, 21);
            streetLabel.TabIndex = 13;
            streetLabel.Text = "Көшесі:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(95, 365);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(85, 21);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Телефон:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cityLabel.Location = new System.Drawing.Point(121, 277);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(53, 21);
            cityLabel.TabIndex = 27;
            cityLabel.Text = "Кала:";
            // 
            // p_idLabel
            // 
            p_idLabel.AutoSize = true;
            p_idLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            p_idLabel.Location = new System.Drawing.Point(75, 412);
            p_idLabel.Name = "p_idLabel";
            p_idLabel.Size = new System.Drawing.Size(97, 21);
            p_idLabel.TabIndex = 28;
            p_idLabel.Text = "Лауазымы:";
            // 
            // sexLabel1
            // 
            sexLabel1.AutoSize = true;
            sexLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sexLabel1.Location = new System.Drawing.Point(91, 196);
            sexLabel1.Name = "sexLabel1";
            sexLabel1.Size = new System.Drawing.Size(85, 21);
            sexLabel1.TabIndex = 30;
            sexLabel1.Text = "Жынысы:";
            sexLabel1.Click += new System.EventHandler(this.sexLabel1_Click);
            // 
            // real_estate_agencyDataSet
            // 
            this.real_estate_agencyDataSet.DataSetName = "real_estate_agencyDataSet";
            this.real_estate_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.real_estate_agencyDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = this.contractsTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Immovables_buyTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.ServiceesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "SurName", true));
            this.surNameTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surNameTextBox.Location = new System.Drawing.Point(181, 79);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(156, 28);
            this.surNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(181, 120);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(156, 28);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Patronymic", true));
            this.patronymicTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextBox.Location = new System.Drawing.Point(180, 159);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(157, 28);
            this.patronymicTextBox.TabIndex = 6;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Age", true));
            this.ageTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageTextBox.Location = new System.Drawing.Point(181, 233);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(160, 28);
            this.ageTextBox.TabIndex = 10;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetTextBox.Location = new System.Drawing.Point(181, 312);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(160, 28);
            this.streetTextBox.TabIndex = 14;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(182, 362);
            this.phoneMaskedTextBox.Mask = "+7(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(159, 28);
            this.phoneMaskedTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(246, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(169, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(92, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 33);
            this.button3.TabIndex = 21;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(323, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 33);
            this.button4.TabIndex = 22;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(92, 514);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 33);
            this.button5.TabIndex = 23;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(169, 514);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 33);
            this.button6.TabIndex = 24;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(246, 514);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 33);
            this.button7.TabIndex = 25;
            this.button7.Text = "Сақтау";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(323, 514);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 33);
            this.button8.TabIndex = 26;
            this.button8.Text = "Жабу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(92, 571);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(302, 33);
            this.button9.TabIndex = 27;
            this.button9.Text = "Кесте";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(180, 274);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(161, 28);
            this.cityTextBox.TabIndex = 28;
            // 
            // p_idNumericUpDown
            // 
            this.p_idNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.workersBindingSource, "p_id", true));
            this.p_idNumericUpDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_idNumericUpDown.Location = new System.Drawing.Point(182, 410);
            this.p_idNumericUpDown.Name = "p_idNumericUpDown";
            this.p_idNumericUpDown.Size = new System.Drawing.Size(159, 28);
            this.p_idNumericUpDown.TabIndex = 29;
            this.p_idNumericUpDown.ValueChanged += new System.EventHandler(this.p_idNumericUpDown_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // sexTextBox1
            // 
            this.sexTextBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "female",
            "male"});
            this.sexTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Sex", true));
            this.sexTextBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexTextBox1.Location = new System.Drawing.Point(182, 193);
            this.sexTextBox1.Name = "sexTextBox1";
            this.sexTextBox1.Size = new System.Drawing.Size(155, 28);
            this.sexTextBox1.TabIndex = 31;
            this.sexTextBox1.TextChanged += new System.EventHandler(this.sexTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(343, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "male-ер адам, female-айел адам";
            // 
            // fKContractsWorkersBindingSource
            // 
            this.fKContractsWorkersBindingSource.DataMember = "FK_Contracts_Workers";
            this.fKContractsWorkersBindingSource.DataSource = this.workersBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(177, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Жұмысшылар";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(sexLabel1);
            this.Controls.Add(this.sexTextBox1);
            this.Controls.Add(p_idLabel);
            this.Controls.Add(this.p_idNumericUpDown);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(surNameLabel);
            this.Controls.Add(this.surNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жұмысшылар";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_idNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContractsWorkersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private real_estate_agencyDataSet real_estate_agencyDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private real_estate_agencyDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private real_estate_agencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.NumericUpDown p_idNumericUpDown;
        private real_estate_agencyDataSetTableAdapters.ContractsTableAdapter contractsTableAdapter;
        private System.Windows.Forms.BindingSource fKContractsWorkersBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox sexTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}