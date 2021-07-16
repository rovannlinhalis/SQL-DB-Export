using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace DBSQLExport
{
    public partial class Form1 : Form
    {
        Random r;
        public Form1()
        {
            r = new Random();
            InitializeComponent();
            textBoxPastaExportar.Text = Application.StartupPath + "\\Exportado\\";
        }
        List<string> listTables = new List<string>();

        public string GetConnectionString()
        {
            //User=SYSDBA;Password=MASTERKEY;Database=D:\Base_Clientes\Michel\ECONTAB.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=ISO8859_1;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;
            return $"User={textBoxUsuario.Text};Password={textBoxSenha.Text};Database={textBoxDatabase.Text};DataSource={textBoxServidor.Text};Port={textBoxPorta.Text};Dialect={textBoxDialect.Text};Charset={textBoxCharSet.Text};Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;";
        }

        public static IDbConnection GetConnection(BancosDeDados db, string user, string database, string host, string senha, string porta, string dialect, string charset)
        {
            IDbConnection conexao = null;
            if (db == BancosDeDados.FireBird)
            {
                //conexao = new FirebirdSql.Data.FirebirdClient.FbConnection("User=" + emp.DbUser + ";Password=" + emp.DbSenha + ";Database=" + emp.DbDataBase + ";DataSource=" + emp.DbHost + ";Port=" + emp.DbPorta + ";Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;");
                //conexao = new FirebirdSql.Data.FirebirdClient.FbConnection($"User={user};Password={senha};Database={bd};DataSource={host};Port={porta};Dialect={dialect};Charset={charset};Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;");
                conexao = new FirebirdSql.Data.FirebirdClient.FbConnection("User=" + user + ";Password=" +senha + ";Database=" + database + ";DataSource=" + host + ";Port=" + porta+ ";Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;");
            }
            else if (db == BancosDeDados.SQLServer)
            {
                conexao = new System.Data.SqlClient.SqlConnection("Server=" + host + "," + porta + ";Database=" + database + ";User Id=" + user + ";Password=" + senha + ";");
            }
            else if (db == BancosDeDados.MySQL)
            {
                conexao = new MySql.Data.MySqlClient.MySqlConnection("Server=" + host + ";Port=" + porta + ";Database=" + database + ";Uid=" + user + ";Pwd=" + senha + ";");
            }
            else if (db == BancosDeDados.PostgreSQL)
            {
                conexao = new Npgsql.NpgsqlConnection("Server=" + host + ";Port=" + porta + ";Database=" + database + ";User Id=" + user + ";Password=" + senha + ";");
            }
            else if (db == BancosDeDados.ODBC)
            {
                conexao = new System.Data.Odbc.OdbcConnection("DNS=" + host);
            }

            return conexao;
        }
        public static IDbCommand GetCommand(BancosDeDados db, string query)
        {
            IDbCommand cmd = null;
            if (db == BancosDeDados.FireBird)
            {
                cmd = new FirebirdSql.Data.FirebirdClient.FbCommand(query);
            }
            else if (db == BancosDeDados.SQLServer)
            {
                cmd = new System.Data.SqlClient.SqlCommand(query);
            }
            else if (db == BancosDeDados.MySQL)
            {
                cmd = new MySql.Data.MySqlClient.MySqlCommand(query);
            }
            else if (db == BancosDeDados.PostgreSQL)
            {
                cmd = new Npgsql.NpgsqlCommand(query);
            }
            else if (db == BancosDeDados.ODBC)
            {
                cmd = new System.Data.Odbc.OdbcCommand(query);
            }
            cmd.CommandTimeout = 180000;
            return cmd;
        }
        public static IDbDataAdapter GetDbAdaptaer(BancosDeDados db,  IDbCommand cmd)
        {
            IDbDataAdapter da = null;
            if (db == BancosDeDados.FireBird)
            {
                da = new FirebirdSql.Data.FirebirdClient.FbDataAdapter((FbCommand)cmd);
            }
            else if (db == BancosDeDados.SQLServer)
            {
                da = new System.Data.SqlClient.SqlDataAdapter((SqlCommand)cmd);
            }
            else if (db == BancosDeDados.MySQL)
            {
                da = new MySql.Data.MySqlClient.MySqlDataAdapter((MySql.Data.MySqlClient.MySqlCommand)cmd);
            }
            else if (db == BancosDeDados.PostgreSQL)
            {
                da = new Npgsql.NpgsqlDataAdapter((Npgsql.NpgsqlCommand)cmd);
            }
            else if (db == BancosDeDados.ODBC)
            {
                da = new System.Data.Odbc.OdbcDataAdapter((System.Data.Odbc.OdbcCommand)cmd);
            }
            return da;
        }
        public static string GetSQLTables(BancosDeDados db, string schema)
        {
            if (db == BancosDeDados.FireBird)
            {
                return @"SELECT RDB$RELATION_NAME FROM RDB$RELATIONS
WHERE (RDB$SYSTEM_FLAG <> 1 OR RDB$SYSTEM_FLAG IS NULL) AND RDB$VIEW_BLR IS NULL
ORDER BY RDB$RELATION_NAME;";
            }
            else if (db == BancosDeDados.SQLServer)
            {
                return @"SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='"+ schema + "'";

            }
            else if (db == BancosDeDados.MySQL)
            {
                return @"SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA='" + schema + "';";

            }
            else if (db == BancosDeDados.PostgreSQL)
            {
                return @"SELECT table_name FROM information_schema.tables WHERE table_type ='BASE TABLE' and table_schema='" + schema+"';";

            }
            else // (db == BancosDeDados.ODBC)
            {
                return @"";

            }
        }

        private  void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.DataSource = null;
                BancosDeDados sgdb = (BancosDeDados)comboBoxSGDB.SelectedItem;
                //User=SYSDBA;Password=MASTERKEY;Database=D:\Base_Clientes\Michel\ECONTAB.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;
                //WIN1252
                //User=SYSDBA;Password=MASTERKEY;Database=D:\Base_Clientes\Michel\ECONTAB.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=ISO8859_1;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;
                listTables.Clear();
                string conn = GetConnectionString();
                using (IDbConnection conexao = GetConnection(sgdb, textBoxUsuario.Text, textBoxDatabase.Text, textBoxServidor.Text, textBoxSenha.Text, textBoxPorta.Text, textBoxDialect.Text, textBoxCharSet.Text))
                {
                    conexao.Open();


                    string sqlTables = GetSQLTables(sgdb, sgdb == BancosDeDados.PostgreSQL ? "public" : textBoxDatabase.Text);


                    using (IDbCommand cmd = GetCommand(sgdb, sqlTables)) // new FbCommand(sqlTables, conexao))
                    {
                        if (cmd != null)
                        {
                            cmd.Connection = conexao;



                            using (IDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    listTables.Add(dr.GetString(0)?.Trim());
                                }
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
                BancosDeDados sgdb = (BancosDeDados)comboBoxSGDB.SelectedItem;


                Parallel.ForEach(listTables, table => { ExportarTabela(table, sgdb); });
                labelStatus.Text = "Tabelas Exportadas com sucesso";
            }
            catch (Exception ex)
            {
                labelStatus.Text = "Erro ao exportar tabelas: "+ ex.Message;
            }
        }

        private  void ExportarTabela(string table, BancosDeDados sgdb)
        {
           
            using (IDbConnection conexao = GetConnection(sgdb, textBoxUsuario.Text, textBoxDatabase.Text, textBoxServidor.Text, textBoxSenha.Text, textBoxPorta.Text, textBoxDialect.Text, textBoxCharSet.Text)) // new FbConnection(GetConnectionString()))
            {
                conexao.Open();
                DataSet ds = new DataSet();
                string sql = @"select * from " + table;
                using (IDbCommand cmd = GetCommand(sgdb, sql))// new FbCommand(sql, conexao))
                {
                    if (cmd != null)
                    {

                        cmd.Connection = conexao;

                        FileInfo fileSaida = new FileInfo(Path.Combine(textBoxPastaExportar.Text, table + ".csv"));
                        if (!fileSaida.Directory.Exists)
                            fileSaida.Directory.Create();

                        if (fileSaida.Exists)
                            fileSaida.Delete();

                        string s = textBoxSeparador.Text;
                        using (TextWriter tw = new StreamWriter(fileSaida.FullName, false, Encoding.Default))
                        {
                            using (IDataReader dr =  cmd.ExecuteReader())
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
                                        //if (dr[i] == null || dr.IsDBNull(i))
                                        //    tw.Write("" + s);
                                        //else

                                            tw.Write((dr[i]?.ToString().Replace("\r", "").Replace("\n", "").Replace(s,"/") ?? "") + s);
                                    }
                                    tw.WriteLine();
                                }
                            }

                            tw.Close();

                        }
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
                    BancosDeDados sgdb = (BancosDeDados)comboBoxSGDB.SelectedItem;
                    ExportarTabela(table, sgdb);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BancosDeDados sgdb = (BancosDeDados)comboBoxSGDB.SelectedItem;


                string table = listBox1.SelectedItem?.ToString();
                if (!String.IsNullOrWhiteSpace(table))
                {
                    DataSet ds = new DataSet();
                    using (IDbConnection conexao = GetConnection(sgdb, textBoxUsuario.Text, textBoxDatabase.Text, textBoxServidor.Text, textBoxSenha.Text, textBoxPorta.Text, textBoxDialect.Text, textBoxCharSet.Text)) // new FbConnection(GetConnectionString()))
                    {
                        conexao.Open();

                        string sql = @"select * from " + table;
                        using (IDbCommand cmd = GetCommand(sgdb, sql)) // new FbCommand(sql, conexao))
                        {
                            if (cmd != null)
                            {
                                cmd.Connection = conexao;
                                IDbDataAdapter da = GetDbAdaptaer(sgdb, cmd);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSGDB.DataSource = Enum.GetValues(typeof(BancosDeDados));

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Visible = true;
                textBoxSQLQuery.Visible = false;
                buttonTabela.Enabled = true;
                buttonExportarTodasTabelas.Enabled = true;
                buttonSQLQuery.Enabled = false;
                buttonExecutaQuery.Enabled = false;
            }
            else
            {
                listBox1.Visible = false;
                textBoxSQLQuery.Visible = true;
                buttonTabela.Enabled = false;
                buttonExportarTodasTabelas.Enabled = false;
                buttonSQLQuery.Enabled = true;
                buttonExecutaQuery.Enabled = true;
                textBoxSQLQuery.Dock = DockStyle.Fill;
            }
        }

        private void buttonExecutaQuery_Click(object sender, EventArgs e)
        {
            try
            {
                BancosDeDados sgdb = (BancosDeDados)comboBoxSGDB.SelectedItem;


                string table = listBox1.SelectedItem?.ToString();
                if (!String.IsNullOrWhiteSpace(table))
                {
                    DataSet ds = new DataSet();
                    using (IDbConnection conexao = GetConnection(sgdb, textBoxUsuario.Text, textBoxDatabase.Text, textBoxServidor.Text, textBoxSenha.Text, textBoxPorta.Text, textBoxDialect.Text, textBoxCharSet.Text)) // new FbConnection(GetConnectionString()))
                    {
                        conexao.Open();

                        string sql = textBoxSQLQuery.Text;
                        using (IDbCommand cmd = GetCommand(sgdb, sql)) // new FbCommand(sql, conexao))
                        {
                            if (cmd != null)
                            {
                                cmd.Connection = conexao;
                                IDbDataAdapter da = GetDbAdaptaer(sgdb, cmd);
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

        private void buttonSQLQuery_Click(object sender, EventArgs e)
        {
            BancosDeDados sgdb = (BancosDeDados)comboBoxSGDB.SelectedItem;

            using (IDbConnection conexao = GetConnection(sgdb, textBoxUsuario.Text, textBoxDatabase.Text, textBoxServidor.Text, textBoxSenha.Text, textBoxPorta.Text, textBoxDialect.Text, textBoxCharSet.Text)) // new FbConnection(GetConnectionString()))
            {
                conexao.Open();
                DataSet ds = new DataSet();
                string sql = textBoxSQLQuery.Text;
                using (IDbCommand cmd = GetCommand(sgdb, sql))// new FbCommand(sql, conexao))
                {
                    if (cmd != null)
                    {

                        cmd.Connection = conexao;

                        FileInfo fileSaida = new FileInfo(Path.Combine(textBoxPastaExportar.Text,"CustomQuery"+ DateTime.Now.ToString("yy-MM-ddHHmmssttt")  + ".csv"));
                        if (!fileSaida.Directory.Exists)
                            fileSaida.Directory.Create();

                        if (fileSaida.Exists)
                            fileSaida.Delete();

                        string s = textBoxSeparador.Text;
                        using (TextWriter tw = new StreamWriter(fileSaida.FullName, false, Encoding.Default))
                        {
                            using (IDataReader dr = cmd.ExecuteReader())
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
                                        //if (dr[i] == null || dr.IsDBNull(i))
                                        //    tw.Write("" + s);
                                        //else
                                        tw.Write((dr[i]?.ToString().Replace("\r", "").Replace("\n", "").Replace(s, "/") ?? "") + s);
                                    }
                                    tw.WriteLine();
                                }
                            }

                            tw.Close();

                        }
                    }
                }
            }
        }
    }
}
