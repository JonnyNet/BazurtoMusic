using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos
    {
        public static IEnumerable<Usuario> getUsuario()
        {
            List<Usuario> usuario = new List<Usuario>();
            Usuario user = new Usuario("User", "user", "02-10-2003", "Standar", "usuario@miweb.com", 1047567345);
            usuario.Add(user);
            return usuario;
        }

        public IEnumerable<Cancion> getCancion()
        {
            List<Cancion> canciones = new List<Cancion>();

            Cancion cancion0 = new Cancion(3.45, "Champeta", "Niche", 6000, 4, "Chammpeta uno", 34, "Juan Piña", "");
            canciones.Add(cancion0);
            Cancion cancion1 = new Cancion(4.45, "Vallenato", "Niche", 7000, 4, "Parranda", 34, "Juan Piña", "");
            canciones.Add(cancion1);
            Cancion cancion2 = new Cancion(3.55, "Champeta", "Niche", 6500, 4, "El Celulaar", 34, "Juan Piña", "");
            canciones.Add(cancion2);
            Cancion cancion3 = new Cancion(4.20, "Salsa", "Niche", 6030, 4, "Salsa Buema", 34, "Juan Piña", "");
            canciones.Add(cancion3);
            Cancion cancion4 = new Cancion(3.35, "Reggeton", "Niche", 8000, 4, "Lalala", 34, "Juan Piña", "");
            canciones.Add(cancion4);
            Cancion cancion5 = new Cancion(3.42, "Merengue", "Niche", 5000, 4, "El perro", 34, "Juan Piña", "");
            canciones.Add(cancion5);
            Cancion cancion6 = new Cancion(4.45, "Salsa", "Niche", 7000, 4, "Dos", 34, "Juan Piña", "");
            canciones.Add(cancion6);
            Cancion cancion7 = new Cancion(3.15, "Valada", "Niche", 6300, 4, "Noviembre", 34, "Juan Piña", "");
            canciones.Add(cancion7);
            Cancion cancion8 = new Cancion(5.25, "Champeta", "Niche", 6100, 4, "La cantua", 34, "Juan Piña", "");
            canciones.Add(cancion8);
            Cancion cancion9 = new Cancion(3.57, "Salsa", "Niche", 8700, 4, "Hijo", 34, "Juan Piña", "");
            canciones.Add(cancion9);
            Cancion cancion10 = new Cancion(3.31, "Bachata", "Niche", 5600, 4, "Donde", 34, "Juan Piña", "");
            canciones.Add(cancion10);
            Cancion cancion11 = new Cancion(4.13, "Vallenato", "Niche", 7200, 4, "Un amor", 34, "Juan Piña", "");
            canciones.Add(cancion11);
            Cancion cancion12 = new Cancion(3.45, "Champeta", "Niche", 8400, 4, "La chapa", 34, "Juan Piña", "");
            canciones.Add(cancion12);
            Cancion cancion13 = new Cancion(4.31, "Salsa", "Niche", 9600, 4, "Con Ella", 34, "Juan Piña", "");
            canciones.Add(cancion13);
            Cancion cancion14 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "La goma", 34, "Juan Piña", "");
            canciones.Add(cancion14);
            Cancion cancion15 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Un verano", 34, "Juan Piña", "");
            canciones.Add(cancion15);
            Cancion cancion16 = new Cancion(4.24, "Champeta", "Niche", 6700, 4, "El Propio", 34, "Juan Piña", "");
            canciones.Add(cancion16);
            Cancion cancion17 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "Mujereando", 34, "Juan Piña", "");
            canciones.Add(cancion17);
            Cancion cancion18 = new Cancion(4.24, "Merengue", "Niche", 6700, 4, "La Tumbadora", 34, "Juan Piña", "");
            canciones.Add(cancion18);
            Cancion cancion19 = new Cancion(4.24, "Champeta", "Niche", 6700, 4, "El serrucho", 34, "Juan Piña", "");
            canciones.Add(cancion19);
            Cancion cancion20 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Mentiras", 34, "Juan Piña", "");
            canciones.Add(cancion20);
            Cancion cancion21 = new Cancion(4.24, "Bachata", "Niche", 6700, 4, "Aqui", 34, "Juan Piña", "");
            canciones.Add(cancion21);
            Cancion cancion22 = new Cancion(4.24, "Merengue", "Niche", 6700, 4, "El Mono", 34, "Juan Piña", "");
            canciones.Add(cancion22);
            Cancion cancion23 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "El Comelon", 34, "Juan Piña", "");
            canciones.Add(cancion23);
            Cancion cancion24 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Mujeres", 34, "Juan Piña", "");
            canciones.Add(cancion24);
            Cancion cancion25 = new Cancion(4.24, "Bachata", "Niche", 6700, 4, "Bonita", 34, "Juan Piña", "");
            canciones.Add(cancion25);
            Cancion cancion26 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Mariana", 34, "Juan Piña", "");
            canciones.Add(cancion26);
            Cancion cancion27 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "Otra Mujer", 34, "Juan Piña", "");
            canciones.Add(cancion27);
            Cancion cancion28 = new Cancion(4.24, "Champeta", "Niche", 6700, 4, "Muha", 34, "Juan Piña", "");
            canciones.Add(cancion28);
            Cancion cancion29 = new Cancion(4.24, "Reggeton", "Niche", 6700, 4, "El Son ", 34, "Juan Piña", "");
            canciones.Add(cancion29);
            Cancion cancion30 = new Cancion(4.24, "Bachata", "Niche", 6700, 4, "Mami", 34, "Juan Piña", "");
            canciones.Add(cancion30);

            return canciones;
        }


        public IEnumerable<Disco> getDiscos()
        {
            List<Disco> discos = new List<Disco>();

            Disco c1 = new Disco("Crossover", "Los Mejores");
            Cancion cancion0 = new Cancion(3.45, "Champeta", "Niche", 6000, 4, "Chammpeta uno", 34, "Juan Piña", "");
            c1.AgregarCancion(cancion0);
            Cancion cancion1 = new Cancion(4.45, "Vallenato", "Niche", 7000, 4, "Parranda", 34, "Juan Piña", "");
            c1.AgregarCancion(cancion1);
            Cancion cancion2 = new Cancion(3.55, "Champeta", "Niche", 6500, 4, "El Celulaar", 34, "Juan Piña", "");
            c1.AgregarCancion(cancion2);
            Cancion cancion3 = new Cancion(4.20, "Salsa", "Niche", 6030, 4, "Salsa Buema", 34, "Juan Piña", "");
            c1.AgregarCancion(cancion3);
            Cancion cancion4 = new Cancion(3.35, "Reggeton", "Niche", 8000, 4, "Lalala", 34, "Juan Piña", "");
            discos.Add(c1);

            Disco c2 = new Disco("Crossover", "Musica para hoy");
            Cancion cancion6 = new Cancion(4.45, "Salsa", "Niche", 7000, 4, "Dos", 34, "Juan Piña", "");
            c2.AgregarCancion(cancion6);
            Cancion cancion7 = new Cancion(3.15, "Valada", "Niche", 6300, 4, "Noviembre", 34, "Juan Piña", "");
            c2.AgregarCancion(cancion7);
            Cancion cancion8 = new Cancion(5.25, "Champeta", "Niche", 6100, 4, "La cantua", 34, "Juan Piña", "");
            c2.AgregarCancion(cancion8);
            Cancion cancion9 = new Cancion(3.57, "Salsa", "Niche", 8700, 4, "Hijo", 34, "Juan Piña", "");
            c2.AgregarCancion(cancion9);
            Cancion cancion10 = new Cancion(3.31, "Bachata", "Niche", 5600, 4, "Donde", 34, "Juan Piña", "");
            c2.AgregarCancion(cancion10);
            discos.Add(c2);

            Disco c3 = new Disco("Crossover", "Musica del Año");
            Cancion cancion11 = new Cancion(4.13, "Vallenato", "Niche", 7200, 4, "Un amor", 34, "Juan Piña", "");
            c3.AgregarCancion(cancion11);
            Cancion cancion12 = new Cancion(3.45, "Champeta", "Niche", 8400, 4, "La chapa", 34, "Juan Piña", "");
            c3.AgregarCancion(cancion12);
            Cancion cancion13 = new Cancion(4.31, "Salsa", "Niche", 9600, 4, "Con Ella", 34, "Juan Piña", "");
            c3.AgregarCancion(cancion13);
            Cancion cancion14 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "La goma", 34, "Juan Piña", "");
            c3.AgregarCancion(cancion14);
            Cancion cancion15 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Un verano", 34, "Juan Piña", "");
            c3.AgregarCancion(cancion15);
            discos.Add(c3);

            Disco c4 = new Disco("Crossover", "Variadistos");
            Cancion cancion16 = new Cancion(4.24, "Champeta", "Niche", 6700, 4, "El Propio", 34, "Juan Piña", "");
            c4.AgregarCancion(cancion16);
            Cancion cancion17 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "Mujereando", 34, "Juan Piña", "");
            c4.AgregarCancion(cancion17);
            Cancion cancion18 = new Cancion(4.24, "Merengue", "Niche", 6700, 4, "La Tumbadora", 34, "Juan Piña", "");
            c4.AgregarCancion(cancion18);
            Cancion cancion19 = new Cancion(4.24, "Champeta", "Niche", 6700, 4, "El serrucho", 34, "Juan Piña", "");
            c4.AgregarCancion(cancion19);
            Cancion cancion20 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Mentiras", 34, "Juan Piña", "");
            c4.AgregarCancion(cancion20);
            discos.Add(c4);

            Disco c5 = new Disco("Crossover", "Lo mas pegado");
            Cancion cancion21 = new Cancion(4.24, "Bachata", "Niche", 6700, 4, "Aqui", 34, "Juan Piña", "");
            c5.AgregarCancion(cancion21);
            Cancion cancion22 = new Cancion(4.24, "Merengue", "Niche", 6700, 4, "El Mono", 34, "Juan Piña", "");
            c5.AgregarCancion(cancion22);
            Cancion cancion23 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "El Comelon", 34, "Juan Piña", "");
            c5.AgregarCancion(cancion23);
            Cancion cancion24 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Mujeres", 34, "Juan Piña", "");
            c5.AgregarCancion(cancion24);
            Cancion cancion25 = new Cancion(4.24, "Bachata", "Niche", 6700, 4, "Bonita", 34, "Juan Piña", "");
            c5.AgregarCancion(cancion25);
            discos.Add(c5);

            Disco c6 = new Disco("Crossover", "Lo del momento");
            Cancion cancion26 = new Cancion(4.24, "Salsa", "Niche", 6700, 4, "Mariana", 34, "Juan Piña", "");
            c6.AgregarCancion(cancion26);
            Cancion cancion27 = new Cancion(4.24, "Vallenato", "Niche", 6700, 4, "Otra Mujer", 34, "Juan Piña", "");
            c6.AgregarCancion(cancion27);
            Cancion cancion28 = new Cancion(4.24, "Champeta", "Niche", 6700, 4, "Muha", 34, "Juan Piña", "");
            c6.AgregarCancion(cancion28);
            Cancion cancion29 = new Cancion(4.24, "Reggeton", "Niche", 6700, 4, "El Son ", 34, "Juan Piña", "");
            c6.AgregarCancion(cancion29);
            Cancion cancion30 = new Cancion(4.24, "Bachata", "Niche", 6700, 4, "Mami", 34, "Juan Piña", "");
            c6.AgregarCancion(cancion30);
            discos.Add(c6);

            return discos;
        }
    }
}
