namespace DemoDriveInfo
{
    public class Sistema
    {
        //Função que recebe os parametros enviados na chamada do executavel
        public static string[] RetornaParametro()
        {
            //Salva os argumentos recebidos na variavel args
            string[] args = Environment.GetCommandLineArgs();
            return args;
        }

        //Função que escreve no arquivo "out.txt" a saida do teste
        public static void WriteFile(int cod)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\log\\out.txt");

                if (cod == 100)
                {
                    //Write a line of text
                    sw.WriteLine("100");
                    //Write a line of text
                    sw.WriteLine("TESTE OK");

                    //Close the file
                    sw.Close();

                }
                else if (cod == 1000)
                {
                    //Write a line of text
                    sw.WriteLine("1000");
                    //Write a line of text
                    sw.WriteLine("Teste Cancelado Pelo Usuário");

                    //Close the file
                    sw.Close();

                }
                else
                {
                    //Write a line of text
                    sw.WriteLine("500");

                    //Close the file
                    sw.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            //Encerra app
            Application.Exit();
            global::System.Environment.Exit(1);
        }
    }
}