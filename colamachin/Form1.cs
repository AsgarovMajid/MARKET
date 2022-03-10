using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itemmachine
{
    public partial class Form1 : Form
    {
        double capacity = 0;
        public Form1()
        {
            InitializeComponent();
        }

        items item = new items()
        {
            albeni = 100,
            bounty = 100,
            snickers = 100,
            cola = 100,
            fanta = 100,
            icetea = 100,
            mars = 100,
            pepsi = 100,
            Keks = 100
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            kcola.label1.Text = "Cola";
            kalbeni.label1.Text = "Albeni";
            kbounty.label1.Text = "Bounty";
            kfanta.label1.Text = "Fanta";
            kicetea.label1.Text = "ICE Tea";
            kpepsi.label1.Text = "Pepsi";
            ksnick.label1.Text = "Snickers";
            kKeks.label1.Text = "Keks";
            kmars.label1.Text = "Mars";
            kcola.label4.Text = "1.00";
            kfanta.label4.Text = "1.00";
            kicetea.label4.Text = "1.50";
            kpepsi.label4.Text = "1.00";
            ksnick.label4.Text = "0.80";
            kmars.label4.Text = "0.80";
            kKeks.label4.Text = "0.50";
            kalbeni.label4.Text = "0.50";
            kbounty.label4.Text = "0.80";

            if (File.Exists("maqazin.json"))
            {
                var jsonStr = File.ReadAllText("maqazin.json");
                item = JsonConvert.DeserializeObject<items>(jsonStr);
                kcola.label3.Text = item.cola.ToString();
                kmars.label3.Text = item.mars.ToString();
                kbounty.label3.Text = item.bounty.ToString();
                kalbeni.label3.Text = item.albeni.ToString();
                ksnick.label3.Text = item.snickers.ToString();
                kKeks.label3.Text = item.Keks.ToString();
                kpepsi.label3.Text = item.pepsi.ToString();
                kfanta.label3.Text = item.fanta.ToString();
                kicetea.label3.Text = item.icetea.ToString();


            }
            else
            {

                kcola.label3.Text = item.cola.ToString();
                kmars.label3.Text = item.mars.ToString();
                kbounty.label3.Text = item.bounty.ToString();
                kalbeni.label3.Text = item.albeni.ToString();
                ksnick.label3.Text = item.snickers.ToString();
                kKeks.label3.Text = item.Keks.ToString();
                kpepsi.label3.Text = item.pepsi.ToString();
                kfanta.label3.Text = item.fanta.ToString();
                kicetea.label3.Text = item.icetea.ToString();

            }
        }
        public void take_btn(object sender, EventArgs e)
        {

            if (sender == btn_cola){
                if (double.Parse(label3.Text) >= 1)
                {
                    capacity += 1;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.cola--;
                    kcola.label3.Text = item.cola.ToString();
                }}


            else if (sender == btn_fanta) {

                if (double.Parse(label3.Text) >= 1)
                {
                    capacity += 1;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.fanta--;
                    kfanta.label3.Text = item.fanta.ToString();

                } }


            else if (sender == btn_pepsi) {

                if (double.Parse(label3.Text) >= 1)
                {
                    capacity += 1;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.pepsi--;
                    kpepsi.label3.Text = item.pepsi.ToString();

                } }


            else if (sender == btn_icet)  {

                if (double.Parse(label3.Text) >= 1.5)
                {
                    capacity += 1.5;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.icetea--;
                    kicetea.label3.Text = item.icetea.ToString();

                } }


            else if (sender == btn_bounty){

                if (double.Parse(label3.Text) >= 0.8)
                {
                    capacity += 0.8;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.bounty--;
                    kbounty.label3.Text = item.bounty.ToString();

                }}


            else if (sender == btn_mars) {

                if (double.Parse(label3.Text) >= 0.8)
                {
                    capacity += 0.8;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.mars--;
                    kmars.label3.Text = item.mars.ToString();

                } }


            else if (sender == btn_snic) {

                if (double.Parse(label3.Text) >= 0.8)
                {
                    capacity += 0.8;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.snickers--;
                    ksnick.label3.Text = item.snickers.ToString();

                } }


            else if (sender == btn_Keks) {

                if (double.Parse(label3.Text) >= 0.5)
                {
                    capacity += 0.5;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.Keks--;
                    kKeks.label3.Text = item.Keks.ToString();

                }}


            else if (sender == btn_albeni){

                if (double.Parse(label3.Text) >= 1) {
                    capacity += 0.5;
                    label6.Text = capacity.ToString();
                    label4.Text = (double.Parse(label3.Text) - capacity).ToString();
                    item.albeni--;
                    kalbeni.label3.Text = item.albeni.ToString(); 

                } }  
        }


        private void q10_btn(object sender, EventArgs e)  {    label3.Text = (double.Parse(label3.Text) + 0.1).ToString(); }
        private void azn10_btn(object sender, EventArgs e) { label3.Text = (double.Parse(label3.Text) + 10).ToString(); }
        private void q50_btn(object sender, EventArgs e){  label3.Text = (double.Parse(label3.Text) + 0.5).ToString(); }
        private void q20_btn(object sender, EventArgs e){   label3.Text = (double.Parse(label3.Text) + 0.2).ToString();   }
        private void azn5_btn(object sender, EventArgs e) { label3.Text = (double.Parse(label3.Text) + 5).ToString(); }
        private void azn1_btn(object sender, EventArgs e)  { label3.Text = (double.Parse(label3.Text) + 1).ToString(); }

        private void buy_btn(object sender, EventArgs e)
        {
            var str = JsonConvert.SerializeObject(item, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("maqazin.json", str);
            label3.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
            MessageBox.Show("Success");
        }


    }
}
