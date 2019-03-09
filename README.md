# Mercado-Pago-Net-Core
Migration from Mercado Pago SDK from Net Framework 3.5 to NetCore 2.1

## Installation 

### Using our nuget package

**Using Package Manager**

`PM> Install-Package Mercado-Pago-Net-Core -Version 1.0.10`

### 1. You have to import the Mercado Pago SDK.
```csharp
using MercadoPago;
```

### 2. Setup your credentials

**For Web-checkout:**
```csharp
MercadoPago.SDK sdk = new MercadoPago.SDK();
sdk.ClientId = "YOUR_CLIENT_ID";
sdk.ClientSecret = "YOUR_CLIENT_SECRET";
```
**For API or custom checkout:**
```csharp
MercadoPago.SDK sdk = new MercadoPago.SDK();
sdk.AccessToken = "YOUR_ACCESS_TOKEN";
```

**Sample (Creating a Preference)**
```csharp
using MercadoPago;
using MercadoPago.Resources;
using MercadoPago.DataStructures.Preference;


MercadoPago.SDK sdk = new MercadoPago.SDK();
sdk.ClientId = "YOUR_CLIENT_ID";
sdk.ClientSecret = "YOUR_CLIENT_SECRET";

// Create a preference object
Preference preference = new Preference(sdk); 
# Adding an item object
preference.Items.Add(
  new Item()
  {
    Id = "1234",
    Title = "Synergistic Cotton Watch", 
    Quantity = 5,
    CurrencyId = "ARS",
    UnitPrice = (float)23.25
  }
);
// Setting a payer object as value for Payer property
preference.Payer = new Payer(){
  Email = "willa@yahoo.com"
}
// Save and posting preference
preference.Save();
```




**Sample (Creating a Payment)**
    
```csharp
using MercadoPago;
using MercadoPago.Resources;
using MercadoPago.DataStructures.Payment;
using MercadoPago.Common;

MercadoPago.SDK sdk = new MercadoPago.SDK();
sdk.AccessToken = "YOUR_ACCESS_TOKEN";

Payment payment = new Payment(sdk)
{
    TransactionAmount = (float)100.0,
    Token = "YOUR_CARD_TOKEN"
    Description = "Ergonomic Silk Shirt",
    PaymentMethodId = "visa", 
    Installments = 1,
    Payer = new Payer {
        Email = "larue.nienow@hotmail.com"
    }
};

payment.Save();

Console.Out.WriteLine(payment.Status);
```

### 4. Handling Errors

**Error response structure**

![errorstructure](https://user-images.githubusercontent.com/864790/40929584-9cc4c96e-67fb-11e8-80a4-8d797953233a.png)

You can check the errors and causes returned by the API using the `errors` attribute.

```csharp
Console.Out.WriteLine(payment.Errors.Message) // Print the error Message 
```
