// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Generic.BadParamsError
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Generic
{
  public struct BadParamsError
  {
    private string _message;
    private string _error;
    private int _status;
    private BadParamsCause[] _cause;

    public string Message
    {
      get
      {
        return this._message;
      }
      set
      {
        this._message = value;
      }
    }

    public string Error
    {
      get
      {
        return this._error;
      }
      set
      {
        this._error = value;
      }
    }

    public int Status
    {
      get
      {
        return this._status;
      }
      set
      {
        this._status = value;
      }
    }

    public BadParamsCause[] Cause
    {
      get
      {
        return this._cause;
      }
      set
      {
        this._cause = value;
      }
    }
  }
}
