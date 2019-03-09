using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Farmacity.Negocio.Entidades;
using Farmacity.Negocio.Servicio;
using Farmacity.Comunes;

namespace Farmacity.Negocio
{
    public static class CacheEntidades<T> 
    {
        private static CacheItemDictionary<String, ListCacheEntidad<T>> _data = new CacheItemDictionary<String, ListCacheEntidad<T>>();

        private static bool AddCache(ListCacheEntidad<T> cache)
        {
            if (!_data.ContainsKey(cache.Nombre))
            {
                _data.Add(cache.Nombre, cache);
                return true;
            }
            return false;
        }

        private static ListCacheEntidad<T> GetCache(string nombre)
        {
            if (!_data.ContainsKey(nombre))
                return null;
            else
                return _data[nombre];
        }

        private static ListCacheEntidad<T> GetCache()
        {
            return GetCache(typeof(T).Name);
        }

        public static bool ExisteCache(string nombre)
        {
            return _data.ContainsKey(nombre);
        }

        public static bool ExisteCache()
        {
            return _data.ContainsKey(typeof(T).Name);
        }

        public static bool BorrarCache(string nombre)
        {
            return _data.Remove(nombre);
        }

        public static bool BorrarCache()
        {
            return _data.Remove(typeof(T).Name);
        }

        public static ListCacheEntidad<T> ObtenerCache(string nombre, CondicionBase cond, List<T> lista)
        {
            // Si no se especifca nombre se toma el de la clase T.
            if (String.IsNullOrEmpty(nombre)) nombre = typeof(T).Name;

            ListCacheEntidad<T> r = CacheEntidades<T>.GetCache(nombre);
            if (r == null)
            {
                ListCacheEntidad<T> l = new ListCacheEntidad<T>(nombre, cond, lista);
                l.Cargar();
                CacheEntidades<T>.AddCache(l);
                r = l;
            }
            return r;
        }

        public static ListCacheEntidad<T> ObtenerCache(string nombre, CondicionBase cond)
        {
            return ObtenerCache(nombre, cond, null);
        }

        public static ListCacheEntidad<T> ObtenerCache(string nombre)
        {
            return ObtenerCache(nombre, null, null);
        }

        public static ListCacheEntidad<T> ObtenerCache(CondicionBase cond)
        {
            return ObtenerCache(null, cond, null);
        }

        public static ListCacheEntidad<T> ObtenerCache()
        {
            return ObtenerCache(String.Empty);
        }
    }
}
