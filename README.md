# nexmo-smartstore
Nexmo + SmartStore .NET eCommerce

# Requirements

* SmartStore.NET eCommerce Solution (http://www.smartstore.com/net/en/)

* JSON.NET

* Nexmo Account with API Key and Secret

# Install and Setup

1. Copy the custom BillingAddress.cshtml to the \Views\Checkout\ folder in your SmartStore installation directory:
eg. C:\SmartStore\Views\Checkout\

2. Integrate the server-side code in your .NET solution on the same-domain as the shop (for Cross Origin policy purposes)

* Change the Nexmo API key and secret to your credentials

3. Change the following lines in BillingAddress.cshtml to point to your new and proper endpoints:

* Line 304: call that triggers the phone verification request
* Line 333: call that triggers the code confirmation request

4.  Shoppers now have to verify their billing phone number!  Fraud Prevention!

# License

Licensed under GNU GENERAL PUBLIC LICENSE Version 3