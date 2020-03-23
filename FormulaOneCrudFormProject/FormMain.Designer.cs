namespace FormulaOneCrudFormProject
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgSecondDriver = new System.Windows.Forms.PictureBox();
            this.imgFirstDriver = new System.Windows.Forms.PictureBox();
            this.lblNameFirstDriver = new System.Windows.Forms.Label();
            this.lblNameSecondDriver = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPowerUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTechnicalChief = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgTeam = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuovoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.apriToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stampaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.incollaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPageDriver = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecondDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFirstDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeam)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTeam);
            this.tabControlMain.Controls.Add(this.tabPageDriver);
            this.tabControlMain.Controls.Add(this.tabPageServices);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(998, 558);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTeam.Controls.Add(this.label5);
            this.tabPageTeam.Controls.Add(this.txtPowerUnit);
            this.tabPageTeam.Controls.Add(this.label4);
            this.tabPageTeam.Controls.Add(this.txtChassis);
            this.tabPageTeam.Controls.Add(this.label3);
            this.tabPageTeam.Controls.Add(this.txtTechnicalChief);
            this.tabPageTeam.Controls.Add(this.label2);
            this.tabPageTeam.Controls.Add(this.txtFullName);
            this.tabPageTeam.Controls.Add(this.txtCountry);
            this.tabPageTeam.Controls.Add(this.label1);
            this.tabPageTeam.Controls.Add(this.imgTeam);
            this.tabPageTeam.Controls.Add(this.btnExport);
            this.tabPageTeam.Controls.Add(this.listBoxTeam);
            this.tabPageTeam.Controls.Add(this.toolStrip1);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(990, 532);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "TEAM";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imgSecondDriver, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgFirstDriver, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNameFirstDriver, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNameSecondDriver, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(487, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 501);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // imgSecondDriver
            // 
            this.imgSecondDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSecondDriver.Location = new System.Drawing.Point(253, 3);
            this.imgSecondDriver.Name = "imgSecondDriver";
            this.imgSecondDriver.Size = new System.Drawing.Size(244, 294);
            this.imgSecondDriver.TabIndex = 1;
            this.imgSecondDriver.TabStop = false;
            // 
            // imgFirstDriver
            // 
            this.imgFirstDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFirstDriver.Location = new System.Drawing.Point(3, 3);
            this.imgFirstDriver.Name = "imgFirstDriver";
            this.imgFirstDriver.Size = new System.Drawing.Size(244, 294);
            this.imgFirstDriver.TabIndex = 0;
            this.imgFirstDriver.TabStop = false;
            // 
            // lblNameFirstDriver
            // 
            this.lblNameFirstDriver.AutoSize = true;
            this.lblNameFirstDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameFirstDriver.Font = new System.Drawing.Font("Calibri Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirstDriver.Location = new System.Drawing.Point(3, 350);
            this.lblNameFirstDriver.Name = "lblNameFirstDriver";
            this.lblNameFirstDriver.Size = new System.Drawing.Size(244, 100);
            this.lblNameFirstDriver.TabIndex = 2;
            this.lblNameFirstDriver.Text = "First driver name";
            this.lblNameFirstDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameSecondDriver
            // 
            this.lblNameSecondDriver.AutoSize = true;
            this.lblNameSecondDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameSecondDriver.Font = new System.Drawing.Font("Calibri Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSecondDriver.Location = new System.Drawing.Point(253, 350);
            this.lblNameSecondDriver.Name = "lblNameSecondDriver";
            this.lblNameSecondDriver.Size = new System.Drawing.Size(244, 100);
            this.lblNameSecondDriver.TabIndex = 3;
            this.lblNameSecondDriver.Text = "Second driver name";
            this.lblNameSecondDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Power unit";
            // 
            // txtPowerUnit
            // 
            this.txtPowerUnit.Location = new System.Drawing.Point(326, 375);
            this.txtPowerUnit.Name = "txtPowerUnit";
            this.txtPowerUnit.Size = new System.Drawing.Size(120, 20);
            this.txtPowerUnit.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chassis";
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(326, 349);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(120, 20);
            this.txtChassis.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Technical chief";
            // 
            // txtTechnicalChief
            // 
            this.txtTechnicalChief.Location = new System.Drawing.Point(326, 323);
            this.txtTechnicalChief.Name = "txtTechnicalChief";
            this.txtTechnicalChief.Size = new System.Drawing.Size(120, 20);
            this.txtTechnicalChief.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Full name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(326, 272);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(120, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(326, 297);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(120, 20);
            this.txtCountry.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Country";
            // 
            // imgTeam
            // 
            this.imgTeam.Location = new System.Drawing.Point(165, 31);
            this.imgTeam.Name = "imgTeam";
            this.imgTeam.Size = new System.Drawing.Size(200, 200);
            this.imgTeam.TabIndex = 3;
            this.imgTeam.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(749, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export to JSON";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.Location = new System.Drawing.Point(3, 28);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(153, 501);
            this.listBoxTeam.TabIndex = 1;
            this.listBoxTeam.SelectedIndexChanged += new System.EventHandler(this.listBoxTeam_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripButton,
            this.apriToolStripButton,
            this.salvaToolStripButton,
            this.stampaToolStripButton,
            this.toolStripSeparator,
            this.tagliaToolStripButton,
            this.copiaToolStripButton,
            this.incollaToolStripButton,
            this.toolStripSeparator1,
            this.ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nuovoToolStripButton
            // 
            this.nuovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuovoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripButton.Image")));
            this.nuovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripButton.Name = "nuovoToolStripButton";
            this.nuovoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuovoToolStripButton.Text = "&Nuovo";
            // 
            // apriToolStripButton
            // 
            this.apriToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apriToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripButton.Image")));
            this.apriToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripButton.Name = "apriToolStripButton";
            this.apriToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.apriToolStripButton.Text = "&Apri";
            // 
            // salvaToolStripButton
            // 
            this.salvaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripButton.Image")));
            this.salvaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripButton.Name = "salvaToolStripButton";
            this.salvaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvaToolStripButton.Text = "&Salva";
            // 
            // stampaToolStripButton
            // 
            this.stampaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stampaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripButton.Image")));
            this.stampaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripButton.Name = "stampaToolStripButton";
            this.stampaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stampaToolStripButton.Text = "&Stampa";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tagliaToolStripButton
            // 
            this.tagliaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagliaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripButton.Image")));
            this.tagliaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripButton.Name = "tagliaToolStripButton";
            this.tagliaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.tagliaToolStripButton.Text = "&Taglia";
            // 
            // copiaToolStripButton
            // 
            this.copiaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripButton.Image")));
            this.copiaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripButton.Name = "copiaToolStripButton";
            this.copiaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiaToolStripButton.Text = "&Copia";
            // 
            // incollaToolStripButton
            // 
            this.incollaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incollaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripButton.Image")));
            this.incollaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripButton.Name = "incollaToolStripButton";
            this.incollaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.incollaToolStripButton.Text = "&Incolla";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            // 
            // tabPageDriver
            // 
            this.tabPageDriver.Location = new System.Drawing.Point(4, 22);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDriver.Size = new System.Drawing.Size(990, 532);
            this.tabPageDriver.TabIndex = 1;
            this.tabPageDriver.Text = "DRIVER";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(990, 532);
            this.tabPageServices.TabIndex = 2;
            this.tabPageServices.Text = "-- Services --";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Formula One CRUD";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSecondDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFirstDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeam)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.TabPage tabPageDriver;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuovoToolStripButton;
        private System.Windows.Forms.ToolStripButton apriToolStripButton;
        private System.Windows.Forms.ToolStripButton salvaToolStripButton;
        private System.Windows.Forms.ToolStripButton stampaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tagliaToolStripButton;
        private System.Windows.Forms.ToolStripButton copiaToolStripButton;
        private System.Windows.Forms.ToolStripButton incollaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox imgTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTechnicalChief;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPowerUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox imgSecondDriver;
        private System.Windows.Forms.PictureBox imgFirstDriver;
        private System.Windows.Forms.Label lblNameFirstDriver;
        private System.Windows.Forms.Label lblNameSecondDriver;
    }
}

