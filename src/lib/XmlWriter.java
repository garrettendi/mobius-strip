package lib;

import java.io.*;
import com.thoughtworks.xstream.XStream;

/**
 * Used to facilitate writing to and from xml files. Uses the XStream libraries,
 * licenced under the BSD Licence
 * @author Dale
 *
 */
public class XmlWriter {	
	public XmlWriter() {
	}
	
	/**
	 * Serialise and write the Object to an xml file
	 * @param obj Object to write to xml file
	 * @param path Path to write to. Null if writing to path is not required
	 * @return
	 */
	public static String toXml(Object obj, String path) throws IOException {
		XStream xmlOut = new XStream();
		String xml = xmlOut.toXML(obj); // Write xml
		// We only want to save xml to file if path is set. See javadoc comments above.
		if (path != null)
		{
				FileWriter fileOut = new FileWriter(path);
				BufferedWriter writer = new BufferedWriter(fileOut);
				writer.write(xml);
				// Always close streams when finished.
				writer.close();
				fileOut.close();
		}
		return xml;
	}
	
	/**
	 * Load Object from xml formatted text file. This will only ever read 
	 * xml from a file. If you want to read from a string, use fromXmlString
	 * @param path Path of file to read from
	 * @return Plain Object read from xml. Cast to correct type
	 * @throws IOException
	 */
	public static Object fromXmlFile(String path) throws IOException {
		XStream xmlIn = new XStream();
		FileReader fileIn = new FileReader(path);
		Object obj = xmlIn.fromXML(fileIn); // Read to plain object
		fileIn.close(); // Always close streams
		return obj; // Return plain object
	}
	
	/**
	 * Load Object from xml formatted string.
	 * @param xml Xml formatted string for Object.
	 * @return Plain Object read from xml. Cast to correct type
	 */
	public static Object fromXmlString(String xml)
	{
		XStream xmlIn = new XStream();
		return xmlIn.fromXML(xml);
	}
}