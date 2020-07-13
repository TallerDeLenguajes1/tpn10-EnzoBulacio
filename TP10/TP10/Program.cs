using System;
using System.Collections.Generic;
using System.IO;


namespace TP10
{
    class Program
    {
        public enum TipoDeOperacion
        {
            Venta,
            Alquiler
        };
        public enum TipoDePropiedad
        {
            Departamento,
            Casa,
            Duplex,
            Penthouse,
            Terreno
        };
        public class Propiedad
        {
            private int id;
            private TipoDeOperacion tipodeOperacion;
            private TipoDePropiedad tipodePropiedad;
            private float tamanio;
            private int cantidadBanios;
            private int cantidadHabitaciones;
            private string domicilio;
            private int precio;
            private bool estadoInmueble;


            public int ID
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
                }
            }

            public TipoDeOperacion Tipodeoperacion
            {
                get
                {
                    return tipodeOperacion;
                }

                set
                {
                    tipodeOperacion = value;
                }
            }

            public TipoDePropiedad Tipodepropiedad
            {
                get
                {
                    return tipodePropiedad;
                }

                set
                {
                    tipodePropiedad = value;
                }
            }

            public float Tamanio
            {
                get
                {
                    return tamanio;
                }

                set
                {
                    tamanio = value;
                }
            }

            public int CantidadBanios
            {
                get
                {
                    return cantidadBanios;
                }

                set
                {
                    cantidadBanios = value;
                }
            }

            public int CantidadHabitaciones
            {
                get
                {
                    return cantidadHabitaciones;
                }

                set
                {
                    cantidadHabitaciones = value;
                }
            }

            public string Domicilio
            {
                get
                {
                    return domicilio;
                }

                set
                {
                    domicilio = value;
                }
            }

            public int Precio
            {
                get
                {
                    return precio;
                }

                set
                {
                    precio = value;
                }
            }

            public bool EstadoInmueble
            {
                get
                {
                    return estadoInmueble;
                }

                set
                {
                    estadoInmueble = value;
                }
            }

        };
        static void Main(string[] args)
        {
           

        }
    }
}
