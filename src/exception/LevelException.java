package exception;

public class LevelException extends Exception {
  private String fileName;

  public LevelException(String message, String _fileName)
  {
    super(message);
    this.fileName = _fileName;
  }

  public String getFileName() { return fileName; }
}
