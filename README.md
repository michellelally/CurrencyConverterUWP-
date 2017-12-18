# CurrencyConverterUWP-
This app allows the user to learn about the different currencies used not just in Europe, but in the European Union alone. There are eleven countries that haven't opted to use the Euro as their currnecy since they joined the EU and the difference in values between each of these currencies is outstanding.

This app was created using XAML and C#. I had no experience in either of these languages before creating these apps so it could do with a lot of refractoring but with a strcit deadline, I aimed to get the main features working and learn more about these languages and completely update the app. 

Using the XAML feature, Pivot, I created a page for each currency which includes an text box, combo box, button and text block. The C# code pulls the input from the text box to use the amount the user would like to convert. It them uses the number of the selected index to deccipher which currency the user wants to convert to. I used the currency exchange rates from http://www.xe.com/currencyconverter/ and multiply the value from the input box by the exchange rate and output it to the screen. 
