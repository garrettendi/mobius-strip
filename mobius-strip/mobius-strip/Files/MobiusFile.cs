using System;
using System.ComponentModel;

namespace Mobius
{
  [Serializable]
  public abstract class MobiusFile : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected string id;
    [System.Xml.Serialization.XmlElement("Id")]
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public string Id { get { return id; } set { id = value; InvokePropertyChanged(new PropertyChangedEventArgs("Id")); } }

    /// <summary>
    /// Gets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    internal abstract string Type { get; }
  
    /// <summary>
    /// Initializes a new instance of the <see cref="Mobius.MobiusFile"/> class.
    /// </summary>
    /// <param name='id'>
    /// Identifier.
    /// </param>
    public MobiusFile(string id)
    {
      this.Id = id;
    }

    public void InvokePropertyChanged(PropertyChangedEventArgs e)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null) handler(this, e);
    }
  }
}

