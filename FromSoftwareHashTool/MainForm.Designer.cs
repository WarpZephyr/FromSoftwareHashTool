namespace FromSoftwareHashTool
{
    partial class MainForm
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
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnHash = new Button();
            chxLong = new CheckBox();
            txtFinalInput = new TextBox();
            lblInput = new Label();
            label1 = new Label();
            lblFinalInput = new Label();
            chxDoNotReplace = new CheckBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(84, 12);
            txtInput.MinimumSize = new Size(15, 0);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(499, 23);
            txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Location = new Point(84, 70);
            txtOutput.MinimumSize = new Size(15, 0);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(499, 23);
            txtOutput.TabIndex = 1;
            // 
            // btnHash
            // 
            btnHash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHash.Location = new Point(589, 12);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(75, 23);
            btnHash.TabIndex = 2;
            btnHash.Text = "Hash";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // chxLong
            // 
            chxLong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chxLong.AutoSize = true;
            chxLong.Location = new Point(589, 72);
            chxLong.Name = "chxLong";
            chxLong.Size = new Size(57, 19);
            chxLong.TabIndex = 3;
            chxLong.Text = "64-bit";
            chxLong.UseVisualStyleBackColor = true;
            // 
            // txtFinalInput
            // 
            txtFinalInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFinalInput.Location = new Point(84, 41);
            txtFinalInput.MinimumSize = new Size(15, 0);
            txtFinalInput.Name = "txtFinalInput";
            txtFinalInput.ReadOnly = true;
            txtFinalInput.Size = new Size(499, 23);
            txtFinalInput.TabIndex = 4;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 15);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(38, 15);
            lblInput.TabIndex = 5;
            lblInput.Text = "Input:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "Output:";
            // 
            // lblFinalInput
            // 
            lblFinalInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFinalInput.AutoSize = true;
            lblFinalInput.Location = new Point(12, 45);
            lblFinalInput.Name = "lblFinalInput";
            lblFinalInput.Size = new Size(66, 15);
            lblFinalInput.TabIndex = 7;
            lblFinalInput.Text = "Final Input:";
            // 
            // chxDoNotReplace
            // 
            chxDoNotReplace.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chxDoNotReplace.AutoSize = true;
            chxDoNotReplace.Location = new Point(589, 43);
            chxDoNotReplace.Name = "chxDoNotReplace";
            chxDoNotReplace.Size = new Size(134, 19);
            chxDoNotReplace.TabIndex = 8;
            chxDoNotReplace.Text = "Do not replace input";
            chxDoNotReplace.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 106);
            Controls.Add(chxDoNotReplace);
            Controls.Add(lblFinalInput);
            Controls.Add(label1);
            Controls.Add(lblInput);
            Controls.Add(txtFinalInput);
            Controls.Add(chxLong);
            Controls.Add(btnHash);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            MaximizeBox = false;
            MinimumSize = new Size(350, 145);
            Name = "MainForm";
            Text = "FromSoftware Hash Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnHash;
        private CheckBox chxLong;
        private TextBox txtFinalInput;
        private Label lblInput;
        private Label label1;
        private Label lblFinalInput;
        private CheckBox chxDoNotReplace;
    }
}