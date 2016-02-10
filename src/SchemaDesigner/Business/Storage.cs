using System;

namespace SchemaDesigner.Business
{
    public static class Storage
    {
        public static string LocalStorageFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),"PS","SchemaDesigner");
    }
}
