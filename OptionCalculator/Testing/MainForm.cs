using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Options
{
    public partial class MainForm : Form
    {
        static Greeks greeks;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDayInc_Click(object sender, EventArgs e)
        {
            dtpCondDate.Value = dtpCondDate.Value.AddDays(1);
        }             

        private void btnDayDesc_Click(object sender, EventArgs e)
        {
            dtpCondDate.Value = dtpCondDate.Value.AddDays(-1);
        }

        private void btnBAInc_Click(object sender, EventArgs e)
        {
            if (txtPriceBA.Text == "") MessageBox.Show("Введите значение");
            double p;
            try
            {
                p = Convert.ToDouble(txtPriceBA.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

            }
            if (p == 0)
            { 
                MessageBox.Show("Задано нулевое значение БА"); 
                return;
            }
            p = p * 1.1;
            txtPriceBA.Text = p.ToString("F");

        }

        private void btnBADesc_Click(object sender, EventArgs e)
        {
            if (txtPriceBA.Text == "") MessageBox.Show("Введите значение");
            double p;
            try
            {
                p = Convert.ToDouble(txtPriceBA.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

            }
            if (p == 0)
            {
                MessageBox.Show("Задано нулевое значение БА");
                return;
            }
            p = p / 1.1;
            txtPriceBA.Text = p.ToString("F");
        }

        private void btnVolInc_Click(object sender, EventArgs e)
        {
            //txtVolat
            if (txtVolat.Text == "") MessageBox.Show("Введите значение");
            double p;
            try
            {
                p = Convert.ToDouble(txtVolat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

            }
            if (p == 0)
            {
                MessageBox.Show("Задано нулевое значение волатильности");
                return;
            }
            p = p * 1.1;
            txtVolat.Text = p.ToString("F");
        }

        private void btnVolDesc_Click(object sender, EventArgs e)
        {
            if (txtVolat.Text == "") MessageBox.Show("Введите значение");
            double p;
            try
            {
                p = Convert.ToDouble(txtVolat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

            }
            if (p == 0)
            {
                MessageBox.Show("Задано нулевое значение волатильности");
                return;
            }
            p = p / 1.1;
            txtVolat.Text = p.ToString("F");
        }

        private void btnRiscInc_Click(object sender, EventArgs e)
        {
            //txtRisk
            if (txtRisk.Text == "") MessageBox.Show("Введите значение");
            double p;
            try
            {
                p = Convert.ToDouble(txtRisk.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

            }
            if (p == 0)
            {
                MessageBox.Show("Задано нулевое значение безриск ставки");
                return;
            }
            p = p * 1.1;
            txtRisk.Text = p.ToString("F");
        }

        private void btnRiscDesc_Click(object sender, EventArgs e)
        {
            if (txtRisk.Text == "") MessageBox.Show("Введите значение");
            double p;
            try
            {
                p = Convert.ToDouble(txtRisk.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {

            }
            if (p == 0)
            {
                MessageBox.Show("Задано нулевое значение безриск ставки");
                return;
            }
            p = p / 1.1;
            txtRisk.Text = p.ToString("F");
        }

        private bool CondChecked()
        {
            bool res=true;
            if (dtpCondDate.Value> dtpOptExp.Value) res = false;
            if (txtPriceBA.Text == "") res = false;
            if (txtVolat.Text == "") res = false;
            if (txtRisk.Text == "") res = false;
            return res;
        }

        private bool OptChecked()
        {
            bool res=true;
            if (dtpCondDate.Value > dtpOptExp.Value) res = false;
            if (txtStrike.Text == "") res = false;
            if (cmbOtpType.Text == "") res = false;
            return res;
        }

        private void Calculating()
        {
            //Greeks g;
            if (!CondChecked()||!OptChecked())
            {
                MessageBox.Show("Проверьте условия расчета и параметры опциона");
                return;
            }
            Condition cond;
            cond.priceBA = Convert.ToDouble(txtPriceBA.Text);
            cond.currentDate = Convert.ToDateTime(dtpCondDate.Value);
            cond.volatility = Convert.ToDouble(txtVolat.Text)/100;
            cond.ratio = Convert.ToDouble(txtRisk.Text)/100;

            Option opt;
            opt.ExpireDate = Convert.ToDateTime(dtpOptExp.Value);
            opt.Strike = Convert.ToDouble(txtStrike.Text);
            if (cmbOtpType.Text=="CALL") opt.Type = OptionType.call;
            else opt.Type = OptionType.put;

            greeks = opt.GetGreeks(cond);
            return;
        }

        private void ShowGreeks()
        {
            lbTheorPrice.Text = greeks.TheorPrice.ToString("F");
            lbDelta.Text = greeks.Delta.ToString("F");
            lbGamma.Text = greeks.Gamma.ToString("P");
            lbVega.Text = greeks.Vega.ToString("F");
            lbTheta.Text = greeks.Theta.ToString("F");
            lbRo.Text = greeks.Ro.ToString("F");
        }

        private void bnCalculate_Click(object sender, EventArgs e)
        {
            
            Calculating();
            ShowGreeks();
            
            /*
            MessageBox.Show("Тип.текст = "+ cmbOtpType.Text);
            MessageBox.Show("Тип.значение = " + cmbOtpType.SelectedValue);
            */
        }
    }
}
