using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EUCurrencyConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //1
        private void ConvertBtnEUR_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amountEUR = double.Parse(TextBox_EUR.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox1.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amountEUR * 1.95583;
                output.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amountEUR * 0.882482;
                output.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian koruna
            else if (option == 2)
            {
                converted = amountEUR * 7.54244;
                output.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech kuna
            else if (option == 3)
            {
                converted = amountEUR * 25.6006;
                output.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 4)
            {
                converted = amountEUR * 7.44250;
                output.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 5)
            {
                converted = amountEUR * 314.552;
                output.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amountEUR * 4.19857;
                output.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amountEUR * 4.63217;
                output.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amountEUR * 10.0137;
                output.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amountEUR * 1.16713;
                output.Text = String.Format("Fr.{0:0.00}", converted);
            }


        }
        //2
        private void ConvertBtnGBP_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_GBP.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox2.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 2.21741;
                output2.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to croatian koruna
            else if (option == 1)
            {
                converted = amount * 8.55240;
                output2.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 2)
            {
                converted = amount * 29.0183;
                output2.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 3)
            {
                converted = amount * 8.43663;
                output2.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 4)
            {
                converted = amount * 1.13362;
                output2.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 5)
            {
                converted = amount * 356.587;
                output2.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amount * 4.75947;
                output2.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 5.25178;
                output2.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 11.3511;
                output2.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 1.32290;
                output2.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //3
        private void ConvertBtnBGN_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_BGN.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox3.SelectedIndex;

            //converting to british pound
            if (option == 0)
            {
                converted = amount * 0.451086;
                output3.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian koruna
            else if (option == 1)
            {
                converted = amount * 3.85088;
                output3.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 2)
            {
                converted = amount * 13.1256;
                output3.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 3)
            {
                converted = amount * 3.80606;
                output3.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 4)
            {
                converted = amount * 0.511292;
                output3.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 5)
            {
                converted = amount * 160.630;
                output3.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amount * 2.15227;
                output3.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 2.36465;
                output3.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 5.10874;
                output3.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.595451;
                output3.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //4
        private void ConvertBtnHRK_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_HRK.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox4.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.259604;
                output4.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.117073;
                output4.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 2)
            {
                converted = amount * 3.40865;
                output4.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 3)
            {
                converted = amount * 0.988102;
                output4.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 4)
            {
                converted = amount * 0.132737;
                output4.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 5)
            {
                converted = amount * 41.6993;
                output4.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amount * 0.558566;
                output2.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 0.613851;
                output4.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 1.32625;
                output4.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.154579;
                output4.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //5
        private void ConvertBtnCZK_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_CZK.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox5.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.0761607;
                output5.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.0343373;
                output5.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian koruna
            else if (option == 2)
            {
                converted = amount * 0.293401;
                output5.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 3)
            {
                converted = amount * 0.289870;
                output5.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 4)
            {
                converted = amount * 0.0389392;
                output5.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 5)
            {
                converted = amount * 12.2302;
                output5.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amount * 0.163864;
                output5.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 0.180093;
                output5.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 0.389073;
                output5.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.0453457;
                output5.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //6
        private void ConvertBtnDKK_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_DKK.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox6.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.262741;
                output6.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.118469;
                output6.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian kuna
            else if (option == 2)
            {
                converted = amount * 1.01234;
                output6.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 3)
            {
                converted = amount * 3.44959;
                output4.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 4)
            {
                converted = amount * 0.134335;
                output6.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 5)
            {
                converted = amount * 42.1941;
                output6.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amount * 0.565579;
                output6.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 0.621462;
                output6.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 1.34164;
                output6.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.156431;
                output6.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //7
        private void ConvertBtnHUF_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_HUF.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox7.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.00622332;
                output7.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.00280620;
                output7.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian kuna
            else if (option == 2)
            {
                converted = amount * 0.0239947;
                output7.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 3)
            {
                converted = amount * 0.0816836;
                output7.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 4)
            {
                converted = amount * 0.0236859;
                output4.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 5)
            {
                converted = amount * 0.00318189;
                output7.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 6)
            {
                converted = amount * 0.0133983;
                output7.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 0.0147224;
                output7.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 0.0317862;
                output7.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.00370638;
                output7.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //8
        private void ConvertBtnPLN_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_PLN.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox8.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.464430;
                output8.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.209405;
                output8.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian kuna
            else if (option == 2)
            {
                converted = amount * 1.79060;
                output8.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 3)
            {
                converted = amount * 6.09606;
                output8.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 4)
            {
                converted = amount * 1.76766;
                output8.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 5)
            {
                converted = amount * 0.237462;
                output8.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 6)
            {
                converted = amount * 74.6318;
                output8.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to romanian leu
            else if (option == 7)
            {
                converted = amount * 1.09868;
                output8.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 2.37203;
                output8.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.276536;
                output8.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //9
        private void ConvertBtnRON_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_RON.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox9.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.422754;
                output9.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.190625;
                output9.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian kuna
            else if (option == 2)
            {
                converted = amount * 1.62992;
                output9.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 3)
            {
                converted = amount * 5.54879;
                output9.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 4)
            {
                converted = amount * 1.60904;
                output9.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 5)
            {
                converted = amount * 0.216142;
                output9.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 6)
            {
                converted = amount * 67.9314;
                output9.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 7)
            {
                converted = amount * 0.910303;
                output9.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to swedish krona
            else if (option == 8)
            {
                converted = amount * 2.15925;
                output9.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.251748;
                output9.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //10
        private void ConvertBtnSEK_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_SEK.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox10.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 0.195784;
                output10.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.0882825;
                output10.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian kuna
            else if (option == 2)
            {
                converted = amount * 0.754764;
                output10.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 3)
            {
                converted = amount * 2.56959;
                output10.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 4)
            {
                converted = amount * 0.745162;
                output10.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 5)
            {
                converted = amount * 0.100102;
                output10.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 6)
            {
                converted = amount * 31.4373;
                output10.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 7)
            {
                converted = amount * 0.421623;
                output10.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 8)
            {
                converted = amount * 0.463070;
                output8.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swiss franc
            else if (option == 9)
            {
                converted = amount * 0.116578;
                output10.Text = String.Format("Fr.{0:0.00}", converted);
            }
        }
        //11
        private void ConvertBtnCHF_Click(object sender, RoutedEventArgs e)
        {
            //assigning amountEUR to the value of the the textbox TextBox_EUR
            double amount = double.Parse(TextBox_CHF.Text);
            double converted = 0;

            //assigning option to the value of the selected index from the combo box comboBox1
            int option = comboBox11.SelectedIndex;

            //converting to bulgarian lev
            if (option == 0)
            {
                converted = amount * 1.67945;
                output11.Text = String.Format("лв{0:0.00}", converted);
            }
            //converting to british pound
            else if (option == 1)
            {
                converted = amount * 0.757213;
                output11.Text = String.Format("£{0:0.00}", converted);
            }
            //converting to croatian kuna
            else if (option == 2)
            {
                converted = amount * 6.47433;
                output11.Text = String.Format("kn{0:0.00}", converted);
            }
            //converting to czech koruna
            else if (option == 3)
            {
                converted = amount * 22.0423;
                output11.Text = String.Format("Kč{0:0.00}", converted);
            }
            //converting to danish korune
            else if (option == 4)
            {
                converted = amount * 6.39204;
                output11.Text = String.Format("kr{0:0.00}", converted);
            }
            //converting to euro
            else if (option == 5)
            {
                converted = amount * 0.858662;
                output11.Text = String.Format("€{0:0.00}", converted);
            }
            //converting to hungarian forint 
            else if (option == 6)
            {
                converted = amount * 269.706;
                output11.Text = String.Format("Ft{0:0.00}", converted);
            }
            //converting to polish zloty
            else if (option == 7)
            {
                converted = amount * 3.61669;
                output11.Text = String.Format("{0:0.00}zł", converted);
            }
            //converting to romanian leu
            else if (option == 8)
            {
                converted = amount * 3.97242;
                output11.Text = String.Format("{0:0.00}Leu", converted);
            }
            //converting to swedish krona
            else if (option == 9)
            {
                converted = amount * 8.57797;
                output5.Text = String.Format("kr{0:0.00}", converted);
            }
        }

    }
}
