using Android.App;
using Android.Widget;
using Android.OS;

namespace CalculadoraGorgeta
{
    [Activity(Label = "CalculadoraGorgeta", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText edtValor;
        Button btnCalcular;
        TextView txtGorgeta;
        TextView txtValorTotal;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            edtValor = FindViewById<EditText>(Resource.Id.edtValor);
            btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
            txtGorgeta = FindViewById<TextView>(Resource.Id.txtGorgeta);
            txtValorTotal = FindViewById<TextView>(Resource.Id.txtValorTotal);


            btnCalcular.Click += BtnCalcular_Click;


        }
        void BtnCalcular_Click(object sender, System.EventArgs e)
        {
        
            double valor = 0;
            valor = double.Parse(edtValor.Text);
            double valorTotal = 0;



            valor = valor * .10;
            valorTotal=valor * .10 + valor;
            txtGorgeta.Text = valor.ToString();
            txtValorTotal.Text =valorTotal.ToString();


        }

        
    }
}

