namespace _08.BGN_to_EUR
{
    partial class Form1
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
            this.labelConvert = new System.Windows.Forms.Label();
            this.labelBGNtoEUR = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Location = new System.Drawing.Point(35, 42);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(64, 20);
            this.labelConvert.TabIndex = 0;
            this.labelConvert.Text = "Convert";
            // 
            // labelBGNtoEUR
            // 
            this.labelBGNtoEUR.AutoSize = true;
            this.labelBGNtoEUR.Location = new System.Drawing.Point(231, 42);
            this.labelBGNtoEUR.Name = "labelBGNtoEUR";
            this.labelBGNtoEUR.Size = new System.Drawing.Size(101, 20);
            this.labelBGNtoEUR.TabIndex = 1;
            this.labelBGNtoEUR.Text = "BGN to EUR";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.LightGreen;
            this.labelResult.Location = new System.Drawing.Point(39, 99);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(293, 42);
            this.labelResult.TabIndex = 2;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(105, 40);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAmount.TabIndex = 3;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBGNtoEUR);
            this.Controls.Add(this.labelConvert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BGN to EUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.Label labelBGNtoEUR;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
    }
}

