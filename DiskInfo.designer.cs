namespace CurseH
{
    partial class DiskInfoForm
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
            this.LblDriveName = new System.Windows.Forms.Label();
            this.LblDriveType = new System.Windows.Forms.Label();
            this.LblDriveFormat = new System.Windows.Forms.Label();
            this.LblTotalSpace = new System.Windows.Forms.Label();
            this.LblFreeSpace = new System.Windows.Forms.Label();
            this.LblOccupiedSpace = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDriveName
            // 
            this.LblDriveName.AutoSize = true;
            this.LblDriveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDriveName.Location = new System.Drawing.Point(168, 9);
            this.LblDriveName.Name = "LblDriveName";
            this.LblDriveName.Size = new System.Drawing.Size(50, 20);
            this.LblDriveName.TabIndex = 0;
            this.LblDriveName.Text = "Диск ";
            // 
            // LblDriveType
            // 
            this.LblDriveType.AutoSize = true;
            this.LblDriveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDriveType.Location = new System.Drawing.Point(23, 46);
            this.LblDriveType.Name = "LblDriveType";
            this.LblDriveType.Size = new System.Drawing.Size(112, 18);
            this.LblDriveType.TabIndex = 1;
            this.LblDriveType.Text = "Тип пристрою: ";
            // 
            // LblDriveFormat
            // 
            this.LblDriveFormat.AutoSize = true;
            this.LblDriveFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDriveFormat.Location = new System.Drawing.Point(23, 85);
            this.LblDriveFormat.Name = "LblDriveFormat";
            this.LblDriveFormat.Size = new System.Drawing.Size(141, 18);
            this.LblDriveFormat.TabIndex = 2;
            this.LblDriveFormat.Text = "Файлова система: ";
            // 
            // LblTotalSpace
            // 
            this.LblTotalSpace.AutoSize = true;
            this.LblTotalSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTotalSpace.Location = new System.Drawing.Point(23, 125);
            this.LblTotalSpace.Name = "LblTotalSpace";
            this.LblTotalSpace.Size = new System.Drawing.Size(148, 18);
            this.LblTotalSpace.TabIndex = 3;
            this.LblTotalSpace.Text = "Загальна місткість: ";
            // 
            // LblFreeSpace
            // 
            this.LblFreeSpace.AutoSize = true;
            this.LblFreeSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblFreeSpace.Location = new System.Drawing.Point(23, 205);
            this.LblFreeSpace.Name = "LblFreeSpace";
            this.LblFreeSpace.Size = new System.Drawing.Size(63, 18);
            this.LblFreeSpace.TabIndex = 4;
            this.LblFreeSpace.Text = "Вільно: ";
            // 
            // LblOccupiedSpace
            // 
            this.LblOccupiedSpace.AutoSize = true;
            this.LblOccupiedSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblOccupiedSpace.Location = new System.Drawing.Point(23, 164);
            this.LblOccupiedSpace.Name = "LblOccupiedSpace";
            this.LblOccupiedSpace.Size = new System.Drawing.Size(74, 18);
            this.LblOccupiedSpace.TabIndex = 5;
            this.LblOccupiedSpace.Text = "Зайнято: ";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(175, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DiskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblOccupiedSpace);
            this.Controls.Add(this.LblFreeSpace);
            this.Controls.Add(this.LblTotalSpace);
            this.Controls.Add(this.LblDriveFormat);
            this.Controls.Add(this.LblDriveType);
            this.Controls.Add(this.LblDriveName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiskInfoForm";
            this.Text = "DiskInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDriveName;
        private System.Windows.Forms.Label LblDriveType;
        private System.Windows.Forms.Label LblDriveFormat;
        private System.Windows.Forms.Label LblTotalSpace;
        private System.Windows.Forms.Label LblFreeSpace;
        private System.Windows.Forms.Label LblOccupiedSpace;
        private System.Windows.Forms.Button button1;
    }
}