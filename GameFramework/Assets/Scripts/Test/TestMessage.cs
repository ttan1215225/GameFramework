//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
   
// Generated from: TestMessage.proto
namespace Test
{
  [Serializable, ProtoContract(Name=@"TestMessage")]
  public partial class TestMessage : IExtensible
  {
    public TestMessage() {}
    
    private Test.TestMessage.CS_TestMessage1 _cs_testmessage1 = null;
    [ProtoMember(1, IsRequired = false, Name=@"cs_testmessage1", DataFormat = DataFormat.Default)]
    [DefaultValue(null)]
    public Test.TestMessage.CS_TestMessage1 cs_testmessage1
    {
      get { return _cs_testmessage1; }
      set { _cs_testmessage1 = value; }
    }
  [Serializable, ProtoContract(Name=@"CS_TestMessage1")]
  public partial class CS_TestMessage1 : IExtensible
  {
    public CS_TestMessage1() {}
    
    private int _id;
    [ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _context;
    [ProtoMember(2, IsRequired = true, Name=@"context", DataFormat = DataFormat.Default)]
    public string context
    {
      get { return _context; }
      set { _context = value; }
    }
    private IExtension extensionObject;
    IExtension IExtensible.GetExtensionObject(bool createIfMissing)
      { return Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [ProtoContract(Name=@"ID")]
    public enum ID
    {
            
      [ProtoEnum(Name=@"ID_UNKNOW", Value=0)]
      ID_UNKNOW = 0,
            
      [ProtoEnum(Name=@"CS_TESTMESSAGE1", Value=1)]
      CS_TESTMESSAGE1 = 1
    }
  
    private IExtension extensionObject;
    IExtension IExtensible.GetExtensionObject(bool createIfMissing)
      { return Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}