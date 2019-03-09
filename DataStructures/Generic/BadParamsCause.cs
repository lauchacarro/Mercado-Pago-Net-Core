// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Generic.BadParamsCause
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Generic
{
  public struct BadParamsCause
  {
    private string _code;
    private string _description;
    private string _data;

    public string Code
    {
      get
      {
        return this._code;
      }
      set
      {
        this._code = value;
      }
    }

    public string Description
    {
      get
      {
        return this._description;
      }
      set
      {
        this._description = value;
      }
    }

    public string Data
    {
      get
      {
        return this._data;
      }
      set
      {
        this._data = value;
      }
    }
  }
}
