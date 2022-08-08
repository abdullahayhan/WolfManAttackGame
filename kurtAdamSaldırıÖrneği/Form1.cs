using kurtAdamSaldırıÖrneği.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurtAdamSaldırıÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account account = new Account();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            /*txtUserName.Clear();
            txtWeapon.Clear();
            cmbBrans.Items.RemoveAt(cmbBrans.SelectedIndex);
            cmbRace.Items.RemoveAt(cmbRace.SelectedIndex);
            ChangeState(true);
            ChangeVisible(false);*/
            account.userName = txtUserName.Text;
            account.race = cmbRace.SelectedItem.ToString();
            account.branch = cmbRace.SelectedItem.ToString();
            account.weapon = txtWeapon.Text;
            ChangeState(false);
            ChangeVisible(true);
        }

        public void ChangeState(bool state)
        {
            txtUserName.Enabled = state;
            txtWeapon.Enabled = state;
            cmbBrans.Enabled = state;
            cmbRace.Enabled = state;
            btnSelect.Enabled = state;
        }

        public void ChangeVisible(bool isVisible)
        {
            btnAttack.Visible = picWolf.Visible = lblHealth.Visible = lblMyHealth.Visible = isVisible;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            account.Attack();
            lblHealth.Width -= account.damage;
            MessageBox.Show($"Düşmana {account.damage} kadar hasar verdiniz.");
            lblMyHealth.Width -= account.myDamage;
            MessageBox.Show($"Düşman size {account.myDamage} kadar hasar verdi.");
            if (lblHealth.Width<=0)
            {
                MessageBox.Show("Düşmanı yendiniz.");
                picWolf.Visible = false; 
            }
            else if (lblMyHealth.Width<=0)
            {
                MessageBox.Show("Düşman sizi yendi.");
            }
        }
    }
}
