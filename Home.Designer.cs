
namespace CourseWork
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.openPriceSetting = new System.Windows.Forms.Button();
            this.visitorCheckIn = new System.Windows.Forms.Button();
            this.openReports = new System.Windows.Forms.Button();
            this.visitorCheckOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recreational Center";
            // 
            // openPriceSetting
            // 
            this.openPriceSetting.BackColor = System.Drawing.Color.RoyalBlue;
            this.openPriceSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPriceSetting.Location = new System.Drawing.Point(880, 221);
            this.openPriceSetting.Name = "openPriceSetting";
            this.openPriceSetting.Size = new System.Drawing.Size(164, 49);
            this.openPriceSetting.TabIndex = 1;
            this.openPriceSetting.Text = "Price Setting";
            this.openPriceSetting.UseVisualStyleBackColor = false;
            this.openPriceSetting.Click += new System.EventHandler(this.openPriceSetting_Click);
            // 
            // visitorCheckIn
            // 
            this.visitorCheckIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.visitorCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorCheckIn.Location = new System.Drawing.Point(30, 221);
            this.visitorCheckIn.Name = "visitorCheckIn";
            this.visitorCheckIn.Size = new System.Drawing.Size(164, 49);
            this.visitorCheckIn.TabIndex = 2;
            this.visitorCheckIn.Text = "Visitor Check In";
            this.visitorCheckIn.UseVisualStyleBackColor = false;
            this.visitorCheckIn.Click += new System.EventHandler(this.visitorCheckIn_Click);
            // 
            // openReports
            // 
            this.openReports.BackColor = System.Drawing.Color.RoyalBlue;
            this.openReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openReports.Location = new System.Drawing.Point(880, 316);
            this.openReports.Name = "openReports";
            this.openReports.Size = new System.Drawing.Size(164, 49);
            this.openReports.TabIndex = 3;
            this.openReports.Text = "Open Reports";
            this.openReports.UseVisualStyleBackColor = false;
            this.openReports.Click += new System.EventHandler(this.openReports_Click);
            // 
            // visitorCheckOut
            // 
            this.visitorCheckOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.visitorCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorCheckOut.Location = new System.Drawing.Point(30, 316);
            this.visitorCheckOut.Name = "visitorCheckOut";
            this.visitorCheckOut.Size = new System.Drawing.Size(164, 49);
            this.visitorCheckOut.TabIndex = 4;
            this.visitorCheckOut.Text = "Visitor Check Out";
            this.visitorCheckOut.UseVisualStyleBackColor = false;
            this.visitorCheckOut.Click += new System.EventHandler(this.visitorCheckOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Today\'s Visitors";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 263);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Visitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(925, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Admin";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitorCheckOut);
            this.Controls.Add(this.openReports);
            this.Controls.Add(this.visitorCheckIn);
            this.Controls.Add(this.openPriceSetting);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openPriceSetting;
        private System.Windows.Forms.Button visitorCheckIn;
        private System.Windows.Forms.Button openReports;
        private System.Windows.Forms.Button visitorCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}