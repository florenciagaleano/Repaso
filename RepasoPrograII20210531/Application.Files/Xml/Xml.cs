using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using Application.Models;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Files.Xml
{
    public class Xml<T> : IFile<T>
    {
        //TODO implementar IFile
        public bool Read(string path, out List<Application.Models.Customer> customers)
        {
            List<Application.Models.Customer> lista = null;
            bool ret = false;
            try
            {
                using(XmlTextReader r = new XmlTextReader(path))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(List<Application.Models.Customer>));
                    lista = (List<Application.Models.Customer>)serializar.Deserialize(r);
                }
                ret = true;
            }catch(Exception e)
            {

            }

            customers = lista;
            return ret;
        }

        public bool Read(string file, out T data)
        {
            bool ret = false;
            data = default;
            try
            {
                using (XmlTextReader reader = new XmlTextReader(file))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    data = (T)ser.Deserialize(reader);
                }
                ret = true;

            }
            catch(Exception e)
            {

            }

            return ret;        
        }


        public bool Save(string file, T data)
        {
            throw new NotImplementedException();
        }
    }
}
