using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191216
{
    public partial class FrmUtas : Form
    {
        OleDbConnection conn;
        DateTime ma;
        public FrmUtas(OleDbConnection conn, DateTime ma)
        {
            this.conn = conn;
            this.ma = ma;
            InitializeComponent();
        }

        public FrmUtas(OleDbConnection conn, int utasId, string nev, string cim, int jel)
        {
            this.ma = new DateTime(2015, 10, 11);
            this.conn = conn;
            InitializeComponent();

            tbKod.Text = utasId + "";
            tbNev.Text = nev;
            rtbCim.Text = cim;
            cbJelentkezes.Text = jel + "";
        }

        private void tbKod_TextChanged(object sender, EventArgs e)
        {
            tsmiTorles.Enabled = !string.IsNullOrWhiteSpace(tbKod.Text);
        }

        private void FrmUtas_Load(object sender, EventArgs e)
        {
            JelentkezesekFeltoltese();
        }

        private void JelentkezesekFeltoltese()
        {
            conn.Open();

            var cmd = new OleDbCommand(
                "SELECT T_KÓD FROM TÚRA " +
                $"WHERE KEZDET >= #{ma.ToString("yyyy-MM-") + "01"}#;", conn);

            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbJelentkezes.Items.Add(r[0]);
            }
            conn.Close();
        }

        private void KeresesTSMI_Click(object sender, EventArgs e)
        {
            var frm = new FrmUtasLista(conn);
            frm.ShowDialog();
        }

        private void MentesTSMI_Click(object sender, EventArgs e)
        {
            string jel = (cbJelentkezes.SelectedIndex == -1)
                    ? "NULL"
                    : cbJelentkezes.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(tbNev.Text))
                MessageBox.Show("Név megadása kötelező!");
            else if (string.IsNullOrWhiteSpace(rtbCim.Text))
                MessageBox.Show("Cím megadása kötelező!");
            else if(string.IsNullOrWhiteSpace(tbKod.Text))
            {
                conn.Open();
                var adapter = new OleDbDataAdapter()
                {
                    InsertCommand = new OleDbCommand(
                        "INSERT INTO UTAS (NÉV, CÍM, JELENTKEZIK) VALUES " +
                        $"('{tbNev.Text}', '{rtbCim.Text}', {jel});", conn),
                };
                adapter.InsertCommand.ExecuteNonQuery();

                var cmd = new OleDbCommand("SELECT MAX(U_KÓD) FROM UTAS;", conn);
                var r = cmd.ExecuteReader();
                r.Read();
                tbKod.Text = r[0] + "";

                conn.Close();
                MessageBox.Show("Új utas rögzítése megtörtént!");
            }
            else
            {
                conn.Open();

                var adapter = new OleDbDataAdapter()
                {
                    UpdateCommand = new OleDbCommand(
                        "UPDATE UTAS SET " +
                        $"NÉV = '{tbNev.Text}', " +
                        $"CÍM = '{rtbCim.Text}', " +
                        $"JELENTKEZIK = {jel}, " +
                        $"WHERE U_KÓD = {tbKod.Text};", conn),
                };

                adapter.UpdateCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Utas adatainak frissítése megtörtént!");
            }
        }

        private void tsmiTorles_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "Biztosan törölni akarod ezt a kis köcsögöt?",
                "megerősítés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                conn.Open();

                var adapter = new OleDbDataAdapter()
                {
                    DeleteCommand = new OleDbCommand(
                        "DELETE FROM UTAS WHERE " +
                        $"U_KÓD = {tbKod.Text};", conn),
                };
                adapter.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Utas véglegesen törölve!");
                UresUrlap();
            }
        }
        private void UresUrlap()
        {
            tbKod.Text = "";
            tbNev.Text = "";
            rtbCim.Text = "";
            cbJelentkezes.SelectedIndex = -1;
        }

        private void UresUrlapTSMI_Click(object sender, EventArgs e)
        {
            UresUrlap();
        }
    }
}
