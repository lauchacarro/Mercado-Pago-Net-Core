// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.Identification
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
  public struct Identification
  {
    [StringLength(256)]
    private string _type;
    [StringLength(256)]
    private string _number;

    public string Type
    {
      get
      {
        return this._type;
      }
      set
      {
        this._type = value;
      }
    }

    public string Number
    {
      get
      {
        return this._number;
      }
      set
      {
        this._number = value;
      }
    }
  }
}
