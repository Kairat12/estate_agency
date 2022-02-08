
namespace estate_agency
{
    partial class Form12
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
            System.Windows.Forms.Label postNameLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label necessarilyLabel;
            System.Windows.Forms.Label pDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.label2 = new System.Windows.Forms.Label();
            this.real_estate_agencyDataSet = new estate_agency.real_estate_agencyDataSet();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new estate_agency.real_estate_agencyDataSetTableAdapters.PostTableAdapter();
            this.tableAdapterManager = new estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager();
            this.postNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.necessarilyTextBox = new System.Windows.Forms.TextBox();
            this.pDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            postNameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            necessarilyLabel = new System.Windows.Forms.Label();
            pDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(179, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "Лауазымдар";
            // 
            // real_estate_agencyDataSet
            // 
            this.real_estate_agencyDataSet.DataSetName = "real_estate_agencyDataSet";
            this.real_estate_agencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.real_estate_agencyDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Immovables_buyTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = this.postTableAdapter;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.ServiceesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = estate_agency.real_estate_agencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // postNameLabel
            // 
            postNameLabel.AutoSize = true;
            postNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postNameLabel.Location = new System.Drawing.Point(63, 118);
            postNameLabel.Name = "postNameLabel";
            postNameLabel.Size = new System.Drawing.Size(176, 24);
            postNameLabel.TabIndex = 75;
            postNameLabel.Text = "Лауазымның аты:";
            // 
            // postNameTextBox
            // 
            this.postNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "PostName", true));
            this.postNameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postNameTextBox.Location = new System.Drawing.Point(256, 115);
            this.postNameTextBox.Name = "postNameTextBox";
            this.postNameTextBox.Size = new System.Drawing.Size(167, 32);
            this.postNameTextBox.TabIndex = 76;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            salaryLabel.Location = new System.Drawing.Point(157, 168);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(75, 24);
            salaryLabel.TabIndex = 76;
            salaryLabel.Text = "Айлық:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Salary", true));
            this.salaryTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryTextBox.Location = new System.Drawing.Point(256, 165);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(167, 32);
            this.salaryTextBox.TabIndex = 77;
            // 
            // necessarilyLabel
            // 
            necessarilyLabel.AutoSize = true;
            necessarilyLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            necessarilyLabel.Location = new System.Drawing.Point(115, 224);
            necessarilyLabel.Name = "necessarilyLabel";
            necessarilyLabel.Size = new System.Drawing.Size(118, 24);
            necessarilyLabel.TabIndex = 77;
            necessarilyLabel.Text = "Талаптары:";
            // 
            // necessarilyTextBox
            // 
            this.necessarilyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Necessarily", true));
            this.necessarilyTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.necessarilyTextBox.Location = new System.Drawing.Point(256, 216);
            this.necessarilyTextBox.Name = "necessarilyTextBox";
            this.necessarilyTextBox.Size = new System.Drawing.Size(167, 32);
            this.necessarilyTextBox.TabIndex = 78;
            // 
            // pDescriptionLabel
            // 
            pDescriptionLabel.AutoSize = true;
            pDescriptionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pDescriptionLabel.Location = new System.Drawing.Point(133, 288);
            pDescriptionLabel.Name = "pDescriptionLabel";
            pDescriptionLabel.Size = new System.Drawing.Size(106, 24);
            pDescriptionLabel.TabIndex = 78;
            pDescriptionLabel.Text = "Описание:";
            // 
            // pDescriptionTextBox
            // 
            this.pDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "PDescription", true));
            this.pDescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pDescriptionTextBox.Location = new System.Drawing.Point(256, 280);
            this.pDescriptionTextBox.Name = "pDescriptionTextBox";
            this.pDescriptionTextBox.Size = new System.Drawing.Size(167, 32);
            this.pDescriptionTextBox.TabIndex = 79;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(338, 405);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 33);
            this.button8.TabIndex = 110;
            this.button8.Text = "Жабу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(261, 405);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 33);
            this.button7.TabIndex = 109;
            this.button7.Text = "Сақтау";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(184, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 33);
            this.button6.TabIndex = 108;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(107, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 33);
            this.button5.TabIndex = 107;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(338, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 33);
            this.button4.TabIndex = 106;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(107, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 33);
            this.button3.TabIndex = 105;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(184, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 33);
            this.button2.TabIndex = 104;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(261, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 33);
            this.button1.TabIndex = 103;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 502);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(pDescriptionLabel);
            this.Controls.Add(this.pDescriptionTextBox);
            this.Controls.Add(necessarilyLabel);
            this.Controls.Add(this.necessarilyTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(postNameLabel);
            this.Controls.Add(this.postNameTextBox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "Лауазымдар";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_agencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private real_estate_agencyDataSet real_estate_agencyDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private real_estate_agencyDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private real_estate_agencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox postNameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox necessarilyTextBox;
        private System.Windows.Forms.TextBox pDescriptionTextBox;
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