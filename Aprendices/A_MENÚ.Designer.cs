namespace Aprendices
{
    partial class A_MENÚ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_MENÚ));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.A_LOGO = new System.Windows.Forms.PictureBox();
            this.A_dgv_LISTA = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_btn_ORDENARFILA = new System.Windows.Forms.Button();
            this.A_panelDegradado1 = new Aprendices.PanelDegradado();
            this.b_CLOSE = new System.Windows.Forms.Button();
            this.A_p_LATERAL = new Aprendices.PanelDegradado();
            this.A_btn_SEARCH = new System.Windows.Forms.Button();
            this.A_txt_search = new System.Windows.Forms.TextBox();
            this.A_lblDELETE = new System.Windows.Forms.Label();
            this.A_txt_icd = new System.Windows.Forms.TextBox();
            this.A_b_ADD = new System.Windows.Forms.Button();
            this.A_t_PU = new System.Windows.Forms.TextBox();
            this.A_t_CAN = new System.Windows.Forms.TextBox();
            this.A_t_NOM = new System.Windows.Forms.TextBox();
            this.A_t_COD = new System.Windows.Forms.TextBox();
            this.A_lbl_pu = new System.Windows.Forms.Label();
            this.A_lbl_can = new System.Windows.Forms.Label();
            this.A_lbl_nom = new System.Windows.Forms.Label();
            this.A_lbl_cod = new System.Windows.Forms.Label();
            this.t_Registro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.A_LOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_dgv_LISTA)).BeginInit();
            this.A_panelDegradado1.SuspendLayout();
            this.A_p_LATERAL.SuspendLayout();
            this.SuspendLayout();
            // 
            // A_LOGO
            // 
            this.A_LOGO.BackColor = System.Drawing.Color.Transparent;
            this.A_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("A_LOGO.Image")));
            this.A_LOGO.Location = new System.Drawing.Point(89, 487);
            this.A_LOGO.Name = "A_LOGO";
            this.A_LOGO.Size = new System.Drawing.Size(159, 162);
            this.A_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.A_LOGO.TabIndex = 2;
            this.A_LOGO.TabStop = false;
            // 
            // A_dgv_LISTA
            // 
            this.A_dgv_LISTA.AllowUserToAddRows = false;
            this.A_dgv_LISTA.AllowUserToDeleteRows = false;
            this.A_dgv_LISTA.AllowUserToResizeColumns = false;
            this.A_dgv_LISTA.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.A_dgv_LISTA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.A_dgv_LISTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_dgv_LISTA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.A_dgv_LISTA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(169)))), ((int)(((byte)(141)))));
            this.A_dgv_LISTA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.A_dgv_LISTA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.A_dgv_LISTA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(169)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.A_dgv_LISTA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.A_dgv_LISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_dgv_LISTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nom,
            this.can,
            this.pu,
            this.mi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.A_dgv_LISTA.DefaultCellStyle = dataGridViewCellStyle3;
            this.A_dgv_LISTA.EnableHeadersVisualStyles = false;
            this.A_dgv_LISTA.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.A_dgv_LISTA.Location = new System.Drawing.Point(345, 28);
            this.A_dgv_LISTA.Name = "A_dgv_LISTA";
            this.A_dgv_LISTA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.A_dgv_LISTA.RowHeadersVisible = false;
            this.A_dgv_LISTA.RowHeadersWidth = 51;
            this.A_dgv_LISTA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(208)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.A_dgv_LISTA.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.A_dgv_LISTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.A_dgv_LISTA.Size = new System.Drawing.Size(734, 692);
            this.A_dgv_LISTA.TabIndex = 6;
            this.A_dgv_LISTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_dgv_LISTA_CellContentClick);
            this.A_dgv_LISTA.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LISTA_CellValueChanged);
            // 
            // cod
            // 
            this.cod.FillWeight = 80F;
            this.cod.HeaderText = "CÓDIGO";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            // 
            // nom
            // 
            this.nom.FillWeight = 150F;
            this.nom.HeaderText = "NOMBRE";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            // 
            // can
            // 
            this.can.FillWeight = 80F;
            this.can.HeaderText = "CANTIDAD";
            this.can.MinimumWidth = 6;
            this.can.Name = "can";
            // 
            // pu
            // 
            this.pu.HeaderText = "PRECIO UNITARIO";
            this.pu.MinimumWidth = 6;
            this.pu.Name = "pu";
            // 
            // mi
            // 
            this.mi.HeaderText = "MONTO INVERTIDO";
            this.mi.MinimumWidth = 6;
            this.mi.Name = "mi";
            // 
            // A_btn_ORDENARFILA
            // 
            this.A_btn_ORDENARFILA.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_btn_ORDENARFILA.Location = new System.Drawing.Point(578, 36);
            this.A_btn_ORDENARFILA.Name = "A_btn_ORDENARFILA";
            this.A_btn_ORDENARFILA.Size = new System.Drawing.Size(33, 24);
            this.A_btn_ORDENARFILA.TabIndex = 17;
            this.A_btn_ORDENARFILA.Text = "▲▼";
            this.A_btn_ORDENARFILA.UseVisualStyleBackColor = true;
            this.A_btn_ORDENARFILA.Click += new System.EventHandler(this.btn_ORDENARFILA_Click);
            // 
            // A_panelDegradado1
            // 
            this.A_panelDegradado1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_panelDegradado1.BackColor = System.Drawing.SystemColors.Control;
            this.A_panelDegradado1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(169)))), ((int)(((byte)(141)))));
            this.A_panelDegradado1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(169)))), ((int)(((byte)(141)))));
            this.A_panelDegradado1.Controls.Add(this.b_CLOSE);
            this.A_panelDegradado1.Location = new System.Drawing.Point(345, 0);
            this.A_panelDegradado1.Name = "A_panelDegradado1";
            this.A_panelDegradado1.Size = new System.Drawing.Size(737, 30);
            this.A_panelDegradado1.TabIndex = 7;
            // 
            // b_CLOSE
            // 
            this.b_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.b_CLOSE.FlatAppearance.BorderSize = 0;
            this.b_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_CLOSE.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CLOSE.ForeColor = System.Drawing.Color.DarkRed;
            this.b_CLOSE.Location = new System.Drawing.Point(699, 3);
            this.b_CLOSE.Name = "b_CLOSE";
            this.b_CLOSE.Size = new System.Drawing.Size(30, 23);
            this.b_CLOSE.TabIndex = 8;
            this.b_CLOSE.Text = "X";
            this.b_CLOSE.UseVisualStyleBackColor = false;
            this.b_CLOSE.Click += new System.EventHandler(this.b_CLOSE_Click);
            // 
            // A_p_LATERAL
            // 
            this.A_p_LATERAL.BackColor = System.Drawing.Color.Transparent;
            this.A_p_LATERAL.ColorBottom = System.Drawing.Color.PaleTurquoise;
            this.A_p_LATERAL.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(169)))), ((int)(((byte)(141)))));
            this.A_p_LATERAL.Controls.Add(this.A_btn_SEARCH);
            this.A_p_LATERAL.Controls.Add(this.A_txt_search);
            this.A_p_LATERAL.Controls.Add(this.A_lblDELETE);
            this.A_p_LATERAL.Controls.Add(this.A_txt_icd);
            this.A_p_LATERAL.Controls.Add(this.A_b_ADD);
            this.A_p_LATERAL.Controls.Add(this.A_t_PU);
            this.A_p_LATERAL.Controls.Add(this.A_t_CAN);
            this.A_p_LATERAL.Controls.Add(this.A_t_NOM);
            this.A_p_LATERAL.Controls.Add(this.A_t_COD);
            this.A_p_LATERAL.Controls.Add(this.A_lbl_pu);
            this.A_p_LATERAL.Controls.Add(this.A_lbl_can);
            this.A_p_LATERAL.Controls.Add(this.A_lbl_nom);
            this.A_p_LATERAL.Controls.Add(this.A_lbl_cod);
            this.A_p_LATERAL.Controls.Add(this.t_Registro);
            this.A_p_LATERAL.Location = new System.Drawing.Point(-2, 0);
            this.A_p_LATERAL.Name = "A_p_LATERAL";
            this.A_p_LATERAL.Size = new System.Drawing.Size(351, 464);
            this.A_p_LATERAL.TabIndex = 0;
            // 
            // A_btn_SEARCH
            // 
            this.A_btn_SEARCH.Location = new System.Drawing.Point(20, 410);
            this.A_btn_SEARCH.Name = "A_btn_SEARCH";
            this.A_btn_SEARCH.Size = new System.Drawing.Size(75, 23);
            this.A_btn_SEARCH.TabIndex = 16;
            this.A_btn_SEARCH.Text = "BUSCAR : ";
            this.A_btn_SEARCH.UseVisualStyleBackColor = true;
            this.A_btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // A_txt_search
            // 
            this.A_txt_search.Location = new System.Drawing.Point(109, 410);
            this.A_txt_search.Name = "A_txt_search";
            this.A_txt_search.Size = new System.Drawing.Size(183, 20);
            this.A_txt_search.TabIndex = 15;
            this.A_txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // A_lblDELETE
            // 
            this.A_lblDELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_lblDELETE.AutoSize = true;
            this.A_lblDELETE.BackColor = System.Drawing.Color.Transparent;
            this.A_lblDELETE.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_lblDELETE.Location = new System.Drawing.Point(14, 335);
            this.A_lblDELETE.Name = "A_lblDELETE";
            this.A_lblDELETE.Size = new System.Drawing.Size(155, 17);
            this.A_lblDELETE.TabIndex = 14;
            this.A_lblDELETE.Text = "BORRAR POR CÓDIGO :";
            // 
            // A_txt_icd
            // 
            this.A_txt_icd.Location = new System.Drawing.Point(175, 335);
            this.A_txt_icd.Name = "A_txt_icd";
            this.A_txt_icd.Size = new System.Drawing.Size(80, 20);
            this.A_txt_icd.TabIndex = 13;
            this.A_txt_icd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.A_txt_icd_KeyDown);
            this.A_txt_icd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_icd_KeyPress);
            // 
            // A_b_ADD
            // 
            this.A_b_ADD.FlatAppearance.BorderSize = 0;
            this.A_b_ADD.Location = new System.Drawing.Point(95, 277);
            this.A_b_ADD.Name = "A_b_ADD";
            this.A_b_ADD.Size = new System.Drawing.Size(87, 26);
            this.A_b_ADD.TabIndex = 11;
            this.A_b_ADD.Text = "AGREGAR";
            this.A_b_ADD.UseVisualStyleBackColor = true;
            this.A_b_ADD.Click += new System.EventHandler(this.b_ADD_Click);
            // 
            // A_t_PU
            // 
            this.A_t_PU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_t_PU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(208)))), ((int)(((byte)(196)))));
            this.A_t_PU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A_t_PU.Location = new System.Drawing.Point(154, 231);
            this.A_t_PU.Name = "A_t_PU";
            this.A_t_PU.Size = new System.Drawing.Size(126, 20);
            this.A_t_PU.TabIndex = 10;
            this.A_t_PU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_PU_KeyPress);
            // 
            // A_t_CAN
            // 
            this.A_t_CAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_t_CAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(208)))), ((int)(((byte)(196)))));
            this.A_t_CAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A_t_CAN.Location = new System.Drawing.Point(109, 193);
            this.A_t_CAN.Name = "A_t_CAN";
            this.A_t_CAN.Size = new System.Drawing.Size(171, 20);
            this.A_t_CAN.TabIndex = 9;
            this.A_t_CAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_CAN_KeyPress);
            // 
            // A_t_NOM
            // 
            this.A_t_NOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_t_NOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(208)))), ((int)(((byte)(196)))));
            this.A_t_NOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A_t_NOM.Location = new System.Drawing.Point(95, 156);
            this.A_t_NOM.Name = "A_t_NOM";
            this.A_t_NOM.Size = new System.Drawing.Size(185, 20);
            this.A_t_NOM.TabIndex = 8;
            this.A_t_NOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_NOM_KeyPress);
            // 
            // A_t_COD
            // 
            this.A_t_COD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_t_COD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(208)))), ((int)(((byte)(196)))));
            this.A_t_COD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A_t_COD.Location = new System.Drawing.Point(93, 118);
            this.A_t_COD.Name = "A_t_COD";
            this.A_t_COD.Size = new System.Drawing.Size(187, 20);
            this.A_t_COD.TabIndex = 7;
            this.A_t_COD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_COD_KeyPress);
            // 
            // A_lbl_pu
            // 
            this.A_lbl_pu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_lbl_pu.AutoSize = true;
            this.A_lbl_pu.BackColor = System.Drawing.Color.Transparent;
            this.A_lbl_pu.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_lbl_pu.Location = new System.Drawing.Point(17, 234);
            this.A_lbl_pu.Name = "A_lbl_pu";
            this.A_lbl_pu.Size = new System.Drawing.Size(131, 17);
            this.A_lbl_pu.TabIndex = 6;
            this.A_lbl_pu.Text = "PRECIO UNITARIO :";
            // 
            // A_lbl_can
            // 
            this.A_lbl_can.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_lbl_can.AutoSize = true;
            this.A_lbl_can.BackColor = System.Drawing.Color.Transparent;
            this.A_lbl_can.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_lbl_can.Location = new System.Drawing.Point(17, 196);
            this.A_lbl_can.Name = "A_lbl_can";
            this.A_lbl_can.Size = new System.Drawing.Size(86, 17);
            this.A_lbl_can.TabIndex = 6;
            this.A_lbl_can.Text = "CANTIDAD :";
            // 
            // A_lbl_nom
            // 
            this.A_lbl_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_lbl_nom.AutoSize = true;
            this.A_lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.A_lbl_nom.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_lbl_nom.Location = new System.Drawing.Point(17, 156);
            this.A_lbl_nom.Name = "A_lbl_nom";
            this.A_lbl_nom.Size = new System.Drawing.Size(72, 17);
            this.A_lbl_nom.TabIndex = 6;
            this.A_lbl_nom.Text = "NOMBRE :";
            // 
            // A_lbl_cod
            // 
            this.A_lbl_cod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_lbl_cod.AutoSize = true;
            this.A_lbl_cod.BackColor = System.Drawing.Color.Transparent;
            this.A_lbl_cod.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_lbl_cod.Location = new System.Drawing.Point(17, 118);
            this.A_lbl_cod.Name = "A_lbl_cod";
            this.A_lbl_cod.Size = new System.Drawing.Size(70, 17);
            this.A_lbl_cod.TabIndex = 6;
            this.A_lbl_cod.Text = "CÓDIGO : ";
            // 
            // t_Registro
            // 
            this.t_Registro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Registro.AutoSize = true;
            this.t_Registro.BackColor = System.Drawing.Color.Transparent;
            this.t_Registro.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Registro.Location = new System.Drawing.Point(13, 40);
            this.t_Registro.Name = "t_Registro";
            this.t_Registro.Size = new System.Drawing.Size(323, 23);
            this.t_Registro.TabIndex = 6;
            this.t_Registro.Text = "REGISTRO DE MEDICAMENTOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // A_MENÚ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1077, 718);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.A_btn_ORDENARFILA);
            this.Controls.Add(this.A_panelDegradado1);
            this.Controls.Add(this.A_dgv_LISTA);
            this.Controls.Add(this.A_p_LATERAL);
            this.Controls.Add(this.A_LOGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A_MENÚ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A_LOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_dgv_LISTA)).EndInit();
            this.A_panelDegradado1.ResumeLayout(false);
            this.A_p_LATERAL.ResumeLayout(false);
            this.A_p_LATERAL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelDegradado A_p_LATERAL;
        private System.Windows.Forms.PictureBox A_LOGO;
        private System.Windows.Forms.TextBox A_t_PU;
        private System.Windows.Forms.TextBox A_t_CAN;
        private System.Windows.Forms.TextBox A_t_NOM;
        private System.Windows.Forms.TextBox A_t_COD;
        private System.Windows.Forms.Label A_lbl_pu;
        private System.Windows.Forms.Label A_lbl_can;
        private System.Windows.Forms.Label A_lbl_nom;
        private System.Windows.Forms.Label A_lbl_cod;
        private System.Windows.Forms.Label t_Registro;
        private System.Windows.Forms.Button A_b_ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn can;
        private System.Windows.Forms.DataGridViewTextBoxColumn pu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mi;
        private PanelDegradado A_panelDegradado1;
        private System.Windows.Forms.Button b_CLOSE;
        public System.Windows.Forms.DataGridView A_dgv_LISTA;
        private System.Windows.Forms.TextBox A_txt_icd;
        private System.Windows.Forms.Label A_lblDELETE;
        private System.Windows.Forms.Button A_btn_SEARCH;
        private System.Windows.Forms.TextBox A_txt_search;
        private System.Windows.Forms.Button A_btn_ORDENARFILA;
        private System.Windows.Forms.Button button1;
    }
}