
using System.Windows.Forms;

namespace CourseWork
{
    partial class PriceFrom
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
            this.GroupCB = new System.Windows.Forms.ComboBox();
            this.DurationCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.childWeekDaysTB = new System.Windows.Forms.TextBox();
            this.childWeekEndsTB = new System.Windows.Forms.TextBox();
            this.adultWeekDaysTB = new System.Windows.Forms.TextBox();
            this.adultWeekEndsTB = new System.Windows.Forms.TextBox();
            this.oldWeekDaysTB = new System.Windows.Forms.TextBox();
            this.oldWeekEndsTB = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            // 
            // GroupCB
            // 
            this.GroupCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupCB.FormattingEnabled = true;
            this.GroupCB.Items.AddRange(new object[] {
            "1-4",
            "5-9",
            "10-19",
            "20 and Above"});
            this.GroupCB.Location = new System.Drawing.Point(120, 82);
            this.GroupCB.Name = "GroupCB";
            this.GroupCB.Size = new System.Drawing.Size(121, 33);
            this.GroupCB.TabIndex = 2;
            // 
            // DurationCB
            // 
            this.DurationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurationCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationCB.FormattingEnabled = true;
            this.DurationCB.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hour",
            "3 Hour",
            "4 Hour",
            "Whole Day"});
            this.DurationCB.Location = new System.Drawing.Point(430, 85);
            this.DurationCB.Name = "DurationCB";
            this.DurationCB.Size = new System.Drawing.Size(121, 33);
            this.DurationCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weekdays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Weekends";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "3-15";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "16-59";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "60 and Above";
            // 
            // childWeekDaysTB
            // 
            this.childWeekDaysTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childWeekDaysTB.Location = new System.Drawing.Point(227, 220);
            this.childWeekDaysTB.Name = "childWeekDaysTB";
            this.childWeekDaysTB.Size = new System.Drawing.Size(100, 30);
            this.childWeekDaysTB.TabIndex = 10;
            this.childWeekDaysTB.TextChanged += new System.EventHandler(this.childWeekDaysTB_TextChanged);
            // 
            // childWeekEndsTB
            // 
            this.childWeekEndsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childWeekEndsTB.Location = new System.Drawing.Point(430, 220);
            this.childWeekEndsTB.Name = "childWeekEndsTB";
            this.childWeekEndsTB.Size = new System.Drawing.Size(100, 30);
            this.childWeekEndsTB.TabIndex = 11;
            this.childWeekEndsTB.TextChanged += new System.EventHandler(this.childWeekEndsTB_TextChanged);
            // 
            // adultWeekDaysTB
            // 
            this.adultWeekDaysTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultWeekDaysTB.Location = new System.Drawing.Point(227, 298);
            this.adultWeekDaysTB.Name = "adultWeekDaysTB";
            this.adultWeekDaysTB.Size = new System.Drawing.Size(100, 30);
            this.adultWeekDaysTB.TabIndex = 12;
            this.adultWeekDaysTB.TextChanged += new System.EventHandler(this.adultWeekDaysTB_TextChanged);
            // 
            // adultWeekEndsTB
            // 
            this.adultWeekEndsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultWeekEndsTB.Location = new System.Drawing.Point(427, 297);
            this.adultWeekEndsTB.Name = "adultWeekEndsTB";
            this.adultWeekEndsTB.Size = new System.Drawing.Size(100, 30);
            this.adultWeekEndsTB.TabIndex = 13;
            this.adultWeekEndsTB.TextChanged += new System.EventHandler(this.adultWeekEndsTB_TextChanged);
            // 
            // oldWeekDaysTB
            // 
            this.oldWeekDaysTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldWeekDaysTB.Location = new System.Drawing.Point(227, 371);
            this.oldWeekDaysTB.Name = "oldWeekDaysTB";
            this.oldWeekDaysTB.Size = new System.Drawing.Size(100, 30);
            this.oldWeekDaysTB.TabIndex = 14;
            this.oldWeekDaysTB.TextChanged += new System.EventHandler(this.oldWeekDaysTB_TextChanged);
            // 
            // oldWeekEndsTB
            // 
            this.oldWeekEndsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldWeekEndsTB.Location = new System.Drawing.Point(427, 370);
            this.oldWeekEndsTB.Name = "oldWeekEndsTB";
            this.oldWeekEndsTB.Size = new System.Drawing.Size(100, 30);
            this.oldWeekEndsTB.TabIndex = 15;
            this.oldWeekEndsTB.TextChanged += new System.EventHandler(this.oldWeekEndsTB_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.RoyalBlue;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(223, 474);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(104, 44);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 39);
            this.label9.TabIndex = 17;
            this.label9.Text = "Price Setting";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(430, 474);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(97, 44);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(672, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 423);
            this.dataGridView1.TabIndex = 19;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.RoyalBlue;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(37, 474);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 44);
            this.update.TabIndex = 20;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // PriceFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1559, 651);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.oldWeekEndsTB);
            this.Controls.Add(this.oldWeekDaysTB);
            this.Controls.Add(this.adultWeekEndsTB);
            this.Controls.Add(this.adultWeekDaysTB);
            this.Controls.Add(this.childWeekEndsTB);
            this.Controls.Add(this.childWeekDaysTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DurationCB);
            this.Controls.Add(this.GroupCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PriceFrom";
            this.Text = "Price Setting Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GroupCB;
        private System.Windows.Forms.ComboBox DurationCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox childWeekDaysTB;
        private System.Windows.Forms.TextBox childWeekEndsTB;
        private System.Windows.Forms.TextBox adultWeekDaysTB;
        private System.Windows.Forms.TextBox adultWeekEndsTB;
        private System.Windows.Forms.TextBox oldWeekDaysTB;
        private System.Windows.Forms.TextBox oldWeekEndsTB;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button update;
    }
}

