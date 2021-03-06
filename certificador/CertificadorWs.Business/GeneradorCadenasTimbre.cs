using System;
using System.Web;
using System.Xml;
using System.Xml.Xsl;
using System.IO;

namespace CertificadorWs.Business
{
    class GeneradorCadenasTimbre
    {
        private XmlTextReader xsltReader;
        private string xsl;
        private StringReader xsltInput;
        private XslCompiledTransform xsltTransform = new XslCompiledTransform();


        /// <summary>
        /// Generador de cadenas originales de timbre
        /// </summary>
        public GeneradorCadenasTimbre()
        {
            if (xsl == null)
            {
                var cwd = Environment.CurrentDirectory;
                try
                {
                    xsl = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Xsl33\cadenaoriginal_TFD_1_1.xslt");
                    Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory + @"Xsl33\";
                    xsltInput = new StringReader(xsl);
                    xsltReader = new XmlTextReader(xsltInput);
                    xsltTransform.Load(xsltReader);
                }
                catch (Exception exception)
                {
                    throw;
                }
                finally
                {
                    Environment.CurrentDirectory = cwd;
                }
            }
        }

        public string CadenaOriginal(string xml)
        {
            if (string.IsNullOrEmpty(xml))
            {
                throw new ArgumentException("Error", "xml");
            }
            StringReader xmlInput = new StringReader(xml);
            XmlTextReader xmlReader = new XmlTextReader(xmlInput);
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter transformedXml = new XmlTextWriter(stringWriter);
            try
            {
                xsltTransform.Transform(xmlReader, transformedXml);
            }
            catch (Exception ex)
            {
                throw;
            }
            return HttpUtility.HtmlDecode(stringWriter.ToString());
        }
    }
}
