namespace FileSystemProject
{
    internal class Program
    {
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

            //File.Create(fileTxt);
            //File.Delete(fileTxt);

            //File.Copy(fileTxt, "aaaa.txt", true);

            //File.Open(fileTxt, FileMode.OpenOrCreate);
            File.AppendAllLines(fileTxt, textStr);

        }
    }
}