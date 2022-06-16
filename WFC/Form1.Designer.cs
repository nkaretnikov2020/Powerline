namespace Powerline
{
    partial class PowerlinePilot
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
            this.numCurrentSpeed = new System.Windows.Forms.NumericUpDown();
            this.numFuelTankCapacity = new System.Windows.Forms.NumericUpDown();
            this.numFuelLeftPercentage = new System.Windows.Forms.NumericUpDown();
            this.lblDistanceLeft = new System.Windows.Forms.Label();
            this.lblMinutesToFullstop = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numAverageFuelConsumptionPer100 = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfPassengers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFuelLeftPercentage = new System.Windows.Forms.Label();
            this.lblAverageFuelConsumptionPer100 = new System.Windows.Forms.Label();
            this.lblnumNumberOfPassengers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numTCurrentLoad = new System.Windows.Forms.NumericUpDown();
            this.numTAverageFuelConsumptionPer100 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTMinutesToFullstop = new System.Windows.Forms.Label();
            this.lblTDistanceLeft = new System.Windows.Forms.Label();
            this.numTFuelLeftPercentage = new System.Windows.Forms.NumericUpDown();
            this.numTFuelTankCapacity = new System.Windows.Forms.NumericUpDown();
            this.numTCurrentSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelTankCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelLeftPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAverageFuelConsumptionPer100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTCurrentLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTAverageFuelConsumptionPer100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTFuelLeftPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTFuelTankCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTCurrentSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // numCurrentSpeed
            // 
            this.numCurrentSpeed.Location = new System.Drawing.Point(409, 55);
            this.numCurrentSpeed.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numCurrentSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrentSpeed.Name = "numCurrentSpeed";
            this.numCurrentSpeed.Size = new System.Drawing.Size(210, 35);
            this.numCurrentSpeed.TabIndex = 0;
            this.numCurrentSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numFuelTankCapacity
            // 
            this.numFuelTankCapacity.Location = new System.Drawing.Point(409, 121);
            this.numFuelTankCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFuelTankCapacity.Name = "numFuelTankCapacity";
            this.numFuelTankCapacity.Size = new System.Drawing.Size(210, 35);
            this.numFuelTankCapacity.TabIndex = 1;
            this.numFuelTankCapacity.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numFuelLeftPercentage
            // 
            this.numFuelLeftPercentage.Location = new System.Drawing.Point(409, 182);
            this.numFuelLeftPercentage.Name = "numFuelLeftPercentage";
            this.numFuelLeftPercentage.Size = new System.Drawing.Size(210, 35);
            this.numFuelLeftPercentage.TabIndex = 2;
            this.numFuelLeftPercentage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblDistanceLeft
            // 
            this.lblDistanceLeft.AutoSize = true;
            this.lblDistanceLeft.Location = new System.Drawing.Point(409, 446);
            this.lblDistanceLeft.Name = "lblDistanceLeft";
            this.lblDistanceLeft.Size = new System.Drawing.Size(128, 30);
            this.lblDistanceLeft.TabIndex = 3;
            this.lblDistanceLeft.Text = "DistanceLeft";
            this.lblDistanceLeft.Click += new System.EventHandler(this.lblDistanceLeft_Click);
            // 
            // lblMinutesToFullstop
            // 
            this.lblMinutesToFullstop.AutoSize = true;
            this.lblMinutesToFullstop.Location = new System.Drawing.Point(409, 492);
            this.lblMinutesToFullstop.Name = "lblMinutesToFullstop";
            this.lblMinutesToFullstop.Size = new System.Drawing.Size(181, 30);
            this.lblMinutesToFullstop.TabIndex = 4;
            this.lblMinutesToFullstop.Text = "MinutesToFullstop";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(182, 386);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 40);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // numAverageFuelConsumptionPer100
            // 
            this.numAverageFuelConsumptionPer100.Location = new System.Drawing.Point(409, 249);
            this.numAverageFuelConsumptionPer100.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAverageFuelConsumptionPer100.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAverageFuelConsumptionPer100.Name = "numAverageFuelConsumptionPer100";
            this.numAverageFuelConsumptionPer100.Size = new System.Drawing.Size(210, 35);
            this.numAverageFuelConsumptionPer100.TabIndex = 6;
            this.numAverageFuelConsumptionPer100.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numNumberOfPassengers
            // 
            this.numNumberOfPassengers.Location = new System.Drawing.Point(409, 326);
            this.numNumberOfPassengers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNumberOfPassengers.Name = "numNumberOfPassengers";
            this.numNumberOfPassengers.Size = new System.Drawing.Size(210, 35);
            this.numNumberOfPassengers.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Current Speed in km (1-250)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter FuelTankCapacity (1-100)";
            // 
            // lblFuelLeftPercentage
            // 
            this.lblFuelLeftPercentage.AutoSize = true;
            this.lblFuelLeftPercentage.Location = new System.Drawing.Point(23, 184);
            this.lblFuelLeftPercentage.Name = "lblFuelLeftPercentage";
            this.lblFuelLeftPercentage.Size = new System.Drawing.Size(313, 30);
            this.lblFuelLeftPercentage.TabIndex = 10;
            this.lblFuelLeftPercentage.Text = "Enter FuelLeftPercentage (0-100)";
            // 
            // lblAverageFuelConsumptionPer100
            // 
            this.lblAverageFuelConsumptionPer100.AutoSize = true;
            this.lblAverageFuelConsumptionPer100.Location = new System.Drawing.Point(23, 251);
            this.lblAverageFuelConsumptionPer100.Name = "lblAverageFuelConsumptionPer100";
            this.lblAverageFuelConsumptionPer100.Size = new System.Drawing.Size(258, 60);
            this.lblAverageFuelConsumptionPer100.TabIndex = 11;
            this.lblAverageFuelConsumptionPer100.Text = "Enter Average  Fuel \r\nConsumptionPer100 (1-50)";
            this.lblAverageFuelConsumptionPer100.Click += new System.EventHandler(this.lblAverageFuelConsumptionPer100_Click);
            // 
            // lblnumNumberOfPassengers
            // 
            this.lblnumNumberOfPassengers.AutoSize = true;
            this.lblnumNumberOfPassengers.Location = new System.Drawing.Point(23, 331);
            this.lblnumNumberOfPassengers.Name = "lblnumNumberOfPassengers";
            this.lblnumNumberOfPassengers.Size = new System.Drawing.Size(324, 30);
            this.lblnumNumberOfPassengers.TabIndex = 12;
            this.lblnumNumberOfPassengers.Text = "Enter Number of Passengers (0-5)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "The car will go another (km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "The car will go for another (min)";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 554);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger Car";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "The Truck will go for another (min)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "The Truck will go another (km)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Enter Load in kg. (0-20000)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(712, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 60);
            this.label8.TabIndex = 27;
            this.label8.Text = "Enter Average  Fuel \r\nConsumptionPer100 (1-50)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(712, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Enter FuelLeftPercentage (0-100)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Enter FuelTankCapacity (1-100)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(326, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Enter Current Speed in km (1-250)";
            // 
            // numTCurrentLoad
            // 
            this.numTCurrentLoad.Location = new System.Drawing.Point(1098, 323);
            this.numTCurrentLoad.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numTCurrentLoad.Name = "numTCurrentLoad";
            this.numTCurrentLoad.Size = new System.Drawing.Size(210, 35);
            this.numTCurrentLoad.TabIndex = 23;
            // 
            // numTAverageFuelConsumptionPer100
            // 
            this.numTAverageFuelConsumptionPer100.Location = new System.Drawing.Point(1098, 246);
            this.numTAverageFuelConsumptionPer100.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTAverageFuelConsumptionPer100.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTAverageFuelConsumptionPer100.Name = "numTAverageFuelConsumptionPer100";
            this.numTAverageFuelConsumptionPer100.Size = new System.Drawing.Size(210, 35);
            this.numTAverageFuelConsumptionPer100.TabIndex = 22;
            this.numTAverageFuelConsumptionPer100.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblTMinutesToFullstop
            // 
            this.lblTMinutesToFullstop.AutoSize = true;
            this.lblTMinutesToFullstop.Location = new System.Drawing.Point(1098, 489);
            this.lblTMinutesToFullstop.Name = "lblTMinutesToFullstop";
            this.lblTMinutesToFullstop.Size = new System.Drawing.Size(192, 30);
            this.lblTMinutesToFullstop.TabIndex = 20;
            this.lblTMinutesToFullstop.Text = "TMinutesToFullstop";
            // 
            // lblTDistanceLeft
            // 
            this.lblTDistanceLeft.AutoSize = true;
            this.lblTDistanceLeft.Location = new System.Drawing.Point(1098, 443);
            this.lblTDistanceLeft.Name = "lblTDistanceLeft";
            this.lblTDistanceLeft.Size = new System.Drawing.Size(139, 30);
            this.lblTDistanceLeft.TabIndex = 19;
            this.lblTDistanceLeft.Text = "TDistanceLeft";
            // 
            // numTFuelLeftPercentage
            // 
            this.numTFuelLeftPercentage.Location = new System.Drawing.Point(1098, 179);
            this.numTFuelLeftPercentage.Name = "numTFuelLeftPercentage";
            this.numTFuelLeftPercentage.Size = new System.Drawing.Size(210, 35);
            this.numTFuelLeftPercentage.TabIndex = 18;
            this.numTFuelLeftPercentage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numTFuelTankCapacity
            // 
            this.numTFuelTankCapacity.Location = new System.Drawing.Point(1098, 118);
            this.numTFuelTankCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTFuelTankCapacity.Name = "numTFuelTankCapacity";
            this.numTFuelTankCapacity.Size = new System.Drawing.Size(210, 35);
            this.numTFuelTankCapacity.TabIndex = 17;
            this.numTFuelTankCapacity.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numTCurrentSpeed
            // 
            this.numTCurrentSpeed.Location = new System.Drawing.Point(1098, 52);
            this.numTCurrentSpeed.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numTCurrentSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTCurrentSpeed.Name = "numTCurrentSpeed";
            this.numTCurrentSpeed.Size = new System.Drawing.Size(210, 35);
            this.numTCurrentSpeed.TabIndex = 16;
            this.numTCurrentSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(701, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 554);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truck";
            // 
            // PowerlinePilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 586);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numTCurrentLoad);
            this.Controls.Add(this.numTAverageFuelConsumptionPer100);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTMinutesToFullstop);
            this.Controls.Add(this.lblTDistanceLeft);
            this.Controls.Add(this.numTFuelLeftPercentage);
            this.Controls.Add(this.numTFuelTankCapacity);
            this.Controls.Add(this.numTCurrentSpeed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnumNumberOfPassengers);
            this.Controls.Add(this.lblAverageFuelConsumptionPer100);
            this.Controls.Add(this.lblFuelLeftPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNumberOfPassengers);
            this.Controls.Add(this.numAverageFuelConsumptionPer100);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMinutesToFullstop);
            this.Controls.Add(this.lblDistanceLeft);
            this.Controls.Add(this.numFuelLeftPercentage);
            this.Controls.Add(this.numFuelTankCapacity);
            this.Controls.Add(this.numCurrentSpeed);
            this.Controls.Add(this.groupBox1);
            this.Name = "PowerlinePilot";
            this.Text = "Powerline Pilot";
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelTankCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelLeftPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAverageFuelConsumptionPer100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTCurrentLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTAverageFuelConsumptionPer100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTFuelLeftPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTFuelTankCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTCurrentSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numCurrentSpeed;
        private NumericUpDown numFuelTankCapacity;
        private NumericUpDown numFuelLeftPercentage;
        private Label lblDistanceLeft;
        private Label lblMinutesToFullstop;
        private Button btnCalculate;
        private NumericUpDown numAverageFuelConsumptionPer100;
        private NumericUpDown numNumberOfPassengers;
        private Label label1;
        private Label label2;
        private Label lblFuelLeftPercentage;
        private Label lblAverageFuelConsumptionPer100;
        private Label lblnumNumberOfPassengers;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private NumericUpDown numTCurrentLoad;
        private NumericUpDown numTAverageFuelConsumptionPer100;
        private Button button1;
        private Label lblTMinutesToFullstop;
        private Label lblTDistanceLeft;
        private NumericUpDown numTFuelLeftPercentage;
        private NumericUpDown numTFuelTankCapacity;
        private NumericUpDown numTCurrentSpeed;
        private GroupBox groupBox2;
    }
}