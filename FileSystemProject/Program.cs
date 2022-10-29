using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileSystemProject
{
    [Serializable]
    class User
    {
        public string? FullName { set; get; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null) return null;
            BinaryFormatter binaryFormatter = new();
            MemoryStream memoryStream = new();
            binaryFormatter?.Serialize(memoryStream, obj);

            return memoryStream.ToArray();
        }

        static object ByteArrayToObject(byte[] byteArray)
        {
            BinaryFormatter binaryFormatter = new();
            MemoryStream memoryStream = new();

            memoryStream.Write(byteArray, 0, byteArray.Length);
            memoryStream.Seek(0, SeekOrigin.Begin);

            Object obj = binaryFormatter.Deserialize(memoryStream);

            return obj;
        }
        static void Main(string[] args)
        {
            // class DriveInfo

            //DriveInfo[] driveInfos = DriveInfo.GetDrives();

            //foreach(var drive in driveInfos)
            //{
            //    Console.WriteLine($"Drive name: {drive.Name}");
            //    Console.WriteLine($"Drive type: {drive.DriveType}");
            //    if(drive.IsReady)
            //    {
            //        Console.WriteLine($"Drive label: {drive.VolumeLabel}");
            //        Console.WriteLine($"Drive total space: {drive.TotalSize}");
            //        Console.WriteLine($"Drive free space: {drive.TotalFreeSpace}");
            //    }
            //    Console.WriteLine(new String('-', 20));
            //}


            // class Directory

            //Directory.CreateDirectory("images");
            ////Directory.CreateDirectory("../docs");
            //Directory.CreateDirectory("styles/files");
            //Directory.CreateDirectory("D:/rpo/works");


            //Directory.Delete("images");

            //string myPath = Directory.GetCurrentDirectory();
            //Console.WriteLine(myPath);
            //Console.WriteLine(new String('-', 20));


            //foreach(var dir in Directory.GetDirectories(myPath))
            //    Console.WriteLine(dir);
            //Console.WriteLine(new String('-', 20));

            //foreach (var dir in Directory.GetFiles(myPath))
            //    Console.WriteLine(dir);
            //Console.WriteLine(new String('-', 20));

            //foreach (var dir in Directory.GetFileSystemEntries(myPath))
            //    Console.WriteLine(dir);
            //Console.WriteLine(new String('-', 20));

            //Console.WriteLine(Directory.GetParent(myPath));
            //Console.WriteLine(new String('-', 20));



            // class DirectoryInfo

            //DirectoryInfo directory = new("images");
            //Console.WriteLine(directory.Exists ? "dir exists" : "dir not exists");
            //directory.Create();
            //Console.WriteLine(directory.Exists ? "dir exists" : "dir not exists");

            //foreach(var dir in directory.GetDirectories("i*"))
            //{
            //    Console.WriteLine(dir);
            //}

            //directory.MoveTo(@"newimages");

            // Console.WriteLine(directory.Parent);


            // File
            string[] textStr = { "jhghj jhgjhgh", "jhjhhjh jhjhjh", "qqwqpoioi oiiwq" };


            string fileTxt = "myfile.txt";


            string strText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            //File.Create(fileTxt);
            //File.Delete(fileTxt);
            //File.Copy(fileTxt, "aaaa.txt", true);
            //File.Open(fileTxt, FileMode.OpenOrCreate);

            //File.WriteAllLines(fileTxt, textStr);
            //File.WriteAllText(fileTxt, strText);

            //FileInfo fileInfo = new FileInfo(fileTxt);
            
            //using (FileStream stream = fileInfo.Open(FileMode.Open))
            //{
            //    byte[] buffer = Encoding.Default.GetBytes(strText);
            //    stream.Write(buffer);
            //}

            string fileBin = "myfile.dat";
            //User user = new() { Name = "Bob", Age = 24 };
            //using(FileStream stream = File.OpenWrite(fileBin))
            //{
            //    stream.Write(ObjectToByteArray(user));
            //}


            using (FileStream stream = File.OpenRead(fileBin))
            {
                try
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    User user = (User)ByteArrayToObject(buffer);
                    Console.WriteLine($"{user.FullName} {user.Age}");
                }
                catch(Exception e)
                {

                }
            }




        }
    }
}