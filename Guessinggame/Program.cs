using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Guessinggame
{
    class Createxml
    { 
    public Createxml(string create = @".\createXML.xml")
    {
        XmlWriter = new XmlTextWriter(@create, null);
        XmlWriter.WriteStartDocument();
        XmlWriter.WriteStartElement("Player_details");
    }

    public bool XMLTerm()
    {
        XmlWriter.WriteEndElement();
        XmlWriter.WriteEndDocument();
        XmlWriter.Close();
        return true;
    }


    public bool CreateUser(string UserName)
    {
        XmlWriter.WriteStartElement("UserName", " ");
        XmlWriter.WriteString(UserName);
        XmlWriter.WriteEndElement();
        return true;
    }
    public bool CreatePass(string PassWord)
    {
        XmlWriter.WriteStartElement("PassWord", " ");
        XmlWriter.WriteString(PassWord);
        XmlWriter.WriteEndElement();
        return true;
    }

    public bool CreateName(string FullName)
    {
         XmlWriter.WriteStartElement("FullName", " ");
         XmlWriter.WriteString(FullName);
         XmlWriter.WriteEndElement();
         return true;
    }


        protected
        XmlTextWriter XmlWriter;


   }
public struct LoginData
{
    public string FullName;
    public string UserName;
    public string PassWord;

    
};

public class LoginDump
{
    public LoginDump(string create = @".\createXML.xml")
    {
        XmlRead = new XmlTextReader(create);
        
        XmlRead.MoveToContent();
        L = new LinkedList<LoginData>();
        recfound = LoginFile();
        XmlRead.Close();
    }
    ~LoginDump()
    {

    }

    bool LoginFile()
    {
        LoginData dum = new LoginData(); bool lflag = false;
        while (XmlRead.Read())
        {
            if (XmlRead.Depth == 2)
            {
                dum.FullName = XmlRead.Value;
                XmlRead.Skip(); XmlRead.Skip();

                XmlRead.Read();
                dum.UserName = XmlRead.Value;
                XmlRead.Skip(); XmlRead.Skip();
                
                XmlRead.Read();
                dum.PassWord = XmlRead.Value;
                XmlRead.Skip(); XmlRead.Skip();

                L.AddLast(dum);
                lflag = true;

            }
        }

        return lflag;
    }
    public LinkedList<LoginData> ListOut()
    {
        if (recfound)
        {
            L.First(); return L;

        }
        else return null;
    }

    public bool FindInfo(string username, string password)
    {
        if (!recfound) return false;
        LoginData lg = new LoginData();
        lg.UserName = username;
        lg.PassWord = password;
        L.First();
        foreach (var dum1 in L) if ((lg.UserName == dum1.UserName) && (lg.PassWord == dum1.PassWord)) return true;
        return false;
    }

    public bool AddLoginList()
    {
        Createxml xml = new Createxml();
        L.First();
        foreach (var dum1 in L)
        {

            xml.CreateName(dum1.FullName);
            xml.CreateUser(dum1.UserName);
            xml.CreatePass(dum1.PassWord);
            
        }
        
        xml.XMLTerm();
        return false;
    }
    public bool FindInfo(string username)
    {
        if (!recfound) return false;
        LoginData lg = new LoginData();
        lg.UserName = username;

        L.First();
        foreach (var dum1 in L) if ((lg.UserName == dum1.UserName)) return true;

        return false;
    }

    public bool GetRecFound() { return (recfound); }

    public bool AddInfo(string fullname,string username, string password)
    {
        LoginData lg = new LoginData();
        lg.FullName = fullname;
        lg.UserName = username;
        lg.PassWord = password;
        
        L.AddLast(lg); recfound = true;
        AddLoginList();
        return true;
    }
    protected
        XmlTextReader XmlRead;
    LinkedList<LoginData> L;
    bool recfound = false;
}
public class RegLink
{
    public bool RegisterUser(string fullname,string username, string password)
    {
        if (xml.FindInfo(username))
        {
            return false;
        } 
        else if (xml.AddInfo(fullname,username, password))
        {
            return true;
        }

        Console.ReadKey();
        return true;
    }
    public RegLink(string create = @".\createXML.xml")
    {
        xml = new LoginDump(create);
    }

    public LoginDump xml;

};
static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
