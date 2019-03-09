// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.MerchantOrder.Payer
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.MerchantOrder
{
  public struct Payer
  {
    private string id;
    private string email;
    private string nickName;

    public string ID
    {
      get
      {
        return this.id;
      }
      set
      {
        this.id = value;
      }
    }

    public string Email
    {
      get
      {
        return this.email;
      }
      set
      {
        this.email = value;
      }
    }

    public string NickName
    {
      get
      {
        return this.nickName;
      }
      set
      {
        this.nickName = value;
      }
    }
  }
}
