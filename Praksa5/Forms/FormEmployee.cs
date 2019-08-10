using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Praksa5
{
    public partial class frmEmployee : Form
    {
        public EmployeeAndCity employee = null;
        public List<MESTO> cities = null;
        public Praksa5Entities db = null;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            if (cities == null)
            {
                MessageBox.Show("Failed to load cities data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cbEmployeeCity.DataSource = cities;
            cbEmployeeCity.DisplayMember = "Naziv_Mesto";
            cbEmployeeCity.ValueMember = "Sifra_Mesto";
            if (employee != null)
            {
                txtJMBG.Text = employee.JMBG.ToString();
                txtEmployeeName.Text = employee.Name;
                txtEmployeeSurname.Text = employee.Surname;
                txtEmployeeParentName.Text = employee.ParentName;
                txtEmployeeAddress.Text = employee.Address;
                cbEmployeeCity.SelectedIndex = cbEmployeeCity.FindStringExact(employee.City.ToString());
                txtEmployeeEmail.Text = employee.Email;
            }
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Failed to reach database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate form input
            bool ok = false;
            ok = Int64.TryParse(txtJMBG.Text, out long jmbg);
            if (!ok)
            {
                MessageBox.Show("Please enter valid JMBG!");
                return;
            }
            string employeeName = txtEmployeeName.Text.Trim();
            if (employeeName == "")
            {
                MessageBox.Show("Please enter valid employee name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string employeeSurname = txtEmployeeSurname.Text.Trim();
            if (employeeSurname == "")
            {
                MessageBox.Show("Please enter valid employee surname!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string employeeParentName = txtEmployeeParentName.Text.Trim();
            if (employeeParentName == "")
            {
                MessageBox.Show("Please enter valid employee parent name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string employeeAddress = txtEmployeeAddress.Text.Trim();
            if (employeeAddress == "")
            {
                MessageBox.Show("Please enter valid employee address!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ok = Int32.TryParse(cbEmployeeCity.SelectedValue.ToString(), out int cityZip);
            if (!ok)
            {
                MessageBox.Show("Please select employee city!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string employeeEmail = txtEmployeeEmail.Text.Trim();
            if (!(new EmailAddressAttribute().IsValid(employeeEmail)))
            {
                MessageBox.Show("Please enter valid employee email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Insert employee
                if (employee == null)
                {
                    var employee_ = new ZAPOSLENI
                    {
                        Maticni_Broj_Zaposlenog = jmbg,
                        Prezime_Zaposlenog = employeeName,
                        Ime_Zaposlenog = employeeSurname,
                        Ime_Jednog_Roditelja = employeeParentName,
                        Adresa = employeeAddress,
                        Sifra_Mesto = cityZip,
                        Email = employeeEmail
                    };
                    db.ZAPOSLENI.Add(employee_);
                    int affectedRows = db.SaveChanges();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show(String.Format("Successfully added employee!", affectedRows), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Update employee
                else
                {
                    var employee_ = db.ZAPOSLENI.Where(x => x.Maticni_Broj_Zaposlenog == jmbg).First();
                    employee_.Maticni_Broj_Zaposlenog = jmbg;
                    employee_.Prezime_Zaposlenog = employeeName;
                    employee_.Ime_Zaposlenog = employeeSurname;
                    employee_.Ime_Jednog_Roditelja = employeeParentName;
                    employee_.Adresa = employeeAddress;
                    employee_.Sifra_Mesto = cityZip;
                    employee_.Email = employeeEmail;
                    int affectedRows = db.SaveChanges();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show(String.Format("Successfully updated employee!", affectedRows), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert/update an employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmMain mainForm = (frmMain)this.Owner;
            mainForm.dgvPregledPodatakaRefresh();
            this.Close();
        }
    }
}
