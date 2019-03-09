// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Customer.Shipment
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.Collections.Generic;

namespace MercadoPago.DataStructures.Customer
{
  public struct Shipment
  {
    private bool success;
    private List<Error> errors;
    private string name;

    public bool Success
    {
      get
      {
        return this.success;
      }
    }

    public List<Error> Errors
    {
      get
      {
        return this.errors;
      }
    }

    public string Name
    {
      get
      {
        return this.name;
      }
    }
  }
}
