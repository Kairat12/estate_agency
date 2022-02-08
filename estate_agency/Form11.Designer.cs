
namespace estate_agency
{
    partial class Form11
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
            System.Windows.Forms.Label namesLabel;
            System.Windows.Forms.Label descriptionsLabel;
            System.Windows.Forms.Label costsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.real_estate_agencyDataSet = new estate_agency.real_estate_agencyDataSet();
            this.serviceesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceesTableAdapter = new estate_agency.real_estate_agencyDataSetTableAdapters.ServiceesTableAdapter();
            this.tableAdapterManager = new estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.descriptionsTextBox = new System.Windows.Forms.TextBox();
            this.costsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            namesLabel = new System.Windows.Forms.Label();
            descriptionsLabel = new System.Windows.Forms.Label();
            costsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // namesLabel
            // 
            namesLabel.AutoSize = true;
            namesLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            namesLabel.Location = new System.Drawing.Point(77, 100);
            namesLabel.Name = "namesLabel";
            namesLabel.Size = new System.Drawing.Size(52, 24);
            namesLabel.TabIndex = 1;
            namesLabel.Text = "Аты:";
            // 
            // descriptionsLabel
            // 
            descriptionsLabel.AutoSize = true;
            descriptionsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionsLabel.Location = new System.Drawing.Point(43, 158);
            descriptionsLabel.Name = "descriptionsLabel";
            descriptionsLabel.Size = new System.Drawing.Size(106, 24);
            descriptionsLabel.TabIndex = 3;
            descriptionsLabel.Text = "Описание:";
            // 
            // costsLabel
            // 
            costsLabel.AutoSize = true;
            costsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costsLabel.Location = new System.Drawing.Point(86, 225);
            costsLabel.Name = "costsLabel";
            costsLabel.Size = new System.Drawing.Size(82, 24);
            costsLabel.TabIndex = 5;
            costsLabel.Text = "Бағасы:";
            // 
            // real_estate_agencyDataSet
            // 
            this.real_estate_agencyDataSet.DataSetName = "real_estate_agencyDataSet";
            this.real_estate_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceesBindingSource
            // 
            this.serviceesBindingSource.DataMember = "Servicees";
            this.serviceesBindingSource.DataSource = this.real_estate_agencyDataSet;
            // 
            // serviceesTableAdapter
            // 
            this.serviceesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Immovables_buyTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.ServiceesTableAdapter = this.serviceesTableAdapter;
            this.tableAdapterManager.UpdateOrder = estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // namesTextBox
            // 
            this.namesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceesBindingSource, "Names", true));
            this.namesTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesTextBox.Location = new System.Drawing.Point(171, 97);
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(166, 32);
            this.namesTextBox.TabIndex = 2;
            // 
            // descriptionsTextBox
            // 
            this.descriptionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceesBindingSource, "Descriptions", true));
            this.descriptionsTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionsTextBox.Location = new System.Drawing.Point(171, 155);
            this.descriptionsTextBox.Name = "descriptionsTextBox";
            this.descriptionsTextBox.Size = new System.Drawing.Size(166, 32);
            this.descriptionsTextBox.TabIndex = 4;
            // 
            // costsTextBox
            // 
            this.costsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceesBindingSource, "Costs", true));
            this.costsTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costsTextBox.Location = new System.Drawing.Point(171, 225);
            this.costsTextBox.Name = "costsTextBox";
            this.costsTextBox.Size = new System.Drawing.Size(166, 32);
            this.costsTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "Сервистер";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(278, 365);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 33);
            this.button8.TabIndex = 102;
            this.button8.Text = "Жабу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(201, 365);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 33);
            this.button7.TabIndex = 101;
            this.button7.Text = "Сақтау";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(124, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 33);
            this.button6.TabIndex = 100;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(47, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 33);
            this.button5.TabIndex = 99;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(278, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 33);
            this.button4.TabIndex = 98;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(47, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 33);
            this.button3.TabIndex = 97;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(124, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 33);
            this.button2.TabIndex = 96;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(201, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 95;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 433);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(costsLabel);
            this.Controls.Add(this.costsTextBox);
            this.Controls.Add(descriptionsLabel);
            this.Controls.Add(this.descriptionsTextBox);
            this.Controls.Add(namesLabel);
            this.Controls.Add(this.namesTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Сервистер";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private real_estate_agencyDataSet real_estate_agencyDataSet;
        private System.Windows.Forms.BindingSource serviceesBindingSource;
        private real_estate_agencyDataSetTableAdapters.ServiceesTableAdapter serviceesTableAdapter;
        private real_estate_agencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox namesTextBox;
        private System.Windows.Forms.TextBox descriptionsTextBox;
        private System.Windows.Forms.TextBox costsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}