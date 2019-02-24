// Decompiled with JetBrains decompiler
// Type: MercadoPago.MPException
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace MercadoPago
{
  [Serializable]
  public class MPException : Exception
  {
    private List<string> cause = new List<string>();

    public string RequestId { get; private set; }

    public int? StatusCode { get; set; }

    public string ErrorMessage { get; set; }

    public string Error { get; private set; }

    public List<string> Cause
    {
      get
      {
        return this.cause;
      }
      set
      {
        this.cause = value;
      }
    }

    public MPException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.ErrorMessage = info.GetString(nameof (ErrorMessage));
    }

    public MPException(string message)
      : base(message)
    {
    }

    public MPException(string message, Exception innerException)
      : base(message, innerException)
    {
    }

    public MPException(string message, string requestId, int? statusCode)
      : base(message)
    {
      this.RequestId = requestId;
      this.StatusCode = statusCode;
    }

    public MPException(string message, string requestId, int statusCode, Exception innerException)
      : base(message, innerException)
    {
      this.RequestId = requestId;
      this.StatusCode = new int?(statusCode);
    }

    public MPException(int statusCode, string message, List<string> cause)
      : base(message)
    {
      this.StatusCode = new int?(statusCode);
      this.Cause = cause;
    }

    public MPException()
    {
    }

    public override string ToString()
    {
      string str1 = string.Empty;
      if (!string.IsNullOrEmpty(this.RequestId))
        str1 = "; request-id: " + this.RequestId;
      string str2 = string.Empty;
      int? statusCode = this.StatusCode;
      if (statusCode.HasValue)
      {
        statusCode = this.StatusCode;
        str2 = "; status_code: " + (object) statusCode.Value;
      }
      return base.ToString() + str1 + str2;
    }

    [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      base.GetObjectData(info, context);
      info.AddValue("RequestId", (object) this.RequestId);
      info.AddValue("StatusCode", (object) this.StatusCode);
    }
  }
}
