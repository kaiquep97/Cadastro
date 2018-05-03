using System;
using System.IO;
using System.Text;
using Cadastro.Droid;
using Cadastro.Interfaces;

[assembly:Xamarin.Forms.Dependency(typeof(File_Android))]
namespace Cadastro.Droid
{
    public class File_Android : IFile
    {
        public bool SaveFile(string content, string nameFile = "relatorio.csv")
        {
            var path = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, nameFile);

            try
            {
                File.WriteAllText(path, content, Encoding.UTF8);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}