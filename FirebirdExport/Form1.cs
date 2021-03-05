using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace FirebirdExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPastaExportar.Text = Application.StartupPath + "\\Exportado\\";
        }
        List<string> listTables = new List<string>();

        public string GetConnectionString()
        {
            //User=SYSDBA;Password=MASTERKEY;Database=D:\Base_Clientes\Michel\ECONTAB.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=ISO8859_1;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;
            return $"User={textBoxUsuario.Text};Password={textBoxSenha.Text};Database={textBoxDatabase.Text};DataSource={textBoxServidor.Text};Port={textBoxPorta.Text};Dialect={textBoxDialect.Text};Charset={textBoxCharSet.Text};Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;";
        }

        private async void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //User=SYSDBA;Password=MASTERKEY;Database=D:\Base_Clientes\Michel\ECONTAB.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;
                //WIN1252
                //User=SYSDBA;Password=MASTERKEY;Database=D:\Base_Clientes\Michel\ECONTAB.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=ISO8859_1;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;
                listTables.Clear();
                string conn = GetConnectionString();
                using (FbConnection conexao = new FbConnection(conn))
                {
                    await conexao.OpenAsync();

                    string sqlTables = @"SELECT RDB$RELATION_NAME FROM RDB$RELATIONS
WHERE (RDB$SYSTEM_FLAG <> 1 OR RDB$SYSTEM_FLAG IS NULL) AND RDB$VIEW_BLR IS NULL
ORDER BY RDB$RELATION_NAME;";


                    using (FbCommand cmd = new FbCommand(sqlTables, conexao))
                    {
                        using (IDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            while (dr.Read())
                            {
                                listTables.Add(dr.GetString(0)?.Trim());
                            }
                        }
                    }
                }

                listBox1.DataSource = listTables;
                labelStatus.Text = "Conectado com sucesso. " + listTables.Count + " Tabelas Carregadas";
                
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao conectar. Erro: "+ ex.Message;
                if (ex.InnerException != null)
                {
                    labelStatus.Text += " / " +  ex.InnerException.Message;
                }
                
            }
        }

        private  void buttonExportarTabelas_Click(object sender, EventArgs e)
        {
            try
            {
                Parallel.ForEach(listTables, table => { ExportarTabela(table); });
                labelStatus.Text = "Tabelas Exportadas com sucesso";
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao exportar tabelas: "+ ex.Message;
            }
        }

        private async void ExportarTabela(string table)
        {
            using (FbConnection conexao = new FbConnection(GetConnectionString()))
            {
                await conexao.OpenAsync();
                DataSet ds = new DataSet();
                string sql = @"select * from " + table;
                using (FbCommand cmd = new FbCommand(sql, conexao))
                {
                    FileInfo fileSaida = new FileInfo(Path.Combine(textBoxPastaExportar.Text,table + ".csv"));
                    if (!fileSaida.Directory.Exists)
                        fileSaida.Directory.Create();

                    if (fileSaida.Exists)
                        fileSaida.Delete();

                    string s = textBoxSeparador.Text;
                    using (TextWriter tw = new StreamWriter(fileSaida.FullName, false, Encoding.Default))
                    {
                        using (IDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                tw.Write(dr.GetName(i) + s);
                            }
                            tw.WriteLine();

                            while (dr.Read())
                            {
                                for (int i = 0; i < dr.FieldCount; i++)
                                {
                                    if (dr.IsDBNull(i) || dr[i] == null)
                                        tw.Write("" + s);
                                    else
                                        tw.Write(dr[i].ToString().Replace("\r", "").Replace("\n", "") + s);
                                }
                                tw.WriteLine();
                            }
                        }

                        tw.Close();

                    }
                }
            }
        }

        private void buttonAbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Firebird/Interbase|*.fdb;*.gdb|All Files|*.*";
            diag.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            diag.Multiselect = false;
            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBoxDatabase.Text = diag.FileName;
            }

        }

        private void buttonFolderExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.SelectedPath = Application.StartupPath;
            diag.ShowNewFolderButton = true;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBoxPastaExportar.Text = diag.SelectedPath;
            }
        }

        private void buttonExportarSelecionada_Click(object sender, EventArgs e)
        {
            string table = listBox1.SelectedItem?.ToString();
            if (!String.IsNullOrWhiteSpace(table))
            {
                try
                {
                    ExportarTabela(table);
                    labelStatus.Text = "Tabela exportada com sucesso";

                }
                catch (Exception ex)
                {
                    labelStatus.Text = "Erro ao exportar tabela: "+ ex.Message;

                }
            }
        }

        private void labelStatus_TextChanged(object sender, EventArgs e)
        {
            if (labelStatus.Text.ToLower().Contains("erro"))
            {
                labelStatus.BackColor = Color.IndianRed;
            }
            else if (labelStatus.Text.ToLower().Contains("sucesso"))
            {
                labelStatus.BackColor = Color.LightGreen;
            }
            else
            {
                labelStatus.BackColor = Color.Empty;
            }
            
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                string table = listBox1.SelectedItem?.ToString();
                if (!String.IsNullOrWhiteSpace(table))
                {
                    DataSet ds = new DataSet();
                    using (FbConnection conexao = new FbConnection(GetConnectionString()))
                    {
                        await conexao.OpenAsync();

                        string sql = @"select * from " + table;
                        using (FbCommand cmd = new FbCommand(sql, conexao))
                        {
                            using (FbDataAdapter da = new FbDataAdapter(cmd))
                            {
                                da.Fill(ds);
                            }
                        }
                    }
                    dataGridViewDados.DataSource = ds.Tables[0];

                    labelStatus.Text = ds.Tables[0].Rows.Count + " Registros carregados";
                }
                else
                {
                    labelStatus.Text = "";
                }
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao carregar tabela: Erro: " + ex.Message;
            }
        }

    }
}
