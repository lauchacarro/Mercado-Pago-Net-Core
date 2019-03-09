// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.Phone
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
  public struct Phone
  {
    [StringLength(256)]
    private string _area_code;
    [StringLength(256)]
    private string _number;

    public string AreaCode
    {
      get
      {
        return this._area_code;
      }
      set
      {
        this._area_code = value;
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
