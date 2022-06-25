
namespace TemperatureMonitoringWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbKindOfFish = new System.Windows.Forms.TextBox();
            this.tbMaxStorageTemperature = new System.Windows.Forms.TextBox();
            this.tbTimeExceededMaxTemperature = new System.Windows.Forms.TextBox();
            this.tbMinStorageTemperature = new System.Windows.Forms.TextBox();
            this.tbTimeExceededMinTemperature = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbKindOfFish
            // 
            this.tbKindOfFish.Location = new System.Drawing.Point(12, 12);
            this.tbKindOfFish.Name = "tbKindOfFish";
            this.tbKindOfFish.Size = new System.Drawing.Size(100, 23);
            this.tbKindOfFish.TabIndex = 0;
            // 
            // tbMaxStorageTemperature
            // 
            this.tbMaxStorageTemperature.Location = new System.Drawing.Point(12, 62);
            this.tbMaxStorageTemperature.Name = "tbMaxStorageTemperature";
            this.tbMaxStorageTemperature.Size = new System.Drawing.Size(100, 23);
            this.tbMaxStorageTemperature.TabIndex = 1;
            // 
            // tbTimeExceededMaxTemperature
            // 
            this.tbTimeExceededMaxTemperature.Location = new System.Drawing.Point(12, 112);
            this.tbTimeExceededMaxTemperature.Name = "tbTimeExceededMaxTemperature";
            this.tbTimeExceededMaxTemperature.Size = new System.Drawing.Size(100, 23);
            this.tbTimeExceededMaxTemperature.TabIndex = 2;
            // 
            // tbMinStorageTemperature
            // 
            this.tbMinStorageTemperature.Location = new System.Drawing.Point(12, 165);
            this.tbMinStorageTemperature.Name = "tbMinStorageTemperature";
            this.tbMinStorageTemperature.Size = new System.Drawing.Size(100, 23);
            this.tbMinStorageTemperature.TabIndex = 3;
            // 
            // tbTimeExceededMinTemperature
            // 
            this.tbTimeExceededMinTemperature.Location = new System.Drawing.Point(12, 214);
            this.tbTimeExceededMinTemperature.Name = "tbTimeExceededMinTemperature";
            this.tbTimeExceededMinTemperature.Size = new System.Drawing.Size(100, 23);
            this.tbTimeExceededMinTemperature.TabIndex = 4;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(12, 265);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 23);
            this.tbDate.TabIndex = 5;
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(12, 314);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(100, 23);
            this.tbTemperature.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(541, 392);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 8;
            this.btnGetReport.Text = "button2";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbTimeExceededMinTemperature);
            this.Controls.Add(this.tbMinStorageTemperature);
            this.Controls.Add(this.tbTimeExceededMaxTemperature);
            this.Controls.Add(this.tbMaxStorageTemperature);
            this.Controls.Add(this.tbKindOfFish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKindOfFish;
        private System.Windows.Forms.TextBox tbMaxStorageTemperature;
        private System.Windows.Forms.TextBox tbTimeExceededMaxTemperature;
        private System.Windows.Forms.TextBox tbMinStorageTemperature;
        private System.Windows.Forms.TextBox tbTimeExceededMinTemperature;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetReport;
    }
}

