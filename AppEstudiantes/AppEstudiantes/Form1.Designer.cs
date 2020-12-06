namespace AppEstudiantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripButton tsGuardar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigoin = new System.Windows.Forms.TextBox();
            this.txtnombrein = new System.Windows.Forms.TextBox();
            this.txtcorreoin = new System.Windows.Forms.TextBox();
            this.txtnota1in = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnota2in = new System.Windows.Forms.TextBox();
            this.txtnota3in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnota4in = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgTablaDatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsAddUser = new System.Windows.Forms.ToolStripButton();
            this.tsSearchUser = new System.Windows.Forms.ToolStripButton();
            this.tsEditUser = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            tsGuardar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // tsGuardar
            // 
            tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
            tsGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsGuardar.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            tsGuardar.Name = "tsGuardar";
            tsGuardar.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            tsGuardar.Size = new System.Drawing.Size(101, 94);
            tsGuardar.Text = "Guardar Archivo XLM";
            tsGuardar.Visible = false;
            tsGuardar.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 1";
            // 
            // txtcodigoin
            // 
            this.txtcodigoin.Location = new System.Drawing.Point(676, 210);
            this.txtcodigoin.Name = "txtcodigoin";
            this.txtcodigoin.Size = new System.Drawing.Size(162, 30);
            this.txtcodigoin.TabIndex = 5;
            // 
            // txtnombrein
            // 
            this.txtnombrein.Location = new System.Drawing.Point(175, 277);
            this.txtnombrein.Name = "txtnombrein";
            this.txtnombrein.Size = new System.Drawing.Size(663, 30);
            this.txtnombrein.TabIndex = 6;
            // 
            // txtcorreoin
            // 
            this.txtcorreoin.Location = new System.Drawing.Point(175, 338);
            this.txtcorreoin.Name = "txtcorreoin";
            this.txtcorreoin.Size = new System.Drawing.Size(663, 30);
            this.txtcorreoin.TabIndex = 7;
            // 
            // txtnota1in
            // 
            this.txtnota1in.Location = new System.Drawing.Point(174, 394);
            this.txtnota1in.Name = "txtnota1in";
            this.txtnota1in.Size = new System.Drawing.Size(63, 30);
            this.txtnota1in.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nota 2";
            // 
            // txtnota2in
            // 
            this.txtnota2in.Location = new System.Drawing.Point(374, 394);
            this.txtnota2in.Name = "txtnota2in";
            this.txtnota2in.Size = new System.Drawing.Size(63, 30);
            this.txtnota2in.TabIndex = 10;
            // 
            // txtnota3in
            // 
            this.txtnota3in.Location = new System.Drawing.Point(574, 396);
            this.txtnota3in.Name = "txtnota3in";
            this.txtnota3in.Size = new System.Drawing.Size(63, 30);
            this.txtnota3in.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nota 3";
            // 
            // txtnota4in
            // 
            this.txtnota4in.Location = new System.Drawing.Point(775, 396);
            this.txtnota4in.Name = "txtnota4in";
            this.txtnota4in.Size = new System.Drawing.Size(63, 30);
            this.txtnota4in.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nota 4";
            // 
            // dgTablaDatos
            // 
            this.dgTablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaDatos.Location = new System.Drawing.Point(76, 483);
            this.dgTablaDatos.Name = "dgTablaDatos";
            this.dgTablaDatos.RowHeadersWidth = 62;
            this.dgTablaDatos.RowTemplate.Height = 28;
            this.dgTablaDatos.Size = new System.Drawing.Size(762, 141);
            this.dgTablaDatos.TabIndex = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenFile,
            this.tsAddUser,
            this.tsSearchUser,
            this.tsEditUser,
            this.tsDeleteUser,
            tsGuardar,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 119);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsOpenFile
            // 
            this.tsOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenFile.Image")));
            this.tsOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFile.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.tsOpenFile.Name = "tsOpenFile";
            this.tsOpenFile.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.tsOpenFile.Size = new System.Drawing.Size(101, 94);
            this.tsOpenFile.Text = "toolStripButton1";
            this.tsOpenFile.Visible = false;
            this.tsOpenFile.Click += new System.EventHandler(this.tsOpenFile_Click_1);
            // 
            // tsAddUser
            // 
            this.tsAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsAddUser.Image")));
            this.tsAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUser.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.tsAddUser.Name = "tsAddUser";
            this.tsAddUser.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.tsAddUser.Size = new System.Drawing.Size(101, 94);
            this.tsAddUser.Text = "toolStripButton2";
            this.tsAddUser.Click += new System.EventHandler(this.tsAddUser_Click);
            // 
            // tsSearchUser
            // 
            this.tsSearchUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSearchUser.Image = ((System.Drawing.Image)(resources.GetObject("tsSearchUser.Image")));
            this.tsSearchUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSearchUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearchUser.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.tsSearchUser.Name = "tsSearchUser";
            this.tsSearchUser.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.tsSearchUser.Size = new System.Drawing.Size(101, 94);
            this.tsSearchUser.Text = "toolStripButton3";
            this.tsSearchUser.Click += new System.EventHandler(this.tsSearchUser_Click);
            // 
            // tsEditUser
            // 
            this.tsEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEditUser.Enabled = false;
            this.tsEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsEditUser.Image")));
            this.tsEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditUser.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.tsEditUser.Name = "tsEditUser";
            this.tsEditUser.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.tsEditUser.Size = new System.Drawing.Size(101, 94);
            this.tsEditUser.Text = "toolStripButton4";
            this.tsEditUser.Click += new System.EventHandler(this.tsEditUser_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteUser.Enabled = false;
            this.tsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsDeleteUser.Image")));
            this.tsDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteUser.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.tsDeleteUser.Size = new System.Drawing.Size(101, 94);
            this.tsDeleteUser.Text = "toolStripButton5";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Margin = new System.Windows.Forms.Padding(10, 20, 10, 5);
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.toolStripButton7.Size = new System.Drawing.Size(101, 94);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 744);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgTablaDatos);
            this.Controls.Add(this.txtnota4in);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnota3in);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnota2in);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnota1in);
            this.Controls.Add(this.txtcorreoin);
            this.Controls.Add(this.txtnombrein);
            this.Controls.Add(this.txtcodigoin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigoin;
        private System.Windows.Forms.TextBox txtnombrein;
        private System.Windows.Forms.TextBox txtcorreoin;
        private System.Windows.Forms.TextBox txtnota1in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnota2in;
        private System.Windows.Forms.TextBox txtnota3in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnota4in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgTablaDatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsOpenFile;
        private System.Windows.Forms.ToolStripButton tsAddUser;
        private System.Windows.Forms.ToolStripButton tsSearchUser;
        private System.Windows.Forms.ToolStripButton tsEditUser;
        private System.Windows.Forms.ToolStripButton tsDeleteUser;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ErrorProvider errorM;
    }
}

