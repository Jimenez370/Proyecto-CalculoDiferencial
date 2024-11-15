namespace Proyecto_CalculoDiferencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelmenu = new Panel();
            icbraices = new FontAwesome.Sharp.IconButton();
            icbdivididas = new FontAwesome.Sharp.IconButton();
            icbnuméricas = new FontAwesome.Sharp.IconButton();
            icbtrapecio = new FontAwesome.Sharp.IconButton();
            icbimpson = new FontAwesome.Sharp.IconButton();
            panellogo = new Panel();
            pcbinicio = new PictureBox();
            paneltitulo = new Panel();
            lbtitulo = new Label();
            icpbinicio = new FontAwesome.Sharp.IconPictureBox();
            panelsombra = new Panel();
            panelescritorio = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelmenu.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbinicio).BeginInit();
            paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icpbinicio).BeginInit();
            panelescritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(25, 118, 210);
            panelmenu.Controls.Add(icbraices);
            panelmenu.Controls.Add(icbdivididas);
            panelmenu.Controls.Add(icbnuméricas);
            panelmenu.Controls.Add(icbtrapecio);
            panelmenu.Controls.Add(icbimpson);
            panelmenu.Controls.Add(panellogo);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(220, 623);
            panelmenu.TabIndex = 0;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // icbraices
            // 
            icbraices.Dock = DockStyle.Top;
            icbraices.FlatAppearance.BorderSize = 0;
            icbraices.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 0, 255);
            icbraices.FlatStyle = FlatStyle.Flat;
            icbraices.ForeColor = Color.White;
            icbraices.IconChar = FontAwesome.Sharp.IconChar.SquareRootAlt;
            icbraices.IconColor = Color.White;
            icbraices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbraices.IconSize = 32;
            icbraices.ImageAlign = ContentAlignment.MiddleLeft;
            icbraices.Location = new Point(0, 380);
            icbraices.Name = "icbraices";
            icbraices.Padding = new Padding(10, 0, 20, 0);
            icbraices.Size = new Size(220, 60);
            icbraices.TabIndex = 5;
            icbraices.Text = "Raices";
            icbraices.TextAlign = ContentAlignment.MiddleLeft;
            icbraices.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbraices.UseVisualStyleBackColor = true;
            icbraices.Click += icbraices_Click;
            // 
            // icbdivididas
            // 
            icbdivididas.Dock = DockStyle.Top;
            icbdivididas.FlatAppearance.BorderSize = 0;
            icbdivididas.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 0, 255);
            icbdivididas.FlatStyle = FlatStyle.Flat;
            icbdivididas.ForeColor = Color.White;
            icbdivididas.IconChar = FontAwesome.Sharp.IconChar.Divide;
            icbdivididas.IconColor = Color.White;
            icbdivididas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbdivididas.IconSize = 32;
            icbdivididas.ImageAlign = ContentAlignment.MiddleLeft;
            icbdivididas.Location = new Point(0, 320);
            icbdivididas.Name = "icbdivididas";
            icbdivididas.Padding = new Padding(10, 0, 20, 0);
            icbdivididas.Size = new Size(220, 60);
            icbdivididas.TabIndex = 4;
            icbdivididas.Text = "Divididas";
            icbdivididas.TextAlign = ContentAlignment.MiddleLeft;
            icbdivididas.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbdivididas.UseVisualStyleBackColor = true;
            icbdivididas.Click += icbdivididas_Click;
            // 
            // icbnuméricas
            // 
            icbnuméricas.Dock = DockStyle.Top;
            icbnuméricas.FlatAppearance.BorderSize = 0;
            icbnuméricas.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 0, 255);
            icbnuméricas.FlatStyle = FlatStyle.Flat;
            icbnuméricas.ForeColor = Color.White;
            icbnuméricas.IconChar = FontAwesome.Sharp.IconChar.NotEqual;
            icbnuméricas.IconColor = Color.White;
            icbnuméricas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbnuméricas.IconSize = 32;
            icbnuméricas.ImageAlign = ContentAlignment.MiddleLeft;
            icbnuméricas.Location = new Point(0, 260);
            icbnuméricas.Name = "icbnuméricas";
            icbnuméricas.Padding = new Padding(10, 0, 20, 0);
            icbnuméricas.Size = new Size(220, 60);
            icbnuméricas.TabIndex = 3;
            icbnuméricas.Text = "Numéricas";
            icbnuméricas.TextAlign = ContentAlignment.MiddleLeft;
            icbnuméricas.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbnuméricas.UseVisualStyleBackColor = true;
            icbnuméricas.Click += icbnuméricas_Click;
            // 
            // icbtrapecio
            // 
            icbtrapecio.Dock = DockStyle.Top;
            icbtrapecio.FlatAppearance.BorderSize = 0;
            icbtrapecio.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 0, 255);
            icbtrapecio.FlatStyle = FlatStyle.Flat;
            icbtrapecio.ForeColor = Color.White;
            icbtrapecio.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            icbtrapecio.IconColor = Color.White;
            icbtrapecio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtrapecio.IconSize = 32;
            icbtrapecio.ImageAlign = ContentAlignment.MiddleLeft;
            icbtrapecio.Location = new Point(0, 200);
            icbtrapecio.Name = "icbtrapecio";
            icbtrapecio.Padding = new Padding(10, 0, 20, 0);
            icbtrapecio.Size = new Size(220, 60);
            icbtrapecio.TabIndex = 2;
            icbtrapecio.Text = "Trapecio";
            icbtrapecio.TextAlign = ContentAlignment.MiddleLeft;
            icbtrapecio.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbtrapecio.UseVisualStyleBackColor = true;
            icbtrapecio.Click += icbtrapecio_Click;
            // 
            // icbimpson
            // 
            icbimpson.Dock = DockStyle.Top;
            icbimpson.FlatAppearance.BorderSize = 0;
            icbimpson.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 0, 255);
            icbimpson.FlatStyle = FlatStyle.Flat;
            icbimpson.ForeColor = Color.White;
            icbimpson.IconChar = FontAwesome.Sharp.IconChar.WaveSquare;
            icbimpson.IconColor = Color.White;
            icbimpson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbimpson.IconSize = 32;
            icbimpson.ImageAlign = ContentAlignment.MiddleLeft;
            icbimpson.Location = new Point(0, 140);
            icbimpson.Name = "icbimpson";
            icbimpson.Padding = new Padding(10, 0, 20, 0);
            icbimpson.Size = new Size(220, 60);
            icbimpson.TabIndex = 1;
            icbimpson.Text = "Simpson";
            icbimpson.TextAlign = ContentAlignment.MiddleLeft;
            icbimpson.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbimpson.UseVisualStyleBackColor = true;
            icbimpson.Click += icbimpson_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(pcbinicio);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(220, 140);
            panellogo.TabIndex = 0;
            // 
            // pcbinicio
            // 
            pcbinicio.Image = (Image)resources.GetObject("pcbinicio.Image");
            pcbinicio.Location = new Point(12, 12);
            pcbinicio.Name = "pcbinicio";
            pcbinicio.Size = new Size(178, 112);
            pcbinicio.SizeMode = PictureBoxSizeMode.Zoom;
            pcbinicio.TabIndex = 0;
            pcbinicio.TabStop = false;
            pcbinicio.Click += pcbinicio_Click;
            // 
            // paneltitulo
            // 
            paneltitulo.BackColor = Color.FromArgb(25, 118, 210);
            paneltitulo.Controls.Add(lbtitulo);
            paneltitulo.Controls.Add(icpbinicio);
            paneltitulo.Dock = DockStyle.Top;
            paneltitulo.Location = new Point(220, 0);
            paneltitulo.Name = "paneltitulo";
            paneltitulo.Size = new Size(962, 75);
            paneltitulo.TabIndex = 1;
            // 
            // lbtitulo
            // 
            lbtitulo.AutoSize = true;
            lbtitulo.Location = new Point(94, 29);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(50, 20);
            lbtitulo.TabIndex = 1;
            lbtitulo.Text = "label1";
            lbtitulo.Click += lbtitulo_Click_1;
            // 
            // icpbinicio
            // 
            icpbinicio.BackColor = Color.FromArgb(25, 118, 210);
            icpbinicio.ForeColor = SystemColors.ActiveCaption;
            icpbinicio.IconChar = FontAwesome.Sharp.IconChar.House;
            icpbinicio.IconColor = SystemColors.ActiveCaption;
            icpbinicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icpbinicio.IconSize = 44;
            icpbinicio.Location = new Point(23, 18);
            icpbinicio.Name = "icpbinicio";
            icpbinicio.Size = new Size(65, 44);
            icpbinicio.TabIndex = 0;
            icpbinicio.TabStop = false;
            // 
            // panelsombra
            // 
            panelsombra.BackColor = Color.FromArgb(25, 118, 210);
            panelsombra.Dock = DockStyle.Top;
            panelsombra.Location = new Point(220, 75);
            panelsombra.Name = "panelsombra";
            panelsombra.Size = new Size(962, 10);
            panelsombra.TabIndex = 2;
            // 
            // panelescritorio
            // 
            panelescritorio.BackColor = Color.FromArgb(33, 150, 243);
            panelescritorio.Controls.Add(pictureBox2);
            panelescritorio.Controls.Add(pictureBox1);
            panelescritorio.Dock = DockStyle.Fill;
            panelescritorio.Location = new Point(220, 85);
            panelescritorio.Name = "panelescritorio";
            panelescritorio.Size = new Size(962, 538);
            panelescritorio.TabIndex = 3;
            panelescritorio.Paint += panelescritorio_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.unnamed;
            pictureBox2.Location = new Point(692, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 148);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 623);
            Controls.Add(panelescritorio);
            Controls.Add(panelsombra);
            Controls.Add(paneltitulo);
            Controls.Add(panelmenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelmenu.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbinicio).EndInit();
            paneltitulo.ResumeLayout(false);
            paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icpbinicio).EndInit();
            panelescritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenu;
        private FontAwesome.Sharp.IconButton icbimpson;
        private Panel panellogo;
        private FontAwesome.Sharp.IconButton icbraices;
        private FontAwesome.Sharp.IconButton icbdivididas;
        private FontAwesome.Sharp.IconButton icbnuméricas;
        private FontAwesome.Sharp.IconButton icbtrapecio;
        private PictureBox pcbinicio;
        private Panel paneltitulo;
        private FontAwesome.Sharp.IconPictureBox icpbinicio;
        private Panel panelsombra;
        private Panel panelescritorio;
        private Label lbtitulo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
