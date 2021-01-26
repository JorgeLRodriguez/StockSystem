﻿using FontAwesome.Sharp;
using Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ABM;
using UI.Reportes;
using UI.Stock;

namespace UI
{
    public partial class MainMenufrm : Form
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        public MainMenufrm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            panelLeft.Controls.Add(leftBorderBtn);
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                panelStock.Visible = false;
                panelABM.Visible = false;
                panelReportes.Visible = false;
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStock);
            ActivateButton(sender, Color.FromArgb(5, 26, 14));
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            showSubMenu(panelABM);
            ActivateButton(sender, Color.FromArgb(5, 26, 14));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
            ActivateButton(sender, Color.FromArgb(5, 26, 14));
        }
        private void btnconfig_Click(object sender, EventArgs e)
        {
            Form recfrm = configfrm.getInstance();
            openChildFormInPanel(recfrm);
            ActivateButton(sender, Color.FromArgb(5, 26, 14));
        }
        private void openChildFormInPanel(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(8, 204, 41);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                labtitle.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(5, 26, 14);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumSpringGreen;
            //labtitle.Text = strings.Inicio;
        }
        private void homepic_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnrecepcion_Click(object sender, EventArgs e)
        {
            Form recfrm = Recepcionfrm.getInstance();
            openChildFormInPanel(recfrm);
        }
        private void btnscaneo_Click(object sender, EventArgs e)
        {
            Form scanfrm = Scaneofrm.getInstance();
            openChildFormInPanel(scanfrm);
        }

        private void btnpicking_Click(object sender, EventArgs e)
        {
            Form pickfrm = Pickingfrm.getInstance();
            openChildFormInPanel(pickfrm);
        }

        private void btntransf_Click(object sender, EventArgs e)
        {
            Form tranfrm = Transferenciafrm.getInstance();
            openChildFormInPanel(tranfrm);
        }

        private void btnajuste_Click(object sender, EventArgs e)
        {
            Form ajfrm = AjusteInvfrm.getInstance();
            openChildFormInPanel(ajfrm);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Form impfrm = Importarfrm.getInstance();
            openChildFormInPanel(impfrm);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Form artfrm = Articfrm.getInstance();
            openChildFormInPanel(artfrm);
        }

        private void btnPxE_Click(object sender, EventArgs e)
        {
            Form pxefrm = PxEfrm.getInstance();
            openChildFormInPanel(pxefrm);
        }

        private void btnLayout_Click(object sender, EventArgs e)
        {
            Form layfrm = Layoutfrm.getInstance();
            openChildFormInPanel(layfrm);
        }

        private void btnEtiq_Click(object sender, EventArgs e)
        {
            Form etiqfrm = Etiquetasfrm.getInstance();
            openChildFormInPanel(etiqfrm);
        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            Form depofrm = Depositofrm.getInstance();
            openChildFormInPanel(depofrm);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Form invfrm = Inventariofrm.getInstance();
            openChildFormInPanel(invfrm);
        }

        private void btnMovim_Click(object sender, EventArgs e)
        {
            Form movimfrm = Movimientosfrm.getInstance();
            openChildFormInPanel(movimfrm);
        }

        private void btnHxI_Click(object sender, EventArgs e)
        {
            Form hxifrm = HxEfrm.getInstance();
            openChildFormInPanel(hxifrm);
        }

        private void btnIxC_Click(object sender, EventArgs e)
        {
            Form ixcfrm = IxCfrm.getInstance();
            openChildFormInPanel(ixcfrm);
        }

        private void btnListStock_Click(object sender, EventArgs e)
        {
            Form liststfrm = ListadoStockfrm.getInstance();
            openChildFormInPanel(liststfrm);
        }

        private void MainMenufrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenufrm_Load(object sender, EventArgs e)
        {
            //labtitle.Text = strings.Inicio;
            //btnrecepcion.Text = strings.Recepcion;
            //btnscaneo.Text = strings.Scaneo;
            //btnpicking.Text = strings.Picking;
            //btntransf.Text = strings.Transferencia;
            //btnajuste.Text = strings.Ajuste;
            //btnImportar.Text = strings.Importar;
            //btnABM.Text = strings.Administrar;
            //btnArticulos.Text = strings.Articulos;
            //btnPxE.Text = strings.PxE;
            //btnLayout.Text = strings.Layout;
            //btnEtiq.Text = strings.Etiq;
            //btnReportes.Text = strings.Reportes;
            //btndeposito.Text = strings.Deposito;
            //btnInventario.Text = strings.Inventario;
            //btnMovim.Text = strings.Movimientos;
            //btnHxI.Text = strings.HxI;
            //btnIxC.Text = strings.IxC;
            //btnListStock.Text = strings.List_Stock;
            //btnconfig.Text = strings.Config;
        }
    }
}
