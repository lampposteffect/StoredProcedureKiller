namespace StoredProcedureKiller
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
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.btnKillIt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSeeSharp = new System.Windows.Forms.RadioButton();
            this.rdoVisualBasic = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(12, 11);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(575, 493);
            this.txtSQL.TabIndex = 0;
            this.txtSQL.Text = "";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(597, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(575, 492);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "";
            // 
            // btnKillIt
            // 
            this.btnKillIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillIt.Location = new System.Drawing.Point(550, 510);
            this.btnKillIt.Name = "btnKillIt";
            this.btnKillIt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKillIt.Size = new System.Drawing.Size(87, 30);
            this.btnKillIt.TabIndex = 2;
            this.btnKillIt.Text = "Kill It!";
            this.btnKillIt.UseVisualStyleBackColor = true;
            this.btnKillIt.Click += new System.EventHandler(this.btnKillIt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(913, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // rdoSeeSharp
            // 
            this.rdoSeeSharp.AutoSize = true;
            this.rdoSeeSharp.Location = new System.Drawing.Point(666, 513);
            this.rdoSeeSharp.Name = "rdoSeeSharp";
            this.rdoSeeSharp.Size = new System.Drawing.Size(39, 17);
            this.rdoSeeSharp.TabIndex = 5;
            this.rdoSeeSharp.Text = "C#";
            this.rdoSeeSharp.UseVisualStyleBackColor = true;
            // 
            // rdoVisualBasic
            // 
            this.rdoVisualBasic.AutoSize = true;
            this.rdoVisualBasic.Checked = true;
            this.rdoVisualBasic.Location = new System.Drawing.Point(711, 513);
            this.rdoVisualBasic.Name = "rdoVisualBasic";
            this.rdoVisualBasic.Size = new System.Drawing.Size(39, 17);
            this.rdoVisualBasic.TabIndex = 6;
            this.rdoVisualBasic.TabStop = true;
            this.rdoVisualBasic.Text = "VB";
            this.rdoVisualBasic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 542);
            this.Controls.Add(this.rdoVisualBasic);
            this.Controls.Add(this.rdoSeeSharp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKillIt);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtSQL);
            this.Name = "Form1";
            this.Text = "Stored Procedure Killah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Button btnKillIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSeeSharp;
        private System.Windows.Forms.RadioButton rdoVisualBasic;
    }
}

