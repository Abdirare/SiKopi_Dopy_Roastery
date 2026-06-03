namespace SiKopi_Dopy_Roastery.Views
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbox_username = new TextBox();
            label4 = new Label();
            textbox_password = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textbox_password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtbox_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(369, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 641);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 77);
            label1.Name = "label1";
            label1.Size = new Size(202, 39);
            label1.TabIndex = 0;
            label1.Text = "SiKopi Dopy";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(196, 149);
            label2.Name = "label2";
            label2.Size = new Size(183, 17);
            label2.TabIndex = 1;
            label2.Text = "Sangrai Cerdas, Kelola Mudas";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 211);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txtbox_username
            // 
            txtbox_username.BorderStyle = BorderStyle.FixedSingle;
            txtbox_username.Location = new Point(67, 235);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(418, 31);
            txtbox_username.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 313);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 4;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // textbox_password
            // 
            textbox_password.BorderStyle = BorderStyle.FixedSingle;
            textbox_password.Location = new Point(67, 347);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(418, 31);
            textbox_password.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(491, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(491, 339);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(67, 445);
            button1.Name = "button1";
            button1.Size = new Size(460, 41);
            button1.TabIndex = 8;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textbox_password;
        private Label label4;
        private TextBox txtbox_username;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox2;
    }
}