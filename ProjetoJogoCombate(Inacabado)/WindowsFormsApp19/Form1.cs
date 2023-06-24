using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random EscolhaM = new Random(); // escolha do monstro que ira para a luta

        Random percentA = new Random(); // chance de ataque do personagem
        int percentAtaqueP = 90;//chance de acerto do ataque
        int percentCriticoP = 15;//chance de critico do personagem
        int intervaloErro = 0; //quanto tempo a msg de erro fica na tela(erro de ataque ou sei lá o que eu quiser colocar)

        //os dois de baixo indicam se o cara errou ou deu critico lá no tick do erro
        bool ErroPBoll = false;
        bool CriticoPBoll = false;

        //fazer outro form que vai falar quanto de energia vc ta usando nos botões, sua chance de acerto e de critico


        int sonoE = 25; //energia ganha dormindo
        int sonoV = 5; //vida ganha dormindo
        int energiaP = 100; //energia total do personagem

        string itemAtaque = "Mão"; //item que o personagem tem em mãos
        int vidaP = 100; //vida do personagem
        //não tem variavel de vida total pq posso melhorar no Mximum Da barra de vida
        int danoPer = 10; //dano do personagem
        int defesaPer = 5; //defesa do personagem
        bool defender = false; //se a defesa ta ativa
        int perdaEnergiaD = 10; //quando perde energia por defesa
        double cargaPerTotal = 100; //quantidade total de energia
        double cargaPer = 100; //energia do personagem
        int perdaEnergiaA = 10; //quanto ele perde de energia por ataque
        public int poçãoVida = 3; //poção que vai recuperar a vida 
        int maximoPoçãoV = 3; //maximo de poções que pode carregar
        int jogadas = 0; //numero de jogadas (saber quando o monstro vai atacar)




        int jogadasI = 0; // numero de jogadas para o inimigo atacar
        int danoI = 0; //dano do inimigo
        bool MorteI = false; //ve se o inimigo ta morto

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //botão de ataque, da dano e perde energia
        {
            defender = false;

            int chance = percentA.Next(1,101);  //verifica se acertou o ataque
            if (chance <= percentAtaqueP)
            {
                int Verificar = VidaInimigoBar.Value;

                int chance2 = percentA.Next(1, 101);  //verifica se deu crítico
                if (chance2 <= percentCriticoP)
                {
                    Verificar -= danoPer * 2;
                    CriticoPBoll = true;
                    erroDoP.Enabled = true;
                }
                else
                {
                    Verificar -= danoPer;
                }

                if (Verificar >= 0)
                    VidaInimigoBar.Value = Verificar;
                else
                    VidaInimigoBar.Value = 0;

            }
            else
            {
                ErroPBoll = true;
                erroDoP.Enabled = true; //chama a mensagem que errou o ataque
            }

                cargaPer -= perdaEnergiaA;
            

            jogadas++;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Valores_Tick(object sender, EventArgs e) //mostra as informações na tela (vida e essas paradas)
        {
            //Personagem
            EnergiaLabel.Text = "Energia: "+Convert.ToString(cargaPer);
            ItemMao.Text = itemAtaque;
            VidaPersonagemLabel.Text = "Vida: "+Convert.ToString(VidaPersonagemBar.Value);
            ataquePLabel.Text = "Dano: " + Convert.ToString(danoPer);
            JogadasP.Text = "Jogada: " + Convert.ToString(jogadas);
            DefesaLabel.Text = "escudo: " + Convert.ToString(defesaPer);
            PoçãoVidaLabel.Text = "Poções: " + Convert.ToString(poçãoVida);
            if (defender)
            {
                AtivaçãoDLabel.Text = "Defesa ativada";
                AtivaçãoDLabel.BackColor = Color.Green;
            }
            else
            {
                AtivaçãoDLabel.Text = "Defesa desativada";
                AtivaçãoDLabel.BackColor = Color.Red;
            }

            if (cargaPer >= cargaPerTotal * 0.6)      //Cor de carga do personagem
                EnergiaLabel.BackColor = Color.Green;
            if (cargaPer <= cargaPerTotal * 0.3)
                EnergiaLabel.BackColor = Color.Red;
            if (cargaPer > cargaPerTotal*0.3 && cargaPer <= cargaPerTotal*0.6)
                EnergiaLabel.BackColor = Color.Yellow;

            if (VidaPersonagemBar.Value > VidaPersonagemBar.Maximum * 0.6)   //Estado do coração 
            {
                coração1.Visible = true;
                coração2.Visible = false;
                coração3.Visible = false;
                VidaPersonagemLabel.BackColor = Color.Green;
            }
            if (VidaPersonagemBar.Value <= VidaPersonagemBar.Maximum * 0.3)
            {
                coração1.Visible = false;
                coração2.Visible = false;
                coração3.Visible = true;
                VidaPersonagemLabel.BackColor = Color.White;
            }
            if (VidaPersonagemBar.Value > VidaPersonagemBar.Maximum * 0.3 && VidaPersonagemBar.Value <= VidaPersonagemBar.Maximum * 0.6)
            {
                coração1.Visible = false;
                coração2.Visible = true;
                coração3.Visible = false;
                VidaPersonagemLabel.BackColor = Color.LightGreen;
            }

            if (poçãoVida >= 3) //cor da quantidade de poções
                PoçãoVidaLabel.BackColor = Color.Green;
            if (poçãoVida == 0)
                PoçãoVidaLabel.BackColor = Color.Red;
            if (poçãoVida == 2 || poçãoVida == 1)
                PoçãoVidaLabel.BackColor = Color.Yellow;










            //Montro
            VidaInimigoLabel.Text = "Vida: "+Convert.ToString(VidaInimigoBar.Value);
            ataqueILabel.Text = "Dano: " + Convert.ToString(danoI);
            jogaI.Text = "jogadas para o Inimigo atacar: " + Convert.ToString(jogadasI);

            if (VidaInimigoBar.Value >= VidaInimigoBar.Maximum * 0.6)
                VidaInimigoLabel.BackColor = Color.Green;
            if (VidaInimigoBar.Value <= VidaInimigoBar.Maximum * 0.3)
                VidaInimigoLabel.BackColor = Color.Red;
            if (VidaInimigoBar.Value > VidaInimigoBar.Maximum * 0.3 && VidaInimigoBar.Value <= VidaInimigoBar.Maximum * 0.6)
                VidaInimigoLabel.BackColor = Color.Yellow;


        }

        private void Atacar_Tick(object sender, EventArgs e) // verifica se pode usar os botões de acordo com as regras deles
        {
            if (cargaPer < perdaEnergiaA)
                DanoB.Enabled = false;
            else
                DanoB.Enabled = true;


            if (cargaPer < perdaEnergiaD)
                Defender.Enabled = false;
            else
                Defender.Enabled = true;

            if (poçãoVida == 0)
                PoçãoV.Enabled = false;
            else
                PoçãoV.Enabled = true;

        }

        private void Recarga_Click(object sender, EventArgs e) // recarrega energia e um pouco de vida
        {
            defender = false;
            //energia
            cargaPer += sonoE;
            if (cargaPer > energiaP)
                cargaPer = energiaP;

            jogadas++;



            //vida
            double verificar = VidaPersonagemBar.Value;
            verificar += sonoV;
            if (verificar >= VidaPersonagemBar.Maximum)
            {
                VidaPersonagemBar.Value = vidaP;
            }

            if (verificar < VidaPersonagemBar.Maximum)
            {
                
                VidaPersonagemBar.Value += sonoV;
            }
            

        }

        private void EscolherMonstro_Tick(object sender, EventArgs e) // escolhe qual será o proximo inimigo e fala sua recompensa
        {
            if (MorteI)
            {
                MorteI = false;

                poçãoVida += ClassJojo.Pocao();//quantidade ganha de poções de vida
                if (poçãoVida > maximoPoçãoV)
                { poçãoVida = maximoPoçãoV; }
            }


            int es = EscolhaM.Next(1, 3); //montros que serão escolhidos pelo 'dado'

            if (es == 1)
            {
                NomeI.Text = "Gladiador Armadurado";
                VidaInimigoBar.Maximum = 85;
                VidaInimigoBar.Value = VidaInimigoBar.Maximum;
                jogadasI = 2;
                danoI = 15;
            }

            else if (es == 2)
            {
                NomeI.Text = "Gladiador Da Espada";
                VidaInimigoBar.Maximum = 60;
                VidaInimigoBar.Value = VidaInimigoBar.Maximum;
                jogadasI = 2;
                danoI = 25;
            }
        }

        private void VerificarVidaM_Tick(object sender, EventArgs e) // verifica se alguém morreu ou se o inimigo já pode atacar
        {
            if (VidaInimigoBar.Value <= 0) //quando o inimigo morre
            {
                MorteI = true;
                EscolherMonstro_Tick(sender, e);
            }
 

            if (jogadas == jogadasI) //jogada do inimigo, se tá com escudo ou nâo
            {
                jogadas = 0;

                if (defender)
                {
                    int danoV = danoI - defesaPer;

                    if (danoV < 0)
                    { danoV = 0; }

                    VidaPersonagemBar.Value = VidaPersonagemBar.Value - danoV;
                }

                else
                {
                    VidaPersonagemBar.Value -= danoI;
                }
            }

            if (VidaPersonagemBar.Value <= 0) // quando o personagem morre
            {
                Application.OpenForms[1].Close();  //fecha o programa(o forms 1)
            }
        }

        private void Defender_Click(object sender, EventArgs e) //botão para defender
        {
            defender = true;
            cargaPer -= perdaEnergiaD;
            jogadas++;
        }

        private void DanoB_MouseCaptureChanged(object sender, EventArgs e)
        {}

        private void DanoB_DragEnter(object sender, DragEventArgs e)
        {}

        private void DanoB_MouseEnter(object sender, EventArgs e)
        {}

        private void PoçãoV_Click(object sender, EventArgs e) //botão de poção
        {
            poçãoVida--;

            double verificar = VidaPersonagemBar.Value;
            verificar += 20;
            if (verificar >= vidaP)
            {
                VidaPersonagemBar.Value = VidaPersonagemBar.Maximum;
            }

            if (verificar < VidaPersonagemBar.Maximum)
            {

                VidaPersonagemBar.Value += 20;
            }
        }

        private void erroDoP_Tick(object sender, EventArgs e) //Quando o jogador erra o ataque uma mensagem é mostrada na tela
        {
            if (ErroPBoll)//erro do ataque do personagem
            {
                ataqueErroPLabel.Visible = true;
                intervaloErro++;
                if (intervaloErro == 2)
                {
                    intervaloErro = 0;
                    ataqueErroPLabel.Visible = false;
                    ErroPBoll = false;
                    erroDoP.Enabled = false;

                }
            }

            if (CriticoPBoll)//critico do ataque do personagem
            {
                AtaqueCriticoLabel.Visible = true;
                intervaloErro++;
                if (intervaloErro == 2)
                {
                    intervaloErro = 0;
                    AtaqueCriticoLabel.Visible = false;
                    ErroPBoll = false;
                    erroDoP.Enabled = false;

                }
            }

        }
    }
}
