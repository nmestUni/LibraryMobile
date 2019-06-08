using System;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace LibraryApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        private Button _loginBtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_layout);

            _loginBtn = FindViewById<Button>(Resource.Id.btn_login);
            _loginBtn.Click += _loginBtn_Click;


        }

        private void _loginBtn_Click(object sender, EventArgs e)
        {

            string message = string.Empty;
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(ApplicationContext);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutInt("UserID", 1);
            editor.Apply();
            StartActivity(typeof(MainActivity));
            //_generatedCode = Security.GetSecurityCode(_passwordTxt.Text);
            //progressDialog = new ProgressDialog(this);
            //progressDialog.SetTitle("იტვირთება");
            //progressDialog.Show();
            //securityClient.AutorizeUserAsync(_generatedCode, null, _nameTxt.Text, message);
        }

    }
}

