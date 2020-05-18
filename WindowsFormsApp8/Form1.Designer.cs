namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btRunner = new System.Windows.Forms.Button();
            this.btSponsor = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.mbLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lTime = new System.Windows.Forms.Label();
            this.mlTime = new System.Windows.Forms.Label();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марафон Skills 2020";
            // 
            // btRunner
            // 
            this.btRunner.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRunner.Location = new System.Drawing.Point(107, 212);
            this.btRunner.Name = "btRunner";
            this.btRunner.Size = new System.Drawing.Size(317, 48);
            this.btRunner.TabIndex = 1;
            this.btRunner.Text = "Я хочу стать бегуном ";
            this.btRunner.UseVisualStyleBackColor = true;
            this.btRunner.Click += new System.EventHandler(this.btRunner_Click);
            // 
            // btSponsor
            // 
            this.btSponsor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSponsor.Location = new System.Drawing.Point(107, 284);
            this.btSponsor.Name = "btSponsor";
            this.btSponsor.Size = new System.Drawing.Size(317, 46);
            this.btSponsor.TabIndex = 2;
            this.btSponsor.Text = "Я хочу стать спонсором ";
            this.btSponsor.UseVisualStyleBackColor = true;
            this.btSponsor.Click += new System.EventHandler(this.btSponsor_Click);
            // 
            // btInfo
            // 
            this.btInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btInfo.Location = new System.Drawing.Point(107, 356);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(317, 45);
            this.btInfo.TabIndex = 3;
            this.btInfo.Text = "Я хочу узнать больше о марафоне";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // mbLogin
            // 
            this.mbLogin.AutoSize = true;
            this.mbLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbLogin.BackColor = System.Drawing.Color.White;
            this.mbLogin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbLogin.Location = new System.Drawing.Point(355, 407);
            this.mbLogin.Name = "mbLogin";
            this.mbLogin.Size = new System.Drawing.Size(69, 33);
            this.mbLogin.TabIndex = 4;
            this.mbLogin.Text = "Войти";
            this.mbLogin.UseVisualStyleBackColor = true;
            this.mbLogin.Click += new System.EventHandler(this.mbLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.lTime);
            this.panel2.Controls.Add(this.mlTime);
            this.panel2.Location = new System.Drawing.Point(12, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 40);
            this.panel2.TabIndex = 5;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTime.Location = new System.Drawing.Point(133, 11);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 16);
            this.lTime.TabIndex = 1;
            this.lTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(33, 14);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(0, 13);
            this.mlTime.TabIndex = 0;
            // 
            // timerDay
            // 
            this.timerDay.Interval = 1000;
            this.timerDay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbLogin);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btSponsor);
            this.Controls.Add(this.btRunner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRunner;
        private System.Windows.Forms.Button btSponsor;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button mbLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label mlTime;
        private System.Windows.Forms.Timer timerDay;
    }
}

