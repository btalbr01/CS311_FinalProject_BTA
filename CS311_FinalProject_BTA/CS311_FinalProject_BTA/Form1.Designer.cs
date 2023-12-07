namespace CS311_FinalProject_BTA
{
    partial class frmConverter
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
            grpConversions = new GroupBox();
            btnCalculate = new Button();
            rdoOtoG = new RadioButton();
            rdoPtoK = new RadioButton();
            rdoFtoC = new RadioButton();
            rdoMtoK = new RadioButton();
            rdoFtoM = new RadioButton();
            rdoGtoO = new RadioButton();
            rdoKtoP = new RadioButton();
            rdoCtoF = new RadioButton();
            rdoKtoM = new RadioButton();
            rdoMtoF = new RadioButton();
            txtInput = new TextBox();
            lblCU = new Label();
            lblOutput = new Label();
            lblPrompt = new Label();
            grpConversions.SuspendLayout();
            SuspendLayout();
            // 
            // grpConversions
            // 
            grpConversions.Controls.Add(btnCalculate);
            grpConversions.Controls.Add(rdoOtoG);
            grpConversions.Controls.Add(rdoPtoK);
            grpConversions.Controls.Add(rdoFtoC);
            grpConversions.Controls.Add(rdoMtoK);
            grpConversions.Controls.Add(rdoFtoM);
            grpConversions.Controls.Add(rdoGtoO);
            grpConversions.Controls.Add(rdoKtoP);
            grpConversions.Controls.Add(rdoCtoF);
            grpConversions.Controls.Add(rdoKtoM);
            grpConversions.Controls.Add(rdoMtoF);
            grpConversions.Location = new Point(2, 189);
            grpConversions.Name = "grpConversions";
            grpConversions.Size = new Size(795, 192);
            grpConversions.TabIndex = 0;
            grpConversions.TabStop = false;
            grpConversions.Text = "Conversion Choices";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(607, 81);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(124, 60);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // rdoOtoG
            // 
            rdoOtoG.AutoSize = true;
            rdoOtoG.Location = new Point(424, 122);
            rdoOtoG.Name = "rdoOtoG";
            rdoOtoG.Size = new Size(116, 19);
            rdoOtoG.TabIndex = 9;
            rdoOtoG.TabStop = true;
            rdoOtoG.Text = "Ounces to Grams";
            rdoOtoG.UseVisualStyleBackColor = true;
            // 
            // rdoPtoK
            // 
            rdoPtoK.AutoSize = true;
            rdoPtoK.Location = new Point(424, 97);
            rdoPtoK.Name = "rdoPtoK";
            rdoPtoK.Size = new Size(135, 19);
            rdoPtoK.TabIndex = 8;
            rdoPtoK.TabStop = true;
            rdoPtoK.Text = "Pounds to Kilograms";
            rdoPtoK.UseVisualStyleBackColor = true;
            // 
            // rdoFtoC
            // 
            rdoFtoC.AutoSize = true;
            rdoFtoC.Location = new Point(424, 72);
            rdoFtoC.Name = "rdoFtoC";
            rdoFtoC.Size = new Size(135, 19);
            rdoFtoC.TabIndex = 7;
            rdoFtoC.TabStop = true;
            rdoFtoC.Text = "Fahrenheit to Celsius";
            rdoFtoC.UseVisualStyleBackColor = true;
            // 
            // rdoMtoK
            // 
            rdoMtoK.AutoSize = true;
            rdoMtoK.Location = new Point(424, 47);
            rdoMtoK.Name = "rdoMtoK";
            rdoMtoK.Size = new Size(126, 19);
            rdoMtoK.TabIndex = 6;
            rdoMtoK.TabStop = true;
            rdoMtoK.Text = "Miles to Kilometers";
            rdoMtoK.UseVisualStyleBackColor = true;
            // 
            // rdoFtoM
            // 
            rdoFtoM.AutoSize = true;
            rdoFtoM.Location = new Point(424, 22);
            rdoFtoM.Name = "rdoFtoM";
            rdoFtoM.Size = new Size(100, 19);
            rdoFtoM.TabIndex = 5;
            rdoFtoM.TabStop = true;
            rdoFtoM.Text = "Feet to Meters";
            rdoFtoM.UseVisualStyleBackColor = true;
            // 
            // rdoGtoO
            // 
            rdoGtoO.AutoSize = true;
            rdoGtoO.Location = new Point(32, 122);
            rdoGtoO.Name = "rdoGtoO";
            rdoGtoO.Size = new Size(116, 19);
            rdoGtoO.TabIndex = 4;
            rdoGtoO.TabStop = true;
            rdoGtoO.Text = "Grams to Ounces";
            rdoGtoO.UseVisualStyleBackColor = true;
            // 
            // rdoKtoP
            // 
            rdoKtoP.AutoSize = true;
            rdoKtoP.Location = new Point(32, 97);
            rdoKtoP.Name = "rdoKtoP";
            rdoKtoP.Size = new Size(130, 19);
            rdoKtoP.TabIndex = 3;
            rdoKtoP.TabStop = true;
            rdoKtoP.Text = "Kilogram to Pounds";
            rdoKtoP.UseVisualStyleBackColor = true;
            // 
            // rdoCtoF
            // 
            rdoCtoF.AutoSize = true;
            rdoCtoF.Location = new Point(32, 72);
            rdoCtoF.Name = "rdoCtoF";
            rdoCtoF.Size = new Size(135, 19);
            rdoCtoF.TabIndex = 2;
            rdoCtoF.TabStop = true;
            rdoCtoF.Text = "Celsius to Fahrenheit";
            rdoCtoF.UseVisualStyleBackColor = true;
            // 
            // rdoKtoM
            // 
            rdoKtoM.AutoSize = true;
            rdoKtoM.Location = new Point(32, 47);
            rdoKtoM.Name = "rdoKtoM";
            rdoKtoM.Size = new Size(126, 19);
            rdoKtoM.TabIndex = 1;
            rdoKtoM.TabStop = true;
            rdoKtoM.Text = "Kilometers to Miles";
            rdoKtoM.UseVisualStyleBackColor = true;
            // 
            // rdoMtoF
            // 
            rdoMtoF.AutoSize = true;
            rdoMtoF.Location = new Point(32, 22);
            rdoMtoF.Name = "rdoMtoF";
            rdoMtoF.Size = new Size(100, 19);
            rdoMtoF.TabIndex = 0;
            rdoMtoF.TabStop = true;
            rdoMtoF.Text = "Meters to Feet";
            rdoMtoF.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(121, 94);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "0";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // lblCU
            // 
            lblCU.AutoSize = true;
            lblCU.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCU.Location = new Point(409, 85);
            lblCU.Name = "lblCU";
            lblCU.Size = new Size(195, 32);
            lblCU.TabIndex = 2;
            lblCU.Text = "Converted Unit:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutput.Location = new Point(409, 117);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 32);
            lblOutput.TabIndex = 3;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrompt.Location = new Point(36, 23);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(654, 32);
            lblPrompt.TabIndex = 4;
            lblPrompt.Text = "Input a number, choose a conversion and click calculate";
            // 
            // frmConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 385);
            Controls.Add(lblPrompt);
            Controls.Add(lblOutput);
            Controls.Add(lblCU);
            Controls.Add(txtInput);
            Controls.Add(grpConversions);
            Name = "frmConverter";
            Text = "Unit Converter";
            grpConversions.ResumeLayout(false);
            grpConversions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpConversions;
        private Button btnCalculate;
        private RadioButton rdoOtoG;
        private RadioButton rdoPtoK;
        private RadioButton rdoFtoC;
        private RadioButton rdoMtoK;
        private RadioButton rdoFtoM;
        private RadioButton rdoGtoO;
        private RadioButton rdoKtoP;
        private RadioButton rdoCtoF;
        private RadioButton rdoKtoM;
        private RadioButton rdoMtoF;
        private TextBox txtInput;
        private Label lblCU;
        private Label lblOutput;
        private Label lblPrompt;
    }
}