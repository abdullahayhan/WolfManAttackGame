
namespace kurtAdamSaldırıÖrneği
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.picWolf = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblMyHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWolf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Irk : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(130, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Branş : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(130, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silah : ";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(227, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(123, 30);
            this.txtUserName.TabIndex = 1;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWeapon.Location = new System.Drawing.Point(227, 195);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(123, 30);
            this.txtWeapon.TabIndex = 1;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(227, 115);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 24);
            this.cmbRace.TabIndex = 2;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assasin"});
            this.cmbBrans.Location = new System.Drawing.Point(227, 155);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 24);
            this.cmbBrans.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelect.Location = new System.Drawing.Point(156, 254);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(174, 49);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // picWolf
            // 
            this.picWolf.Image = global::kurtAdamSaldırıÖrneği.Properties.Resources.werewolf_3546899__340_1;
            this.picWolf.Location = new System.Drawing.Point(685, 254);
            this.picWolf.Name = "picWolf";
            this.picWolf.Size = new System.Drawing.Size(295, 202);
            this.picWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWolf.TabIndex = 4;
            this.picWolf.TabStop = false;
            this.picWolf.Visible = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Red;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHealth.Location = new System.Drawing.Point(680, 465);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(300, 32);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAttack.Location = new System.Drawing.Point(110, 345);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(261, 92);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblMyHealth
            // 
            this.lblMyHealth.BackColor = System.Drawing.Color.Red;
            this.lblMyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMyHealth.Location = new System.Drawing.Point(91, 465);
            this.lblMyHealth.Name = "lblMyHealth";
            this.lblMyHealth.Size = new System.Drawing.Size(300, 32);
            this.lblMyHealth.TabIndex = 0;
            this.lblMyHealth.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 595);
            this.Controls.Add(this.picWolf);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblMyHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picWolf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox picWolf;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblMyHealth;
    }
}

