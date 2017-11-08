namespace DesignPatterns.MVP
{
    partial class MainForms
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
            this.btnLoadSimpleMVPExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadSimpleMVPExample
            // 
            this.btnLoadSimpleMVPExample.Location = new System.Drawing.Point(12, 12);
            this.btnLoadSimpleMVPExample.Name = "btnLoadSimpleMVPExample";
            this.btnLoadSimpleMVPExample.Size = new System.Drawing.Size(203, 23);
            this.btnLoadSimpleMVPExample.TabIndex = 1;
            this.btnLoadSimpleMVPExample.Text = "Load Simple MVP Example ";
            this.btnLoadSimpleMVPExample.UseVisualStyleBackColor = true;
            this.btnLoadSimpleMVPExample.Click += new System.EventHandler(this.btnLoadSimpleMVPExample_Click);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 397);
            this.Controls.Add(this.btnLoadSimpleMVPExample);
            this.Name = "MainForms";
            this.Text = "SimpleMVPExample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSimpleMVPExample;

    }
}

