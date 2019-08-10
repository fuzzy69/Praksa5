using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Praksa5
{
    public partial class frmMain : Form
    {
        public Praksa5Entities db;
        //public string appTitle = "Employees Management Panel";
        //public string appDescription = "Praksa5 example app";
        //public string appAuthor = "Zoran Vuković";
        //public string appVersion = "0.1.2.190710";
        //public string appLicence = "WTFPL";

        public frmMain()
        {
            InitializeComponent();
            Text = Praksa5.Settings.AppTitle;
            db = new Praksa5Entities();
            dgvPregledPodatakaLoad();
        }

        private void dgvPregledPodatakaLoad()
        {
            dgvEmployees.Columns.Add("Ime_Zaposlenog", "Ime Zaposlenog");
            dgvEmployees.Columns.Add("Prezime_Zaposlenog", "Prezime Zaposlenog");
            dgvEmployees.Columns.Add("Maticni_Broj_Zaposlenog", "Matični Broj Zaposlenog");
            dgvEmployees.Columns.Add("Ime_Jednog_Roditelja", "Ime Jednog Roditelja");
            dgvEmployees.Columns.Add("Adresa", "Adresa");
            dgvEmployees.Columns.Add("Mesto", "Mesto");
            dgvEmployees.Columns.Add("Email", "Email");
        }

        public void dgvPregledPodatakaRefresh()
        {
            dgvPregledPodatakaClear();
            dgvPregledPodatakaUpdate();
        }

        private void dgvPregledPodatakaClear()
        {
            for (int i = dgvEmployees.Rows.Count - 1; i >= 0; i--)
            {
                dgvEmployees.Rows.RemoveAt(i);
            }
        }

        private void dgvPregledPodatakaUpdate()
        {
            var results = (
                from z in db.ZAPOSLENI
                join m in db.MESTO on z.Sifra_Mesto equals m.Sifra_Mesto
                select new
                {
                    ImeZaposlenog = z.Ime_Zaposlenog,
                    PrezimeZaposlenog = z.Prezime_Zaposlenog,
                    MaticniBrojZaposlenog = z.Maticni_Broj_Zaposlenog,
                    ImeJednogRoditelja = z.Ime_Jednog_Roditelja,
                    Adresa = z.Adresa,
                    Mesto = m.Naziv_Mesto,
                    Email = z.Email
                }).ToList();
            foreach (var row in results)
            {
                System.Type type = row.GetType();
                //
                string imeZaposlenog = (string)type.GetProperty("ImeZaposlenog").GetValue(row, null);
                string prezimeZaposlenog = (string)type.GetProperty("PrezimeZaposlenog").GetValue(row, null);
                Int64 maticniBrojZaposlenog = (Int64)type.GetProperty("MaticniBrojZaposlenog").GetValue(row, null);
                string imeJednogRoditelja = (string)type.GetProperty("ImeJednogRoditelja").GetValue(row, null);
                string adresa = (string)type.GetProperty("Adresa").GetValue(row, null);
                string mesto = (string)type.GetProperty("Mesto").GetValue(row, null);
                string email = (string)type.GetProperty("Email").GetValue(row, null);
                //
                var index = dgvEmployees.Rows.Add();
                dgvEmployees.Rows[index].Cells["Ime_Zaposlenog"].Value = imeZaposlenog;
                dgvEmployees.Rows[index].Cells["Prezime_Zaposlenog"].Value = prezimeZaposlenog;
                dgvEmployees.Rows[index].Cells["Maticni_Broj_Zaposlenog"].Value = maticniBrojZaposlenog.ToString();
                dgvEmployees.Rows[index].Cells["Ime_Jednog_Roditelja"].Value = imeJednogRoditelja;
                dgvEmployees.Rows[index].Cells["Adresa"].Value = adresa;
                dgvEmployees.Rows[index].Cells["Mesto"].Value = mesto;
                dgvEmployees.Rows[index].Cells["Email"].Value = email;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dgvPregledPodatakaRefresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Helpers.OpenFile("Import Mesta", "CSV files (*.csv)|*.csv|All files (*.*)|*.*");
            City[] mesta = null;
            if (filePath != null)
                mesta = Helpers.ReadCSVMesto(filePath);
            if (mesta == null)
                return;
            int affectedRows = 0;
            try
            {
                foreach (City m in mesta)
                {
                    var mesto = new MESTO
                    {
                        Sifra_Mesto = m.Zip,
                        Naziv_Mesto = m.Name
                    };
                    db.MESTO.Add(mesto);
                    db.SaveChanges();
                    affectedRows++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update MESTO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // FIXME: Rollback on fail
                //dgvMestaLoad();
            }
            if (affectedRows > 0)
            {
                MessageBox.Show(String.Format("Successfully added {0} records.", affectedRows), "Update MESTO Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMailSettings formMailSettings = new frmMailSettings();
            formMailSettings.ShowDialog();
        }

        private void tsmImportZaposleni_Click(object sender, EventArgs e)
        {
            string filePath = Helpers.OpenFile("Import Zaposleni", "CSV files (*.csv)|*.csv|All files (*.*)|*.*");
            object[] zaposleni = null;
            if (filePath != null)
                zaposleni = Helpers.ReadCSVZaposleni(filePath);
            if (zaposleni == null)
                return;
            int affectedRows = 0;
            var email = new EmailAddressAttribute();
            try
            {
                foreach (Employee z in zaposleni)
                {
                    if (email.IsValid(z.Email))
                    {
                        var zaposlen = new ZAPOSLENI
                        {
                            Maticni_Broj_Zaposlenog = z.JMBG,
                            Prezime_Zaposlenog = z.Name,
                            Ime_Zaposlenog = z.Surname,
                            Ime_Jednog_Roditelja = z.ParentName,
                            Adresa = z.Address,
                            Sifra_Mesto = z.CityZip,
                            Email = z.Email
                        };
                        db.ZAPOSLENI.Add(zaposlen);
                        db.SaveChanges();
                        affectedRows++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update ZAPOSLENI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // FIXME: Rollback on fail
                //dgvMestaLoad();
            }
            if (affectedRows > 0)
            {
                dgvPregledPodatakaRefresh();
                MessageBox.Show(String.Format("Successfully added {0} employee(s).", affectedRows), "Update ZAPOSLENI Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one employee!");
                return;
            }
            var mails = new List<string>();
            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                mails.Add(row.Cells[6].Value.ToString());
            }
            frmSendMail formSendMail = new frmSendMail();
            formSendMail.mailTo = String.Join(", ", mails.ToArray());
            formSendMail.ShowDialog();
        }

        private EmployeeAndCity GetSelectedEmployee()
        {
            var index = dgvEmployees.SelectedRows[0].Index;
            Int64 maticniBrojZaposlenog = Int64.Parse((string)dgvEmployees.Rows[index].Cells["Maticni_Broj_Zaposlenog"].Value);
            EmployeeAndCity employee = (
                from z in db.ZAPOSLENI
                join m in db.MESTO on z.Sifra_Mesto equals m.Sifra_Mesto
                where z.Maticni_Broj_Zaposlenog == maticniBrojZaposlenog
                select new EmployeeAndCity
                {
                    Name = z.Ime_Zaposlenog,
                    Surname = z.Prezime_Zaposlenog,
                    JMBG = z.Maticni_Broj_Zaposlenog,
                    ParentName = z.Ime_Jednog_Roditelja,
                    Address = z.Adresa,
                    City = m.Naziv_Mesto,
                    CityZip = m.Sifra_Mesto,
                    Email = z.Email
                }).First();

            return employee;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            List<MESTO> cities = db.MESTO.ToList();
            var formEmployee = new frmEmployee();
            formEmployee.Text = "Add New Employee";
            formEmployee.db = db;
            formEmployee.cities = cities;
            formEmployee.ShowDialog(this);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            List<MESTO> cities = db.MESTO.ToList();
            EmployeeAndCity employee = GetSelectedEmployee();
            var formEmployee = new frmEmployee();
            formEmployee.Text = "Edit Employee";
            formEmployee.db = db;
            formEmployee.cities = cities;
            formEmployee.employee = employee;
            formEmployee.ShowDialog(this);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAndCity employee = GetSelectedEmployee();
            if (employee != null)
            {
                string text = String.Format("Are you sure to delete employee {0} {1}?", employee.Name, employee.Surname);
                DialogResult result = MessageBox.Show(text, "Confirm Employee Removal!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.ZAPOSLENI.Remove(db.ZAPOSLENI.Single(x => x.Maticni_Broj_Zaposlenog == employee.JMBG));
                    int affectedRows = db.SaveChanges();
                    if (affectedRows > 0)
                    {
                        dgvPregledPodatakaRefresh();
                        MessageBox.Show(String.Format("Successfully deleted {0} employee(s)!", affectedRows), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee!");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show((new EmailAddressAttribute().IsValid(" a")).ToString());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox = new frmAboutBox();
            aboutBox.ShowDialog(this);
        }
    }
}
