using System.Diagnostics;

namespace GenClass
{
    public partial class Form1 : Form
    {
        myCon myCon = null;

        AutoCompleteStringCollection _auto = new AutoCompleteStringCollection();
        public Form1()
        {
            InitializeComponent();

            _auto.Add("192.168.84.8");
            _auto.Add("192.168.84.9");
            _auto.Add("192.168.84.10");
            _auto.Add("192.168.84.13");
            _auto.Add("192.168.84.15");
            _auto.Add("192.168.84.18");


            _auto.Add("10.0.250.9");
            _auto.Add("10.0.253.15");
            _auto.Add("10.0.253.16");
            _auto.Add("10.0.253.60");

        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            var db_name = "master";
            DB_Type dB_Type;
            if (cboType.Text.ToLower() == "sql")
            {
                dB_Type = DB_Type.SQL;
            }
            else
            {
                dB_Type = DB_Type.mySQL;
                db_name = "sys";
            }


            myCon = new myCon(dB_Type, txtUsername.Text, txtPassword.Text, txtServer.Text, db_name);

            var dbs = await dbase_info.Get(myCon);

            cboDb.DataSource = dbs;
            cboDb.ValueMember = "Name";
            cboDb.DisplayMember = "Name";
        }

        private async void cboDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDb.SelectedValue != null && cboDb.Text.Contains("GenClass") == false)
            {
                myCon.Database = cboDb.Text;
                var tables = await column_info.Get_Table(myCon, cboDb.Text);
                checkedListBox1.Items.Clear();

                label6.Text = cboDb.SelectedValue.ToString();


                foreach (var item in tables.OrderBy(x=>x.name))
                {
                    checkedListBox1.Items.Add(item.name);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboType.Text = "SQL";

            txtServer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtServer.AutoCompleteCustomSource = _auto;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<Form2> f = new List<Form2>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                Form2 form2 = new Form2(myCon, item.ToString());
                form2.Size = new Size(400, 300);
                form2.Text = item.ToString();
                f.Add(form2);
            }

            foreach (var item in f)
            {
                item.Show();
            }
        }
    }
}
