﻿namespace AssignmentDatabase
{
    partial class AddDeviceTypeForm
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
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deviceTypeGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextbox
            // 
            this.codeTextbox.Location = new System.Drawing.Point(150, 84);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(185, 20);
            this.codeTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Thiết Bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thiết Bị:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(150, 127);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(185, 20);
            this.nameTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi Chú:";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(424, 84);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(331, 80);
            this.descriptionTextbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thiết Bị";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(150, 160);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 26);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deviceTypeGridView
            // 
            this.deviceTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceTypeGridView.Location = new System.Drawing.Point(7, 207);
            this.deviceTypeGridView.Margin = new System.Windows.Forms.Padding(2);
            this.deviceTypeGridView.Name = "deviceTypeGridView";
            this.deviceTypeGridView.RowTemplate.Height = 33;
            this.deviceTypeGridView.Size = new System.Drawing.Size(750, 215);
            this.deviceTypeGridView.TabIndex = 8;
            this.deviceTypeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deviceTypeGridView_CellContentClick);
            // 
            // AddDeviceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 458);
            this.Controls.Add(this.deviceTypeGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTextbox);
            this.Name = "AddDeviceTypeForm";
            this.Text = "Thietbi";
            this.Load += new System.EventHandler(this.AddDeviceTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView deviceTypeGridView;
    }
}