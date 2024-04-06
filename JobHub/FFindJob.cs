using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using Guna.UI2.WinForms;
using System.Reflection;

namespace JobHub
{
    public partial class FJob : Form
    {
        private FindJob fjd=new FindJob();
        private Fmain fm;
        private List<ListUcJobAndBool> list = new List<ListUcJobAndBool>();
        private void InitList()
        {
            for(int i=0; i<= 7; i++)
            {
                this.list.Add(new ListUcJobAndBool()); 
            }
        }
        private void loadJobInPanel()
        {
            fjd.LoadUc_Job(pnJob, fm);
        }
        public FJob(Fmain fm,Account account)
        {
                this.fm = fm;
                InitList();
                InitializeComponent();

        }
        private void FJob_Load(object sender, EventArgs e)
        {
                loadJobInPanel();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.TextLength == 0)
            {
                list[7].Check = false;
                fjd.LoadTxtSearch(pnJob, fm, txtSearch.Text, list, 7);
            }
            else
            {
                fjd.LoadTxtSearch(pnJob, fm, txtSearch.Text, list, 7);
                list[7].Check = true;
            }
            /*          btnTechnique.Checked = false;
                        btnEconomy.Checked = false;
                        btnIT.Checked = false;
                        cboIndustryGroup.SelectedIndex = 0;
                        cboAddress.SelectedIndex = 0;
                        cboExperience.SelectedIndex = 0;
                        cboSalary.SelectedIndex = 0;    */
        }

        private void loadJob(Guna2Button button, int index)
        {
            fjd.LoadButton(pnJob, fm, button.Text, list,index);

        }
        private bool CheckFilterNull()
        {
            if (!btnTechnique.Checked && !btnIT.Checked && !btnEconomy.Checked
                && cboIndustryGroup.SelectedItem.ToString()== "Tất cả các ngành"
                &&cboSalary.SelectedItem.ToString()== "Tất cả mức lương"
                &&cboAddress.SelectedItem.ToString()=="Tất cả tỉnh/thành phố"
                &&cboExperience.SelectedItem.ToString()== "Tất cả kinh nghiệm")
                return true;
            return false;
        }
        private void checkStateButton(Guna2Button button)
        {
                pnJob.Controls.Clear();
                if (btnEconomy.Checked)
                {
                    list[1].Check = true;
                    loadJob(btnEconomy, 1);
                }
                else
                {
                    list[1] = new ListUcJobAndBool();
                    
                }
                    
                if (btnIT.Checked)
                {
                    list[0].Check = true;
                    loadJob(btnIT,0);
                }
                else
                {
                    list[0] = new ListUcJobAndBool();
                }
                if (btnTechnique.Checked)
                {
                    list[2].Check = true;
                    loadJob(btnTechnique,2);
                }
                else
                     list[2] = new ListUcJobAndBool();
                if (CheckFilterNull())
                {
                    loadJobInPanel();
                }
                else 
                    fjd.LoadUc(list,fm, pnJob);
        }

            private void btnIT_Click(object sender, EventArgs e)
            {
                checkStateButton(btnIT);
            }

            private void btnEconomy_Click(object sender, EventArgs e)
            {
                checkStateButton(btnEconomy);
            }

            private void btnTechnique_Click(object sender, EventArgs e)
            {
                checkStateButton(btnTechnique);
            }

            private void cboIndustryGroup_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cboIndustryGroup.SelectedIndex == 3)
                {
                    btnEconomy.Checked = true;
                    checkStateButton(btnEconomy);
                }
                else if (cboIndustryGroup.SelectedIndex == 4)
                {
                    btnIT.Checked = true;
                    checkStateButton(btnIT);
                }
                else if (cboIndustryGroup.SelectedIndex == 5)
                {
                    btnTechnique.Checked = true;
                    checkStateButton(btnTechnique);
                }
                else
                {
                    if (cboIndustryGroup.SelectedItem.ToString() == "Tất cả các ngành")
                    {
                        list[3].Check = false;
                        list[3] = new ListUcJobAndBool();
                        if (CheckFilterNull())
                        {
                            loadJobInPanel();
                        }
                        else
                            fjd.LoadUc(list, fm, pnJob);
                    }
                    else
                    {
                        list[3].Check = true;
                        fjd.LoadTxtIndustry(pnJob, fm, cboIndustryGroup.SelectedItem.ToString(), list, 3);
                    }
                }
            }


        private void cboExperience_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboExperience.SelectedItem.ToString() == "Tất cả kinh nghiệm")
            {
                list[6] = new ListUcJobAndBool();
                if (CheckFilterNull())
                {
                    loadJobInPanel();
                }
                else
                    fjd.LoadUc(list, fm, pnJob);
            }
            else
            {
                list[6].Check = true;
                fjd.LoadTxtExperience(pnJob, fm, cboExperience.SelectedItem.ToString(), list, 6);
            }
             
        }

        private void cboSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSalary.SelectedItem.ToString() == "Tất cả mức lương")
            {
                list[5] = new ListUcJobAndBool();
                if (CheckFilterNull())
                {
                    loadJobInPanel();
                }
                else
                    fjd.LoadUc(list, fm, pnJob);
            }
            else
            {
                list[5].Check = true;
                fjd.LoadTxtSalary(pnJob, fm, cboSalary.SelectedItem.ToString(), list, 5);
            }
            
        }

        private void cboAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAddress.SelectedItem.ToString() == "Tất cả tỉnh/thành phố")
            {
                list[4] = new ListUcJobAndBool ();
                if (CheckFilterNull())
                {
                    loadJobInPanel();
                }
                else
                    fjd.LoadUc(list, fm, pnJob);
            }
            else
            {
                list[4].Check = true;
                fjd.LoadTxtAddress(pnJob, fm, cboAddress.SelectedItem.ToString(), list, 4);
            }
                
        }
    }
} 

