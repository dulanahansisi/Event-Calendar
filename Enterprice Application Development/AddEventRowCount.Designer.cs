namespace Enterprice_Application_Development
{
    partial class AddEventRowCount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxAddEventRowCount = new System.Windows.Forms.TextBox();
            this.btnGenerateAddRows = new System.Windows.Forms.Button();
            this.toolTipRowCount = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGetRows = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtBoxAddEventRowCount
            // 
            this.txtBoxAddEventRowCount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtBoxAddEventRowCount.Location = new System.Drawing.Point(0, 0);
            this.txtBoxAddEventRowCount.Multiline = true;
            this.txtBoxAddEventRowCount.Name = "txtBoxAddEventRowCount";
            this.txtBoxAddEventRowCount.Size = new System.Drawing.Size(84, 23);
            this.txtBoxAddEventRowCount.TabIndex = 8;
            this.toolTipRowCount.SetToolTip(this.txtBoxAddEventRowCount, "How many number of events you need to add?");
            // 
            // btnGenerateAddRows
            // 
            this.btnGenerateAddRows.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGenerateAddRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateAddRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAddRows.Location = new System.Drawing.Point(90, 0);
            this.btnGenerateAddRows.Name = "btnGenerateAddRows";
            this.btnGenerateAddRows.Size = new System.Drawing.Size(197, 23);
            this.btnGenerateAddRows.TabIndex = 9;
            this.btnGenerateAddRows.Text = "Get rows";
            this.toolTipGetRows.SetToolTip(this.btnGenerateAddRows, "Generate rows");
            this.btnGenerateAddRows.UseVisualStyleBackColor = false;
            // 
            // AddEventRowCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGenerateAddRows);
            this.Controls.Add(this.txtBoxAddEventRowCount);
            this.Name = "AddEventRowCount";
            this.Size = new System.Drawing.Size(289, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAddEventRowCount;
        public System.Windows.Forms.Button btnGenerateAddRows;
        private System.Windows.Forms.ToolTip toolTipRowCount;
        private System.Windows.Forms.ToolTip toolTipGetRows;
    }
}
