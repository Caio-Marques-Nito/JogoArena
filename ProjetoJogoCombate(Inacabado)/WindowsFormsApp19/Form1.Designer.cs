namespace WindowsFormsApp19
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.VidaInimigoBar = new System.Windows.Forms.ProgressBar();
            this.VidaPersonagemBar = new System.Windows.Forms.ProgressBar();
            this.NomeP = new System.Windows.Forms.Label();
            this.NomeI = new System.Windows.Forms.Label();
            this.DanoB = new System.Windows.Forms.Button();
            this.Valores = new System.Windows.Forms.Timer(this.components);
            this.Atacar = new System.Windows.Forms.Timer(this.components);
            this.Recarga = new System.Windows.Forms.Button();
            this.EscolherInimigo = new System.Windows.Forms.Timer(this.components);
            this.VerificarVidaI = new System.Windows.Forms.Timer(this.components);
            this.ataqueILabel = new System.Windows.Forms.Label();
            this.jogaI = new System.Windows.Forms.Label();
            this.JogadasP = new System.Windows.Forms.Label();
            this.Defender = new System.Windows.Forms.Button();
            this.EnergiaLabel = new System.Windows.Forms.Label();
            this.ataquePLabel = new System.Windows.Forms.Label();
            this.DefesaLabel = new System.Windows.Forms.Label();
            this.AtivaçãoDLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PoçãoV = new System.Windows.Forms.Button();
            this.PoçãoVidaLabel = new System.Windows.Forms.Label();
            this.VidaPersonagemLabel = new System.Windows.Forms.Label();
            this.VidaInimigoLabel = new System.Windows.Forms.Label();
            this.ItemMao = new System.Windows.Forms.Label();
            this.coração1 = new System.Windows.Forms.PictureBox();
            this.coração2 = new System.Windows.Forms.PictureBox();
            this.coração3 = new System.Windows.Forms.PictureBox();
            this.ataqueErroPLabel = new System.Windows.Forms.Label();
            this.erroDoP = new System.Windows.Forms.Timer(this.components);
            this.AtaqueCriticoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coração1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coração2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coração3)).BeginInit();
            this.SuspendLayout();
            // 
            // VidaInimigoBar
            // 
            this.VidaInimigoBar.Location = new System.Drawing.Point(561, 12);
            this.VidaInimigoBar.Name = "VidaInimigoBar";
            this.VidaInimigoBar.Size = new System.Drawing.Size(180, 39);
            this.VidaInimigoBar.TabIndex = 0;
            // 
            // VidaPersonagemBar
            // 
            this.VidaPersonagemBar.Location = new System.Drawing.Point(177, 57);
            this.VidaPersonagemBar.Name = "VidaPersonagemBar";
            this.VidaPersonagemBar.Size = new System.Drawing.Size(100, 23);
            this.VidaPersonagemBar.TabIndex = 1;
            this.VidaPersonagemBar.Value = 100;
            // 
            // NomeP
            // 
            this.NomeP.AutoSize = true;
            this.NomeP.BackColor = System.Drawing.Color.Black;
            this.NomeP.ForeColor = System.Drawing.Color.Turquoise;
            this.NomeP.Location = new System.Drawing.Point(174, 83);
            this.NomeP.Name = "NomeP";
            this.NomeP.Size = new System.Drawing.Size(35, 13);
            this.NomeP.TabIndex = 2;
            this.NomeP.Text = "Jonas";
            // 
            // NomeI
            // 
            this.NomeI.AutoSize = true;
            this.NomeI.BackColor = System.Drawing.Color.Black;
            this.NomeI.ForeColor = System.Drawing.Color.Red;
            this.NomeI.Location = new System.Drawing.Point(558, 54);
            this.NomeI.Name = "NomeI";
            this.NomeI.Size = new System.Drawing.Size(40, 13);
            this.NomeI.TabIndex = 3;
            this.NomeI.Text = "Inimigo";
            // 
            // DanoB
            // 
            this.DanoB.Location = new System.Drawing.Point(18, 246);
            this.DanoB.Name = "DanoB";
            this.DanoB.Size = new System.Drawing.Size(74, 46);
            this.DanoB.TabIndex = 4;
            this.DanoB.Text = "Ataque";
            this.DanoB.UseVisualStyleBackColor = true;
            this.DanoB.Click += new System.EventHandler(this.button1_Click);
            this.DanoB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DanoB_DragEnter);
            this.DanoB.MouseCaptureChanged += new System.EventHandler(this.DanoB_MouseCaptureChanged);
            this.DanoB.MouseEnter += new System.EventHandler(this.DanoB_MouseEnter);
            // 
            // Valores
            // 
            this.Valores.Enabled = true;
            this.Valores.Interval = 1;
            this.Valores.Tick += new System.EventHandler(this.Valores_Tick);
            // 
            // Atacar
            // 
            this.Atacar.Enabled = true;
            this.Atacar.Interval = 1;
            this.Atacar.Tick += new System.EventHandler(this.Atacar_Tick);
            // 
            // Recarga
            // 
            this.Recarga.Location = new System.Drawing.Point(177, 235);
            this.Recarga.Name = "Recarga";
            this.Recarga.Size = new System.Drawing.Size(70, 29);
            this.Recarga.TabIndex = 8;
            this.Recarga.Text = "Sono";
            this.Recarga.UseVisualStyleBackColor = true;
            this.Recarga.Click += new System.EventHandler(this.Recarga_Click);
            // 
            // EscolherInimigo
            // 
            this.EscolherInimigo.Interval = 1;
            this.EscolherInimigo.Tick += new System.EventHandler(this.EscolherMonstro_Tick);
            // 
            // VerificarVidaI
            // 
            this.VerificarVidaI.Enabled = true;
            this.VerificarVidaI.Interval = 1;
            this.VerificarVidaI.Tick += new System.EventHandler(this.VerificarVidaM_Tick);
            // 
            // ataqueILabel
            // 
            this.ataqueILabel.AutoSize = true;
            this.ataqueILabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ataqueILabel.Location = new System.Drawing.Point(569, 90);
            this.ataqueILabel.Name = "ataqueILabel";
            this.ataqueILabel.Size = new System.Drawing.Size(36, 13);
            this.ataqueILabel.TabIndex = 9;
            this.ataqueILabel.Text = "DanoI";
            // 
            // jogaI
            // 
            this.jogaI.AutoSize = true;
            this.jogaI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.jogaI.Location = new System.Drawing.Point(558, 67);
            this.jogaI.Name = "jogaI";
            this.jogaI.Size = new System.Drawing.Size(47, 13);
            this.jogaI.TabIndex = 10;
            this.jogaI.Text = "Jogadas";
            // 
            // JogadasP
            // 
            this.JogadasP.AutoSize = true;
            this.JogadasP.BackColor = System.Drawing.Color.DarkGray;
            this.JogadasP.Location = new System.Drawing.Point(174, 41);
            this.JogadasP.Name = "JogadasP";
            this.JogadasP.Size = new System.Drawing.Size(68, 13);
            this.JogadasP.TabIndex = 12;
            this.JogadasP.Text = "JogadasDoP";
            // 
            // Defender
            // 
            this.Defender.Location = new System.Drawing.Point(97, 246);
            this.Defender.Name = "Defender";
            this.Defender.Size = new System.Drawing.Size(74, 46);
            this.Defender.TabIndex = 13;
            this.Defender.Text = "Defesa";
            this.Defender.UseVisualStyleBackColor = true;
            this.Defender.Click += new System.EventHandler(this.Defender_Click);
            // 
            // EnergiaLabel
            // 
            this.EnergiaLabel.AutoSize = true;
            this.EnergiaLabel.BackColor = System.Drawing.Color.Yellow;
            this.EnergiaLabel.Location = new System.Drawing.Point(45, 67);
            this.EnergiaLabel.Name = "EnergiaLabel";
            this.EnergiaLabel.Size = new System.Drawing.Size(43, 13);
            this.EnergiaLabel.TabIndex = 5;
            this.EnergiaLabel.Text = "Energia";
            // 
            // ataquePLabel
            // 
            this.ataquePLabel.AutoSize = true;
            this.ataquePLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ataquePLabel.Location = new System.Drawing.Point(45, 16);
            this.ataquePLabel.Name = "ataquePLabel";
            this.ataquePLabel.Size = new System.Drawing.Size(40, 13);
            this.ataquePLabel.TabIndex = 11;
            this.ataquePLabel.Text = "DanoP";
            // 
            // DefesaLabel
            // 
            this.DefesaLabel.AutoSize = true;
            this.DefesaLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.DefesaLabel.Location = new System.Drawing.Point(45, 42);
            this.DefesaLabel.Name = "DefesaLabel";
            this.DefesaLabel.Size = new System.Drawing.Size(41, 13);
            this.DefesaLabel.TabIndex = 14;
            this.DefesaLabel.Text = "Defesa";
            // 
            // AtivaçãoDLabel
            // 
            this.AtivaçãoDLabel.AutoSize = true;
            this.AtivaçãoDLabel.Location = new System.Drawing.Point(46, 100);
            this.AtivaçãoDLabel.Name = "AtivaçãoDLabel";
            this.AtivaçãoDLabel.Size = new System.Drawing.Size(65, 13);
            this.AtivaçãoDLabel.TabIndex = 15;
            this.AtivaçãoDLabel.Text = "DefesaAtiva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp19.Properties.Resources.Menu_Pergaminho;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp19.Properties.Resources.Menu_Pergaminho;
            this.pictureBox2.Location = new System.Drawing.Point(561, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // PoçãoV
            // 
            this.PoçãoV.Location = new System.Drawing.Point(177, 270);
            this.PoçãoV.Name = "PoçãoV";
            this.PoçãoV.Size = new System.Drawing.Size(70, 29);
            this.PoçãoV.TabIndex = 18;
            this.PoçãoV.Text = "PoçãoVida";
            this.PoçãoV.UseVisualStyleBackColor = true;
            this.PoçãoV.Click += new System.EventHandler(this.PoçãoV_Click);
            // 
            // PoçãoVidaLabel
            // 
            this.PoçãoVidaLabel.AutoSize = true;
            this.PoçãoVidaLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.PoçãoVidaLabel.Location = new System.Drawing.Point(46, 55);
            this.PoçãoVidaLabel.Name = "PoçãoVidaLabel";
            this.PoçãoVidaLabel.Size = new System.Drawing.Size(58, 13);
            this.PoçãoVidaLabel.TabIndex = 19;
            this.PoçãoVidaLabel.Text = "poçãoVida";
            // 
            // VidaPersonagemLabel
            // 
            this.VidaPersonagemLabel.AutoSize = true;
            this.VidaPersonagemLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.VidaPersonagemLabel.Location = new System.Drawing.Point(46, 29);
            this.VidaPersonagemLabel.Name = "VidaPersonagemLabel";
            this.VidaPersonagemLabel.Size = new System.Drawing.Size(28, 13);
            this.VidaPersonagemLabel.TabIndex = 20;
            this.VidaPersonagemLabel.Text = "Vida";
            // 
            // VidaInimigoLabel
            // 
            this.VidaInimigoLabel.AutoSize = true;
            this.VidaInimigoLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.VidaInimigoLabel.Location = new System.Drawing.Point(569, 112);
            this.VidaInimigoLabel.Name = "VidaInimigoLabel";
            this.VidaInimigoLabel.Size = new System.Drawing.Size(31, 13);
            this.VidaInimigoLabel.TabIndex = 21;
            this.VidaInimigoLabel.Text = "VidaI";
            // 
            // ItemMao
            // 
            this.ItemMao.AutoSize = true;
            this.ItemMao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ItemMao.Location = new System.Drawing.Point(48, 117);
            this.ItemMao.Name = "ItemMao";
            this.ItemMao.Size = new System.Drawing.Size(62, 13);
            this.ItemMao.TabIndex = 22;
            this.ItemMao.Text = "ItemDeMão";
            // 
            // coração1
            // 
            this.coração1.Image = global::WindowsFormsApp19.Properties.Resources.cocoração;
            this.coração1.Location = new System.Drawing.Point(113, 5);
            this.coração1.Name = "coração1";
            this.coração1.Size = new System.Drawing.Size(47, 39);
            this.coração1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coração1.TabIndex = 23;
            this.coração1.TabStop = false;
            // 
            // coração2
            // 
            this.coração2.Image = global::WindowsFormsApp19.Properties.Resources.coração2;
            this.coração2.Location = new System.Drawing.Point(113, 5);
            this.coração2.Name = "coração2";
            this.coração2.Size = new System.Drawing.Size(47, 39);
            this.coração2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coração2.TabIndex = 24;
            this.coração2.TabStop = false;
            // 
            // coração3
            // 
            this.coração3.Image = global::WindowsFormsApp19.Properties.Resources.coração3;
            this.coração3.Location = new System.Drawing.Point(113, 5);
            this.coração3.Name = "coração3";
            this.coração3.Size = new System.Drawing.Size(47, 39);
            this.coração3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coração3.TabIndex = 25;
            this.coração3.TabStop = false;
            // 
            // ataqueErroPLabel
            // 
            this.ataqueErroPLabel.AutoSize = true;
            this.ataqueErroPLabel.BackColor = System.Drawing.Color.Black;
            this.ataqueErroPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ataqueErroPLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataqueErroPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ataqueErroPLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ataqueErroPLabel.Location = new System.Drawing.Point(97, 191);
            this.ataqueErroPLabel.Name = "ataqueErroPLabel";
            this.ataqueErroPLabel.Size = new System.Drawing.Size(195, 27);
            this.ataqueErroPLabel.TabIndex = 26;
            this.ataqueErroPLabel.Text = "Jonas Errou o Ataque";
            this.ataqueErroPLabel.Visible = false;
            // 
            // erroDoP
            // 
            this.erroDoP.Interval = 1000;
            this.erroDoP.Tick += new System.EventHandler(this.erroDoP_Tick);
            // 
            // AtaqueCriticoLabel
            // 
            this.AtaqueCriticoLabel.AutoSize = true;
            this.AtaqueCriticoLabel.BackColor = System.Drawing.Color.Black;
            this.AtaqueCriticoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AtaqueCriticoLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtaqueCriticoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AtaqueCriticoLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AtaqueCriticoLabel.Location = new System.Drawing.Point(135, 191);
            this.AtaqueCriticoLabel.Name = "AtaqueCriticoLabel";
            this.AtaqueCriticoLabel.Size = new System.Drawing.Size(122, 27);
            this.AtaqueCriticoLabel.TabIndex = 27;
            this.AtaqueCriticoLabel.Text = "Jonas Critou";
            this.AtaqueCriticoLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::WindowsFormsApp19.Properties.Resources.coliseu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 335);
            this.Controls.Add(this.AtaqueCriticoLabel);
            this.Controls.Add(this.ataqueErroPLabel);
            this.Controls.Add(this.coração3);
            this.Controls.Add(this.coração2);
            this.Controls.Add(this.coração1);
            this.Controls.Add(this.ItemMao);
            this.Controls.Add(this.VidaInimigoLabel);
            this.Controls.Add(this.VidaPersonagemLabel);
            this.Controls.Add(this.PoçãoVidaLabel);
            this.Controls.Add(this.PoçãoV);
            this.Controls.Add(this.AtivaçãoDLabel);
            this.Controls.Add(this.DefesaLabel);
            this.Controls.Add(this.Defender);
            this.Controls.Add(this.JogadasP);
            this.Controls.Add(this.ataquePLabel);
            this.Controls.Add(this.jogaI);
            this.Controls.Add(this.ataqueILabel);
            this.Controls.Add(this.Recarga);
            this.Controls.Add(this.EnergiaLabel);
            this.Controls.Add(this.DanoB);
            this.Controls.Add(this.NomeI);
            this.Controls.Add(this.NomeP);
            this.Controls.Add(this.VidaPersonagemBar);
            this.Controls.Add(this.VidaInimigoBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "-------------Batalhas Batalhas-------------";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coração1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coração2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coração3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar VidaInimigoBar;
        private System.Windows.Forms.ProgressBar VidaPersonagemBar;
        private System.Windows.Forms.Label NomeP;
        private System.Windows.Forms.Label NomeI;
        private System.Windows.Forms.Button DanoB;
        private System.Windows.Forms.Timer Valores;
        private System.Windows.Forms.Timer Atacar;
        private System.Windows.Forms.Button Recarga;
        private System.Windows.Forms.Timer EscolherInimigo;
        private System.Windows.Forms.Timer VerificarVidaI;
        private System.Windows.Forms.Label ataqueILabel;
        private System.Windows.Forms.Label jogaI;
        private System.Windows.Forms.Label JogadasP;
        private System.Windows.Forms.Button Defender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EnergiaLabel;
        private System.Windows.Forms.Label ataquePLabel;
        private System.Windows.Forms.Label DefesaLabel;
        private System.Windows.Forms.Label AtivaçãoDLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PoçãoV;
        private System.Windows.Forms.Label PoçãoVidaLabel;
        private System.Windows.Forms.Label VidaPersonagemLabel;
        private System.Windows.Forms.Label VidaInimigoLabel;
        private System.Windows.Forms.Label ItemMao;
        private System.Windows.Forms.PictureBox coração1;
        private System.Windows.Forms.PictureBox coração2;
        private System.Windows.Forms.PictureBox coração3;
        private System.Windows.Forms.Label ataqueErroPLabel;
        private System.Windows.Forms.Timer erroDoP;
        private System.Windows.Forms.Label AtaqueCriticoLabel;
    }
}

