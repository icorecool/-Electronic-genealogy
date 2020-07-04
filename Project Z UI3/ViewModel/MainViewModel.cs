using GalaSoft.MvvmLight;
using System.Security.Cryptography.X509Certificates;
using Project_Z_UI.UserModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace Project_Z_UI.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {

            InitUserCtDbBar();

        }



        public ObservableCollection<UserCtDb> UserCtDbs { get; set; }
        public void InitUserCtDbBar()
        {
            UserCtDbs = new ObservableCollection<UserCtDb>();
            UserCtDbs.Add(new UserCtDb() { username = "��ã�", usermotto = "hello!" });
        }


    }


      
}