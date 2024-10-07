namespace WinForms04
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
            comboBoxCountry = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxStreet = new ComboBox();
            comboBoxBuilding = new ComboBox();
            button1 = new Button();
            labelCity = new Label();
            labelStreet = new Label();
            labelHouse = new Label();
            labelCountry = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(123, 18);
            comboBoxCountry.Margin = new Padding(5);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(166, 38);
            comboBoxCountry.TabIndex = 0;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(126, 2);
            comboBoxCity.Margin = new Padding(5);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(166, 38);
            comboBoxCity.TabIndex = 0;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(126, 7);
            comboBoxStreet.Margin = new Padding(5);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(166, 38);
            comboBoxStreet.TabIndex = 0;
            comboBoxStreet.SelectedIndexChanged += comboBoxStreet_SelectedIndexChanged;
            // 
            // comboBoxBuilding
            // 
            comboBoxBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBuilding.FormattingEnabled = true;
            comboBoxBuilding.Location = new Point(128, 1);
            comboBoxBuilding.Margin = new Padding(5);
            comboBoxBuilding.Name = "comboBoxBuilding";
            comboBoxBuilding.Size = new Size(166, 38);
            comboBoxBuilding.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(119, 302);
            button1.Name = "button1";
            button1.Size = new Size(217, 51);
            button1.TabIndex = 2;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(11, 2);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(72, 30);
            labelCity.TabIndex = 1;
            labelCity.Text = "Город";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(11, 10);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(77, 30);
            labelStreet.TabIndex = 1;
            labelStreet.Text = "Улица";
            // 
            // labelHouse
            // 
            labelHouse.AutoSize = true;
            labelHouse.Location = new Point(13, 4);
            labelHouse.Name = "labelHouse";
            labelHouse.Size = new Size(57, 30);
            labelHouse.TabIndex = 1;
            labelHouse.Text = "Дом";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(8, 21);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(94, 30);
            labelCountry.TabIndex = 1;
            labelCountry.Text = "Страна";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCountry);
            panel1.Controls.Add(comboBoxCountry);
            panel1.Location = new Point(27, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 56);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCity);
            panel2.Controls.Add(comboBoxCity);
            panel2.Location = new Point(27, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 49);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelStreet);
            panel3.Controls.Add(comboBoxStreet);
            panel3.Location = new Point(24, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 59);
            panel3.TabIndex = 5;
            panel3.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelHouse);
            panel4.Controls.Add(comboBoxBuilding);
            panel4.Location = new Point(22, 225);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 44);
            panel4.TabIndex = 6;
            panel4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 386);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Укажите адресс";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxCountry;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxStreet;
        private ComboBox comboBoxBuilding;
        private Button button1;
        private Label labelCity;
        private Label labelStreet;
        private Label labelHouse;
        private Label labelCountry;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
