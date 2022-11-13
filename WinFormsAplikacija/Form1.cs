using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAplikacija
{
    public partial class Form1 : Form
    {
        WinFormsAplikacijaDbEntities1 db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            db = new WinFormsAplikacijaDbEntities1();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
            djelatniciBindingSource.DataSource = db.Djelatnici.Include("ClanoviObitelji").ToList();
            ShowClanoveObitelji();
        }

        private void ShowClanoveObitelji()
        {
         
            Djelatnici obj = djelatniciBindingSource.Current as Djelatnici;
            if (obj != null)
            {
                if (obj.ClanoviObitelji != null)
                {
                    clanoviObiteljiBindingSource.DataSource = obj.ClanoviObitelji.ToList();
                }
            }
            dataGridViewDjelatnici.Columns[0].Visible = false;
            dataGridViewClanovi.Columns[1].HeaderCell.Style.ForeColor = Color.Red;
            dataGridViewClanovi.Columns[0].Visible = false;
            dataGridViewDjelatnici.EnableHeadersVisualStyles = false;
            dataGridViewDjelatnici.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridViewDjelatnici.Columns[1].HeaderCell.Style.BackColor = Color.Red;
            lblIdDjelatnik.Hide();
            txtIdDjelatnik.Hide();


        }

        private void dataGridViewDjelatnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowClanoveObitelji();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            btnDodaj.Enabled = false;
            panel1.Enabled = true;
            txtImeDjelatnik.Focus();
            Djelatnici d = new Djelatnici();
            db.Djelatnici.Add(d);
            djelatniciBindingSource.Add(d);
            djelatniciBindingSource.MoveLast();
            clanoviObiteljiBindingSource.DataSource = null;
        }

       
       
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panel1.Enabled = false;
                btnDodaj.Enabled = true;
                btnUredi.Enabled = true;
                MessageBox.Show("Uspješno spremljeno u bazu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            Djelatnici d = djelatniciBindingSource.Current as Djelatnici;
            if (d != null)
            {
                if (clanoviObiteljiBindingSource.DataSource == null)
                    clanoviObiteljiBindingSource.DataSource = d.ClanoviObitelji.ToList();
                ClanoviObitelji c = new ClanoviObitelji() { Djelatnici = d };
                clanoviObiteljiBindingSource.Add(c);
                db.ClanoviObitelji.Add(c);
            }
        }

        private void dataGridViewDjelatnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDjelatnici.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Jel si siguran da želiš izbrisati ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                {
                    db.ClanoviObitelji.Remove(clanoviObiteljiBindingSource.Current as ClanoviObitelji);
                    clanoviObiteljiBindingSource.RemoveCurrent();
                }
            }
        }

        private void dataGridViewClanovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClanovi.Columns[e.ColumnIndex].Name == "Obriši")
            {
                if (MessageBox.Show("Jel si siguran da želiš izbrisati ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                {
                    db.ClanoviObitelji.Remove(clanoviObiteljiBindingSource.Current as ClanoviObitelji);
                    clanoviObiteljiBindingSource.RemoveCurrent();
                }
            }
           
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            btnUredi.Enabled = false;
            panel1.Enabled = true;
            txtImeDjelatnik.Focus();
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnDodaj.Enabled = true;
            btnUredi.Enabled = true;
            djelatniciBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added:
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
