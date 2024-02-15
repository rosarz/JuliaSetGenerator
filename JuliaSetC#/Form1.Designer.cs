namespace JuliaSetC_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.ObrazPictureBox = new System.Windows.Forms.PictureBox();
            this.iteracjeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WatkitextBox = new System.Windows.Forms.TextBox();
            this.czasCPPLabel = new System.Windows.Forms.Label();
            this.czasASMLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IteracjienumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.wspXnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.wspYnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.WyborcomboBox = new System.Windows.Forms.ComboBox();
            this.KolorycomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.testASM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObrazPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IteracjienumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspXnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspYnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(576, 292);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(55, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Czas C++:";
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ObrazPictureBox
            // 
            this.ObrazPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObrazPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObrazPictureBox.InitialImage = null;
            this.ObrazPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ObrazPictureBox.Name = "ObrazPictureBox";
            this.ObrazPictureBox.Size = new System.Drawing.Size(502, 450);
            this.ObrazPictureBox.TabIndex = 1;
            this.ObrazPictureBox.TabStop = false;
            this.ObrazPictureBox.WaitOnLoad = true;
            this.ObrazPictureBox.Click += new System.EventHandler(this.ObrazPictureBox_Click);
            // 
            // iteracjeLabel
            // 
            this.iteracjeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iteracjeLabel.AutoSize = true;
            this.iteracjeLabel.Location = new System.Drawing.Point(568, 27);
            this.iteracjeLabel.Name = "iteracjeLabel";
            this.iteracjeLabel.Size = new System.Drawing.Size(74, 13);
            this.iteracjeLabel.TabIndex = 2;
            this.iteracjeLabel.Text = "Liczba iteracji:";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(598, 229);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 46);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Rozpocznij";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x0: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "y0: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liczba wątków: ";
            // 
            // WatkitextBox
            // 
            this.WatkitextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WatkitextBox.Location = new System.Drawing.Point(645, 102);
            this.WatkitextBox.Name = "WatkitextBox";
            this.WatkitextBox.Size = new System.Drawing.Size(100, 20);
            this.WatkitextBox.TabIndex = 10;
            // 
            // czasCPPLabel
            // 
            this.czasCPPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.czasCPPLabel.AutoSize = true;
            this.czasCPPLabel.Location = new System.Drawing.Point(634, 292);
            this.czasCPPLabel.Name = "czasCPPLabel";
            this.czasCPPLabel.Size = new System.Drawing.Size(74, 13);
            this.czasCPPLabel.TabIndex = 11;
            this.czasCPPLabel.Text = "XXX.XXXXX s";
            // 
            // czasASMLabel
            // 
            this.czasASMLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.czasASMLabel.AutoSize = true;
            this.czasASMLabel.Location = new System.Drawing.Point(634, 315);
            this.czasASMLabel.Name = "czasASMLabel";
            this.czasASMLabel.Size = new System.Drawing.Size(74, 13);
            this.czasASMLabel.TabIndex = 17;
            this.czasASMLabel.Text = "XXX.XXXXX s";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Czas ASM:";
            // 
            // IteracjienumericUpDown
            // 
            this.IteracjienumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IteracjienumericUpDown.Location = new System.Drawing.Point(645, 25);
            this.IteracjienumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IteracjienumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IteracjienumericUpDown.Name = "IteracjienumericUpDown";
            this.IteracjienumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IteracjienumericUpDown.TabIndex = 18;
            this.IteracjienumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // wspXnumericUpDown
            // 
            this.wspXnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wspXnumericUpDown.DecimalPlaces = 5;
            this.wspXnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.wspXnumericUpDown.Location = new System.Drawing.Point(645, 51);
            this.wspXnumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wspXnumericUpDown.Name = "wspXnumericUpDown";
            this.wspXnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.wspXnumericUpDown.TabIndex = 19;
            this.wspXnumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // wspYnumericUpDown
            // 
            this.wspYnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wspYnumericUpDown.DecimalPlaces = 5;
            this.wspYnumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.wspYnumericUpDown.Location = new System.Drawing.Point(645, 77);
            this.wspYnumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wspYnumericUpDown.Name = "wspYnumericUpDown";
            this.wspYnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.wspYnumericUpDown.TabIndex = 20;
            this.wspYnumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOutButton.Location = new System.Drawing.Point(623, 393);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(62, 33);
            this.zoomOutButton.TabIndex = 22;
            this.zoomOutButton.Text = "Oddal";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            // 
            // zoomInButton
            // 
            this.zoomInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomInButton.Location = new System.Drawing.Point(623, 354);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(62, 33);
            this.zoomInButton.TabIndex = 23;
            this.zoomInButton.Text = "Przybliż";
            this.zoomInButton.UseVisualStyleBackColor = true;
            // 
            // WyborcomboBox
            // 
            this.WyborcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WyborcomboBox.FormattingEnabled = true;
            this.WyborcomboBox.Items.AddRange(new object[] {
            "C++",
            "ASM"});
            this.WyborcomboBox.Location = new System.Drawing.Point(597, 147);
            this.WyborcomboBox.Name = "WyborcomboBox";
            this.WyborcomboBox.Size = new System.Drawing.Size(121, 21);
            this.WyborcomboBox.TabIndex = 24;
            // 
            // KolorycomboBox
            // 
            this.KolorycomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KolorycomboBox.FormattingEnabled = true;
            this.KolorycomboBox.Items.AddRange(new object[] {
            "hsv1",
            "hsv2",
            "greyscale"});
            this.KolorycomboBox.Location = new System.Drawing.Point(597, 197);
            this.KolorycomboBox.Name = "KolorycomboBox";
            this.KolorycomboBox.Size = new System.Drawing.Size(121, 21);
            this.KolorycomboBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Wybór DLL:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Wybór kolorów:";
            // 
            // testASM
            // 
            this.testASM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testASM.AutoSize = true;
            this.testASM.Location = new System.Drawing.Point(530, 374);
            this.testASM.Name = "testASM";
            this.testASM.Size = new System.Drawing.Size(28, 13);
            this.testASM.TabIndex = 28;
            this.testASM.Text = "XXX";
            this.testASM.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testASM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KolorycomboBox);
            this.Controls.Add(this.WyborcomboBox);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.wspYnumericUpDown);
            this.Controls.Add(this.wspXnumericUpDown);
            this.Controls.Add(this.IteracjienumericUpDown);
            this.Controls.Add(this.czasASMLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.czasCPPLabel);
            this.Controls.Add(this.WatkitextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.iteracjeLabel);
            this.Controls.Add(this.ObrazPictureBox);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ObrazPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IteracjienumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspXnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wspYnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox ObrazPictureBox;
        private System.Windows.Forms.Label iteracjeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WatkitextBox;
        private System.Windows.Forms.Label czasCPPLabel;
        private System.Windows.Forms.Label czasASMLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IteracjienumericUpDown;
        private System.Windows.Forms.NumericUpDown wspXnumericUpDown;
        private System.Windows.Forms.NumericUpDown wspYnumericUpDown;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.ComboBox WyborcomboBox;
        private System.Windows.Forms.ComboBox KolorycomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label testASM;
    }
}

