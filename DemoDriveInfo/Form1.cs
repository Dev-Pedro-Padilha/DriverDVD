using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using DemoDriveInfo;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;


namespace DemoDriveInfo
{
    public partial class Form1 : Form
    {
        //DemoDriveInfo.exe /oout.txt /m290.02.323
        String[] teste = Sistema.RetornaParametro();
        string codigo = "";

        public Form1()
        {
            InitializeComponent();
            
            //pega parametro[2](codigo) passado pelo sistema
            codigo = teste[2];
            codigo.Replace("/m", "");

            label3.Text = teste[0];
            label4.Text = teste[1];
            label5.Text = teste[2];
            label6.Text = teste[3];
        }

        public bool Exe()
        {
            /*
            [290.02.323]
            TestaTamanho = true
            TestaBytes = true
            Driver = D
            NomeArquivo = padrao_dvd.sdk
            TamanhoArquivo = 1128040186
            QuantBytes = 60000000
            */

            INIFile ini = new INIFile();

            string driver = ini.IniReadValue(codigo, "driver");

            long TamanhoArquivoPadrao = long.Parse(ini.IniReadValue(codigo, "TamanhoArquivo"));

            bool error = false;
            //long TamanhoArquivoPadrao = 1128040186;

            //monta o caminho do arquivo na raiz do projeto
            String caminhoArquivo = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            caminhoArquivo += @"\data\TESTEDVD.txt";
            System.Diagnostics.Debug.WriteLine(caminhoArquivo);


            //Declara variavel com o caminho do arquivo no Disco D
            String pathdvd = "C:\\padrao_dvd.sdk";

            //Declara variavel com o caminho do arquivo padrao
            String pathpadrao = caminhoArquivo;


            //******************************************************************//
            //Compara Tamanho dos Arquivos
            long TamanhoArquivo = Arquivo.InfoFile(pathdvd);
            System.Diagnostics.Debug.WriteLine(TamanhoArquivo);
            label2.Text = TamanhoArquivo.ToString();
            Application.DoEvents();

            if (TamanhoArquivo == TamanhoArquivoPadrao)
            {
                error = true;
            }
            else
            {
                error = false;
            }
            //******************************************************************//


            //******************************************************************//
            if (error)
            {
                //Compara Caracteres dos Arquivos

                //Pega caracteres do arquivo padrao
                lblDesc.Text = "Lendo arquivo padrão";
                Application.DoEvents();
                String padrao = Arquivo.ReadFile(pathpadrao, 100000);

                //Pega caracteres do arquivo no dvd
                lblDesc.Text = "Lendo arquivo dvd";
                Application.DoEvents();
                String dvd = Arquivo.ReadFile(pathdvd, 100000);

                //Compara arquivo padrão com arquivo lido no dvd
                if (padrao == dvd)
                {
                    error = true;
                }
                else
                {
                    error = false;
                }
            }
            //******************************************************************//

            return error;
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);

            bool teste = Exe();

            if (teste)
            {
                System.Diagnostics.Debug.WriteLine("Teste OK!");
                lblDesc.Text = "Teste OK!";
                Application.DoEvents();
                Sistema.WriteFile(100);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Erro no teste!");
                lblDesc.Text = "Erro no teste!";
                Application.DoEvents();
                Sistema.WriteFile(500);
            }

            Thread.Sleep(milliseconds);
        }

    }
}