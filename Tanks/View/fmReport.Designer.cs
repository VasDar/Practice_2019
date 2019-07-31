namespace View
{
	partial class fmReport
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
			this.dgvReport = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvReport
			// 
			this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.x,
            this.y});
			this.dgvReport.Location = new System.Drawing.Point(0, 1);
			this.dgvReport.Name = "dgvReport";
			this.dgvReport.Size = new System.Drawing.Size(347, 453);
			this.dgvReport.TabIndex = 0;
			// 
			// name
			// 
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			// 
			// x
			// 
			this.x.HeaderText = "X";
			this.x.Name = "x";
			// 
			// y
			// 
			this.y.HeaderText = "Y";
			this.y.Name = "y";
			// 
			// fmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 450);
			this.Controls.Add(this.dgvReport);
			this.Name = "fmReport";
			this.Text = "fmReport";
			((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvReport;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn x;
		private System.Windows.Forms.DataGridViewTextBoxColumn y;
	}
}