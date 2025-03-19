namespace BeerOrder
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.chkLight = new System.Windows.Forms.CheckBox();
            this.chkDark = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(288, 111);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 0;
            // 
            // chkLight
            // 
            this.chkLight.AutoSize = true;
            this.chkLight.Location = new System.Drawing.Point(242, 145);
            this.chkLight.Name = "chkLight";
            this.chkLight.Size = new System.Drawing.Size(70, 20);
            this.chkLight.TabIndex = 1;
            this.chkLight.Text = "світле";
            this.chkLight.UseVisualStyleBackColor = true;
            // 
            // chkDark
            // 
            this.chkDark.AutoSize = true;
            this.chkDark.Location = new System.Drawing.Point(358, 145);
            this.chkDark.Name = "chkDark";
            this.chkDark.Size = new System.Drawing.Size(69, 20);
            this.chkDark.TabIndex = 2;
            this.chkDark.Text = "темне";
            this.chkDark.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(302, 171);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Обчисл";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(318, 92);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 16);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Рез";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkDark);
            this.Controls.Add(this.chkLight);
            this.Controls.Add(this.txtQuantity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.CheckBox chkLight;
        private System.Windows.Forms.CheckBox chkDark;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

