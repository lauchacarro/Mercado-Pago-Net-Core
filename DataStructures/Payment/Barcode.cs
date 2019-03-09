// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Barcode
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
  public struct Barcode
  {
    private EncodingType? _encoding_type;
    private string _content;
    private int? width;
    private int? height;

    public EncodingType? Encoding_type
    {
      get
      {
        return this._encoding_type;
      }
      set
      {
        this._encoding_type = value;
      }
    }

    public string Content
    {
      get
      {
        return this._content;
      }
      set
      {
        this._content = value;
      }
    }

    public int? Width
    {
      get
      {
        return this.width;
      }
      set
      {
        this.width = value;
      }
    }

    public int? Height
    {
      get
      {
        return this.height;
      }
      set
      {
        this.height = value;
      }
    }
  }
}
