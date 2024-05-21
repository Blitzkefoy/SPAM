namespace SpamEmailDetectionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtEmail;
        private Button btnCheckSpam;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            btnCheckSpam = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 18);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(479, 152);
            txtEmail.TabIndex = 0;
            // 
            // btnCheckSpam
            // 
            btnCheckSpam.BackColor = Color.LightSkyBlue;
            btnCheckSpam.Location = new Point(16, 182);
            btnCheckSpam.Margin = new Padding(4, 5, 4, 5);
            btnCheckSpam.Name = "btnCheckSpam";
            btnCheckSpam.Size = new Size(480, 35);
            btnCheckSpam.TabIndex = 1;
            btnCheckSpam.Text = "Check for Spam";
            btnCheckSpam.UseVisualStyleBackColor = false;
            btnCheckSpam.Click += btnCheckSpam_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.DarkRed;
            lblResult.Location = new Point(196, 238);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result: ";
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 343);
            Controls.Add(lblResult);
            Controls.Add(btnCheckSpam);
            Controls.Add(txtEmail);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Spam Email Detection";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}