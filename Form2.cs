namespace GenClass
{

    public partial class Form2 : Form
    {
        myCon con1;
        string _table;
        public Form2(myCon con, string table)
        {
            InitializeComponent();
            con1 = con;
            _table = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateClass();
        }

        async void CreateClass()
        {
            label1.Text = _table;

            var data = await column_info.Get_Columns(con1, _table);

            var txt = $"public class {_table}Model";
            txt += @"{";
            txt += Environment.NewLine;
            //txt += @"\n";
            foreach (var item in data)
            {
                var t = "";
                switch (item.DATA_TYPE)
                {
                    case "nvarchar":
                    case "varchar":
                    case "nchar":
                    case "char":
                    case "text":
                        t = "string";
                        break;

                    case "tinyint":
                    case "int":
                    case "bit":
                        t = "int";
                        break;

                    case "date":
                    case "datetime":
                    case "smalldatetime":
                        t = "DateTime";
                        break;

                    case "float":
                    case "numeric":
                        t = "double";
                        break;
                    default:
                        t = item.DATA_TYPE;
                        break;
                }

                txt += $"public {t} {item.name} {{ get; set; }}";
                txt += Environment.NewLine;
                //txt += @"\n";
            }


            txt += Environment.NewLine;
            txt += @"}";

            //txt += "\n\nvar dictionary = new Dictionary<string, object>\r\n{";
            //foreach (var item in data)
            //{
            //    txt += $"{{\"@{item.name}\",{item.name}}},\r\n";
            //}
            //txt += "};";



            //txt += "\n\n\n";
            //foreach (var item in data)
            //{
            //    txt += $"\"@{item.name},\" +\n";
            //}


            //var count = 0;
            txt += "\n\n\n";
            txt += $"insert into {_table} (";
            txt += string.Join(',', data.Select(x => $"{x.name}").ToList());
            txt += ")values(";
            txt += string.Join(',', data.Select(x => $"@{x.name}").ToList());
            txt += ")";

            //foreach (var item in data)
            //{

            //    if (count>= 5)
            //    {
            //        count = 0;
            //    }

            //    txt += $"\"@{item.name},\";

            //    count++;
            //}
            //foreach (var item in data)
            //{
            //    txt += $"\"@{item.name},\" +\n";
            //}


            richTextBox1.Text = txt;



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }
    }




    public class ServersList
    {
        public int id { get; set; }
        public string ServerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Entry_Date { get; set; }
        public string hname { get; set; }
        public string iname { get; set; }
    }
}
