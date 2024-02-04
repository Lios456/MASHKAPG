namespace MASHKAPG
{
    partial class RegistrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuarios));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            usuario = new TextBox();
            pictureBox5 = new PictureBox();
            password1 = new TextBox();
            pictureBox3 = new PictureBox();
            password2 = new TextBox();
            pictureBox2 = new PictureBox();
            bt_registrar = new Button();
            bt_limpiar = new Button();
            button5 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.9291344F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.0708656F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 59F));
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
            tableLayoutPanel2.Size = new Size(794, 28);
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
            button1.Location = new Point(636, 3);
            button1.Name = "button1";
            button1.Size = new Size(44, 22);
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
            button2.Location = new Point(686, 3);
            button2.Name = "button2";
            button2.Size = new Size(45, 22);
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
            button3.Location = new Point(737, 3);
            button3.Name = "button3";
            button3.Size = new Size(54, 22);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 28);
            label1.TabIndex = 3;
            label1.Text = "MASHKAPG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 410);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.BackgroundImage = Properties.Resources.logo_MASHKAPG_opaco;
            tableLayoutPanel4.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Controls.Add(label3, 1, 1);
            tableLayoutPanel4.Controls.Add(label4, 1, 2);
            tableLayoutPanel4.Controls.Add(label5, 1, 3);
            tableLayoutPanel4.Controls.Add(usuario, 2, 1);
            tableLayoutPanel4.Controls.Add(pictureBox5, 3, 3);
            tableLayoutPanel4.Controls.Add(password1, 2, 2);
            tableLayoutPanel4.Controls.Add(pictureBox3, 3, 2);
            tableLayoutPanel4.Controls.Add(password2, 2, 3);
            tableLayoutPanel4.Controls.Add(pictureBox2, 5, 5);
            tableLayoutPanel4.Controls.Add(bt_registrar, 0, 5);
            tableLayoutPanel4.Controls.Add(bt_limpiar, 1, 5);
            tableLayoutPanel4.Controls.Add(button5, 4, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 55);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(794, 355);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(282, 103);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(258, 156);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(260, 197);
            label5.Name = "label5";
            label5.Size = new Size(93, 46);
            label5.TabIndex = 5;
            label5.Text = "Confirmar contraseña:";
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usuario.BackColor = Color.White;
            usuario.BorderStyle = BorderStyle.FixedSingle;
            usuario.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usuario.Location = new Point(359, 99);
            usuario.Margin = new Padding(3, 2, 3, 2);
            usuario.Name = "usuario";
            usuario.Size = new Size(152, 30);
            usuario.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.ojo;
            pictureBox5.Location = new Point(517, 212);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 17);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // password1
            // 
            password1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password1.BackColor = Color.White;
            password1.BorderStyle = BorderStyle.FixedSingle;
            password1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password1.Location = new Point(359, 152);
            password1.Margin = new Padding(3, 2, 3, 2);
            password1.Name = "password1";
            password1.PasswordChar = '*';
            password1.Size = new Size(152, 30);
            password1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.ojo;
            pictureBox3.Location = new Point(517, 159);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 17);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // password2
            // 
            password2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password2.BackColor = Color.White;
            password2.BorderStyle = BorderStyle.FixedSingle;
            password2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password2.Location = new Point(359, 205);
            password2.Margin = new Padding(3, 2, 3, 2);
            password2.Name = "password2";
            password2.PasswordChar = '*';
            password2.Size = new Size(152, 30);
            password2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.pesas;
            pictureBox2.Location = new Point(714, 296);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // bt_registrar
            // 
            bt_registrar.Anchor = AnchorStyles.None;
            bt_registrar.BackColor = Color.Transparent;
            bt_registrar.BackgroundImage = Properties.Resources.boton_fondo;
            bt_registrar.BackgroundImageLayout = ImageLayout.Stretch;
            bt_registrar.FlatAppearance.BorderSize = 0;
            bt_registrar.FlatStyle = FlatStyle.Flat;
            bt_registrar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_registrar.Location = new Point(38, 296);
            bt_registrar.Name = "bt_registrar";
            bt_registrar.Size = new Size(121, 44);
            bt_registrar.TabIndex = 16;
            bt_registrar.Text = "REGISTRAR";
            bt_registrar.UseVisualStyleBackColor = false;
            bt_registrar.Click += bt_registrar_Click;
            // 
            // bt_limpiar
            // 
            bt_limpiar.Anchor = AnchorStyles.None;
            bt_limpiar.BackColor = Color.Transparent;
            bt_limpiar.BackgroundImage = Properties.Resources.boton_fondo;
            bt_limpiar.BackgroundImageLayout = ImageLayout.Stretch;
            bt_limpiar.FlatAppearance.BorderSize = 0;
            bt_limpiar.FlatStyle = FlatStyle.Flat;
            bt_limpiar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_limpiar.Location = new Point(222, 296);
            bt_limpiar.Name = "bt_limpiar";
            bt_limpiar.Size = new Size(109, 44);
            bt_limpiar.TabIndex = 17;
            bt_limpiar.Text = "LIMPIAR";
            bt_limpiar.UseVisualStyleBackColor = false;
            bt_limpiar.Click += bt_limpiar_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.boton_fondo;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(599, 296);
            button5.Name = "button5";
            button5.Size = new Size(109, 44);
            button5.TabIndex = 18;
            button5.Text = "REGRESAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(255, 255, 128);
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(794, 55);
            tableLayoutPanel3.TabIndex = 2;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.pesas;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Location = new Point(3, 2);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 51);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pesas;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(598, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 51);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 17.8348637F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(201, 0);
            label2.Name = "label2";
            label2.Size = new Size(391, 55);
            label2.TabIndex = 3;
            label2.Text = "REGISTRO DE USUARIOS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarUsuarios";
            Text = "RegistrarUsuarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private TextBox password2;
        private TextBox password1;
        private TextBox usuario;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private PictureBox pictureBox2;
        private Button bt_registrar;
        private Button bt_limpiar;
        private Button button5;
    }
}