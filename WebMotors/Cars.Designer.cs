namespace WebMotors
{
    partial class Cars
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1       ",
            "CTY-9323",
            "Gray",
            "Chevrolet",
            "Astra",
            "2005",
            "Used"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAddPanel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnSubmitAddCar = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.YearAdd = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.ModelAdd = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.BrandAdd = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.ColorAdd = new System.Windows.Forms.Label();
            this.PlateAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPlate = new System.Windows.Forms.MaskedTextBox();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Plate,
            this.Color,
            this.Brand,
            this.Model,
            this.Year,
            this.Condition});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(938, 478);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.ListViewDoubleClick);
            // 
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 36;
            // 
            // Plate
            // 
            this.Plate.Text = "Plate";
            this.Plate.Width = 73;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 77;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 91;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 97;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars Stored";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShowAddPanel
            // 
            this.btnShowAddPanel.Location = new System.Drawing.Point(874, 13);
            this.btnShowAddPanel.Name = "btnShowAddPanel";
            this.btnShowAddPanel.Size = new System.Drawing.Size(75, 23);
            this.btnShowAddPanel.TabIndex = 2;
            this.btnShowAddPanel.Text = "Add";
            this.btnShowAddPanel.UseVisualStyleBackColor = true;
            this.btnShowAddPanel.Click += new System.EventHandler(this.btnShowAddPanel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(793, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.radioButton2);
            this.panelAdd.Controls.Add(this.radioButton1);
            this.panelAdd.Controls.Add(this.btnEditCar);
            this.panelAdd.Controls.Add(this.btnSubmitAddCar);
            this.panelAdd.Controls.Add(this.textBoxYear);
            this.panelAdd.Controls.Add(this.YearAdd);
            this.panelAdd.Controls.Add(this.textBoxModel);
            this.panelAdd.Controls.Add(this.ModelAdd);
            this.panelAdd.Controls.Add(this.textBoxBrand);
            this.panelAdd.Controls.Add(this.BrandAdd);
            this.panelAdd.Controls.Add(this.textBoxColor);
            this.panelAdd.Controls.Add(this.ColorAdd);
            this.panelAdd.Controls.Add(this.PlateAdd);
            this.panelAdd.Controls.Add(this.panel1);
            this.panelAdd.Controls.Add(this.textBoxPlate);
            this.panelAdd.Location = new System.Drawing.Point(490, 54);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(459, 478);
            this.panelAdd.TabIndex = 4;
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(204, 294);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(75, 23);
            this.btnEditCar.TabIndex = 10;
            this.btnEditCar.Text = "Submit";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnSubmitAddCar
            // 
            this.btnSubmitAddCar.Location = new System.Drawing.Point(204, 313);
            this.btnSubmitAddCar.Name = "btnSubmitAddCar";
            this.btnSubmitAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAddCar.TabIndex = 5;
            this.btnSubmitAddCar.Text = "Submit";
            this.btnSubmitAddCar.UseVisualStyleBackColor = true;
            this.btnSubmitAddCar.Click += new System.EventHandler(this.btnSubmitAddCar_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(19, 264);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(53, 20);
            this.textBoxYear.TabIndex = 9;
            // 
            // YearAdd
            // 
            this.YearAdd.AutoSize = true;
            this.YearAdd.Location = new System.Drawing.Point(16, 247);
            this.YearAdd.Name = "YearAdd";
            this.YearAdd.Size = new System.Drawing.Size(29, 13);
            this.YearAdd.TabIndex = 8;
            this.YearAdd.Text = "Year";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(19, 208);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(228, 20);
            this.textBoxModel.TabIndex = 7;
            // 
            // ModelAdd
            // 
            this.ModelAdd.AutoSize = true;
            this.ModelAdd.Location = new System.Drawing.Point(16, 191);
            this.ModelAdd.Name = "ModelAdd";
            this.ModelAdd.Size = new System.Drawing.Size(36, 13);
            this.ModelAdd.TabIndex = 6;
            this.ModelAdd.Text = "Model";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(19, 153);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(228, 20);
            this.textBoxBrand.TabIndex = 5;
            // 
            // BrandAdd
            // 
            this.BrandAdd.AutoSize = true;
            this.BrandAdd.Location = new System.Drawing.Point(16, 136);
            this.BrandAdd.Name = "BrandAdd";
            this.BrandAdd.Size = new System.Drawing.Size(35, 13);
            this.BrandAdd.TabIndex = 4;
            this.BrandAdd.Text = "Brand";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(19, 94);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(228, 20);
            this.textBoxColor.TabIndex = 3;
            // 
            // ColorAdd
            // 
            this.ColorAdd.AutoSize = true;
            this.ColorAdd.Location = new System.Drawing.Point(16, 77);
            this.ColorAdd.Name = "ColorAdd";
            this.ColorAdd.Size = new System.Drawing.Size(31, 13);
            this.ColorAdd.TabIndex = 2;
            this.ColorAdd.Text = "Color";
            // 
            // PlateAdd
            // 
            this.PlateAdd.AutoSize = true;
            this.PlateAdd.Location = new System.Drawing.Point(16, 23);
            this.PlateAdd.Name = "PlateAdd";
            this.PlateAdd.Size = new System.Drawing.Size(31, 13);
            this.PlateAdd.TabIndex = 0;
            this.PlateAdd.Text = "Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Double click on the table car in order to edit the information stored";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(331, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(384, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Used";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Condition";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(320, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 47);
            this.panel1.TabIndex = 14;
            // 
            // Condition
            // 
            this.Condition.Text = "Condition";
            // 
            // textBoxPlate
            // 
            this.textBoxPlate.Location = new System.Drawing.Point(19, 40);
            this.textBoxPlate.Mask = "0000-000";
            this.textBoxPlate.Name = "textBoxPlate";
            this.textBoxPlate.Size = new System.Drawing.Size(97, 20);
            this.textBoxPlate.TabIndex = 15;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowAddPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAddPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Plate;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label BrandAdd;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label ColorAdd;
        private System.Windows.Forms.Label PlateAdd;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label YearAdd;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label ModelAdd;
        private System.Windows.Forms.Button btnSubmitAddCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.MaskedTextBox textBoxPlate;
    }
}