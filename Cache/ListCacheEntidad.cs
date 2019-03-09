using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Farmacity.Negocio.Entidades;
using Farmacity.Negocio.Servicio;
using Farmacity.Comunes;

namespace Farmacity.Negocio
{
    public class ListCacheEntidad<T> : List<T>
    {
        public Type TipoEntidad { get; set; }

        public Type TipoServicio { get; set; }

        public String Nombre { get; set; }

        public CondicionBase Condicion { get; set; }

        public List<T> Lista { get; set; }

        public ListCacheEntidad(String nombre, CondicionBase condicion, List<T> lista)
        {
            this.TipoEntidad = typeof(T);

            if (!String.IsNullOrEmpty(nombre))
                this.Nombre = nombre;
            else
                this.Nombre = this.TipoEntidad.Name;

            if (lista == null)
                this.TipoServicio = FuncionesVarias.ObtenerTipoServicio(this.TipoEntidad.Name + "Servicio");

            this.Condicion = condicion;
            this.Lista = lista;
        }

        public ListCacheEntidad(String nombre)
            : this(nombre, null, null)
        {
        }

        public ListCacheEntidad()
            : this(null)
        {
        }

        public void Cargar()
        {
            this.Clear();
            IList l = null;

            if (Lista == null)
            {
                if (TipoServicio != null)
                    l = EjecutarServicio.Listar(TipoServicio, Condicion);
            }
            else
                l = Lista;

            foreach (var i in l) { Add((T)i); }
        }

        public List<T> ObtenerLista()
        {
            return this.ToList();
        }
    }
}
