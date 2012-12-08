﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.UI
{
    public partial class ArmarCupon : Form
    {
        LoginWindow login;
        public ArmarCupon(LoginWindow login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (checkearTextBoxs() == false)
            {
                MessageBox.Show("Revise los campos ingresados");
                return;
            }

            Dominio.Cupon cupon = new GrouponDesktop.Dominio.Cupon();
            cupon.CantidadDisponible = Int32.Parse(TxtBox_CantidadDisponible.Text);
            cupon.CantidadMaximaPorUsuario = Int32.Parse(TxtBox_CantidadMaxima.Text);
            cupon.Descripcion = TxtBox_Descripcion.Text;
            cupon.PrecioFicticio =  Double.Parse(TxtBox_PrecioFicticio.Text);
            cupon.PrecioReal = Double.Parse(TxtBox_PrecioReal.Text);
            cupon.FechaFinalizacionOferta = TimePicker_Oferta.Value;
            cupon.FechaVencimiento = TimePicker_Vencimiento.Value;
            cupon.FechaPublicacion = TimePicker_Publicacion.Value;
            cupon.CuitProveedor = login.UsuarioActivo.DatosProveedor.Cuit;


            Dominio.DataAdapter.CuponArmado cuponArmado = new GrouponDesktop.Dominio.DataAdapter.CuponArmado(cupon);
            cuponArmado.guardar();
        }

        private bool checkearTextBoxs()
        {
            List<Control> controls = new List<Control>();
            List<Control> numericControls = new List<Control>();

            numericControls.Add(TxtBox_CantidadDisponible);
            numericControls.Add(TxtBox_CantidadMaxima);
            numericControls.Add(TxtBox_PrecioFicticio);
            numericControls.Add(TxtBox_PrecioReal);

            controls.Add(TxtBox_Descripcion);
            controls.AddRange(numericControls);

            if (Dominio.Utilidades.camposCompletos(controls) == false)
            {
                return false;
            }

            DateTime fechaActual = AdministradorConfiguracion.obtenerFecha();
            if (TimePicker_Oferta.Value < fechaActual)
                return false;
            if(TimePicker_Oferta.Value > TimePicker_Vencimiento.Value)
                return false;
            if (TimePicker_Publicacion.Value > TimePicker_Oferta.Value)
                return false;

            if (Dominio.Utilidades.areNumericControls(numericControls) == false)
                return false;
            return true;

        }
    }
}
