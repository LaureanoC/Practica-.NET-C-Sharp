using System.IO;

FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

while (lector.Length > lector.Position)
{
    Console.Write((char)lector.ReadByte());
}
lector.Close();