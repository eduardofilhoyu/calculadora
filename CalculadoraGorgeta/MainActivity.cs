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

        private void BtnCalcular_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void btnCalcular_Click(object sender, ItemEventArgs e)
        {
            double valor = 0;
            double.Parse(edtValor.Text);
            double valorTotal = 0;

            valor = valor * .10;
            valorTotal = valorTotal + valor;
            txtGorgeta.Text = valor.ToString();
            txtValorTotal.Text = valorTotal.ToString();
        }
    }
}

