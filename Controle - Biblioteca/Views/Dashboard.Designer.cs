namespace Controle___Biblioteca
{
    partial class Dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.divNavbar = new System.Windows.Forms.Panel();
            this.BorderNavbar = new System.Windows.Forms.Panel();
            this.divNavbarContent = new System.Windows.Forms.Panel();
            this.divNavbarLeft = new System.Windows.Forms.Panel();
            this.divNavbarRight = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.navbarLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.divNavbar.SuspendLayout();
            this.divNavbarContent.SuspendLayout();
            this.divNavbarLeft.SuspendLayout();
            this.divNavbarRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navbarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // divNavbar
            // 
            this.divNavbar.BackColor = System.Drawing.Color.White;
            this.divNavbar.Controls.Add(this.divNavbarContent);
            this.divNavbar.Controls.Add(this.BorderNavbar);
            this.divNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.divNavbar.Location = new System.Drawing.Point(0, 0);
            this.divNavbar.Name = "divNavbar";
            this.divNavbar.Size = new System.Drawing.Size(1350, 77);
            this.divNavbar.TabIndex = 0;
            // 
            // BorderNavbar
            // 
            this.BorderNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.BorderNavbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderNavbar.Location = new System.Drawing.Point(0, 76);
            this.BorderNavbar.Name = "BorderNavbar";
            this.BorderNavbar.Size = new System.Drawing.Size(1350, 1);
            this.BorderNavbar.TabIndex = 0;
            // 
            // divNavbarContent
            // 
            this.divNavbarContent.Controls.Add(this.divNavbarRight);
            this.divNavbarContent.Controls.Add(this.divNavbarLeft);
            this.divNavbarContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divNavbarContent.Location = new System.Drawing.Point(0, 0);
            this.divNavbarContent.Name = "divNavbarContent";
            this.divNavbarContent.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.divNavbarContent.Size = new System.Drawing.Size(1350, 76);
            this.divNavbarContent.TabIndex = 1;
            // 
            // divNavbarLeft
            // 
            this.divNavbarLeft.BackColor = System.Drawing.Color.Transparent;
            this.divNavbarLeft.Controls.Add(this.navbarLogo);
            this.divNavbarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.divNavbarLeft.Location = new System.Drawing.Point(100, 0);
            this.divNavbarLeft.Name = "divNavbarLeft";
            this.divNavbarLeft.Size = new System.Drawing.Size(510, 76);
            this.divNavbarLeft.TabIndex = 0;
            // 
            // divNavbarRight
            // 
            this.divNavbarRight.BackColor = System.Drawing.Color.Transparent;
            this.divNavbarRight.Controls.Add(this.linkLabel2);
            this.divNavbarRight.Controls.Add(this.linkLabel1);
            this.divNavbarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.divNavbarRight.Location = new System.Drawing.Point(713, 0);
            this.divNavbarRight.Name = "divNavbarRight";
            this.divNavbarRight.Size = new System.Drawing.Size(537, 76);
            this.divNavbarRight.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.linkLabel1.Location = new System.Drawing.Point(430, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(8);
            this.linkLabel1.Size = new System.Drawing.Size(107, 76);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastros";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Orange;
            // 
            // linkLabel2
            // 
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.linkLabel2.Location = new System.Drawing.Point(323, 0);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Padding = new System.Windows.Forms.Padding(8);
            this.linkLabel2.Size = new System.Drawing.Size(107, 76);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Dashboard";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Orange;
            // 
            // navbarLogo
            // 
            this.navbarLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navbarLogo.BackgroundImage")));
            this.navbarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navbarLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbarLogo.Location = new System.Drawing.Point(0, 0);
            this.navbarLogo.Name = "navbarLogo";
            this.navbarLogo.Size = new System.Drawing.Size(80, 76);
            this.navbarLogo.TabIndex = 0;
            this.navbarLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 652);
            this.panel1.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.divNavbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Inicial";
            this.divNavbar.ResumeLayout(false);
            this.divNavbarContent.ResumeLayout(false);
            this.divNavbarLeft.ResumeLayout(false);
            this.divNavbarRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navbarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel divNavbar;
        private System.Windows.Forms.Panel BorderNavbar;
        private System.Windows.Forms.Panel divNavbarContent;
        private System.Windows.Forms.Panel divNavbarRight;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel divNavbarLeft;
        private System.Windows.Forms.PictureBox navbarLogo;
        private System.Windows.Forms.Panel panel1;
    }
}

