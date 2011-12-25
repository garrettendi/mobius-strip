package mobius;

import mobius.Enums.FileType;

/**
 * The abstract class that is the base for all types of files used for games running
 * under Mobius Strip.
 * @author Dale Hards
 */
public abstract class MobiusFile
{
	private FileType type;
	private String fileName; // Full filename, including extension.

	public FileType getType() { return type; }
	public void setType(FileType value) { type = value; }

	public String getFileName() { return fileName; }
	public void setFileName(String value) { fileName = value; }

	public MobiusFile(FileType _type, String _fileName)
	{
		this.type = _type;
		this.fileName = _fileName;
		Mobius.loadedFiles.add(this.fileName);
	}
}
