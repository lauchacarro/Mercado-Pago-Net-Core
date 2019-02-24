// Decompiled with JetBrains decompiler
// Type: MercadoPago.UserToken
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;

namespace MercadoPago
{
  public class UserToken : Attribute
  {
    private string UserAsignedToken { get; set; }

    public UserToken(string token)
    {
      this.UserAsignedToken = token;
    }

    public string GetUserToken()
    {
      return this.UserAsignedToken;
    }
  }
}
