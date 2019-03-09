// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.Shipment
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Payment
{
  public struct Shipment
  {
    private MercadoPago.DataStructures.Payment.ReceiverAddress? _receiver_address;

    public MercadoPago.DataStructures.Payment.ReceiverAddress? ReceiverAddress
    {
      get
      {
        return this._receiver_address;
      }
      set
      {
        this._receiver_address = value;
      }
    }
  }
}
