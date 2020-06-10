using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwilightReportingClient
{
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private async void btnGetData_ClickAsync(object sender, EventArgs e)
        {
            try

            {
                if ( !string.IsNullOrEmpty(txtLatitude.Text) || !string.IsNullOrEmpty(txtLongitude.Text))
                {
                    decimal latitude = Convert.ToDecimal(txtLatitude.Text);
                    decimal longitude = Convert.ToDecimal(txtLongitude.Text);

                    if (latitude < -90 || latitude > +90)
                    {
                        txtLatitude.Focus();
                        errorProviderForLatitude.SetError(txtLatitude, "Latitude must be between - 90 and 90  degrees inclusive.");
                        return;
                    }

                    else if (longitude < -180 || longitude > 180)
                    {
                        txtLongitude.Focus();
                        errorProviderForLongitude.SetError(txtLongitude, "Longitude must be between - 180 and 180  degrees inclusive.");
                        return;
                    }
                    else
                    {
                        SunriseSunsetApplicationService sa = new SunriseSunsetApplicationService();
                        var sunriseSunsetInfo = await sa.GetData(latitude, longitude);
                        lbl_sunriseSunsetInfo.Text = $"Sunrise is at { sunriseSunsetInfo.Sunrise.ToLocalTime().ToShortTimeString() }\n\n" +
                            $"Sunset is at { sunriseSunsetInfo.Sunset.ToLocalTime().ToShortTimeString() }";
                    }
                }
                else
                {
                    MessageBox.Show("Latitude/ Longitude values cannot be empty");
                }             
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid Lat/Long values");
            }
        }

        private void txtLatitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtLatitude.Text.IndexOf(".") != -1)
                e.Handled = true;
            return;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLongitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46 && txtLongitude.Text.IndexOf(".") != -1)
                e.Handled = true;
                return;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar !=46)
            {
                e.Handled = true;
            }

        }
    }
}
