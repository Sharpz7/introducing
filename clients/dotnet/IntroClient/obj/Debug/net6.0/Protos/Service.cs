// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace IntroClient {

  /// <summary>Holder for reflection information generated from Protos/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90b3Mvc2VydmljZS5wcm90byIzCgdyZXF1ZXN0EhgKC25vX29mX2Nh",
            "cmRzGAEgASgDSACIAQFCDgoMX25vX29mX2NhcmRzIpACCgpwZXJzb25DYXJk",
            "EhEKBG5hbWUYASABKAlIAIgBARIcCg9wcm9maWxlX3BpY3R1cmUYAiABKAlI",
            "AYgBARIVCghsb2NhdGlvbhgDIAEoCUgCiAEBEh0KEGJhY2tncm91bmRfaW1h",
            "Z2UYBCABKAlIA4gBARIQCgNhZ2UYBSABKANIBIgBARIWCgliYWNrc3RvcnkY",
            "BiABKAlIBYgBARISCgV0aXRsZRgHIAEoCUgGiAEBQgcKBV9uYW1lQhIKEF9w",
            "cm9maWxlX3BpY3R1cmVCCwoJX2xvY2F0aW9uQhMKEV9iYWNrZ3JvdW5kX2lt",
            "YWdlQgYKBF9hZ2VCDAoKX2JhY2tzdG9yeUIICgZfdGl0bGUiKAoLcGVyc29u",
            "Q2FyZHMSGQoEY2FyZBgBIAMoCzILLnBlcnNvbkNhcmQyLAoEQ2FyZBIkCghn",
            "ZXRfY2FyZBIILnJlcXVlc3QaDC5wZXJzb25DYXJkcyIAQg6qAgtJbnRyb0Ns",
            "aWVudGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::IntroClient.request), global::IntroClient.request.Parser, new[]{ "NoOfCards" }, new[]{ "NoOfCards" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::IntroClient.personCard), global::IntroClient.personCard.Parser, new[]{ "Name", "ProfilePicture", "Location", "BackgroundImage", "Age", "Backstory", "Title" }, new[]{ "Name", "ProfilePicture", "Location", "BackgroundImage", "Age", "Backstory", "Title" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::IntroClient.personCards), global::IntroClient.personCards.Parser, new[]{ "Card" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Incoming request from client
  /// </summary>
  public sealed partial class request : pb::IMessage<request>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<request> _parser = new pb::MessageParser<request>(() => new request());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::IntroClient.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public request(request other) : this() {
      _hasBits0 = other._hasBits0;
      noOfCards_ = other.noOfCards_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public request Clone() {
      return new request(this);
    }

    /// <summary>Field number for the "no_of_cards" field.</summary>
    public const int NoOfCardsFieldNumber = 1;
    private long noOfCards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long NoOfCards {
      get { if ((_hasBits0 & 1) != 0) { return noOfCards_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        noOfCards_ = value;
      }
    }
    /// <summary>Gets whether the "no_of_cards" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNoOfCards {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "no_of_cards" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNoOfCards() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NoOfCards != other.NoOfCards) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasNoOfCards) hash ^= NoOfCards.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasNoOfCards) {
        output.WriteRawTag(8);
        output.WriteInt64(NoOfCards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasNoOfCards) {
        output.WriteRawTag(8);
        output.WriteInt64(NoOfCards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasNoOfCards) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NoOfCards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(request other) {
      if (other == null) {
        return;
      }
      if (other.HasNoOfCards) {
        NoOfCards = other.NoOfCards;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            NoOfCards = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            NoOfCards = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response to be returned by API service
  /// </summary>
  public sealed partial class personCard : pb::IMessage<personCard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<personCard> _parser = new pb::MessageParser<personCard>(() => new personCard());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<personCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::IntroClient.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public personCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public personCard(personCard other) : this() {
      _hasBits0 = other._hasBits0;
      name_ = other.name_;
      profilePicture_ = other.profilePicture_;
      location_ = other.location_;
      backgroundImage_ = other.backgroundImage_;
      age_ = other.age_;
      backstory_ = other.backstory_;
      title_ = other.title_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public personCard Clone() {
      return new personCard(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 2;
    private string profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProfilePicture {
      get { return profilePicture_ ?? ""; }
      set {
        profilePicture_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "profile_picture" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasProfilePicture {
      get { return profilePicture_ != null; }
    }
    /// <summary>Clears the value of the "profile_picture" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearProfilePicture() {
      profilePicture_ = null;
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 3;
    private string location_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Location {
      get { return location_ ?? ""; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "location" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLocation {
      get { return location_ != null; }
    }
    /// <summary>Clears the value of the "location" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLocation() {
      location_ = null;
    }

    /// <summary>Field number for the "background_image" field.</summary>
    public const int BackgroundImageFieldNumber = 4;
    private string backgroundImage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BackgroundImage {
      get { return backgroundImage_ ?? ""; }
      set {
        backgroundImage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "background_image" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBackgroundImage {
      get { return backgroundImage_ != null; }
    }
    /// <summary>Clears the value of the "background_image" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBackgroundImage() {
      backgroundImage_ = null;
    }

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 5;
    private long age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Age {
      get { if ((_hasBits0 & 1) != 0) { return age_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        age_ = value;
      }
    }
    /// <summary>Gets whether the "age" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAge {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "age" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAge() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "backstory" field.</summary>
    public const int BackstoryFieldNumber = 6;
    private string backstory_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Backstory {
      get { return backstory_ ?? ""; }
      set {
        backstory_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "backstory" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBackstory {
      get { return backstory_ != null; }
    }
    /// <summary>Clears the value of the "backstory" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBackstory() {
      backstory_ = null;
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 7;
    private string title_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_ ?? ""; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "title" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTitle {
      get { return title_ != null; }
    }
    /// <summary>Clears the value of the "title" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTitle() {
      title_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as personCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(personCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ProfilePicture != other.ProfilePicture) return false;
      if (Location != other.Location) return false;
      if (BackgroundImage != other.BackgroundImage) return false;
      if (Age != other.Age) return false;
      if (Backstory != other.Backstory) return false;
      if (Title != other.Title) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasName) hash ^= Name.GetHashCode();
      if (HasProfilePicture) hash ^= ProfilePicture.GetHashCode();
      if (HasLocation) hash ^= Location.GetHashCode();
      if (HasBackgroundImage) hash ^= BackgroundImage.GetHashCode();
      if (HasAge) hash ^= Age.GetHashCode();
      if (HasBackstory) hash ^= Backstory.GetHashCode();
      if (HasTitle) hash ^= Title.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasName) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (HasProfilePicture) {
        output.WriteRawTag(18);
        output.WriteString(ProfilePicture);
      }
      if (HasLocation) {
        output.WriteRawTag(26);
        output.WriteString(Location);
      }
      if (HasBackgroundImage) {
        output.WriteRawTag(34);
        output.WriteString(BackgroundImage);
      }
      if (HasAge) {
        output.WriteRawTag(40);
        output.WriteInt64(Age);
      }
      if (HasBackstory) {
        output.WriteRawTag(50);
        output.WriteString(Backstory);
      }
      if (HasTitle) {
        output.WriteRawTag(58);
        output.WriteString(Title);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasName) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (HasProfilePicture) {
        output.WriteRawTag(18);
        output.WriteString(ProfilePicture);
      }
      if (HasLocation) {
        output.WriteRawTag(26);
        output.WriteString(Location);
      }
      if (HasBackgroundImage) {
        output.WriteRawTag(34);
        output.WriteString(BackgroundImage);
      }
      if (HasAge) {
        output.WriteRawTag(40);
        output.WriteInt64(Age);
      }
      if (HasBackstory) {
        output.WriteRawTag(50);
        output.WriteString(Backstory);
      }
      if (HasTitle) {
        output.WriteRawTag(58);
        output.WriteString(Title);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasProfilePicture) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProfilePicture);
      }
      if (HasLocation) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (HasBackgroundImage) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BackgroundImage);
      }
      if (HasAge) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Age);
      }
      if (HasBackstory) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Backstory);
      }
      if (HasTitle) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(personCard other) {
      if (other == null) {
        return;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasProfilePicture) {
        ProfilePicture = other.ProfilePicture;
      }
      if (other.HasLocation) {
        Location = other.Location;
      }
      if (other.HasBackgroundImage) {
        BackgroundImage = other.BackgroundImage;
      }
      if (other.HasAge) {
        Age = other.Age;
      }
      if (other.HasBackstory) {
        Backstory = other.Backstory;
      }
      if (other.HasTitle) {
        Title = other.Title;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            ProfilePicture = input.ReadString();
            break;
          }
          case 26: {
            Location = input.ReadString();
            break;
          }
          case 34: {
            BackgroundImage = input.ReadString();
            break;
          }
          case 40: {
            Age = input.ReadInt64();
            break;
          }
          case 50: {
            Backstory = input.ReadString();
            break;
          }
          case 58: {
            Title = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            ProfilePicture = input.ReadString();
            break;
          }
          case 26: {
            Location = input.ReadString();
            break;
          }
          case 34: {
            BackgroundImage = input.ReadString();
            break;
          }
          case 40: {
            Age = input.ReadInt64();
            break;
          }
          case 50: {
            Backstory = input.ReadString();
            break;
          }
          case 58: {
            Title = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class personCards : pb::IMessage<personCards>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<personCards> _parser = new pb::MessageParser<personCards>(() => new personCards());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<personCards> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::IntroClient.ServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public personCards() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public personCards(personCards other) : this() {
      card_ = other.card_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public personCards Clone() {
      return new personCards(this);
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 1;
    private static readonly pb::FieldCodec<global::IntroClient.personCard> _repeated_card_codec
        = pb::FieldCodec.ForMessage(10, global::IntroClient.personCard.Parser);
    private readonly pbc::RepeatedField<global::IntroClient.personCard> card_ = new pbc::RepeatedField<global::IntroClient.personCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::IntroClient.personCard> Card {
      get { return card_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as personCards);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(personCards other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!card_.Equals(other.card_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= card_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      card_.WriteTo(output, _repeated_card_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      card_.WriteTo(ref output, _repeated_card_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += card_.CalculateSize(_repeated_card_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(personCards other) {
      if (other == null) {
        return;
      }
      card_.Add(other.card_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            card_.AddEntriesFrom(input, _repeated_card_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            card_.AddEntriesFrom(ref input, _repeated_card_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
