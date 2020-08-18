namespace GitHubForm
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
            this.btnSux = new System.Windows.Forms.Button();
            this.lblMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSux
            // 
            this.btnSux.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSux.Location = new System.Drawing.Point(201, 267);
            this.btnSux.Name = "btnSux";
            this.btnSux.Size = new System.Drawing.Size(319, 117);
            this.btnSux.TabIndex = 0;
            this.btnSux.Text = "Make Map";
            this.btnSux.UseVisualStyleBackColor = true;
            this.btnSux.Click += new System.EventHandler(this.btnSux_Click);
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(230, 80);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(0, 11);
            this.lblMap.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.btnSux);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSux;
        private System.Windows.Forms.Label lblMap;
    }
}

