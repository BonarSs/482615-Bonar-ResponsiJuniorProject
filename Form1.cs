using Npgsql;
using System.Data;
using System.Runtime;

namespace HR_Support
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=hr_supp";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            conn = new NpgsqlConnection(connstring);

            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

            try
            {
                conn.Open();
                sql = @"select * from emp_insert(:_id_karyawan,:_nama,:_id_dep)";

                cmd = new NpgsqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("_id_karywaan", tbIdKaryawan.Text);
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDept.Text);


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data user berhasil dimasukkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    loadData();
                    tbIdKaryawan.Text = tbNamaKaryawan.Text = cbDept.Text = null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "INSERT FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbIdKaryawan.Text = r.Cells["_id_karyawan"].Value.ToString();
                tbNamaKaryawan.Text = r.Cells["_nama"].Value.ToString();
                cbDept.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (r.Cells == null)
            {
                MessageBox.Show("mohon pilih baris data yang akan diedit", "good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"Select * from emp_update(:_id_karyawan,:_nama,:_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_id_karywaan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDept.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data user berhasil diperbarui", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    loadData();
                    tbIdKaryawan.Text = tbNamaKaryawan.Text = cbDept.Text = null;
                    r = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "EDIT FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("mohon pilih baris data yang akan dihapus", "warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Anda yakin ingin menghapus data" + r.Cells["_nama"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
            try
            {
                    conn.Open();
                    sql = @"select * from emp_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    if((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data user berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        loadData();
                        tbIdKaryawan.Text = tbNamaKaryawan.Text = cbDept.Text = null;
                        r = null;
                    }

                }
                catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}