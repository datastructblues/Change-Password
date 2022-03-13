
namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPasswordText1 = new System.Windows.Forms.MaskedTextBox();
            this.newPasswordText2 = new System.Windows.Forms.MaskedTextBox();
            this.passwordText = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password Again";
            // 
            // newPasswordText1
            // 
            this.newPasswordText1.Location = new System.Drawing.Point(315, 182);
            this.newPasswordText1.Mask = "000000";
            this.newPasswordText1.Name = "newPasswordText1";
            this.newPasswordText1.PasswordChar = '*';
            this.newPasswordText1.PromptChar = ' ';
            this.newPasswordText1.Size = new System.Drawing.Size(140, 26);
            this.newPasswordText1.TabIndex = 3;
            this.newPasswordText1.ValidatingType = typeof(int);
            // 
            // newPasswordText2
            // 
            this.newPasswordText2.Location = new System.Drawing.Point(315, 265);
            this.newPasswordText2.Mask = "000000";
            this.newPasswordText2.Name = "newPasswordText2";
            this.newPasswordText2.PasswordChar = '*';
            this.newPasswordText2.PromptChar = ' ';
            this.newPasswordText2.Size = new System.Drawing.Size(140, 26);
            this.newPasswordText2.TabIndex = 4;
            this.newPasswordText2.ValidatingType = typeof(int);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(315, 91);
            this.passwordText.Mask = "000000";
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(140, 26);
            this.passwordText.TabIndex = 5;
            this.passwordText.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newPasswordText2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newPasswordText1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 689);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 371);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "CHANGE PASSWORD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Change Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox newPasswordText1;
        private System.Windows.Forms.MaskedTextBox newPasswordText2;
        private System.Windows.Forms.MaskedTextBox passwordText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

