namespace View
{
	partial class fmBase
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
			this.pBoxBase = new System.Windows.Forms.PictureBox();
			this.dgvBase = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pBoxBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
			this.SuspendLayout();
			// 
			// pBoxBase
			// 
			this.pBoxBase.Location = new System.Drawing.Point(0, 43);
			this.pBoxBase.Name = "pBoxBase";
			this.pBoxBase.Size = new System.Drawing.Size(883, 417);
			this.pBoxBase.TabIndex = 0;
			this.pBoxBase.TabStop = false;
			// 
			// dgvBase
			// 
			this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.score});
			this.dgvBase.Location = new System.Drawing.Point(0, 0);
			this.dgvBase.Name = "dgvBase";
			this.dgvBase.Size = new System.Drawing.Size(246, 45);
			this.dgvBase.TabIndex = 1;
			// 
			// name
			// 
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			// 
			// score
			// 
			this.score.HeaderText = "Score";
			this.score.Name = "score";
			// 
			// btnNewGame
			// 
			this.btnNewGame.Location = new System.Drawing.Point(289, 14);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(75, 23);
			this.btnNewGame.TabIndex = 2;
			this.btnNewGame.Text = "New Game";
			this.btnNewGame.UseVisualStyleBackColor = true;
			// 
			// btnReport
			// 
			this.btnReport.Location = new System.Drawing.Point(391, 14);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(75, 23);
			this.btnReport.TabIndex = 3;
			this.btnReport.Text = "Report";
			this.btnReport.UseVisualStyleBackColor = true;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(493, 14);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// fmBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 453);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.dgvBase);
			this.Controls.Add(this.pBoxBase);
			this.Name = "fmBase";
			this.Text = "Tanks";
			((System.ComponentModel.ISupportInitialize)(this.pBoxBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pBoxBase;
		private System.Windows.Forms.DataGridView dgvBase;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn score;
	}
}