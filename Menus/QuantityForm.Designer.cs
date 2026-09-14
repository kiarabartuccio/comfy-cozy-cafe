using System.Windows.Forms;

namespace Menus
{
    partial class QuantityForm
    {
        private System.ComponentModel.IContainer components = null;
        private NumericUpDown EditValue;
        private Button btnOK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.EditValue = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditValue)).BeginInit();
            this.SuspendLayout();
            // 
            // EditValue
            // 
            this.EditValue.Location = new System.Drawing.Point(57, 23);
            this.EditValue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.EditValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditValue.Name = "EditValue";
            this.EditValue.Size = new System.Drawing.Size(50, 22);
            this.EditValue.TabIndex = 0;
            this.EditValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(20, 60);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 48);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Apply";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // QuantityForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(187)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(150, 120);
            this.Controls.Add(this.EditValue);
            this.Controls.Add(this.btnOK);
            this.Name = "QuantityForm";
            this.Text = "Change Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.EditValue)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
