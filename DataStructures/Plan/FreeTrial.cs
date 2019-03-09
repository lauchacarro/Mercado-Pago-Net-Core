// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Plan.FreeTrial
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

namespace MercadoPago.DataStructures.Plan
{
  public struct FreeTrial
  {
    private int frequency;
    private string frequencyType;

    public int Frequency
    {
      get
      {
        return this.frequency;
      }
      set
      {
        this.frequency = value;
      }
    }

    public string FrequencyType
    {
      get
      {
        return this.frequencyType;
      }
      set
      {
        this.frequencyType = value;
      }
    }
  }
}
