namespace DesignPatterns.MVP.SimpleMVPExample
{
    partial class SimpleMVPExampleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextValue = new System.Windows.Forms.TextBox();
            this.btnReverseText = new System.Windows.Forms.Button();
            this.btnSetTextValue = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Text:";
            // 
            // txtTextValue
            // 
            this.txtTextValue.Location = new System.Drawing.Point(15, 25);
            this.txtTextValue.Name = "txtTextValue";
            this.txtTextValue.Size = new System.Drawing.Size(293, 20);
            this.txtTextValue.TabIndex = 6;
            // 
            // btnReverseText
            // 
            this.btnReverseText.Location = new System.Drawing.Point(105, 51);
            this.btnReverseText.Name = "btnReverseText";
            this.btnReverseText.Size = new System.Drawing.Size(75, 23);
            this.btnReverseText.TabIndex = 5;
            this.btnReverseText.Text = "Reverse";
            this.btnReverseText.UseVisualStyleBackColor = true;
            this.btnReverseText.Click += new System.EventHandler(this.btnReverseText_Click);
            // 
            // btnSetTextValue
            // 
            this.btnSetTextValue.Location = new System.Drawing.Point(15, 51);
            this.btnSetTextValue.Name = "btnSetTextValue";
            this.btnSetTextValue.Size = new System.Drawing.Size(75, 23);
            this.btnSetTextValue.TabIndex = 4;
            this.btnSetTextValue.Text = "Set";
            this.btnSetTextValue.UseVisualStyleBackColor = true;
            this.btnSetTextValue.Click += new System.EventHandler(this.btnSetTextValue_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // SimpleMVPExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 119);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextValue);
            this.Controls.Add(this.btnReverseText);
            this.Controls.Add(this.btnSetTextValue);
            this.Name = "SimpleMVPExampleForm";
            this.Text = "SimpleExampleForm";
            this.Load += new System.EventHandler(this.SimpleExampleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextValue;
        private System.Windows.Forms.Button btnReverseText;
        private System.Windows.Forms.Button btnSetTextValue;
        private System.Windows.Forms.Label lblResult;
    }
}