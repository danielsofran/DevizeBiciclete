namespace DevizeBiciclete
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.button1 = new System.Windows.Forms.Button();
            this.piesaListControl1 = new DevizeBiciclete.UI.Controls.PiesaListControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // piesaListControl1
            // 
            this.piesaListControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piesaListControl1.Location = new System.Drawing.Point(14, 14);
            this.piesaListControl1.Margin = new System.Windows.Forms.Padding(5);
            this.piesaListControl1.Name = "piesaListControl1";
            this.piesaListControl1.Size = new System.Drawing.Size(447, 320);
            this.piesaListControl1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1243, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.piesaListControl1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private UI.Controls.PiesaListControl piesaListControl1;
        private Label label1;
    }
}