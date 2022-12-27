namespace CurseH
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.diskDataGridView = new System.Windows.Forms.DataGridView();
            this.cbMeasureUnits = new System.Windows.Forms.ComboBox();
            this.LbMeasure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diskDataGridView
            // 
            this.diskDataGridView.AllowUserToAddRows = false;
            this.diskDataGridView.AllowUserToDeleteRows = false;
            this.diskDataGridView.AllowUserToResizeRows = false;
            this.diskDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diskDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diskDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.diskDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.diskDataGridView.Location = new System.Drawing.Point(0, 39);
            this.diskDataGridView.MultiSelect = false;
            this.diskDataGridView.Name = "diskDataGridView";
            this.diskDataGridView.ReadOnly = true;
            this.diskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.diskDataGridView.Size = new System.Drawing.Size(534, 168);
            this.diskDataGridView.TabIndex = 0;
            // 
            // cbMeasureUnits
            // 
            this.cbMeasureUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeasureUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasureUnits.FormattingEnabled = true;
            this.cbMeasureUnits.Location = new System.Drawing.Point(401, 12);
            this.cbMeasureUnits.Name = "cbMeasureUnits";
            this.cbMeasureUnits.Size = new System.Drawing.Size(121, 21);
            this.cbMeasureUnits.TabIndex = 2;
            // 
            // LbMeasure
            // 
            this.LbMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbMeasure.AutoSize = true;
            this.LbMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbMeasure.Location = new System.Drawing.Point(296, 15);
            this.LbMeasure.Name = "LbMeasure";
            this.LbMeasure.Size = new System.Drawing.Size(100, 13);
            this.LbMeasure.TabIndex = 3;
            this.LbMeasure.Text = "Відображати у: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 207);
            this.Controls.Add(this.LbMeasure);
            this.Controls.Add(this.cbMeasureUnits);
            this.Controls.Add(this.diskDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "CurseH";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView diskDataGridView;
        private System.Windows.Forms.ComboBox cbMeasureUnits;
        private System.Windows.Forms.Label LbMeasure;
    }
}

