// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Preference.BackUrls
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Preference
{
  public struct BackUrls
  {
    [StringLength(600)]
    private string _success;
    [StringLength(600)]
    private string _pending;
    [StringLength(600)]
    private string _failure;

    public string Success
    {
      get
      {
        return this._success;
      }
      set
      {
        this._success = value;
      }
    }

    public string Pending
    {
      get
      {
        return this._pending;
      }
      set
      {
        this._pending = value;
      }
    }

    public string Failure
    {
      get
      {
        return this._failure;
      }
      set
      {
        this._failure = value;
      }
    }
  }
}
