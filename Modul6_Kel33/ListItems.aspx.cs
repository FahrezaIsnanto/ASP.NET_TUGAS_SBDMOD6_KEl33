using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Modul6_Kel33
{
    public partial class ListItems : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=10.0.10.172;Initial Catalog=TugasMod6DB_Kel33;User ID=sa;Password=dc123";
            con.Open();
            if (!Page.IsPostBack)
            {
                refreshAllGridView();
            }
        }

        public void refreshAllGridView()
        {
            DataShowMhs();
            DataShowJurusan();
            DataShowJoin();
        }
        public void DataShowMhs()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from MAHASISWA";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();

            GridViewMhs.DataSource = ds;
            GridViewMhs.DataBind();
        }

        public void DataShowJurusan()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from JURUSAN";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();

            GridViewJurusan.DataSource = ds;
            GridViewJurusan.DataBind();
        }

        public void DataShowJoin()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from MAHASISWA_JURUSAN";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();

            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
            con.Close();
        }

        protected void btnAddMhs_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into MAHASISWA(ID_MAHASISWA, ID_JURUSAN, NAMA_MAHASISWA, ALAMAT_MAHASISWA, HOBI_MAHASISWA) values('" + txtNimMhs.Text + "', '" + txtIdJurusanMhs.Text.ToString() + "', '" + txtNamaMhs.Text.ToString() + "','" + txtAlamatMhs.Text.ToString() + "','" + txtHobiMhs.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            refreshAllGridView();
        }

        protected void btnDeleteMhs_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from MAHASISWA where ID_MAHASISWA='" + txtNimMhs.Text.ToString() + "'";
            cmd.Connection = con; 
            cmd.ExecuteNonQuery();
            refreshAllGridView();
        }

        protected void btnUpdateMhs_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update MAHASISWA set ID_JURUSAN='" + txtIdJurusanMhs.Text.ToString() + "', NAMA_MAHASISWA='" + txtNamaMhs.Text.ToString() + "',ALAMAT_MAHASISWA='" + txtAlamatMhs.Text.ToString() + "',HOBI_MAHASISWA='" + txtHobiMhs.Text.ToString() + "' WHERE ID_MAHASISWA='" + txtNimMhs.Text.ToString() + "'";

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            refreshAllGridView();
        }

        protected void btnClearMhs_Click(object sender, EventArgs e)
        {
            txtNimMhs.Text = null;
            txtIdJurusan.Text = null;
            txtNamaMhs.Text = null;
            txtAlamatMhs.Text = null;
            txtHobiMhs.Text = null;
        }

        protected void btnAddJurusan_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into JURUSAN(ID_JURUSAN, NAMA_JURUSAN) values('" + txtIdJurusan.Text + "', '" + txtNamaJurusan.Text.ToString() + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            refreshAllGridView();
        }

        protected void btnDeleteJurusan_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from JURUSAN where ID_JURUSAN='" + txtIdJurusan.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            refreshAllGridView();
        }

        protected void btnUpdateJurusan_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update JURUSAN set NAMA_JURUSAN='" + txtNamaJurusan.Text.ToString() + "' WHERE ID_JURUSAN='" + txtIdJurusan.Text.ToString() + "'";

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            refreshAllGridView();
        }

        protected void btnClearJurusan_Click(object sender, EventArgs e)
        {
            txtIdJurusan.Text = null;
            txtNamaJurusan.Text = null;
        }


    }
}