namespace MASHKAPG
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            password = new TextBox();
            ver_con = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label2 = new Label();
            usuario = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            bt_login = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.55555534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.44444F));
            tableLayoutPanel1.Size = new Size(710, 431);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9291344F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0708656F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 4, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(704, 26);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.MouseDown += tableLayoutPanel2_MouseDown;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.minimizar;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(547, 3);
            button1.Name = "button1";
            button1.Size = new Size(44, 20);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.opcion_de_maximizar_tamano;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(597, 3);
            button2.Name = "button2";
            button2.Size = new Size(45, 20);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.boton_salir_a_la_aplicacion;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(648, 3);
            button3.Name = "button3";
            button3.Size = new Size(53, 20);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 0, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 26);
            label1.TabIndex = 3;
            label1.Text = "MASHKAPG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.logo_MASHKAPG_opaco;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 393);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(704, 393);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(698, 288);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.hombre_musculoso;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 282);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(142, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(553, 282);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.6025848F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.99677F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.239096F));
            tableLayoutPanel6.Controls.Add(label3, 0, 0);
            tableLayoutPanel6.Controls.Add(password, 1, 0);
            tableLayoutPanel6.Controls.Add(ver_con, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 144);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(547, 135);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 0;
            label3.Text = "Contraseña:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(187, 3);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(302, 34);
            password.TabIndex = 1;
            // 
            // ver_con
            // 
            ver_con.Anchor = AnchorStyles.Top;
            ver_con.BackColor = Color.White;
            ver_con.BackgroundImage = Properties.Resources.ojo;
            ver_con.BackgroundImageLayout = ImageLayout.Zoom;
            ver_con.FlatAppearance.BorderSize = 0;
            ver_con.FlatStyle = FlatStyle.Flat;
            ver_con.Location = new Point(504, 3);
            ver_con.Name = "ver_con";
            ver_con.Size = new Size(40, 26);
            ver_con.TabIndex = 2;
            ver_con.UseVisualStyleBackColor = false;
            ver_con.Click += ver_con_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel7.Controls.Add(label2, 0, 0);
            tableLayoutPanel7.Controls.Add(usuario, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(547, 135);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 103);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 0;
            label2.Text = "Usuario:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            usuario.BackColor = Color.White;
            usuario.BorderStyle = BorderStyle.FixedSingle;
            usuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usuario.Location = new Point(185, 105);
            usuario.Name = "usuario";
            usuario.Size = new Size(302, 34);
            usuario.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel8.Controls.Add(pictureBox4, 2, 0);
            tableLayoutPanel8.Controls.Add(bt_login, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 297);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(698, 93);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.pesas;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(226, 87);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.pesas;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(467, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(228, 87);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // bt_login
            // 
            bt_login.Anchor = AnchorStyles.None;
            bt_login.BackColor = Color.Transparent;
            bt_login.BackgroundImage = Properties.Resources.fondo_redondeado_negro;
            bt_login.BackgroundImageLayout = ImageLayout.Stretch;
            bt_login.FlatAppearance.BorderSize = 0;
            bt_login.FlatStyle = FlatStyle.Flat;
            bt_login.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bt_login.ForeColor = Color.White;
            bt_login.Location = new Point(265, 21);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(166, 50);
            bt_login.TabIndex = 2;
            bt_login.Text = "Log In";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 431);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "a";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button bt_login;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private TextBox password;
        private Button ver_con;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label2;
        private TextBox usuario;
    }
}
