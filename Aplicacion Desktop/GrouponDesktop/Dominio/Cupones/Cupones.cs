using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Dominio
{
    public class Cupones
    {
        List<Cupon> cuponesList;
        public List<Cupon> CuponesList
        {
            get {return cuponesList; }
            set { cuponesList = value; }
        }
        public Cupones()
        {
            //Indexa con todos los Descuentos de la DB
            cuponesList = new List<Cupon>();
            Cupon cupon = new Cupon();
            cupon.PrecioActual = "10";
            cupon.TituloCupon = "Descuentos en matracas";
            cuponesList.Add(cupon);
             cupon = new Cupon();

            cupon.PrecioActual = "5";
            cupon.TituloCupon = "Beneficios en chicas";
            cuponesList.Add(cupon);
             cupon = new Cupon();

            cupon.PrecioActual = "25";
            cupon.TituloCupon = "Gratis a la cancha con matracas";
            cuponesList.Add(cupon);
             cupon = new Cupon();

            cupon.PrecioActual = "35";
            cupon.TituloCupon = "Descuentos en Lolas";
            cuponesList.Add(cupon);

        }

        public List<Cupon> obtenerCuponesEnFecha(DateTime desde, DateTime hasta)
        {
            return CuponesList;
            return new List<Cupon>();
        }

    }

    public class Cupon
    {
        String tituloCupon;
        public String TituloCupon
        {
            get { return tituloCupon; }
            set { tituloCupon = value; }
        }

        String precioActual;
        public String PrecioActual
        {
            get { return precioActual; }
            set { precioActual = value; }
        }
    }
}
