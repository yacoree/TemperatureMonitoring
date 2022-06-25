
namespace TemperatureMonitoringWinForms
{
    partial class FormReportFish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportFish));
            this.tbKindOfFish = new System.Windows.Forms.TextBox();
            this.tbMaxStorageTemperature = new System.Windows.Forms.TextBox();
            this.tbTimeExceededMaxTemperature = new System.Windows.Forms.TextBox();
            this.tbMinStorageTemperature = new System.Windows.Forms.TextBox();
            this.tbTimeExceededMinTemperature = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemperatureSensorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelKindOfFish = new System.Windows.Forms.Label();
            this.labelMaxStorageTemperature = new System.Windows.Forms.Label();
            this.labelTimeExceededMaxTemperature = new System.Windows.Forms.Label();
            this.labelTimeExceededMinTemperature = new System.Windows.Forms.Label();
            this.labelMinStorageTemperature = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKindOfFish
            // 
            this.tbKindOfFish.Location = new System.Drawing.Point(228, 50);
            this.tbKindOfFish.Name = "tbKindOfFish";
            this.tbKindOfFish.Size = new System.Drawing.Size(175, 23);
            this.tbKindOfFish.TabIndex = 0;
            // 
            // tbMaxStorageTemperature
            // 
            this.tbMaxStorageTemperature.Location = new System.Drawing.Point(228, 100);
            this.tbMaxStorageTemperature.Name = "tbMaxStorageTemperature";
            this.tbMaxStorageTemperature.Size = new System.Drawing.Size(175, 23);
            this.tbMaxStorageTemperature.TabIndex = 1;
            this.tbMaxStorageTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // tbTimeExceededMaxTemperature
            // 
            this.tbTimeExceededMaxTemperature.Location = new System.Drawing.Point(228, 150);
            this.tbTimeExceededMaxTemperature.Name = "tbTimeExceededMaxTemperature";
            this.tbTimeExceededMaxTemperature.Size = new System.Drawing.Size(175, 23);
            this.tbTimeExceededMaxTemperature.TabIndex = 2;
            this.tbTimeExceededMaxTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // tbMinStorageTemperature
            // 
            this.tbMinStorageTemperature.Location = new System.Drawing.Point(228, 200);
            this.tbMinStorageTemperature.Name = "tbMinStorageTemperature";
            this.tbMinStorageTemperature.Size = new System.Drawing.Size(175, 23);
            this.tbMinStorageTemperature.TabIndex = 3;
            this.tbMinStorageTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // tbTimeExceededMinTemperature
            // 
            this.tbTimeExceededMinTemperature.Location = new System.Drawing.Point(228, 250);
            this.tbTimeExceededMinTemperature.Name = "tbTimeExceededMinTemperature";
            this.tbTimeExceededMinTemperature.Size = new System.Drawing.Size(175, 23);
            this.tbTimeExceededMinTemperature.TabIndex = 4;
            this.tbTimeExceededMinTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(228, 300);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(175, 23);
            this.tbDate.TabIndex = 5;
            this.tbDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPresstemperature);
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(228, 350);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(175, 50);
            this.tbTemperature.TabIndex = 6;
            this.tbTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPresstemperature);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(328, 415);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 8;
            this.btnGetReport.Text = "get report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveTemperatureSensorReportToolStripMenuItem,
            this.saveFishToolStripMenuItem,
            this.loadFishToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.loadToolStripMenuItem.Text = "Load temperature sensor report ";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveTemperatureSensorReportToolStripMenuItem
            // 
            this.saveTemperatureSensorReportToolStripMenuItem.Name = "saveTemperatureSensorReportToolStripMenuItem";
            this.saveTemperatureSensorReportToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.saveTemperatureSensorReportToolStripMenuItem.Text = "Save temperature sensor report ";
            this.saveTemperatureSensorReportToolStripMenuItem.Click += new System.EventHandler(this.saveTemperatureSensorReportToolStripMenuItem_Click);
            // 
            // saveFishToolStripMenuItem
            // 
            this.saveFishToolStripMenuItem.Name = "saveFishToolStripMenuItem";
            this.saveFishToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.saveFishToolStripMenuItem.Text = "Save fish";
            this.saveFishToolStripMenuItem.Click += new System.EventHandler(this.saveFishToolStripMenuItem_Click);
            // 
            // loadFishToolStripMenuItem
            // 
            this.loadFishToolStripMenuItem.Name = "loadFishToolStripMenuItem";
            this.loadFishToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.loadFishToolStripMenuItem.Text = "Load fish";
            this.loadFishToolStripMenuItem.Click += new System.EventHandler(this.loadFishToolStripMenuItem_Click);
            // 
            // labelKindOfFish
            // 
            this.labelKindOfFish.AutoSize = true;
            this.labelKindOfFish.Location = new System.Drawing.Point(12, 53);
            this.labelKindOfFish.Name = "labelKindOfFish";
            this.labelKindOfFish.Size = new System.Drawing.Size(67, 15);
            this.labelKindOfFish.TabIndex = 10;
            this.labelKindOfFish.Text = "Kind of fish";
            // 
            // labelMaxStorageTemperature
            // 
            this.labelMaxStorageTemperature.AutoSize = true;
            this.labelMaxStorageTemperature.Location = new System.Drawing.Point(12, 103);
            this.labelMaxStorageTemperature.Name = "labelMaxStorageTemperature";
            this.labelMaxStorageTemperature.Size = new System.Drawing.Size(142, 15);
            this.labelMaxStorageTemperature.TabIndex = 11;
            this.labelMaxStorageTemperature.Text = "Max Storage Temperature";
            // 
            // labelTimeExceededMaxTemperature
            // 
            this.labelTimeExceededMaxTemperature.AutoSize = true;
            this.labelTimeExceededMaxTemperature.Location = new System.Drawing.Point(12, 153);
            this.labelTimeExceededMaxTemperature.Name = "labelTimeExceededMaxTemperature";
            this.labelTimeExceededMaxTemperature.Size = new System.Drawing.Size(181, 15);
            this.labelTimeExceededMaxTemperature.TabIndex = 12;
            this.labelTimeExceededMaxTemperature.Text = "Time Exceeded Max Temperature";
            // 
            // labelTimeExceededMinTemperature
            // 
            this.labelTimeExceededMinTemperature.AutoSize = true;
            this.labelTimeExceededMinTemperature.Location = new System.Drawing.Point(12, 258);
            this.labelTimeExceededMinTemperature.Name = "labelTimeExceededMinTemperature";
            this.labelTimeExceededMinTemperature.Size = new System.Drawing.Size(179, 15);
            this.labelTimeExceededMinTemperature.TabIndex = 13;
            this.labelTimeExceededMinTemperature.Text = "Time Exceeded Min Temperature";
            // 
            // labelMinStorageTemperature
            // 
            this.labelMinStorageTemperature.AutoSize = true;
            this.labelMinStorageTemperature.Location = new System.Drawing.Point(12, 208);
            this.labelMinStorageTemperature.Name = "labelMinStorageTemperature";
            this.labelMinStorageTemperature.Size = new System.Drawing.Size(140, 15);
            this.labelMinStorageTemperature.TabIndex = 14;
            this.labelMinStorageTemperature.Text = "Min Storage Temperature";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 308);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(121, 15);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Start of measurement";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(12, 365);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(73, 15);
            this.labelTemperature.TabIndex = 16;
            this.labelTemperature.Text = "Temperature";
            // 
            // FormReportFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMinStorageTemperature);
            this.Controls.Add(this.labelTimeExceededMinTemperature);
            this.Controls.Add(this.labelTimeExceededMaxTemperature);
            this.Controls.Add(this.labelMaxStorageTemperature);
            this.Controls.Add(this.labelKindOfFish);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbTimeExceededMinTemperature);
            this.Controls.Add(this.tbMinStorageTemperature);
            this.Controls.Add(this.tbTimeExceededMaxTemperature);
            this.Controls.Add(this.tbMaxStorageTemperature);
            this.Controls.Add(this.tbKindOfFish);
            this.Name = "FormReportFish";
            this.Text = "Report fish";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label labelKindOfFish;
        private System.Windows.Forms.Label labelMaxStorageTemperature;
        private System.Windows.Forms.Label labelTimeExceededMaxTemperature;
        private System.Windows.Forms.Label labelTimeExceededMinTemperature;
        private System.Windows.Forms.Label labelMinStorageTemperature;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.ToolStripMenuItem saveTemperatureSensorReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFishToolStripMenuItem;
    }
}

