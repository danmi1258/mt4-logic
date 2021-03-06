//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Signal.proto

using System;
using System.ComponentModel;
using ProtoBuf;

namespace ProtoTypes
{
  [Serializable, ProtoContract(Name=@"Signal")]
  public partial class Signal : IExtensible
  {
    public Signal() {}
    
    private SignalType _Type;
    [ProtoMember(1, IsRequired = true, Name=@"Type", DataFormat = DataFormat.TwosComplement)]
    public SignalType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private byte[] _Content = null;
    [ProtoMember(2, IsRequired = false, Name=@"Content", DataFormat = DataFormat.Default)]
    [DefaultValue(null)]
    public byte[] Content
    {
      get { return _Content; }
      set { _Content = value; }
    }
    private string _Source;
    [ProtoMember(3, IsRequired = true, Name=@"Source", DataFormat = DataFormat.Default)]
    public string Source
    {
      get { return _Source; }
      set { _Source = value; }
    }
    private string _Description = "";
    [ProtoMember(4, IsRequired = false, Name=@"Description", DataFormat = DataFormat.Default)]
    [DefaultValue("")]
    public string Description
    {
      get { return _Description; }
      set { _Description = value; }
    }
    private IExtension extensionObject;
    IExtension IExtensible.GetExtensionObject(bool createIfMissing)
      { return Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [ProtoContract(Name=@"SignalType")]
    public enum SignalType
    {
            
      [ProtoEnum(Name=@"TradeSignal", Value=0)]
      TradeSignal = 0,
            
      [ProtoEnum(Name=@"ConnectSignal", Value=1)]
      ConnectSignal = 1,
            
      [ProtoEnum(Name=@"SignalOrdersStatus", Value=2)]
      SignalOrdersStatus = 2
    }
  
}