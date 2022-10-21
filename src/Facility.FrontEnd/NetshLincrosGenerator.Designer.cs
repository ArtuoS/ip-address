namespace Facility.FrontEnd
{
    partial class NetshLincrosGenerator
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
            this.btnRun = new System.Windows.Forms.Button();
            this.rtbIps = new System.Windows.Forms.RichTextBox();
            this.rtbBindingProtocol = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.Chocolate;
            this.btnRun.Location = new System.Drawing.Point(11, 211);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(468, 43);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtbIps
            // 
            this.rtbIps.Location = new System.Drawing.Point(11, 28);
            this.rtbIps.Name = "rtbIps";
            this.rtbIps.ReadOnly = true;
            this.rtbIps.Size = new System.Drawing.Size(468, 76);
            this.rtbIps.TabIndex = 5;
            this.rtbIps.Text = "";
            // 
            // rtbBindingProtocol
            // 
            this.rtbBindingProtocol.Location = new System.Drawing.Point(11, 129);
            this.rtbBindingProtocol.Name = "rtbBindingProtocol";
            this.rtbBindingProtocol.ReadOnly = true;
            this.rtbBindingProtocol.Size = new System.Drawing.Size(468, 76);
            this.rtbBindingProtocol.TabIndex = 6;
            this.rtbBindingProtocol.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "NETSH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Binding Protocol";
            // 
            // NetshLincrosGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbBindingProtocol);
            this.Controls.Add(this.rtbIps);
            this.Controls.Add(this.btnRun);
            this.Name = "NetshLincrosGenerator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnRun;
        private RichTextBox rtbIps;
        private RichTextBox rtbBindingProtocol;
        private Label label1;
        private Label label2;
    }
}