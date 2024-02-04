namespace MASHKAPG
{
    partial class Vistausu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vistausu));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            bt_regresar = new Button();
            pictureBox3 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            bt_administrarclientes = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            bt_nuevocliente = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel6.SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 5;
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
            button1.Location = new Point(638, 3);
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
            button2.Location = new Point(688, 3);
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
            button3.Location = new Point(739, 3);
            button3.Name = "button3";
            button3.Size = new Size(52, 22);
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
            label1.Size = new Size(292, 28);
            label1.TabIndex = 3;
            label1.Text = "MASHKAPG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.logo_MASHKAPG_opaco;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 410);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 79.7560959F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2439022F));
            tableLayoutPanel3.Size = new Size(794, 410);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.8670044F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.1329918F));
            tableLayoutPanel4.Controls.Add(bt_regresar, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox3, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(400, 330);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(391, 77);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // bt_regresar
            // 
            bt_regresar.Anchor = AnchorStyles.Right;
            bt_regresar.BackColor = Color.Transparent;
            bt_regresar.BackgroundImage = Properties.Resources.boton_fondo;
            bt_regresar.BackgroundImageLayout = ImageLayout.Stretch;
            bt_regresar.FlatAppearance.BorderSize = 0;
            bt_regresar.FlatStyle = FlatStyle.Flat;
            bt_regresar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_regresar.Location = new Point(168, 16);
            bt_regresar.Name = "bt_regresar";
            bt_regresar.Size = new Size(109, 44);
            bt_regresar.TabIndex = 0;
            bt_regresar.Text = "REGRESAR";
            bt_regresar.UseVisualStyleBackColor = false;
            bt_regresar.Click += bt_regresar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.BackgroundImage = Properties.Resources.pesas;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(283, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel5.Controls.Add(bt_administrarclientes, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(400, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(391, 321);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pngtree_silhouettes_of_bodybuilder_and_fat_man_pursy_dense_obese_vector_png_image_5922886;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 234);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // bt_administrarclientes
            // 
            bt_administrarclientes.Anchor = AnchorStyles.None;
            bt_administrarclientes.BackColor = Color.White;
            bt_administrarclientes.FlatAppearance.BorderSize = 2;
            bt_administrarclientes.FlatStyle = FlatStyle.Flat;
            bt_administrarclientes.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            bt_administrarclientes.Location = new Point(92, 244);
            bt_administrarclientes.Name = "bt_administrarclientes";
            bt_administrarclientes.Size = new Size(207, 73);
            bt_administrarclientes.TabIndex = 1;
            bt_administrarclientes.Text = "ADMINISTRAR CLIENTES";
            bt_administrarclientes.UseVisualStyleBackColor = false;
            bt_administrarclientes.Click += bt_administrarclientes_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel6.Controls.Add(bt_nuevocliente, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Size = new Size(391, 321);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.silueta_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_nuevocliente
            // 
            bt_nuevocliente.Anchor = AnchorStyles.None;
            bt_nuevocliente.BackColor = Color.White;
            bt_nuevocliente.FlatAppearance.BorderSize = 2;
            bt_nuevocliente.FlatStyle = FlatStyle.Flat;
            bt_nuevocliente.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            bt_nuevocliente.Location = new Point(120, 243);
            bt_nuevocliente.Name = "bt_nuevocliente";
            bt_nuevocliente.Size = new Size(150, 75);
            bt_nuevocliente.TabIndex = 1;
            bt_nuevocliente.Text = "NUEVO CLIENTE";
            bt_nuevocliente.UseVisualStyleBackColor = false;
            bt_nuevocliente.Click += bt_nuevocliente_Click;
            // 
            // Vistausu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Vistausu";
            Text = "Vistausu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox2;
        private Button bt_administrarclientes;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox1;
        private Button bt_nuevocliente;
        private Button bt_regresar;
        private PictureBox pictureBox3;
    }
}