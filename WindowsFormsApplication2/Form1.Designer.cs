namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.comboEffects = new System.Windows.Forms.ComboBox();
            this.textEffects = new System.Windows.Forms.TextBox();
            this.trackBreath = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelValRed = new System.Windows.Forms.Label();
            this.labelValGreen = new System.Windows.Forms.Label();
            this.labelValBlue = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.labelPulseSpeed = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.trackBreath)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEffects
            // 
            this.comboEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEffects.FormattingEnabled = true;
            this.comboEffects.Items.AddRange(new object[] {
            "None",
            "Rainbow",
            "Breathing"});
            this.comboEffects.Location = new System.Drawing.Point(652, 82);
            this.comboEffects.Name = "comboEffects";
            this.comboEffects.Size = new System.Drawing.Size(193, 21);
            this.comboEffects.TabIndex = 0;
            this.comboEffects.SelectedIndexChanged += new System.EventHandler(this.comboEffects_SelectedIndexChanged);
            // 
            // textEffects
            // 
            this.textEffects.Location = new System.Drawing.Point(158, 82);
            this.textEffects.Name = "textEffects";
            this.textEffects.ReadOnly = true;
            this.textEffects.Size = new System.Drawing.Size(206, 20);
            this.textEffects.TabIndex = 1;
            // 
            // trackBreath
            // 
            this.trackBreath.LargeChange = 0;
            this.trackBreath.Location = new System.Drawing.Point(158, 158);
            this.trackBreath.Maximum = 100;
            this.trackBreath.Minimum = 1;
            this.trackBreath.Name = "trackBreath";
            this.trackBreath.Size = new System.Drawing.Size(206, 45);
            this.trackBreath.TabIndex = 3;
            this.trackBreath.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBreath.Value = 5;
            this.trackBreath.Visible = false;
            this.trackBreath.Scroll += new System.EventHandler(this.trackBreath_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Preset Effects";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(456, 272);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(42, 13);
            this.labelRed.TabIndex = 6;
            this.labelRed.Text = "Red    :";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(456, 304);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(42, 13);
            this.labelGreen.TabIndex = 7;
            this.labelGreen.Text = "Green :";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(456, 335);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(43, 13);
            this.labelBlue.TabIndex = 8;
            this.labelBlue.Text = "Blue    :";
            // 
            // labelValRed
            // 
            this.labelValRed.AutoSize = true;
            this.labelValRed.Location = new System.Drawing.Point(505, 272);
            this.labelValRed.Name = "labelValRed";
            this.labelValRed.Size = new System.Drawing.Size(25, 13);
            this.labelValRed.TabIndex = 9;
            this.labelValRed.Text = "255";
            // 
            // labelValGreen
            // 
            this.labelValGreen.AutoSize = true;
            this.labelValGreen.Location = new System.Drawing.Point(505, 304);
            this.labelValGreen.Name = "labelValGreen";
            this.labelValGreen.Size = new System.Drawing.Size(25, 13);
            this.labelValGreen.TabIndex = 10;
            this.labelValGreen.Text = "180";
            // 
            // labelValBlue
            // 
            this.labelValBlue.AutoSize = true;
            this.labelValBlue.Location = new System.Drawing.Point(503, 335);
            this.labelValBlue.Name = "labelValBlue";
            this.labelValBlue.Size = new System.Drawing.Size(19, 13);
            this.labelValBlue.TabIndex = 11;
            this.labelValBlue.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TEST LED OUTPUT";
            // 
            // labelPulseSpeed
            // 
            this.labelPulseSpeed.AutoSize = true;
            this.labelPulseSpeed.Location = new System.Drawing.Point(231, 142);
            this.labelPulseSpeed.Name = "labelPulseSpeed";
            this.labelPulseSpeed.Size = new System.Drawing.Size(67, 13);
            this.labelPulseSpeed.TabIndex = 14;
            this.labelPulseSpeed.Text = "Pulse Speed";
            this.labelPulseSpeed.Visible = false;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(715, 210);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 75);
            this.buttonColor.TabIndex = 15;
            this.buttonColor.Text = "COLOR";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelPulseSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelValBlue);
            this.Controls.Add(this.labelValGreen);
            this.Controls.Add(this.labelValRed);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBreath);
            this.Controls.Add(this.textEffects);
            this.Controls.Add(this.comboEffects);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBreath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEffects;
        private System.Windows.Forms.TextBox textEffects;
        private System.Windows.Forms.TrackBar trackBreath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelValRed;
        private System.Windows.Forms.Label labelValGreen;
        private System.Windows.Forms.Label labelValBlue;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPulseSpeed;
        private System.Windows.Forms.Button buttonColor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

