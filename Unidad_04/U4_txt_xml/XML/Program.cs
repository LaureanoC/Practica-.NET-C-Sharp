using System.Xml;


escribirXML();
leerxml();
static void escribirXML()
{
    XmlTextWriter escritor = new XmlTextWriter("agendaxml.xml", null);
    escritor.Formatting = Formatting.Indented;
    escritor.WriteStartDocument(true);
    escritor.WriteStartElement("DocumentElement");

    StreamReader lector = File.OpenText("agenda.txt");

    string linea;

    do
    {
        linea = lector.ReadLine();
        if (linea != null)
        {
            string[] valores = linea.Split(";");
            escritor.WriteStartElement("contactos");
            
            escritor.WriteStartElement("nombre");
            escritor.WriteValue(valores[0]);
            escritor.WriteEndElement();

            escritor.WriteStartElement("apellido");
            escritor.WriteValue(valores[1]);
            escritor.WriteEndElement();

            escritor.WriteStartElement("email");
            escritor.WriteValue(valores[2]);
            escritor.WriteEndElement();

            escritor.WriteStartElement("telefono");
            escritor.WriteValue(valores[3]);
            escritor.WriteEndElement();

            escritor.WriteEndElement(); // cerramos el tag de contactos

        }
    }
    while (linea !=null);

    escritor.WriteEndElement(); // Cerramos el tag de documentelement
    escritor.WriteEndDocument();
    escritor.Close();

    lector.Close();
}

static void leerxml()
{
    XmlTextReader lector = new XmlTextReader("agendaxml.xml");

    string tagAnterior = "";
    while(lector.Read())
    {
        if(lector.NodeType == XmlNodeType.Element)
        {
            tagAnterior = lector.Name;
        } 
        else if(lector.NodeType == XmlNodeType.Text)
        {
            Console.WriteLine(tagAnterior + ": " + lector.Value);

        }
    }
    lector.Close();
}