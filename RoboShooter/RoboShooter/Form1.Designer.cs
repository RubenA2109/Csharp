namespace RoboShooter
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textAmmo = new Label();
            textKills = new Label();
            gameStart = new System.Windows.Forms.Timer(components);
            playerController = new PictureBox();
            robotController = new PictureBox();
            progressHealth = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)playerController).BeginInit();
            ((System.ComponentModel.ISupportInitialize)robotController).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 412);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Ammo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 414);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 1;
            label2.Text = "ANIHILATIONS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(550, 412);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "HEALTH:";
            // 
            // textAmmo
            // 
            textAmmo.AutoSize = true;
            textAmmo.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAmmo.Location = new Point(96, 410);
            textAmmo.Name = "textAmmo";
            textAmmo.Size = new Size(24, 27);
            textAmmo.TabIndex = 3;
            textAmmo.Text = "0";
            // 
            // textKills
            // 
            textKills.AutoSize = true;
            textKills.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textKills.Location = new Point(416, 412);
            textKills.Name = "textKills";
            textKills.Size = new Size(24, 27);
            textKills.TabIndex = 4;
            textKills.Text = "0";
            // 
            // gameStart
            // 
            gameStart.Enabled = true;
            gameStart.Interval = 10;
            // 
            // playerController
            // 
            playerController.Image = Properties.Resources.mr;
            playerController.Location = new Point(29, 206);
            playerController.Name = "playerController";
            playerController.Size = new Size(49, 43);
            playerController.SizeMode = PictureBoxSizeMode.AutoSize;
            playerController.TabIndex = 5;
            playerController.TabStop = false;
            playerController.Tag = "player";
            // 
            // robotController
            // 
            robotController.Image = Properties.Resources.rr;
            robotController.Location = new Point(330, 40);
            robotController.Name = "robotController";
            robotController.Size = new Size(49, 43);
            robotController.SizeMode = PictureBoxSizeMode.AutoSize;
            robotController.TabIndex = 6;
            robotController.TabStop = false;
            robotController.Tag = "robot";
            // 
            // progressHealth
            // 
            progressHealth.Location = new Point(648, 401);
            progressHealth.Name = "progressHealth";
            progressHealth.Size = new Size(140, 38);
            progressHealth.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressHealth);
            Controls.Add(robotController);
            Controls.Add(playerController);
            Controls.Add(textKills);
            Controls.Add(textAmmo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RoboShooter";
            KeyDown += keyDown;
            KeyUp += keyUp;
            ((System.ComponentModel.ISupportInitialize)playerController).EndInit();
            ((System.ComponentModel.ISupportInitialize)robotController).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label textAmmo;
        private Label textKills;
        private System.Windows.Forms.Timer gameStart;
        private PictureBox playerController;
        private PictureBox robotController;
        private ProgressBar progressHealth;
    }
}
