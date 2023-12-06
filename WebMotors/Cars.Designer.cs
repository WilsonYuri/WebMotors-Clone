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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAddPanel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlateAdd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ColorAdd = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BrandAdd = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ModelAdd = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.YearAdd = new System.Windows.Forms.Label();
            this.btnSubmitAddCar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.Year});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(938, 478);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // ID
            // 
            this.ID.Tag = "ID";
            this.ID.Text = "ID";
            // 
            // Plate
            // 
            this.Plate.Text = "Plate";
            // 
            // Color
            // 
            this.Color.Text = "Color";
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            // 
            // Model
            // 
            this.Model.Text = "Model";
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubmitAddCar);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.YearAdd);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.ModelAdd);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.BrandAdd);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.ColorAdd);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.PlateAdd);
            this.panel1.Location = new System.Drawing.Point(490, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 478);
            this.panel1.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 3;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 5;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(19, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 20);
            this.textBox4.TabIndex = 7;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(19, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 20);
            this.textBox5.TabIndex = 9;
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
            // btnSubmitAddCar
            // 
            this.btnSubmitAddCar.Location = new System.Drawing.Point(204, 313);
            this.btnSubmitAddCar.Name = "btnSubmitAddCar";
            this.btnSubmitAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAddCar.TabIndex = 5;
            this.btnSubmitAddCar.Text = "Submit";
            this.btnSubmitAddCar.UseVisualStyleBackColor = true;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowAddPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label BrandAdd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ColorAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PlateAdd;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label YearAdd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ModelAdd;
        private System.Windows.Forms.Button btnSubmitAddCar;
    }
}