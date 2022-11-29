using System;
using System.IO;

namespace Archivos
{
    public class Archivo
    {
        private string path;

        #region Constructor
        public Archivo(string path)
        {
            this.path = path;
        }
        #endregion

        #region Guardado de archivos
        public bool GuardarArchivo(string texto)
        {
            return this.GuardarArchivo(texto, false);
        }

        public bool GuardarArchivo(string texto, bool append)
        {
            bool rtn = true;
            var sw = new StreamWriter(path, append);

            try
            {
                sw.Write(texto);
            }
            catch (Exception)
            {
                rtn = false;
            }
            finally
            {
                sw.Close();
                sw.Dispose();
            }

            return rtn;
        }

        #endregion

        #region Lectura de archivos
        public bool LeerArchivo(out string text)
        {
            bool rtn = true;

            text = "";
            
            try
            {
                using StreamReader sr = new StreamReader(path);
                text = sr.ReadToEnd();
            }
            catch (Exception)
            {
                rtn = false;
            }
            return rtn;
        }

        #endregion
    }
}
