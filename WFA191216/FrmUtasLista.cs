using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191216
{
    
    public partial class FrmUtasLista : Form
    {
        OleDbConnection conn;
        public FrmUtasLista(OleDbConnection conn)
        {
            this.conn = conn;
            InitializeComponent();

            tbNev.TextChanged += Kereses;
            tbCel.TextChanged += Kereses;
        }

        private void Kereses(object sender, EventArgs e)
        {
            dgvUtasok.Rows.Clear();
            conn.Open();
            var cmd = new OleDbCommand(
                "SELECT U_KÓD, NÉV, CÍM, ÚT_KÓD, KEZDET, HOVÁ " +
                "FROM ((TÚRA " +
                "INNER JOIN UTAS ON TÚRA.T_KÓD = UTAS.JELENTKEZIK) " +
                "INNER JOIN ÚTVONAL ON TÚRA.ÚTVONAL = ÚTVONAL.ÚT_KÓD) " +
                $"WHERE NÉV LIKE '{tbNev.Text}%' AND HOVÁ LIKE '{tbCel.Text}%';", conn);

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                dgvUtasok.Rows.Add(
                    r[0], r[1], r[2], r[3],
                    r.GetDateTime(4).ToString("yyyy-MM-dd"),
                    r[5]);
            }
            conn.Close();
        }

        private void dgvUtasok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new FrmUtas(
                conn, 
                (int)dgvUtasok[0, e.RowIndex].Value,
                (string)dgvUtasok[1, e.RowIndex].Value,
                (string)dgvUtasok[2, e.RowIndex].Value,
                (int)dgvUtasok[3, e.RowIndex].Value);

            frm.ShowDialog();
        }
    }
}
