
namespace estate_agency
{
    partial class Form9
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label flatLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label residentialComplexLabel;
            System.Windows.Forms.Label flatfloorLabel;
            System.Windows.Forms.Label roomCountLabel;
            System.Windows.Forms.Label roomSquareLabel;
            System.Windows.Forms.Label yearOfConstructionLabel;
            System.Windows.Forms.Label fDescriptionLabel;
            System.Windows.Forms.Label costLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label2 = new System.Windows.Forms.Label();
            this.real_estate_agencyDataSet = new estate_agency.real_estate_agencyDataSet();
            this.immovables_buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.immovables_buyTableAdapter = new estate_agency.real_estate_agencyDataSetTableAdapters.Immovables_buyTableAdapter();
            this.tableAdapterManager = new estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.flatTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.residentialComplexTextBox = new System.Windows.Forms.TextBox();
            this.flatfloorTextBox = new System.Windows.Forms.TextBox();
            this.roomSquareTextBox = new System.Windows.Forms.TextBox();
            this.fDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yearOfConstructionTextBox = new System.Windows.Forms.TextBox();
            this.roomCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            flatLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            residentialComplexLabel = new System.Windows.Forms.Label();
            flatfloorLabel = new System.Windows.Forms.Label();
            roomCountLabel = new System.Windows.Forms.Label();
            roomSquareLabel = new System.Windows.Forms.Label();
            yearOfConstructionLabel = new System.Windows.Forms.Label();
            fDescriptionLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immovables_buyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cityLabel.Location = new System.Drawing.Point(99, 93);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(54, 21);
            cityLabel.TabIndex = 74;
            cityLabel.Text = "Қала:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            streetLabel.Location = new System.Drawing.Point(90, 141);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(57, 21);
            streetLabel.TabIndex = 75;
            streetLabel.Text = "Көше:";
            // 
            // flatLabel
            // 
            flatLabel.AutoSize = true;
            flatLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            flatLabel.Location = new System.Drawing.Point(107, 188);
            flatLabel.Name = "flatLabel";
            flatLabel.Size = new System.Drawing.Size(36, 21);
            flatLabel.TabIndex = 76;
            flatLabel.Text = "Үй:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(82, 239);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(65, 21);
            numberLabel.TabIndex = 77;
            numberLabel.Text = "Номер:";
            // 
            // residentialComplexLabel
            // 
            residentialComplexLabel.AutoSize = true;
            residentialComplexLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            residentialComplexLabel.Location = new System.Drawing.Point(1, 282);
            residentialComplexLabel.Name = "residentialComplexLabel";
            residentialComplexLabel.Size = new System.Drawing.Size(146, 21);
            residentialComplexLabel.TabIndex = 78;
            residentialComplexLabel.Text = "Жилой комплекс:";
            // 
            // flatfloorLabel
            // 
            flatfloorLabel.AutoSize = true;
            flatfloorLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            flatfloorLabel.Location = new System.Drawing.Point(94, 333);
            flatfloorLabel.Name = "flatfloorLabel";
            flatfloorLabel.Size = new System.Drawing.Size(55, 21);
            flatfloorLabel.TabIndex = 79;
            flatfloorLabel.Text = "Этаж:";
            // 
            // roomCountLabel
            // 
            roomCountLabel.AutoSize = true;
            roomCountLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roomCountLabel.Location = new System.Drawing.Point(21, 379);
            roomCountLabel.Name = "roomCountLabel";
            roomCountLabel.Size = new System.Drawing.Size(132, 21);
            roomCountLabel.TabIndex = 80;
            roomCountLabel.Text = "Бөлменің саны:";
            // 
            // roomSquareLabel
            // 
            roomSquareLabel.AutoSize = true;
            roomSquareLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roomSquareLabel.Location = new System.Drawing.Point(36, 425);
            roomSquareLabel.Name = "roomSquareLabel";
            roomSquareLabel.Size = new System.Drawing.Size(119, 21);
            roomSquareLabel.TabIndex = 81;
            roomSquareLabel.Text = "Үйдің өлшемі:";
            // 
            // yearOfConstructionLabel
            // 
            yearOfConstructionLabel.AutoSize = true;
            yearOfConstructionLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            yearOfConstructionLabel.Location = new System.Drawing.Point(5, 472);
            yearOfConstructionLabel.Name = "yearOfConstructionLabel";
            yearOfConstructionLabel.Size = new System.Drawing.Size(142, 21);
            yearOfConstructionLabel.TabIndex = 82;
            yearOfConstructionLabel.Text = "Салынған жылы:";
            // 
            // fDescriptionLabel
            // 
            fDescriptionLabel.AutoSize = true;
            fDescriptionLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fDescriptionLabel.Location = new System.Drawing.Point(53, 514);
            fDescriptionLabel.Name = "fDescriptionLabel";
            fDescriptionLabel.Size = new System.Drawing.Size(94, 21);
            fDescriptionLabel.TabIndex = 83;
            fDescriptionLabel.Text = "Описание:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(56, 559);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(91, 21);
            costLabel.TabIndex = 84;
            costLabel.Text = "Бағасы тг:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 73;
            this.label2.Text = "Жылжымайтын мүліктер";
            // 
            // real_estate_agencyDataSet
            // 
            this.real_estate_agencyDataSet.DataSetName = "real_estate_agencyDataSet";
            this.real_estate_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // immovables_buyBindingSource
            // 
            this.immovables_buyBindingSource.DataMember = "Immovables_buy";
            this.immovables_buyBindingSource.DataSource = this.real_estate_agencyDataSet;
            // 
            // immovables_buyTableAdapter
            // 
            this.immovables_buyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Immovables_buyTableAdapter = this.immovables_buyTableAdapter;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.ServiceesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(167, 93);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(204, 28);
            this.cityTextBox.TabIndex = 75;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "Street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetTextBox.Location = new System.Drawing.Point(167, 141);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(204, 28);
            this.streetTextBox.TabIndex = 76;
            // 
            // flatTextBox
            // 
            this.flatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "Flat", true));
            this.flatTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flatTextBox.Location = new System.Drawing.Point(167, 188);
            this.flatTextBox.Name = "flatTextBox";
            this.flatTextBox.Size = new System.Drawing.Size(204, 28);
            this.flatTextBox.TabIndex = 77;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "Number", true));
            this.numberTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(167, 239);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(204, 28);
            this.numberTextBox.TabIndex = 78;
            // 
            // residentialComplexTextBox
            // 
            this.residentialComplexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "ResidentialComplex", true));
            this.residentialComplexTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.residentialComplexTextBox.Location = new System.Drawing.Point(167, 282);
            this.residentialComplexTextBox.Name = "residentialComplexTextBox";
            this.residentialComplexTextBox.Size = new System.Drawing.Size(204, 28);
            this.residentialComplexTextBox.TabIndex = 79;
            // 
            // flatfloorTextBox
            // 
            this.flatfloorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "Flatfloor", true));
            this.flatfloorTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flatfloorTextBox.Location = new System.Drawing.Point(168, 333);
            this.flatfloorTextBox.Name = "flatfloorTextBox";
            this.flatfloorTextBox.Size = new System.Drawing.Size(204, 28);
            this.flatfloorTextBox.TabIndex = 80;
            // 
            // roomSquareTextBox
            // 
            this.roomSquareTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "RoomSquare", true));
            this.roomSquareTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomSquareTextBox.Location = new System.Drawing.Point(168, 425);
            this.roomSquareTextBox.Name = "roomSquareTextBox";
            this.roomSquareTextBox.Size = new System.Drawing.Size(204, 28);
            this.roomSquareTextBox.TabIndex = 82;
            // 
            // fDescriptionTextBox
            // 
            this.fDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "FDescription", true));
            this.fDescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fDescriptionTextBox.Location = new System.Drawing.Point(168, 511);
            this.fDescriptionTextBox.Name = "fDescriptionTextBox";
            this.fDescriptionTextBox.Size = new System.Drawing.Size(204, 28);
            this.fDescriptionTextBox.TabIndex = 84;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "Cost", true));
            this.costTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTextBox.Location = new System.Drawing.Point(167, 559);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(204, 28);
            this.costTextBox.TabIndex = 85;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(76, 729);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(302, 33);
            this.button9.TabIndex = 94;
            this.button9.Text = "Кесте";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(307, 672);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 33);
            this.button8.TabIndex = 93;
            this.button8.Text = "Жабу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(230, 672);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 33);
            this.button7.TabIndex = 92;
            this.button7.Text = "Сақтау";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(153, 672);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 33);
            this.button6.TabIndex = 91;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(76, 672);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 33);
            this.button5.TabIndex = 90;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(307, 617);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 33);
            this.button4.TabIndex = 89;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(76, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 33);
            this.button3.TabIndex = 88;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(153, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 33);
            this.button2.TabIndex = 87;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(230, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 86;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearOfConstructionTextBox
            // 
            this.yearOfConstructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.immovables_buyBindingSource, "YearOfConstruction", true));
            this.yearOfConstructionTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearOfConstructionTextBox.Location = new System.Drawing.Point(167, 471);
            this.yearOfConstructionTextBox.Name = "yearOfConstructionTextBox";
            this.yearOfConstructionTextBox.Size = new System.Drawing.Size(204, 28);
            this.yearOfConstructionTextBox.TabIndex = 95;
            // 
            // roomCountNumericUpDown
            // 
            this.roomCountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.immovables_buyBindingSource, "RoomCount", true));
            this.roomCountNumericUpDown.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomCountNumericUpDown.Location = new System.Drawing.Point(168, 377);
            this.roomCountNumericUpDown.Name = "roomCountNumericUpDown";
            this.roomCountNumericUpDown.Size = new System.Drawing.Size(208, 28);
            this.roomCountNumericUpDown.TabIndex = 81;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(457, 791);
            this.Controls.Add(this.yearOfConstructionTextBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(fDescriptionLabel);
            this.Controls.Add(this.fDescriptionTextBox);
            this.Controls.Add(yearOfConstructionLabel);
            this.Controls.Add(roomSquareLabel);
            this.Controls.Add(this.roomSquareTextBox);
            this.Controls.Add(roomCountLabel);
            this.Controls.Add(this.roomCountNumericUpDown);
            this.Controls.Add(flatfloorLabel);
            this.Controls.Add(this.flatfloorTextBox);
            this.Controls.Add(residentialComplexLabel);
            this.Controls.Add(this.residentialComplexTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(flatLabel);
            this.Controls.Add(this.flatTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "Жылжымайтын мүліктер";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immovables_buyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private real_estate_agencyDataSet real_estate_agencyDataSet;
        private System.Windows.Forms.BindingSource immovables_buyBindingSource;
        private real_estate_agencyDataSetTableAdapters.Immovables_buyTableAdapter immovables_buyTableAdapter;
        private real_estate_agencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox flatTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox residentialComplexTextBox;
        private System.Windows.Forms.TextBox flatfloorTextBox;
        private System.Windows.Forms.TextBox roomSquareTextBox;
        private System.Windows.Forms.TextBox fDescriptionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox yearOfConstructionTextBox;
        private System.Windows.Forms.NumericUpDown roomCountNumericUpDown;
    }
}