using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using G06.Minesweeper.Common.Models;

namespace G06.Minesweeper.Common.ServerEndPoint
{
    public class Server
    {
        private class ServerEndPoint
        {
            public static string BaseUrl => "https://prateleira.utad.priv:1234/LPDSW/2019-2020";
            public static string PostRegisto => "/registo";
            public static string PostLogin => "/autentica";
            public static string GetNovoJogo => "/novo";
            public static string PostRegistoResultado => "/resultado";
            public static string GetPerfil => "/perfil";
            public static string GetTop10 => "/top10";
        }

        public string Registo(string username, string password, string mail, string nomeabv, string pais)
        {
            string ID = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            XDocument xmlPedido = null;
            XElement root = null;
            byte[] data = null;
            string msg = string.Empty;
            Stream stream = null;
            StreamReader readStream = null;
            Stream receiveStream = null;
            XDocument xmlResposta = null;
            string resultado = string.Empty;

            try
            {

                request =
                    (HttpWebRequest)WebRequest.Create(ServerEndPoint.BaseUrl + "/" + ServerEndPoint.PostRegisto);

                ServicePointManager.ServerCertificateValidationCallback =
                    new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                xmlPedido = XDocument.Parse("<registo><nomeabreviado></nomeabreviado><username></username><password></password><email></email><fotografia></fotografia><pais></pais></registo>");
                xmlPedido.Element("registo").Element("username").Value = username;
                xmlPedido.Element("registo").Element("password").Value = password;
                xmlPedido.Element("registo").Element("email").Value = mail;
                xmlPedido.Element("registo").Element("nomeabreviado").Value = nomeabv;
                xmlPedido.Element("registo").Element("pais").Value = pais;

                msg = xmlPedido.Root.ToString();

                data = Encoding.Default.GetBytes(msg);
                request.Method = "POST";
                request.ContentType = "application/xml";
                request.ContentLength = data.Length;

                stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                response.Close();
                readStream.Close();

                xmlResposta = XDocument.Parse(resultado);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    //MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID = string.Empty;
                }
                else
                {
                    ID = xmlResposta.Element("resultado").Element("objeto").Element("ID").Value;
                }

            }
            catch (Exception excep)
            {
                throw excep;
            }

            return ID;
        }

        public string Login(string username, string password)
        {
            string status = string.Empty;
            XDocument xmlPedido = null;
            string msg = string.Empty;
            byte[] data = null;
            Stream stream = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Stream receiveStream = null;
            StreamReader readStream = null;
            string resultado = string.Empty;
            XDocument xmlResposta = null;

            try
            {
                request =
                    (HttpWebRequest)WebRequest.Create(ServerEndPoint.BaseUrl + "/" + ServerEndPoint.PostLogin);

                ServicePointManager.ServerCertificateValidationCallback =
                    new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                xmlPedido = XDocument.Parse(
                    "<credenciais><username></username><password></password></credenciais>");

                xmlPedido.Element("credenciais").Element("username").Value = username;
                xmlPedido.Element("credenciais").Element("password").Value = password;

                msg = xmlPedido.Root.ToString();

                data = Encoding.Default.GetBytes(msg);

                request.Method = "POST";
                request.ContentType = "application/xml";
                request.ContentLength = data.Length;

                stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                response.Close();
                receiveStream.Close();

                xmlResposta = XDocument.Parse(resultado);

                status = xmlResposta.Element("resultado").Element("status").Value;
            }
            catch (Exception excep)
            {
                throw excep;
            }

            return status;
        }
        
        public XDocument NovoJogo(string nivel, string ID)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            XDocument xmlResposta = null;
            Stream receiveStream = null;
            StreamReader readStream = null;
            string resultado = string.Empty;



            try
            {
                request = (HttpWebRequest) WebRequest.Create(ServerEndPoint.BaseUrl + ServerEndPoint.GetNovoJogo + "/" + nivel + "/" + ID);

                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                request.Method = "GET";
                request.ContentType = "application/xml";

                response = (HttpWebResponse) request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                receiveStream.Close();
                readStream.Close();

                xmlResposta = XDocument.Parse(resultado);
            }
            catch (Exception excep)
            {
                throw excep;
            }

            return xmlResposta;
        }

        public string RegistoResultado(string nivel, int tempo, string vitoria, string ID)
        {
            string status = string.Empty;
            string resultado = string.Empty;
            HttpWebRequest request = null;
            XDocument xmlPedido = null;
            string msg = string.Empty;
            byte[] data = null;
            Stream stream = null;
            StreamReader readStream = null;
            Stream receiveStream = null;
            HttpWebResponse response = null;
            XDocument xmlResposta = null;

            string tempo_s = tempo.ToString();

            try
                {
                    request = (HttpWebRequest)WebRequest.Create(ServerEndPoint.BaseUrl + "/" + ServerEndPoint.PostRegistoResultado + "/" + ID);
                    ServicePointManager.ServerCertificateValidationCallback =
                        new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                    xmlPedido = XDocument.Parse("<resultado_jogo><nivel></nivel><tempo></tempo><vitoria></vitoria></resultado_jogo>");
                    xmlPedido.Element("resultado_jogo").Element("nivel").Value = nivel;
                    xmlPedido.Element("resultado_jogo").Element("tempo").Value = tempo_s;
                    xmlPedido.Element("resultado_jogo").Element("vitoria").Value = vitoria;

                    msg = xmlPedido.Root.ToString();

                    data = Encoding.Default.GetBytes(msg);

                    request.Method = "POST";
                    request.ContentType = "application/xml";
                    request.ContentLength = data.Length;

                    stream = request.GetRequestStream();
                    stream.Write(data, 0, data.Length);
                    stream.Close();

                    response = (HttpWebResponse)request.GetResponse();
                    receiveStream = response.GetResponseStream();
                    readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    resultado = readStream.ReadToEnd();
                    response.Close();
                    readStream.Close();

                    xmlResposta = XDocument.Parse(resultado);

                    status = xmlResposta.Element("resultado").Element("status").Value;

                }
                catch (Exception excep)
                {
                    throw excep;
                }

            return status;

        }
    
        public XDocument GetPerfil(string username)
        {
            XDocument umPerfil = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Stream receiveStream = null;
            StreamReader readStream = null;
            XDocument xmlResposta = null;
            string resultado = string.Empty;


            try
            {
                request = (HttpWebRequest)WebRequest.Create(ServerEndPoint.BaseUrl + ServerEndPoint.GetPerfil + "/" + username);

                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                request.Method = "GET";
                request.ContentType = "application/xml";

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                receiveStream.Close();
                readStream.Close();

                umPerfil = XDocument.Parse(resultado);

                return umPerfil;

            }
            catch (Exception excep)
            {
                throw (excep);
            }
        }

        public XDocument Top10()
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            string resultado = string.Empty;
            Stream receiveStream = null;
            StreamReader readStream = null;
            XDocument xmlPerfis = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(ServerEndPoint.BaseUrl + "/" + ServerEndPoint.GetTop10);
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);


                request.Method = "GET";
                request.ContentType = "application/xml";

                response = (HttpWebResponse)request.GetResponse();
                receiveStream = response.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                resultado = readStream.ReadToEnd();
                receiveStream.Close();
                readStream.Close();


                xmlPerfis = XDocument.Parse(resultado);

                return xmlPerfis;

            }
            catch (Exception excep)
            {
                throw (excep);
            }
        }



        public Server()
        {

        }


        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

    }
}
