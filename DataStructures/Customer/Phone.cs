// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Phone
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Customer
{
  public struct Phone
  {
    private string _area_code;
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
