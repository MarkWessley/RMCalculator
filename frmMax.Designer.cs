using System;

namespace RMCalculator
{
    partial class frmMax
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
            this.lstRM = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.cboRM = new System.Windows.Forms.ComboBox();
            this.cboMovement = new System.Windows.Forms.ComboBox();
            this.btnPercentages = new System.Windows.Forms.Button();
            this.lstPercent = new System.Windows.Forms.ListBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.lblRMList = new System.Windows.Forms.Label();
            this.lblPercentRM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRM
            // 
            this.lstRM.FormattingEnabled = true;
            this.lstRM.ItemHeight = 24;
            this.lstRM.Location = new System.Drawing.Point(45, 239);
            this.lstRM.Margin = new System.Windows.Forms.Padding(4);
            this.lstRM.Name = "lstRM";
            this.lstRM.Size = new System.Drawing.Size(289, 364);
            this.lstRM.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "1 RM Calculator";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(416, 142);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(114, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Percent RM";
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(119, 611);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 45);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Reps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Weight";
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(532, 103);
            this.txtReps.Margin = new System.Windows.Forms.Padding(4);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(136, 29);
            this.txtReps.TabIndex = 2;
            this.txtReps.TextChanged += new System.EventHandler(this.ClearValues);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(234, 139);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(136, 29);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.TextChanged += new System.EventHandler(this.ClearValues);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Movement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(617, 51);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Date";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(605, 671);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(760, 671);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(733, 48);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(136, 29);
            this.txtDateTime.TabIndex = 8;
            this.txtDateTime.TabStop = false;
            // 
            // cboRM
            // 
            this.cboRM.FormattingEnabled = true;
            this.cboRM.Location = new System.Drawing.Point(532, 139);
            this.cboRM.Name = "cboRM";
            this.cboRM.Size = new System.Drawing.Size(136, 32);
            this.cboRM.TabIndex = 3;
            // 
            // cboMovement
            // 
            this.cboMovement.FormattingEnabled = true;
            this.cboMovement.Location = new System.Drawing.Point(234, 100);
            this.cboMovement.Name = "cboMovement";
            this.cboMovement.Size = new System.Drawing.Size(165, 32);
            this.cboMovement.TabIndex = 0;
            // 
            // btnPercentages
            // 
            this.btnPercentages.AutoSize = true;
            this.btnPercentages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPercentages.Location = new System.Drawing.Point(398, 611);
            this.btnPercentages.Margin = new System.Windows.Forms.Padding(4);
            this.btnPercentages.Name = "btnPercentages";
            this.btnPercentages.Size = new System.Drawing.Size(138, 45);
            this.btnPercentages.TabIndex = 5;
            this.btnPercentages.Text = "&Percentages";
            this.btnPercentages.UseVisualStyleBackColor = true;
            this.btnPercentages.Click += new System.EventHandler(this.BtnPercentages_Click);
            // 
            // lstPercent
            // 
            this.lstPercent.FormattingEnabled = true;
            this.lstPercent.ItemHeight = 24;
            this.lstPercent.Location = new System.Drawing.Point(342, 239);
            this.lstPercent.Margin = new System.Windows.Forms.Padding(4);
            this.lstPercent.Name = "lstPercent";
            this.lstPercent.Size = new System.Drawing.Size(289, 364);
            this.lstPercent.TabIndex = 40;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(638, 239);
            this.txtPercent.Multiline = true;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(226, 364);
            this.txtPercent.TabIndex = 42;
            // 
            // lblRMList
            // 
            this.lblRMList.AutoSize = true;
            this.lblRMList.Location = new System.Drawing.Point(118, 195);
            this.lblRMList.Name = "lblRMList";
            this.lblRMList.Size = new System.Drawing.Size(125, 25);
            this.lblRMList.TabIndex = 43;
            this.lblRMList.Text = "Rep Max List";
            // 
            // lblPercentRM
            // 
            this.lblPercentRM.AutoSize = true;
            this.lblPercentRM.Location = new System.Drawing.Point(434, 195);
            this.lblPercentRM.Name = "lblPercentRM";
            this.lblPercentRM.Size = new System.Drawing.Size(133, 29);
            this.lblPercentRM.TabIndex = 44;
            this.lblPercentRM.Text = "Percent RM";
            // 
            // frmMax
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1115, 729);
            this.Controls.Add(this.lblPercentRM);
            this.Controls.Add(this.lblRMList);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.lstPercent);
            this.Controls.Add(this.btnPercentages);
            this.Controls.Add(this.cboMovement);
            this.Controls.Add(this.cboRM);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstRM);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMax";
            this.Text = "99";
            this.Load += new System.EventHandler(this.frmMax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClear;
        //private System.Windows.Forms.Button btnGetPercentages;
        //private EventHandler lstRM_SelectedIndexChanged;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.ComboBox cboRM;
        private System.Windows.Forms.ComboBox cboMovement;
        private System.Windows.Forms.Button btnPercentages;
        private System.Windows.Forms.ListBox lstPercent;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label lblRMList;
        private System.Windows.Forms.Label lblPercentRM;
    }
}

