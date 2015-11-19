using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Sqo;
using Windows.Storage;

// http://blogs.u2u.be/diederik/post/2015/09/08/Using-SQLite-on-the-Universal-Windows-Platform.aspx
// http://blog.chrisbriggsy.com/Using-SQLITE-in-Windows-10-IoT-Core-Insider-Preview/
namespace LocalData
{
    public sealed class LocalData
    {
        public LocalData()
        {
        }

        public async void storeData()
        { 
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFolder newFolder = await folder.CreateFolderAsync("Siaqodb", CreationCollisionOption.OpenIfExists);

            String folderName = newFolder.Path;
            System.Diagnostics.Debug.WriteLine("Folder Name: " + folderName);

            Siaqodb siaqodb = new Siaqodb(newFolder.Path + "\\Siaqodb");
            //Company company = new Company();
            //company.Name = "MyCompany";


            //siaqodb.StoreObject(company);

            //Employee employee1 = new Employee();
            //employee1.Employer = company;
            //employee1.FirstName = "John";
            //employee1.LastName = "Walter";

            //siaqodb.StoreObject(employee1);
        }

    }
}
