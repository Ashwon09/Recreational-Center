
namespace CourseWork
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportDailyButton = new System.Windows.Forms.Button();
            this.reportWeeklyButton = new System.Windows.Forms.Button();
            this.reportChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Daily Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "View Weekly Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "View Chart";
            // 
            // reportDailyButton
            // 
            this.reportDailyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.reportDailyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDailyButton.Location = new System.Drawing.Point(375, 161);
            this.reportDailyButton.Name = "reportDailyButton";
            this.reportDailyButton.Size = new System.Drawing.Size(179, 53);
            this.reportDailyButton.TabIndex = 4;
            this.reportDailyButton.Text = "Daily Report";
            this.reportDailyButton.UseVisualStyleBackColor = false;
            this.reportDailyButton.Click += new System.EventHandler(this.reportDailyButton_Click);
            // 
            // reportWeeklyButton
            // 
            this.reportWeeklyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.reportWeeklyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportWeeklyButton.Location = new System.Drawing.Point(375, 242);
            this.reportWeeklyButton.Name = "reportWeeklyButton";
            this.reportWeeklyButton.Size = new System.Drawing.Size(179, 53);
            this.reportWeeklyButton.TabIndex = 5;
            this.reportWeeklyButton.Text = "Weekly Report";
            this.reportWeeklyButton.UseVisualStyleBackColor = false;
            this.reportWeeklyButton.Click += new System.EventHandler(this.reportWeeklyButton_Click);
            // 
            // reportChartButton
            // 
            this.reportChartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.reportChartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportChartButton.Location = new System.Drawing.Point(375, 326);
            this.reportChartButton.Name = "reportChartButton";
            this.reportChartButton.Size = new System.Drawing.Size(179, 53);
            this.reportChartButton.TabIndex = 6;
            this.reportChartButton.Text = "Chart Report";
            this.reportChartButton.UseVisualStyleBackColor = false;
            this.reportChartButton.Click += new System.EventHandler(this.reportChartButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 474);
            this.Controls.Add(this.reportChartButton);
            this.Controls.Add(this.reportWeeklyButton);
            this.Controls.Add(this.reportDailyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reportDailyButton;
        private System.Windows.Forms.Button reportWeeklyButton;
        private System.Windows.Forms.Button reportChartButton;
    }
}