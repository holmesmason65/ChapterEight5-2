using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChapterEight5_2
{
    public partial class Form1 : Form
    {
        SqlConnection booksConnection;
        SqlCommand authorsCommand;
        SqlDataAdapter authorsAdapter;
        DataTable authorsTable;
        CurrencyManager authorsManager; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            booksConnection = new SqlConnection(@"Data Source=SQLEXPRESS;
                                                    AttachDbFileName=C:\Users\mholmes022726\source\repos\ChapterEight5-2\ChapterEight5-2\bin\Debug\netcoreapp3.1\SQLBooksDB.mdf;
                                                    Integrated Security=True; Connect Timeout=30; User Instance=True");
            booksConnection.Open(); 
        }
    }
}
