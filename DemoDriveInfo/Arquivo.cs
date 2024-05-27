namespace DemoDriveInfo
{
    public static class Arquivo
    {


        //Função que lista informações referentes ao arquivo passado por parametro
        public static long InfoFile(String path)
        {
            FileInfo infoArquivo = new FileInfo(path);
            //System.Diagnostics.Debug.WriteLine("\n\nInformações arquivo: " + path);
            //System.Diagnostics.Debug.WriteLine("Nome: " + infoArquivo.Name);
            //System.Diagnostics.Debug.WriteLine("Extensão: " + infoArquivo.Extension);
            //System.Diagnostics.Debug.WriteLine("Tamanho: " + infoArquivo.Length + " ou " + FormataBytes(infoArquivo.Length));
            //System.Diagnostics.Debug.WriteLine("Data de criação: " + infoArquivo.CreationTime);
            //System.Diagnostics.Debug.WriteLine("Diretório: " + infoArquivo.DirectoryName);
            long LenghtFile = infoArquivo.Length;

            return LenghtFile;
        }

        public static String ReadFile(String path, int length)
        {

            StreamReader cr = new StreamReader(path);

            //abrindo um arquivo texto
            //x = File.OpenText(path);

            global::System.Diagnostics.Debug.WriteLine("\n\nConteudo do arquivo: " + path);
            //449473
            String result = "";
            int i = 0;
            while (i < length)
            {
                //le conteúdo da linha
                String linha = cr.ReadLine();

                foreach (char c in linha.ToCharArray())
                {
                    result = result + c;
                    //escreve na tela o conteúdo da linha

                    i++;
                }
                //escreve na tela o conteúdo da linha
                //System.Diagnostics.Debug.WriteLine(linha);
            }
            global::System.Diagnostics.Debug.WriteLine("ok");
            //após sair do loop, é porque leu todo o conteúdo, então
            //temos que fechar o arquivo texto que está aberto
            cr.Close();


            return result;

        }

        public static string FormataBytes(long bytes)
        {
            if (bytes >= 0x1000000000000000) { return ((double)(bytes >> 50) / 1024).ToString("0.### EB"); }
            if (bytes >= 0x4000000000000) { return ((double)(bytes >> 40) / 1024).ToString("0.### PB"); }
            if (bytes >= 0x10000000000) { return ((double)(bytes >> 30) / 1024).ToString("0.### TB"); }
            if (bytes >= 0x40000000) { return ((double)(bytes >> 20) / 1024).ToString("0.### GB"); }
            if (bytes >= 0x100000) { return ((double)(bytes >> 10) / 1024).ToString("0.### MB"); }
            if (bytes >= 0x400) { return ((double)(bytes) / 1024).ToString("0.###") + " KB"; }
            return bytes.ToString("0 Bytes");
        }

        private static bool ExisteDiretorio(String pathdirectory)
        {
            //Ve se diretorio existe - "C:\\"
            bool existeDiretorio = Directory.Exists(pathdirectory);

            if (existeDiretorio)
            {
                //label1.Text = "Diretorio C:\\ existe";
                return true;
            }
            else
            {
                //label1.Text = "Diretorio C:\\ não existe";
                return false;
            }
        }

        private static bool ExisteArquivo(String pathfile)
        {
            //Ve se arquivo existe - "C:\\teste.txt"
            bool existeArquivo = File.Exists(pathfile);

            if (existeArquivo)
            {
                //label2.Text = "Arquivo teste.txt existe";
                return true;
            }
            else
            {
                //label2.Text = "Arquivo teste.txt não existe";
                return false;
            }
        }
    }
}