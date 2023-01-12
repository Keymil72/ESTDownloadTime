namespace ESTDownloadTime
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Speed = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SpeedUnit = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.DownloadUnit = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.Size = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.calc = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.Time = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
            this.SuspendLayout();
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Speed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Speed.DecimalPlaces = 2;
            this.Speed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Speed.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.Speed.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Speed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Speed.Location = new System.Drawing.Point(31, 59);
            this.Speed.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Speed.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(172, 45);
            this.Speed.TabIndex = 1;
            this.Speed.UpDownButtonBorderVisible = false;
            this.Speed.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Speed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Speed.ValueChanged += new System.EventHandler(this.siticoneNumericUpDown1_ValueChanged);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(31, 12);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(121, 29);
            this.siticoneHtmlLabel1.TabIndex = 2;
            this.siticoneHtmlLabel1.Text = "Prędkość:";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // SpeedUnit
            // 
            this.SpeedUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.SpeedUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.SpeedUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SpeedUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedUnit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SpeedUnit.FocusedColor = System.Drawing.Color.Transparent;
            this.SpeedUnit.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.SpeedUnit.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeedUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SpeedUnit.ItemHeight = 30;
            this.SpeedUnit.Items.AddRange(new object[] {
            "b/s",
            "B/s",
            "Kb/s",
            "KB/s",
            "Mb/s",
            "MB/s",
            "Gb/s",
            "GB/s"});
            this.SpeedUnit.Location = new System.Drawing.Point(168, 12);
            this.SpeedUnit.Name = "SpeedUnit";
            this.SpeedUnit.Size = new System.Drawing.Size(136, 36);
            this.SpeedUnit.StartIndex = 4;
            this.SpeedUnit.TabIndex = 3;
            this.SpeedUnit.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.ForestGreen;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(31, 145);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(160, 29);
            this.siticoneHtmlLabel2.TabIndex = 4;
            this.siticoneHtmlLabel2.Text = "Do pobrania:";
            // 
            // DownloadUnit
            // 
            this.DownloadUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.DownloadUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.DownloadUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DownloadUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DownloadUnit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DownloadUnit.FocusedColor = System.Drawing.Color.Transparent;
            this.DownloadUnit.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.DownloadUnit.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DownloadUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DownloadUnit.ItemHeight = 30;
            this.DownloadUnit.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB"});
            this.DownloadUnit.Location = new System.Drawing.Point(209, 145);
            this.DownloadUnit.Name = "DownloadUnit";
            this.DownloadUnit.Size = new System.Drawing.Size(95, 36);
            this.DownloadUnit.StartIndex = 3;
            this.DownloadUnit.TabIndex = 5;
            // 
            // Size
            // 
            this.Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Size.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Size.DecimalPlaces = 2;
            this.Size.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Size.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Size.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Size.Location = new System.Drawing.Point(31, 192);
            this.Size.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Size.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(172, 45);
            this.Size.TabIndex = 6;
            this.Size.UpDownButtonBorderVisible = false;
            this.Size.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // calc
            // 
            this.calc.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.calc.HoverState.ImageSize = new System.Drawing.Size(92, 92);
            this.calc.Image = ((System.Drawing.Image)(resources.GetObject("calc.Image")));
            this.calc.ImageOffset = new System.Drawing.Point(0, 0);
            this.calc.ImageRotate = 0F;
            this.calc.ImageSize = new System.Drawing.Size(77, 77);
            this.calc.Location = new System.Drawing.Point(31, 248);
            this.calc.Name = "calc";
            this.calc.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.calc.Size = new System.Drawing.Size(77, 77);
            this.calc.TabIndex = 8;
            this.calc.Click += new System.EventHandler(this.Calculate);
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Time.Location = new System.Drawing.Point(296, 326);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(103, 34);
            this.Time.TabIndex = 9;
            this.Time.Text = "No Data";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Georgia", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.ForestGreen;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(31, 331);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(259, 29);
            this.siticoneHtmlLabel3.TabIndex = 10;
            this.siticoneHtmlLabel3.Text = "EST. czas pobierania:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(649, 376);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.DownloadUnit);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.SpeedUnit);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.Speed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "EST Download Time";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown Speed;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox SpeedUnit;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox DownloadUnit;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown Size;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton calc;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Time;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
    }
}