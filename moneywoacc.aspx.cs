using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class moneywoacc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btexchange_Click(object sender, EventArgs e)
    {
        double from = double.Parse(FromtextBox.Text);
        double exchange;
        if (FromDDbox.SelectedItem.Text == "Indian Rupee")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 2.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.013 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 1.14 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 7.53 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.087 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.32 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.036 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.011 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.057 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 1.60 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 2.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 1.00 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Pakistani Rupee")
        {
            if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 2.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.0061 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 0.52 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 3.14 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.040 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.15 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.016 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.0052 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.026 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.094 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.0085 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 0.72 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 1.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 0.45 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "United States Doller")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 164.25 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 74.43 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 84.96 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 586.10 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 6.50 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 24.00 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 2.70 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.86 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 4.24 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 15.45 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 1.40 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 118.77 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 199.51 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 74.19 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Bangladesh Taka")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 1.93 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.012 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.88 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 6.59 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.077 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.38 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.032 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.009 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.050 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.18 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.0025 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 1.93 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 2.35 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 0.87 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Central African")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 0.29 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.0018 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 0.15 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.13 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.012 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.018 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.0048 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.0015 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.0076 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.028 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.22 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 0.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 0.36 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 0.13 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Chinese Yuan")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 25.27 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.15 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 13.06 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 86.13 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 11.45 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 15.65 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.42 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.18 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.65 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 2.38 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 18.26 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 30.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 11.40 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Cuban Peso")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 2.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.013 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 1.14 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 7.53 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.087 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.32 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.036 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.011 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.057 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 1.60 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 2.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 1.00 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "East Caribbean Doller")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 60.78 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.71 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 31.44 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 207.25 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 2.41 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 2.41 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 27.56 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 1.25 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 1.57 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 5.27 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 1.64 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 43.95 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 73.82 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 27.44 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Euro")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 191.94 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 1.17 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 1.14 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 7.53 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 7.60 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 28.05 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 3.16 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.25 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 4.95 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 18.05 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 138.79 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 233.16 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 86.68 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Malaysian Ringgit")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 38.76 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.24 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 20.05 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 7.53 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.087 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 5.66 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.64 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.20 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.20 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.33 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 28.03 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 2.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 3.28 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 2.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.065 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 5.50 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 36.25 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 2.23 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 1.55 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.17 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.055 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 7.69 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 4.82 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 7.69 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 2.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 4.80 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Australian Doller")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 117.20 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 25.26 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 60.61 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 399.62 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 4.64 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 17.12 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 1.93 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.61 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.057 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 53.11 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 11.03 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 84.72 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 142.32 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 52.89 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Nepalese Rupee")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 1.38 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.0084 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 0.72 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 4.72 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.55 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.20 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.023 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.0072 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.036 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.63 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.012 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.13 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 1.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 0.62 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Sri Lankan")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 0.82 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.0050 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 0.43 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 2.31 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.033 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.12 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.036 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.011 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.057 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 0.60 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 0.077 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Russian Ruble")
            {
                exchange = 0.37 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
        else if (FromDDbox.SelectedItem.Text == "Russian Ruble")
        {
            if (ToDDbox.SelectedItem.Text == "Pakistani Rupee")
            {
                exchange = 2.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "United States Doller")
            {
                exchange = 0.013 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Bangladesh Taka")
            {
                exchange = 1.14 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Central African")
            {
                exchange = 7.53 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Chinese Yuan")
            {
                exchange = 0.087 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Cuban Peso")
            {
                exchange = 0.32 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "East Caribbean Doller")
            {
                exchange = 0.036 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Euro")
            {
                exchange = 0.011 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Malaysian Ringgit")
            {
                exchange = 0.057 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Indian Rupee")
            {
                exchange = 0.21 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Australian Doller")
            {
                exchange = 0.019 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Nepalese Rupee")
            {
                exchange = 1.60 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Sri Lankan")
            {
                exchange = 2.68 * from;
                toTextBox.Text = exchange.ToString();
            }
            else if (ToDDbox.SelectedItem.Text == "Maldivian Rufiyaa")
            {
                exchange = 1.00 * from;
                toTextBox.Text = exchange.ToString();
            }

        }
    }
    protected void FromDDbox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Fromtextbox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Btbackfree_Click(object sender, EventArgs e)
    {
        Response.Redirect("freeconversions.aspx");
    }
}
