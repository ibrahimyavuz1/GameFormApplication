namespace OOP2Lab1
{
    partial class form_Settings
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
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Color_Settings = new System.Windows.Forms.CheckedListBox();
            this.button_Save_Settings = new System.Windows.Forms.Button();
            this.checkedListBox_RoundShapes = new System.Windows.Forms.CheckedListBox();
            this.radioButton_Normal_Settings = new System.Windows.Forms.RadioButton();
            this.radioButton_Custom_Settings = new System.Windows.Forms.RadioButton();
            this.textBox_FirstNumberCustom_Settings = new System.Windows.Forms.TextBox();
            this.textBox_SecondNumberCustom_Settings = new System.Windows.Forms.TextBox();
            this.radioButton_Hard_Settings = new System.Windows.Forms.RadioButton();
            this.radioButton_Easy_Settings = new System.Windows.Forms.RadioButton();
            this.groupBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.checkedListBox_Color_Settings);
            this.groupBox_Settings.Controls.Add(this.button_Save_Settings);
            this.groupBox_Settings.Controls.Add(this.checkedListBox_RoundShapes);
            this.groupBox_Settings.Controls.Add(this.radioButton_Normal_Settings);
            this.groupBox_Settings.Controls.Add(this.radioButton_Custom_Settings);
            this.groupBox_Settings.Controls.Add(this.textBox_FirstNumberCustom_Settings);
            this.groupBox_Settings.Controls.Add(this.textBox_SecondNumberCustom_Settings);
            this.groupBox_Settings.Controls.Add(this.radioButton_Hard_Settings);
            this.groupBox_Settings.Controls.Add(this.radioButton_Easy_Settings);
            this.groupBox_Settings.Location = new System.Drawing.Point(7, 98);
            this.groupBox_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Settings.Size = new System.Drawing.Size(786, 368);
            this.groupBox_Settings.TabIndex = 16;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // checkedListBox_Color_Settings
            // 
            this.checkedListBox_Color_Settings.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox_Color_Settings.FormattingEnabled = true;
            this.checkedListBox_Color_Settings.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.checkedListBox_Color_Settings.Location = new System.Drawing.Point(604, 40);
            this.checkedListBox_Color_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox_Color_Settings.Name = "checkedListBox_Color_Settings";
            this.checkedListBox_Color_Settings.Size = new System.Drawing.Size(153, 158);
            this.checkedListBox_Color_Settings.TabIndex = 17;
            // 
            // button_Save_Settings
            // 
            this.button_Save_Settings.Location = new System.Drawing.Point(238, 270);
            this.button_Save_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Save_Settings.Name = "button_Save_Settings";
            this.button_Save_Settings.Size = new System.Drawing.Size(110, 51);
            this.button_Save_Settings.TabIndex = 16;
            this.button_Save_Settings.Text = "Save";
            this.button_Save_Settings.UseVisualStyleBackColor = true;
            this.button_Save_Settings.Click += new System.EventHandler(this.button_Save_Settings_Click);
            // 
            // checkedListBox_RoundShapes
            // 
            this.checkedListBox_RoundShapes.BackColor = System.Drawing.Color.Gray;
            this.checkedListBox_RoundShapes.FormattingEnabled = true;
            this.checkedListBox_RoundShapes.Items.AddRange(new object[] {
            "Triangle",
            "Square",
            "Circle",
            "Rectangle",
            "Cube",
            "Octagon",
            "Oval",
            "Star",
            "Diamond"});
            this.checkedListBox_RoundShapes.Location = new System.Drawing.Point(405, 40);
            this.checkedListBox_RoundShapes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox_RoundShapes.Name = "checkedListBox_RoundShapes";
            this.checkedListBox_RoundShapes.Size = new System.Drawing.Size(153, 158);
            this.checkedListBox_RoundShapes.TabIndex = 15;
            // 
            // radioButton_Normal_Settings
            // 
            this.radioButton_Normal_Settings.AutoSize = true;
            this.radioButton_Normal_Settings.Location = new System.Drawing.Point(39, 82);
            this.radioButton_Normal_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Normal_Settings.Name = "radioButton_Normal_Settings";
            this.radioButton_Normal_Settings.Size = new System.Drawing.Size(80, 24);
            this.radioButton_Normal_Settings.TabIndex = 13;
            this.radioButton_Normal_Settings.TabStop = true;
            this.radioButton_Normal_Settings.Text = "Normal";
            this.radioButton_Normal_Settings.UseVisualStyleBackColor = true;
            // 
            // radioButton_Custom_Settings
            // 
            this.radioButton_Custom_Settings.AutoSize = true;
            this.radioButton_Custom_Settings.Location = new System.Drawing.Point(39, 169);
            this.radioButton_Custom_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Custom_Settings.Name = "radioButton_Custom_Settings";
            this.radioButton_Custom_Settings.Size = new System.Drawing.Size(80, 24);
            this.radioButton_Custom_Settings.TabIndex = 14;
            this.radioButton_Custom_Settings.TabStop = true;
            this.radioButton_Custom_Settings.Text = "Custom";
            this.radioButton_Custom_Settings.UseVisualStyleBackColor = true;
            // 
            // textBox_FirstNumberCustom_Settings
            // 
            this.textBox_FirstNumberCustom_Settings.Location = new System.Drawing.Point(141, 169);
            this.textBox_FirstNumberCustom_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FirstNumberCustom_Settings.Name = "textBox_FirstNumberCustom_Settings";
            this.textBox_FirstNumberCustom_Settings.Size = new System.Drawing.Size(39, 27);
            this.textBox_FirstNumberCustom_Settings.TabIndex = 7;
            // 
            // textBox_SecondNumberCustom_Settings
            // 
            this.textBox_SecondNumberCustom_Settings.Location = new System.Drawing.Point(197, 169);
            this.textBox_SecondNumberCustom_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SecondNumberCustom_Settings.Name = "textBox_SecondNumberCustom_Settings";
            this.textBox_SecondNumberCustom_Settings.Size = new System.Drawing.Size(39, 27);
            this.textBox_SecondNumberCustom_Settings.TabIndex = 8;
            // 
            // radioButton_Hard_Settings
            // 
            this.radioButton_Hard_Settings.AutoSize = true;
            this.radioButton_Hard_Settings.Location = new System.Drawing.Point(39, 126);
            this.radioButton_Hard_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Hard_Settings.Name = "radioButton_Hard_Settings";
            this.radioButton_Hard_Settings.Size = new System.Drawing.Size(63, 24);
            this.radioButton_Hard_Settings.TabIndex = 12;
            this.radioButton_Hard_Settings.TabStop = true;
            this.radioButton_Hard_Settings.Text = "Hard";
            this.radioButton_Hard_Settings.UseVisualStyleBackColor = true;
            // 
            // radioButton_Easy_Settings
            // 
            this.radioButton_Easy_Settings.AutoSize = true;
            this.radioButton_Easy_Settings.Location = new System.Drawing.Point(39, 40);
            this.radioButton_Easy_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Easy_Settings.Name = "radioButton_Easy_Settings";
            this.radioButton_Easy_Settings.Size = new System.Drawing.Size(59, 24);
            this.radioButton_Easy_Settings.TabIndex = 11;
            this.radioButton_Easy_Settings.TabStop = true;
            this.radioButton_Easy_Settings.Text = "Easy";
            this.radioButton_Easy_Settings.UseVisualStyleBackColor = true;
            // 
            // form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox_Settings);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_Settings";
            this.Text = "Settings";
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.CheckedListBox checkedListBox_Color_Settings;
        private System.Windows.Forms.Button button_Save_Settings;
        private System.Windows.Forms.CheckedListBox checkedListBox_RoundShapes;
        private System.Windows.Forms.RadioButton radioButton_Normal_Settings;
        private System.Windows.Forms.RadioButton radioButton_Custom_Settings;
        private System.Windows.Forms.TextBox textBox_FirstNumberCustom_Settings;
        private System.Windows.Forms.TextBox textBox_SecondNumberCustom_Settings;
        private System.Windows.Forms.RadioButton radioButton_Hard_Settings;
        private System.Windows.Forms.RadioButton radioButton_Easy_Settings;
    }
}