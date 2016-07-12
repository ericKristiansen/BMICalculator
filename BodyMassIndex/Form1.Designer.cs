namespace BodyMassIndex
{
    partial class bodyMassIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bodyMassIndexForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scalesPictureBox = new System.Windows.Forms.PictureBox();
            this.bmiDescriptionLabel = new System.Windows.Forms.Label();
            this.weightDescriptionLabel = new System.Windows.Forms.Label();
            this.heightDescriptionLabel = new System.Windows.Forms.Label();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.bodyMassIndexLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.clearScreenButton = new System.Windows.Forms.Button();
            this.calculateBMIButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scalesPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.splitContainer1.Panel1.Controls.Add(this.scalesPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.bmiDescriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.weightDescriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.heightDescriptionLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.diagnosisLabel);
            this.splitContainer1.Panel2.Controls.Add(this.poundsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.inchesLabel);
            this.splitContainer1.Panel2.Controls.Add(this.bodyMassIndexLabel);
            this.splitContainer1.Panel2.Controls.Add(this.weightTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.heightTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(431, 162);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // scalesPictureBox
            // 
            this.scalesPictureBox.Image = global::BodyMassIndex.Properties.Resources.customScales;
            this.scalesPictureBox.InitialImage = global::BodyMassIndex.Properties.Resources.customScales;
            this.scalesPictureBox.Location = new System.Drawing.Point(3, 3);
            this.scalesPictureBox.Name = "scalesPictureBox";
            this.scalesPictureBox.Size = new System.Drawing.Size(187, 107);
            this.scalesPictureBox.TabIndex = 20;
            this.scalesPictureBox.TabStop = false;
            // 
            // bmiDescriptionLabel
            // 
            this.bmiDescriptionLabel.AutoSize = true;
            this.bmiDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiDescriptionLabel.Location = new System.Drawing.Point(117, 125);
            this.bmiDescriptionLabel.Name = "bmiDescriptionLabel";
            this.bmiDescriptionLabel.Size = new System.Drawing.Size(150, 20);
            this.bmiDescriptionLabel.TabIndex = 7;
            this.bmiDescriptionLabel.Text = "Body Mass Index:";
            // 
            // weightDescriptionLabel
            // 
            this.weightDescriptionLabel.AutoSize = true;
            this.weightDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightDescriptionLabel.Location = new System.Drawing.Point(196, 65);
            this.weightDescriptionLabel.Name = "weightDescriptionLabel";
            this.weightDescriptionLabel.Size = new System.Drawing.Size(70, 20);
            this.weightDescriptionLabel.TabIndex = 6;
            this.weightDescriptionLabel.Text = "Weight:";
            // 
            // heightDescriptionLabel
            // 
            this.heightDescriptionLabel.AutoSize = true;
            this.heightDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightDescriptionLabel.Location = new System.Drawing.Point(199, 30);
            this.heightDescriptionLabel.Name = "heightDescriptionLabel";
            this.heightDescriptionLabel.Size = new System.Drawing.Size(67, 20);
            this.heightDescriptionLabel.TabIndex = 5;
            this.heightDescriptionLabel.Text = "Height:";
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsLabel.Location = new System.Drawing.Point(78, 68);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(62, 17);
            this.poundsLabel.TabIndex = 22;
            this.poundsLabel.Text = "Pounds";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(78, 33);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(55, 17);
            this.inchesLabel.TabIndex = 21;
            this.inchesLabel.Text = "Inches";
            // 
            // bodyMassIndexLabel
            // 
            this.bodyMassIndexLabel.AutoSize = true;
            this.bodyMassIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyMassIndexLabel.Location = new System.Drawing.Point(22, 125);
            this.bodyMassIndexLabel.Name = "bodyMassIndexLabel";
            this.bodyMassIndexLabel.Size = new System.Drawing.Size(34, 20);
            this.bodyMassIndexLabel.TabIndex = 4;
            this.bodyMassIndexLabel.Text = "0.0";
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.weightTextBox.Location = new System.Drawing.Point(5, 59);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(67, 29);
            this.weightTextBox.TabIndex = 1;
            // 
            // heightTextBox
            // 
            this.heightTextBox.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.heightTextBox.Location = new System.Drawing.Point(5, 24);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(67, 29);
            this.heightTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(17, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 166);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.errorLabel);
            this.panel3.Controls.Add(this.clearScreenButton);
            this.panel3.Controls.Add(this.calculateBMIButton);
            this.panel3.Location = new System.Drawing.Point(17, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 98);
            this.panel3.TabIndex = 21;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.errorLabel.Location = new System.Drawing.Point(0, 78);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 3;
            // 
            // clearScreenButton
            // 
            this.clearScreenButton.BackColor = System.Drawing.Color.DimGray;
            this.clearScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearScreenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearScreenButton.Location = new System.Drawing.Point(102, 13);
            this.clearScreenButton.Name = "clearScreenButton";
            this.clearScreenButton.Size = new System.Drawing.Size(120, 62);
            this.clearScreenButton.TabIndex = 3;
            this.clearScreenButton.Text = "Clear Screen";
            this.clearScreenButton.UseVisualStyleBackColor = false;
            this.clearScreenButton.Click += new System.EventHandler(this.clearScreenButton_Click);
            // 
            // calculateBMIButton
            // 
            this.calculateBMIButton.BackColor = System.Drawing.Color.DimGray;
            this.calculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBMIButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateBMIButton.Location = new System.Drawing.Point(278, 13);
            this.calculateBMIButton.Name = "calculateBMIButton";
            this.calculateBMIButton.Size = new System.Drawing.Size(120, 62);
            this.calculateBMIButton.TabIndex = 2;
            this.calculateBMIButton.Text = "Calculate BMI";
            this.calculateBMIButton.UseVisualStyleBackColor = false;
            this.calculateBMIButton.Click += new System.EventHandler(this.calculateBMIButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(17, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 43);
            this.panel2.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.welcomeLabel);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 33);
            this.panel4.TabIndex = 18;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomeLabel.Location = new System.Drawing.Point(59, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(301, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To BMI Calculator";
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisLabel.Location = new System.Drawing.Point(23, 145);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(0, 17);
            this.diagnosisLabel.TabIndex = 23;
            // 
            // bodyMassIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(472, 345);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bodyMassIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.bodyMassIndexForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scalesPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label heightDescriptionLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearScreenButton;
        private System.Windows.Forms.Button calculateBMIButton;
        private System.Windows.Forms.Label weightDescriptionLabel;
        private System.Windows.Forms.Label bmiDescriptionLabel;
        private System.Windows.Forms.Label bodyMassIndexLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.PictureBox scalesPictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label diagnosisLabel;
    }
}

