﻿using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.ABM;
using UI.Reportes;
using UI.Stock;

namespace UI
{
    public partial class MainMenufrm : Form, ISubscriptorCambioIdioma
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        public MainMenufrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            leftBorderBtn = new Panel{Size = new Size(7, 60)};
            panelLeft.Controls.Add(leftBorderBtn);
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
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
            Form recfrm = configfrm.getInstance(_serviciosAplicacion);
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
        }
        private void homepic_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnrecepcion_Click(object sender, EventArgs e)
        {
            Form recfrm = Recepcionfrm.GetInstance(_serviciosAplicacion);
            openChildFormInPanel(recfrm);
        }
        private void btnscaneo_Click(object sender, EventArgs e)
        {
            Form scanfrm = Scaneofrm.GetInstance(_serviciosAplicacion);
            openChildFormInPanel(scanfrm);
        }
        private void btnpicking_Click(object sender, EventArgs e)
        {
            Form pickfrm = Pickingfrm.GetInstance(_serviciosAplicacion);
            openChildFormInPanel(pickfrm);
        }
        private void btntransf_Click(object sender, EventArgs e)
        {
            Form tranfrm = Transferenciafrm.GetInstance(_serviciosAplicacion);
            openChildFormInPanel(tranfrm);
        }
        private void btnajuste_Click(object sender, EventArgs e)
        {
            Form ajfrm = AjusteInvfrm.GetInstance(_serviciosAplicacion);
            openChildFormInPanel(ajfrm);
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            Form impfrm = Importarfrm.GetInstance(_serviciosAplicacion);
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
            _serviciosAplicacion.Usuario.FinalizarSesion();
            Application.Exit();
        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            labtitle.Text = _traductorUsuario.Traducir(ConstantesTexto.Inicio);
            btnrecepcion.Text = _traductorUsuario.Traducir(ConstantesTexto.Recepcion);
            btnscaneo.Text = _traductorUsuario.Traducir(ConstantesTexto.Scaneo);
            btnpicking.Text = _traductorUsuario.Traducir(ConstantesTexto.Picking);
            btntransf.Text = _traductorUsuario.Traducir(ConstantesTexto.Transferencia);
            btnajuste.Text = _traductorUsuario.Traducir(ConstantesTexto.Ajuste);
            btnImportar.Text = _traductorUsuario.Traducir(ConstantesTexto.Importar);
            btnABM.Text = _traductorUsuario.Traducir(ConstantesTexto.Administrar);
            btnArticulos.Text = _traductorUsuario.Traducir(ConstantesTexto.Articulos);
            btnPxE.Text = _traductorUsuario.Traducir(ConstantesTexto.PxE);
            btnLayout.Text = _traductorUsuario.Traducir(ConstantesTexto.Layout);
            btnEtiq.Text = _traductorUsuario.Traducir(ConstantesTexto.Etiq);
            btnReportes.Text = _traductorUsuario.Traducir(ConstantesTexto.Reportes);
            btndeposito.Text = _traductorUsuario.Traducir(ConstantesTexto.Deposito);
            btnInventario.Text = _traductorUsuario.Traducir(ConstantesTexto.Inventario);
            btnMovim.Text = _traductorUsuario.Traducir(ConstantesTexto.Movimientos);
            btnHxI.Text = _traductorUsuario.Traducir(ConstantesTexto.HxI);
            btnIxC.Text = _traductorUsuario.Traducir(ConstantesTexto.IxC);
            btnListStock.Text = _traductorUsuario.Traducir(ConstantesTexto.ListStock);
            btnconfig.Text = _traductorUsuario.Traducir(ConstantesTexto.Config);
            this.Text = _traductorUsuario.Traducir(ConstantesTexto.Stock);
        }
    }
}