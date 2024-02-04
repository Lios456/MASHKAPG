namespace MASHKAPG
{
    partial class VerClientes
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerClientes));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            bt_actualizar = new Button();
            bt_autorenov = new Button();
            bt_borrar = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            bt_regresar = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            filtro = new ComboBox();
            texto = new TextBox();
            label3 = new Label();
            clientes_view = new DataGridView();
            Eleccion = new DataGridViewCheckBoxColumn();
            clienteBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientes_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
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
            tableLayoutPanel1.TabIndex = 3;
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
            panel1.BackColor = Color.FromArgb(255, 255, 153);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 410);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new Size(794, 410);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(255, 255, 128);
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel4.Controls.Add(label2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(788, 76);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pesas;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pesas;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(672, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 70);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 0);
            label2.Name = "label2";
            label2.Size = new Size(545, 76);
            label2.TabIndex = 2;
            label2.Text = "ADMINISTRACIÓN DE CLIENTES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 351);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(788, 56);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(bt_actualizar, 0, 0);
            tableLayoutPanel6.Controls.Add(bt_autorenov, 1, 0);
            tableLayoutPanel6.Controls.Add(bt_borrar, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(388, 50);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // bt_actualizar
            // 
            bt_actualizar.Anchor = AnchorStyles.None;
            bt_actualizar.BackgroundImage = Properties.Resources.boton_fondo;
            bt_actualizar.BackgroundImageLayout = ImageLayout.Stretch;
            bt_actualizar.FlatAppearance.BorderSize = 0;
            bt_actualizar.FlatStyle = FlatStyle.Flat;
            bt_actualizar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_actualizar.Location = new Point(3, 3);
            bt_actualizar.Name = "bt_actualizar";
            bt_actualizar.Size = new Size(123, 44);
            bt_actualizar.TabIndex = 0;
            bt_actualizar.Text = "ACTUALIZAR";
            bt_actualizar.UseVisualStyleBackColor = true;
            // 
            // bt_autorenov
            // 
            bt_autorenov.Anchor = AnchorStyles.None;
            bt_autorenov.BackgroundImage = Properties.Resources.boton_fondo;
            bt_autorenov.BackgroundImageLayout = ImageLayout.Stretch;
            bt_autorenov.FlatAppearance.BorderSize = 0;
            bt_autorenov.FlatStyle = FlatStyle.Flat;
            bt_autorenov.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_autorenov.Location = new Point(132, 3);
            bt_autorenov.Name = "bt_autorenov";
            bt_autorenov.Size = new Size(123, 44);
            bt_autorenov.TabIndex = 1;
            bt_autorenov.Text = "AUTO RENOV";
            bt_autorenov.UseVisualStyleBackColor = true;
            // 
            // bt_borrar
            // 
            bt_borrar.Anchor = AnchorStyles.None;
            bt_borrar.BackgroundImage = Properties.Resources.boton_fondo;
            bt_borrar.BackgroundImageLayout = ImageLayout.Stretch;
            bt_borrar.FlatAppearance.BorderSize = 0;
            bt_borrar.FlatStyle = FlatStyle.Flat;
            bt_borrar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt_borrar.Location = new Point(261, 3);
            bt_borrar.Name = "bt_borrar";
            bt_borrar.Size = new Size(124, 44);
            bt_borrar.TabIndex = 2;
            bt_borrar.Text = "BORRAR";
            bt_borrar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(pictureBox3, 1, 0);
            tableLayoutPanel7.Controls.Add(bt_regresar, 0, 0);
            tableLayoutPanel7.Location = new Point(551, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(234, 50);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.pesas;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(120, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 44);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // bt_regresar
            // 
            bt_regresar.BackgroundImage = Properties.Resources.boton_fondo;
            bt_regresar.BackgroundImageLayout = ImageLayout.Stretch;
            bt_regresar.Dock = DockStyle.Fill;
            bt_regresar.FlatAppearance.BorderSize = 0;
            bt_regresar.FlatStyle = FlatStyle.Flat;
            bt_regresar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_regresar.Location = new Point(3, 3);
            bt_regresar.Name = "bt_regresar";
            bt_regresar.Size = new Size(111, 44);
            bt_regresar.TabIndex = 1;
            bt_regresar.Text = "REGRESAR";
            bt_regresar.UseVisualStyleBackColor = true;
            bt_regresar.Click += bt_regresar_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel8.Controls.Add(clientes_view, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 85);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel8.Size = new Size(788, 260);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.0895157F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8337593F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel9.Controls.Add(filtro, 2, 0);
            tableLayoutPanel9.Controls.Add(texto, 0, 0);
            tableLayoutPanel9.Controls.Add(label3, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(782, 46);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // filtro
            // 
            filtro.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            filtro.BackColor = Color.White;
            filtro.DropDownStyle = ComboBoxStyle.DropDownList;
            filtro.FlatStyle = FlatStyle.Flat;
            filtro.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filtro.ForeColor = Color.Black;
            filtro.FormattingEnabled = true;
            filtro.Items.AddRange(new object[] { "Todos", "Nombre", "Apellido", "Por Pagar", "Pagados" });
            filtro.Location = new Point(628, 7);
            filtro.Name = "filtro";
            filtro.Size = new Size(151, 31);
            filtro.TabIndex = 1;
            filtro.SelectedIndexChanged += filtro_SelectedIndexChanged;
            // 
            // texto
            // 
            texto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            texto.BorderStyle = BorderStyle.FixedSingle;
            texto.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            texto.Location = new Point(3, 8);
            texto.Name = "texto";
            texto.Size = new Size(503, 30);
            texto.TabIndex = 2;
            texto.TextChanged += texto_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(512, 11);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 3;
            label3.Text = "Filtrar por:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clientes_view
            // 
            clientes_view.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientes_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientes_view.BackgroundColor = Color.White;
            clientes_view.BorderStyle = BorderStyle.None;
            clientes_view.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            clientes_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientes_view.Columns.AddRange(new DataGridViewColumn[] { Eleccion });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            clientes_view.DefaultCellStyle = dataGridViewCellStyle1;
            clientes_view.GridColor = Color.Black;
            clientes_view.Location = new Point(3, 55);
            clientes_view.Name = "clientes_view";
            clientes_view.RowHeadersVisible = false;
            clientes_view.RowTemplate.Height = 25;
            clientes_view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientes_view.Size = new Size(782, 202);
            clientes_view.TabIndex = 1;
            // 
            // Eleccion
            // 
            Eleccion.HeaderText = "";
            Eleccion.Name = "Eleccion";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(clases.Cliente);
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerClientes";
            Text = "VerClientes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientes_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button bt_actualizar;
        private Button bt_autorenov;
        private Button bt_borrar;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox3;
        private Button bt_regresar;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private ComboBox filtro;
        private DataGridView clientes_view;
        private BindingSource clienteBindingSource;
        private DataGridViewCheckBoxColumn Eleccion;
        private TextBox texto;
        private Label label3;
    }
}