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
            this.comboEffects = new System.Windows.Forms.ComboBox();
            this.textEffects = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBreath = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBreath)).BeginInit();
            this.SuspendLayout();
            // 
            // comboEffects
            // 
            this.comboEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEffects.FormattingEnabled = true;
            this.comboEffects.Items.AddRange(new object[] {
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
            this.textEffects.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(700, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Preset Effects";
            // 
            // trackBreath
            // 
            this.trackBreath.Location = new System.Drawing.Point(158, 129);
            this.trackBreath.Name = "trackBreath";
            this.trackBreath.Size = new System.Drawing.Size(206, 45);
            this.trackBreath.TabIndex = 3;
            this.trackBreath.Visible = false;
            this.trackBreath.Scroll += new System.EventHandler(this.trackBreath_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 447);
            this.Controls.Add(this.trackBreath);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textEffects);
            this.Controls.Add(this.comboEffects);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBreath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboEffects;
        private System.Windows.Forms.TextBox textEffects;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBreath;
    }
}

