using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Files.Text;

namespace Application.Files.Text
{
    public class Text<T> : IFile<T>
    {

        public bool Save(string file, T data)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter w = new StreamWriter(file))
                {
                    w.WriteLine(data.ToString());
                }
                retorno = true;
            }catch(Exception e)
            {
                throw new Exception("Ruta invalida");
            }

            return retorno;
        }

        public bool Read(string file, out T data)
        {
            //bool retorno = false;
            //try
            //{
            //    using(StreamReader reader = new StreamReader(file))
            //    {
            //       data = default;
            //    }
            //    retorno = true;
            //}catch(Exception e)
            //{

            //}

            data = default;
            return true;
        }
    }
}
