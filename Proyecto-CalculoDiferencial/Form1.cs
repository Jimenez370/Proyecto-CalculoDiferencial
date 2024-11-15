using System.Drawing;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Proyecto_CalculoDiferencial.forms;

namespace Proyecto_CalculoDiferencial
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form frm2;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelmenu.Controls.Add(leftBorderBtn);
            paneltitulo.MouseDown += new MouseEventHandler(panelTitleBar_MouseDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(224, 247, 250);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                icpbinicio.IconChar = currentBtn.IconChar;
                icpbinicio.IconColor = color;

                lbtitulo.Text = currentBtn.Text;
                lbtitulo.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 118, 210);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormularioHijo(Form childForm)
        {
            if (frm2 != null)
            {
                frm2.Close();
            }
            frm2 = childForm;
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            panelescritorio.Controls.Add(frm2);
            panelescritorio.Tag = frm2;
            frm2.BringToFront();
            frm2.Show();
        }

        private void icbimpson_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormularioHijo(new frmsimpson());
        }

        private void icbtrapecio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormularioHijo(new frmtrapecio());
        }

        private void icbnuméricas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormularioHijo(new frmnumericas());
        }

        private void icbdivididas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormularioHijo(new frmdivididas());
        }

        private void icbraices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormularioHijo(new frmraices());
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pcbinicio_Click(object sender, EventArgs e)
        {
            frm2?.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            icpbinicio.IconChar = IconChar.Home;
            icpbinicio.IconColor = Color.White;
            lbtitulo.Text = "Inicio";
            lbtitulo.ForeColor = Color.White;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, (IntPtr)0xf012, IntPtr.Zero);
        }

        private void lbtitulo_Click(object sender, EventArgs e)
        {
        }

        private void lbtitulo_Click_1(object sender, EventArgs e)
        {
        }

        private void panelescritorio_Paint(object sender, PaintEventArgs e)
        {
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
    }
}

