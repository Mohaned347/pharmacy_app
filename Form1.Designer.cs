﻿namespace Pharmacy
{
    partial class Form1
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
            this.CusmterNameBox = new System.Windows.Forms.TextBox();
            this.MedicineBox = new System.Windows.Forms.TextBox();
            this.PersIDbox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.TotalCostBox = new System.Windows.Forms.TextBox();
            this.Cusmter_Name = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Medicine = new System.Windows.Forms.Label();
            this.Total_Cost = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CusmterNameBox
            // 
            this.CusmterNameBox.Location = new System.Drawing.Point(151, 93);
            this.CusmterNameBox.Name = "CusmterNameBox";
            this.CusmterNameBox.Size = new System.Drawing.Size(177, 22);
            this.CusmterNameBox.TabIndex = 0;
            // 
            // MedicineBox
            // 
            this.MedicineBox.Location = new System.Drawing.Point(518, 177);
            this.MedicineBox.Name = "MedicineBox";
            this.MedicineBox.Size = new System.Drawing.Size(177, 22);
            this.MedicineBox.TabIndex = 1;
            // 
            // PersIDbox
            // 
            this.PersIDbox.Location = new System.Drawing.Point(151, 177);
            this.PersIDbox.Name = "PersIDbox";
            this.PersIDbox.Size = new System.Drawing.Size(177, 22);
            this.PersIDbox.TabIndex = 2;
            // 
            // ContactBox
            // 
            this.ContactBox.Location = new System.Drawing.Point(518, 93);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(177, 22);
            this.ContactBox.TabIndex = 3;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(151, 251);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(177, 22);
            this.QuantityBox.TabIndex = 4;
            // 
            // TotalCostBox
            // 
            this.TotalCostBox.Location = new System.Drawing.Point(518, 251);
            this.TotalCostBox.Name = "TotalCostBox";
            this.TotalCostBox.Size = new System.Drawing.Size(177, 22);
            this.TotalCostBox.TabIndex = 5;
            // 
            // Cusmter_Name
            // 
            this.Cusmter_Name.AutoSize = true;
            this.Cusmter_Name.Location = new System.Drawing.Point(29, 99);
            this.Cusmter_Name.Name = "Cusmter_Name";
            this.Cusmter_Name.Size = new System.Drawing.Size(96, 16);
            this.Cusmter_Name.TabIndex = 6;
            this.Cusmter_Name.Text = "Cusmter Name";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(419, 99);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(52, 16);
            this.Contact.TabIndex = 7;
            this.Contact.Text = "Contact";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(29, 183);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(29, 257);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(55, 16);
            this.Quantity.TabIndex = 9;
            this.Quantity.Text = "Quantity";
            // 
            // Medicine
            // 
            this.Medicine.AutoSize = true;
            this.Medicine.Location = new System.Drawing.Point(419, 183);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(62, 16);
            this.Medicine.TabIndex = 10;
            this.Medicine.Text = "Medicine";
            // 
            // Total_Cost
            // 
            this.Total_Cost.AutoSize = true;
            this.Total_Cost.Location = new System.Drawing.Point(419, 257);
            this.Total_Cost.Name = "Total_Cost";
            this.Total_Cost.Size = new System.Drawing.Size(68, 16);
            this.Total_Cost.TabIndex = 11;
            this.Total_Cost.Text = "Total Cost";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(346, 354);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(96, 37);
            this.Done.TabIndex = 12;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Total_Cost);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Cusmter_Name);
            this.Controls.Add(this.TotalCostBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.PersIDbox);
            this.Controls.Add(this.MedicineBox);
            this.Controls.Add(this.CusmterNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CusmterNameBox;
        private System.Windows.Forms.TextBox MedicineBox;
        private System.Windows.Forms.TextBox PersIDbox;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox TotalCostBox;
        private System.Windows.Forms.Label Cusmter_Name;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.Label Total_Cost;
        private System.Windows.Forms.Button Done;
    }
}

