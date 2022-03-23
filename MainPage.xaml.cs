using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double peso = Convert.ToDouble(txt_peso.Text);
            double altura = Convert.ToDouble(txt_altura.Text);

            double imc = peso / (altura * altura);

           txt_imc.Text = $" Seu IMC é de: {imc.ToString("0.00")}";

            if (imc < 18.5)
            {
                txt_table.Text = " Você está abaixo do peso";
            }
            else if (imc >= 18.5 & imc <= 24.9)
            {
                txt_table.Text = " Você está com o peso normal";
            }
            else if (imc >= 25 & imc <= 29.9)
            {
                txt_table.Text = " Você está com sobrepeso";
            }
            else if (imc >= 30 & imc <= 34.9)
            {
                txt_table.Text = " Você está com obesidade de grau I";
            }
            else if (imc >= 35 & imc <= 39.9)
            {
                txt_table.Text = " Você está com obesidade de grau II";
            }
              else if (imc >= 40)
            {
                txt_table.Text = " Você está com obesidade de grau III";
            }

            //referencia
            txt_referencia.Text = " Abaixo de 18,5 // Abaixo do peso" +
                "\n Entre o imc de 18,5 e 24,9 // Peso normal" +
                "\n Entre o imc de 25 e 29,9 // Sobrepeso" +
                "\n Entre o imc de 30 e 34,9 // Obesidade Grau I" +
                "\n Entre o imc de 35 e 39,9 // Obesidade  Grau II" +
                "\n Acima do imc de 40 // Obesidade Grau III "; 
        
        }
    }
}
