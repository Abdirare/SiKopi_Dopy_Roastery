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
            Btn_Masuk = new Button();
            label_username = new Label();
            txtbox_username = new TextBox();
            SuspendLayout();
            // 
            // Btn_Masuk
            // 
            Btn_Masuk.Location = new Point(577, 336);
            Btn_Masuk.Name = "Btn_Masuk";
            Btn_Masuk.Size = new Size(163, 34);
            Btn_Masuk.TabIndex = 0;
            Btn_Masuk.Text = "Masuk";
            Btn_Masuk.UseVisualStyleBackColor = true;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(445, 101);
            label_username.Name = "label_username";
            label_username.Size = new Size(91, 25);
            label_username.TabIndex = 1;
            label_username.Text = "Username";
            // 
            // txtbox_username
            // 
            txtbox_username.Location = new Point(445, 129);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(390, 31);
            txtbox_username.TabIndex = 2;
            txtbox_username.TextChanged += textBox1_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 450);
            Controls.Add(txtbox_username);
            Controls.Add(label_username);
            Controls.Add(Btn_Masuk);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Masuk;
        private Label label_username;
        private TextBox txtbox_username;
    }
}