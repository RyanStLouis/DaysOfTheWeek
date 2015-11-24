namespace DaysOfTheWeek
{
    partial class frmDaysOfTheWeek
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
            this.lstDays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDays
            // 
            this.lstDays.FormattingEnabled = true;
            this.lstDays.Location = new System.Drawing.Point(70, 75);
            this.lstDays.Name = "lstDays";
            this.lstDays.Size = new System.Drawing.Size(137, 121);
            this.lstDays.TabIndex = 0;
            this.lstDays.SelectedIndexChanged += new System.EventHandler(this.lstDays_SelectedIndexChanged);
            // 
            // frmDaysOfTheWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstDays);
            this.Name = "frmDaysOfTheWeek";
            this.Text = "Days Of The Week";
            this.Load += new System.EventHandler(this.frmDaysOfTheWeek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDays;
    }
}

