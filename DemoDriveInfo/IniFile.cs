using System.Runtime.InteropServices;
using System.Text;

public class INIFile
{
    public string path { get; private set; }

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
    
    public INIFile()
    {
        String pathConfig = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        pathConfig += @"\data\Config.ini";
        path = pathConfig;
    }
    public void IniWriteValue(string Section, string Key, string Value)
    {
        WritePrivateProfileString(Section, Key, Value, this.path);
    }
    public string IniReadValue(string Section, string Key)
    {
        StringBuilder temp = new StringBuilder(255);
        int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
        return temp.ToString();
    }
}