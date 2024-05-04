using Guna.UI2.WinForms;
using JobHub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace JobHub
{
    internal class Function
    {
        DBConection conection = new DBConection();
        public void Insert(string cmd)
        {
            conection.ExcutionInsertData(cmd);
        }

        public void Update(string cmd)
        {
            conection.ExcutionUpdateDate(cmd);
        }

        public void Delete()
        {

        }

        public void WriteJob(string detail, uC_MakeCV_1 uc_make)
        {
            string s = detail;
            if (s.Trim().Length > 0 && s[0] == '|' && s[1] == '!')
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    string temp = "";
                    if (s[i] == '|' && s[i + 1] == '!')
                    {
                        uC_JobDescription uC_JobDescription = new uC_JobDescription();
                        int j = i + 2;
                        while (s[j] != '|' && s[j + 1] != '#')
                        {
                            temp += s[j];
                            j++;
                        }
                        j += 2;
                        uC_JobDescription.lblViewJob.Text = temp;
                        temp = "";
                        while (s[j] != '|' && s[j + 1] != '^')
                        {
                            temp += s[j];
                            j++;
                        }
                        uC_JobDescription.lblSince.Text = temp;
                        j += 2;
                        temp = "";
                        while (j < s.Length - 1 && (s[j] != '|' && s[j + 1] != '+'))
                        {
                            temp += s[j];
                            j++;
                            if (j == s.Length - 1)
                            {
                                temp += s[j];
                            }
                        }
                        uC_JobDescription.lblReviewJob.Text = temp;
                        i = j - 1;
                        uc_make.pnExperience.Controls.Add(uC_JobDescription);
                    }
                }
            }
        }

        public void WriteJob_1(string detail, FlowLayoutPanel fpn, int idCV, int idCandidate)
        {
            Stack<uC_LoadIfJob> containUC = new Stack<uC_LoadIfJob>();
            ControlManager controlManager = new ControlManager(idCV, idCandidate);
            string s = detail.Trim();

            if (s.Trim().Length > 0 && s[0] == '|' && s[1] == '!')
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    string temp = "";
                    if (s[i] == '|' && s[i + 1] == '!')
                    {
                        uC_LoadIfJob uC_LoadIfJob = new uC_LoadIfJob();
                        int j = i + 2;
                        while (s[j] != '|' && s[j + 1] != '#')
                        {
                            temp += s[j];
                            j++;
                        }
                        j += 2;
                        uC_LoadIfJob.txtWhatJob.Text = temp;
                        temp = "";
                        while (s[j] != '|' && s[j + 1] != '^')
                        {
                            temp += s[j];
                            j++;
                        }
                        uC_LoadIfJob.txtTime.Text = temp;
                        j += 2;
                        temp = "";
                        while (j < s.Length - 1 && (s[j] != '|' && s[j + 1] != '+'))
                        {                           
                            temp += s[j];
                            j++;
                            if (j == s.Length - 1)
                            {
                                temp += s[j];
                            }
                        }
                        uC_LoadIfJob.txtReviewJob.Text = temp;
                        AddEventUC(uC_LoadIfJob, containUC, fpn, controlManager);
                        i = j - 1;
                        if (j == s.Length - 1)
                        {
                            uC_LoadIfJob.btnAddPanel.Visible = true;
                        }
                    }
                }
            }
            else
            {
                uC_LoadIfJob uC_LoadIfJob = new uC_LoadIfJob();
                uC_LoadIfJob.btnAddPanel.Visible = true;
                containUC.Push(uC_LoadIfJob);
                AddEventUC(uC_LoadIfJob, containUC, fpn, controlManager);
            }
        }

        public void UpdataCV(Candidate candidate)
        {

        }

        public void UpdataCV(DetailCV den)
        {

        }

        private void setLocation(int x, int y, Control ctrl)
        {
            ctrl.Location = new Point(x, y);
        }

        public void WriteData(DataTable dt, FFMCV fMCV)
        {
            ExcutionWriteData(dt, fMCV);
        }

        public void WriteData(DataTable dt, FCreatCV fMCV, int idCandidate)
        {
            ExcutionWriteData(dt, fMCV, idCandidate);
        }

        public void IImage(string avt, Guna2CirclePictureBox picImage)
        {
            if (avt == "")
            {
                picImage.Image = Resources.iconuser;
            }
            else
            {
                string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", avt);
                using (Image image = Image.FromFile(absoluteImagePath))
                {
                    picImage.Image = new Bitmap(image);
                }
            }
        }

        public void ExcutionWriteData(DataTable dt, FFMCV fMCV)
        {

            uC_MakeCV_1 uc_make = new uC_MakeCV_1();
            foreach (DataRow dr in dt.Rows)
            {
                setLocation(uc_make.lblIntroduce.Location.X, uc_make.lblIntroduce.Location.Y + uc_make.lblIntroduce.Height + 5, uc_make.pnCall);
                setLocation(uc_make.pnCall.Location.X, uc_make.pnCall.Location.Y + uc_make.pnCall.Height + 5, uc_make.pnEducation);
                setLocation(uc_make.pnEducation.Location.X, uc_make.pnEducation.Location.Y + 5 + uc_make.pnEducation.Height, uc_make.pnSkill);
                uc_make.txtFirstName.Text = dr["candidateFirstName"].ToString().Trim();
                uc_make.lblFirstName.Text = dr["candidateFirstName"].ToString().Trim();
                uc_make.lblLastName.Text = dr["candidateFirstName"].ToString().Trim();
                uc_make.lblIntroduce.Text = "Xin chào tôi tên là " + dr["candidateFirstName"].ToString().Trim() + " " + dr["candidateLastName"].ToString().Trim();
                uc_make.lblPhoneNumber.Text = dr["candidatePhone"].ToString().Trim();
                uc_make.lblEmail.Text = dr["candidateEmail"].ToString().Trim();
                uc_make.lblAddress.Text = dr["candidateAddress"].ToString().Trim();
                uc_make.lblSkill.Text = dr["Skill"].ToString().Trim();
                uc_make.lblJobName.Text = dr["jobName"].ToString().Trim();
                uc_make.txtNameJob.Text = dr["jobName"].ToString().Trim();
                uc_make.txtLastName.Text = dr["candidateLastName"].ToString().Trim();
                uc_make.txtEmail.Text = dr["candidateEmail"].ToString().Trim();
                uc_make.txtAddress.Text = dr["candidateAddress"].ToString().Trim();
                uc_make.txtLinkAVT.Text = dr["candidateAvatar"].ToString().Trim();
                uc_make.txtPhoneNumber.Text = dr["candidatePhone"].ToString().Trim();
                uc_make.dtpYob.Value = DateTime.Parse(dr["candidateBirth"].ToString());
                IImage(dr["CVAvatar"].ToString(), uc_make.picAvatar);
                uc_make.LoadImage += (sender, e) =>
                {
                    DetailCVDAO detailCVDAO = new DetailCVDAO();
                    string path = detailCVDAO.SelectImageButton(Application.StartupPath, "Resources");
                    if (path != null)
                    {
                        updateCV(path, uc_make.picAvatar, detailCVDAO, int.Parse(dr["idCV"].ToString()), int.Parse(dr["idCandidate"].ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi");
                    }

                };
                if (bool.Parse(dr["candidateGender"].ToString()))
                {
                    uc_make.rdoBoy.Checked = true;
                    uc_make.rdoGirl.Checked = false;
                }
                else
                {
                    uc_make.rdoBoy.Checked = false;
                    uc_make.rdoGirl.Checked = true;
                }
                uc_make.txtSkills.Text = dr["Skill"].ToString().Trim();
                WriteJob(dr["CVDescription"].ToString().Trim(), uc_make);
                uc_make.lblInfEdu.Text = dr["CVEducation"].ToString().Trim();
                WriteJob_1(dr["CVDescription"].ToString().Trim(), uc_make.pnExperienc, int.Parse(dr["idCV"].ToString()), int.Parse(dr["idCandidate"].ToString()));
                uc_make.Done += (sender, e) =>
                {
                    try
                    {
                        string experience = Repect(uc_make);
                        string education = $"{uc_make.cboSalary.SelectedItem.ToString()} {uc_make.txtSchool.Text.Trim()} năm {uc_make.cboYear.SelectedItem.ToString()} tại {uc_make.cboCity.SelectedItem.ToString()}";
                        FixCVDAO fix = new FixCVDAO(int.Parse(dr["idCV"].ToString()), int.Parse(dr["idCandidate"].ToString()));
                        Candidate candidate = new Candidate(int.Parse(dr["idCandidate"].ToString()), uc_make.txtFirstName.Text.Trim(), uc_make.txtLastName.Text.Trim(), uc_make.txtPhoneNumber.Text.Trim(), uc_make.txtEmail.Text.Trim(),
                        uc_make.rdoBoy.Checked, uc_make.dtpYob.Value, uc_make.txtAddress.Text.Trim(), uc_make.txtLinkAVT.Text.Trim());
                        DetailCV detail = new DetailCV(int.Parse(dr["idCV"].ToString()), int.Parse(dr["idCandidate"].ToString()), uc_make.lblJobName.Text.Trim(), uc_make.txtSkills.Text.Trim(), experience, education);
                        fix.UpdateData(detail, $"{uc_make.pnContainMenu.BackColor.R}, {uc_make.pnContainMenu.BackColor.G}, {uc_make.pnContainMenu.BackColor.B}");
                        fix.UpdateData(candidate);
                        MessageBox.Show("Sửa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };

            }
            fMCV.Controls.Add(uc_make);
            uc_make.Dock = DockStyle.Fill;
        }

        public string Repect(uC_MakeCV_1 uc_make)
        {
            string experience = "";
            foreach (Control control in uc_make.Controls)
            {
                if (control is Guna2Panel)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is FlowLayoutPanel)
                        {
                            foreach (Control control1 in control2.Controls)
                            {
                                if (control1 is uC_LoadIfJob)
                                {
                                    uC_LoadIfJob uc = (uC_LoadIfJob)control1;
                                    if (uc.txtReviewJob.Text.Trim().Length > 0 && uc.txtTime.Text.Trim().Length > 0 && uc.txtReviewJob.Text.Trim().Length > 0)
                                    {
                                        experience += "|!" + uc.txtWhatJob.Text.Trim();
                                        experience += "|#" + uc.txtTime.Text.Trim();
                                        experience += "|^" + uc.txtReviewJob.Text.Trim();
                                    }
                                }
                            }
                        }

                    }
                }
            }
            return experience;

        }
        private void updateCV(string path, Guna2CirclePictureBox picAvatarCV, DetailCVDAO detailCVDAO, int idCV, int idCandidate)
        {
            try
            {
                string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", path);
                if (File.Exists(absoluteImagePath))
                {
                    Image img = Image.FromFile(absoluteImagePath);
                    picAvatarCV.Image = img;
                    string cmd_update = $@"update CV
                                   set CV.CVAvatar = N'{path}'
                                   from CV
                                   inner join Candidate on CV.idCandidate = Candidate.idCandidate
                                   where CV.idCV = {idCV} and Candidate.idCandidate = {idCandidate}";
                    detailCVDAO.Update(cmd_update);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tập tin ảnh.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void ExcutionWriteData(DataTable dt, FCreatCV fMCV, int idCandidate)
        {
            int idCV = -1;
            uC_MakeCV_1 uc_make = new uC_MakeCV_1();
            foreach (DataRow dr in dt.Rows)
            {
                MakeCVDAO makeCVDAO = new MakeCVDAO(int.Parse(dr["idCandidate"].ToString()));
                string cmd = "select max(CV.idCV) as max from CV";
                DataTable dt_max = makeCVDAO.ReadData(cmd);
                idCV = Int32.Parse(dt_max.Rows[0]["max"].ToString()) + 1;
                Stack<uC_LoadIfJob> containUC = new Stack<uC_LoadIfJob>();
                ControlManager controlManager = new ControlManager(idCV, idCandidate);
                setLocation(uc_make.lblIntroduce.Location.X, uc_make.lblIntroduce.Location.Y + uc_make.lblIntroduce.Height + 5, uc_make.pnCall);
                setLocation(uc_make.pnCall.Location.X, uc_make.pnCall.Location.Y + uc_make.pnCall.Height + 5, uc_make.pnEducation);
                setLocation(uc_make.pnEducation.Location.X, uc_make.pnEducation.Location.Y + 5 + uc_make.pnEducation.Height, uc_make.pnSkill);
                uc_make.txtFirstName.Text = dr["candidateFirstName"].ToString().Trim();
                uc_make.lblFirstName.Text = dr["candidateFirstName"].ToString().Trim();
                uc_make.lblLastName.Text = dr["candidateFirstName"].ToString().Trim();
                uc_make.lblIntroduce.Text = "Xin chào tôi tên là " + dr["candidateFirstName"].ToString().Trim() + " " + dr["candidateLastName"].ToString().Trim();
                uc_make.lblPhoneNumber.Text = dr["candidatePhone"].ToString().Trim();
                uc_make.lblEmail.Text = dr["candidateEmail"].ToString().Trim();
                uc_make.lblAddress.Text = dr["candidateAddress"].ToString().Trim();
                uc_make.txtLastName.Text = dr["candidateLastName"].ToString().Trim();
                uc_make.txtEmail.Text = dr["candidateEmail"].ToString().Trim();
                uc_make.txtAddress.Text = dr["candidateAddress"].ToString().Trim();
                uc_make.txtLinkAVT.Text = dr["candidateAvatar"].ToString().Trim();
                uc_make.txtPhoneNumber.Text = dr["candidatePhone"].ToString().Trim();
                uc_make.dtpYob.Value = DateTime.Parse(dr["candidateBirth"].ToString());
                uC_LoadIfJob uC_LoadIfJob = new uC_LoadIfJob();
                uC_LoadIfJob.btnAddPanel.Visible = true;
                uc_make.pnExperienc.Controls.Add(uC_LoadIfJob);
                containUC.Push(uC_LoadIfJob);
                AddEventUC(uC_LoadIfJob, containUC, uc_make.pnExperienc, controlManager);
                if (bool.Parse(dr["candidateGender"].ToString()))
                {
                    uc_make.rdoBoy.Checked = true;
                    uc_make.rdoGirl.Checked = false;
                }
                else
                {
                    uc_make.rdoBoy.Checked = false;
                    uc_make.rdoGirl.Checked = true;
                }
                uc_make.Done += (sender, e) =>
                {
                    string experience = Repect(uc_make);
                    string education = $"{uc_make.cboSalary.SelectedItem.ToString()} {uc_make.txtSchool.Text.Trim()} năm {uc_make.cboYear.SelectedItem.ToString()} tại {uc_make.cboCity.SelectedItem.ToString()}";
                    
                    DetailCV detailCV = new DetailCV(idCV, int.Parse(dr["idCandidate"].ToString()), uc_make.txtNameJob.Text.Trim(),
                    uc_make.txtSkills.Text.Trim(), experience, education);
                    makeCVDAO.Insert(detailCV, $"{uc_make.pnContainMenu.BackColor.R}, {uc_make.pnContainMenu.BackColor.G}, {uc_make.pnContainMenu.BackColor.B}");
                    MessageBox.Show("Lưu thành công");
                };
                uc_make.LoadImage += (sender, e) =>
                {
                    DetailCVDAO detailCVDAO = new DetailCVDAO();
                    string path = detailCVDAO.SelectImageButton(Application.StartupPath, "Resources");
                    if (path != null)
                    {
                        updateCV(path, uc_make.picAvatar, detailCVDAO, idCV, int.Parse(dr["idCandidate"].ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi");
                    }

                };

            }
            fMCV.Controls.Add(uc_make);
            uc_make.Dock = DockStyle.Fill;
        }

        public void WriteData(DataTable dt, Label lblTotalJob)
        {
            lblTotalJob.Text = dt.Rows[0][0].ToString();
        }
        public string SelectImageButton(string pathRoot, string dir)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png;";
            openFileDialog.RestoreDirectory = true;
            string imagePathInResources = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                try
                {
                    string destinationPath = Path.Combine(pathRoot, "..\\..\\" + dir, Path.GetFileName(selectedImagePath));
                    File.Copy(selectedImagePath, destinationPath, true);
                    imagePathInResources = Path.Combine(dir, Path.GetFileName(selectedImagePath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            return imagePathInResources;
        }

        public void AddEvent(int idJob, int idComapny, FlowLayoutPanel contain)
        {
            string cmd = $@"select * froM AppliedCV join CV on AppliedCV.idCV = cv.idCV where AppliedCV.idJob = {idJob}";
            DataTable dt_1 = conection.ExcutionReadData(cmd);
            uc_FollowCV uc_Follow = new uc_FollowCV();
            uc_Follow.btnSumbit.Visible = true;
            uc_Follow.btnSumbit.Visible = true;
            uc_Follow.btnFollow.Visible = false;
            uc_Follow.Sumbit_Click += (sender, e) =>
            {
                int count = 0;
                string cmd_read = $@"select Company.quantityCVAccess
                                     from Company
                                     where Company.idCompany = {idComapny}";
                DataTable dt = conection.ExcutionReadData(cmd_read);
                if (dt.Rows[0][0].ToString() != null && dt.Rows[0][0].ToString() != "")
                {
                    count = int.Parse(dt.Rows[0][0].ToString());
                }
                string cmd_1 = $@"UPDATE Company
                                SET quantityCVAccess = {count + 1}
                                WHERE idCompany = '{idComapny}'";
                conection.ExcutionUpdateDate(cmd_1);
                uc_Follow.btnSumbit.Text = "Đã xác nhận";
            };

            uc_Follow.Remove_Click += (sender, e) =>
            {
                uc_Follow.btnRemove.Enabled = false;
            };

            contain.Controls.Add(uc_Follow);
        }

     
        public void LoadJob(DataTable dt, FlowLayoutPanel fpnJob, FlowLayoutPanel fpnContainCV)
        {
            
            foreach(DataRow dr in dt.Rows)
            {
                uC_Job job = new uC_Job();
                job.lblJobName.Text = dr["jobName"].ToString().Trim();
                job.lblCompanyName.Text = dr["companyName"].ToString().Trim();
                job.lblSalary.Text = dr["jobMinSalary"].ToString().Trim() + "-" + dr["jobMaxSalary"].ToString().Trim();
                job.lblJobAddress.Text = dr["jobAddress"].ToString().Trim();
                int idJob = Int32.Parse(dr["idJob"].ToString().Trim());
                int idcompany = Int32.Parse(dr["idCompany"].ToString().Trim());
                job.loadJobClick += (sender, e) =>
                {
                    AddEvent(idJob, idcompany, fpnContainCV);

                };
                fpnJob.Controls.Add(job);
            }
        }

        public DataTable ReadData(string cmd)
        {
            return conection.ExcutionReadData(cmd);
        }
        public void DeleteMainCV()
        {
            string cmd = $@"Delete from CVReady";
            ReadData(cmd);
        }

        public void SetMainCV(int idCandidate, int idCV, int type)
        {
            string cmd = $@"INSERT INTO CVReady (idCandidate, idCV, CVType  ) VALUES ('{idCandidate}', '{idCV}', '{type}')";
            Insert(cmd);
        } 
        public void WriteData(DataTable dt, FlowLayoutPanel fpn, Label lblNameAvarta, Guna2CirclePictureBox picAvarta)
        {
            FormHandler handler = new FormHandler();
            fpn.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                lblNameAvarta.Text = dr["candidateFirstName"].ToString().Trim() + " " + dr["candidateLastName"].ToString().Trim();
                
                uC_CV uC_CV = new uC_CV();
                uC_CV.lblLastName.Text = dr["candidateFirstName"].ToString();
                uC_CV.lblFirstName.Text = dr["candidateLastName"].ToString();
                uC_CV.lblJobName.Text = dr["jobName"].ToString();

                uC_CV.lblIntroduce.Text = $@"Xin chào, tôi tên là {uC_CV.lblLastName.Text} {uC_CV.lblFirstName.Text}";
                uC_CV.btnMainCV.Click += (sender, e) =>
                {
                    DeleteMainCV();
                    SetMainCV(int.Parse(dr["idCandidate"].ToString()), int.Parse(dr["idCV"].ToString()), 1);
                    uC_CV.btnMainCV.Visible = false;
                    MessageBox.Show("Đặt thành công");
                };
                if (dr["CVAvatar"].ToString().Trim() == "")
                {
                    uC_CV.picAvatarCV.Image = Resources.ưqd;
                }
                else
                {
                    string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", dr["CVAvatar"].ToString().Trim());
                    using (Image image = Image.FromFile(absoluteImagePath))
                    {
                        uC_CV.picAvatarCV.Image = new Bitmap(image);
                    }
                }

                if (dr["candidateAvatar"].ToString().Trim() == "")
                {
                    picAvarta.Image = Resources.iconuser;
                }
                else
                {
                    string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", dr["candidateAvatar"].ToString().Trim());
                    using (Image image = Image.FromFile(absoluteImagePath))
                    {
                        picAvarta.Image = new Bitmap(image);
                    }
                }
                uC_CV.OpenForm += (sender, e) =>
                {
                    int idCandiate = Int32.Parse(dr["idCandidate"].ToString());
                    int idCV = Int32.Parse(dr["idCV"].ToString());
                    handler.OpenNewForm(idCandiate, idCV);
                };
                fpn.Controls.Add(uC_CV);
            }
        }
        public void WriteData(System.Windows.Forms.Label lblFirstName, System.Windows.Forms.Label lblLastName, System.Windows.Forms.Label lblJobName,
            System.Windows.Forms.Label lblIntroduce, System.Windows.Forms.Label lblPhoneNumber, System.Windows.Forms.Label lblEmail,
            System.Windows.Forms.Label lblAddress, System.Windows.Forms.Label lblSkill,
            System.Windows.Forms.Label lblInfEdu, FlowLayoutPanel pnExperience, Guna2CirclePictureBox picAvatarCV, DataTable dt, Guna2Panel pnContailMenu)
        {
            foreach(DataRow dr in dt.Rows)
            {
                lblFirstName.Text = dr["candidateFirstName"].ToString();
                lblLastName.Text = dr["candidateLastName"].ToString();
                lblJobName.Text = dr["jobName"].ToString();
                lblIntroduce.Text = $@"Xin chào, tôi tên là {lblFirstName.Text} {lblLastName.Text}";
                lblPhoneNumber.Text = dr["candidatePhone"].ToString();
                lblEmail.Text = dr["candidateEmail"].ToString();
                lblAddress.Text = dr["candidateAddress"].ToString();
                lblSkill.Text = dr["Skill"].ToString();
                string rgb = dr["ThemeCV"].ToString().Trim();
                string[] components = rgb.Split(',');

                if (components.Length == 3)
                {
                    int red, green, blue;
                    if (int.TryParse(components[0], out red) && int.TryParse(components[1], out green) && int.TryParse(components[2], out blue))
                    {
                        pnContailMenu.FillColor = Color.FromArgb(red, green, blue);
                    }
                }
                if (dr["CVAvatar"].ToString().Trim() == "")
                {
                    picAvatarCV.Image = Resources.iconuser;
                }
                else
                {
                    string absoluteImagePath = Path.Combine(Application.StartupPath, "..\\..\\", dr["CVAvatar"].ToString().Trim());
                    using (Image image = Image.FromFile(absoluteImagePath))
                    {
                        picAvatarCV.Image = new Bitmap(image);
                    }
                }
                string s = dr["CVDescription"].ToString().Trim();
                if (s.Trim().Length > 0 && s[0] == '|' && s[1] == '!')
                {
                    pnExperience.Controls.Clear();
                    for (int i = 0; i < s.Length; ++i)
                    {
                        string temp = "";
                        if (s[i] == '|' && s[i + 1] == '!')
                        {
                            uC_JobDescription uC_JobDescription = new uC_JobDescription();
                            int j = i + 2;
                            while (s[j] != '|' && s[j + 1] != '#')
                            {
                                temp += s[j];
                                j++;
                            }
                            j += 2;
                            uC_JobDescription.lblViewJob.Text = temp;
                            temp = "";
                            while (s[j] != '|' && s[j + 1] != '^')
                            {
                                temp += s[j];
                                j++;
                            }
                            uC_JobDescription.lblSince.Text = temp;
                            j += 2;
                            temp = "";
                            while (j < s.Length - 1 && (s[j] != '|' && s[j + 1] != '+'))
                            {
                                temp += s[j];
                                j++;
                                if (j == s.Length - 1)
                                {
                                    temp += s[j];
                                }
                            }
                            uC_JobDescription.lblReviewJob.Text = temp;
                            pnExperience.Controls.Add(uC_JobDescription);
                            i = j - 1;
                        }
                    }
                }
                lblInfEdu.Text = dr["CVEducation"].ToString().Trim();
            }
                
        }

        public void ShowData(int idCandidate, Guna2TextBox txtAddress,
            Guna2TextBox txtEmail, Guna2TextBox txtFirstName, Guna2TextBox txtLastName,
            Guna2TextBox txtPhoneNumber,
            DataTable dt, Guna2DateTimePicker yob,
            Guna2CustomRadioButton boy, Guna2CustomRadioButton girl)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtAddress.Text = row["candidateAddress"].ToString();
                txtPhoneNumber.Text = row["candidatePhone"].ToString();
                txtEmail.Text = row["candidateEmail"].ToString();
                txtFirstName.Text = row["candidateFirstName"].ToString();
                txtLastName.Text = row["candidateLastName"].ToString();
                txtAddress.Text = row["candidateAddress"].ToString();
                yob.Value = DateTime.Parse(row["candidateBirth"].ToString());
                if (bool.Parse(row["candidateGender"].ToString()))
                {
                    boy.Checked = true;
                    girl.Checked = false;
                }
                else
                {
                    boy.Checked = false;
                    girl.Checked = true;
                }
            }
        }

        public void AddEventUC(uC_LoadIfJob load, Stack<uC_LoadIfJob> stackLoad, FlowLayoutPanel fpn, ControlManager controlManager)
        {
            load.AddPanel += (sender, e) =>
            {
                controlManager.AddPenal(fpn, load, stackLoad);
            };
            load.RemovePanel += (sender, e) =>
            {
                controlManager.RemoveControl(fpn, load, stackLoad);
            };
            fpn.Controls.Add(load);
        }
        public void ShowData(int idCV, int idCandidate, Guna2TextBox txtAddress, Guna2TextBox txtEducation, Guna2TextBox txtEmail, Guna2TextBox txtFirstName, Guna2TextBox txtLastName, Guna2TextBox txtNameJob, Guna2TextBox txtPhoneNumber, Guna2TextBox txtSkill, DataTable dt, FlowLayoutPanel fpn, Guna2CustomRadioButton boy, Guna2CustomRadioButton girl, Guna2DateTimePicker yob)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtAddress.Text = row["candidateAddress"].ToString();
                txtPhoneNumber.Text = row["candidatePhone"].ToString();
                txtEmail.Text = row["candidateEmail"].ToString();
                txtFirstName.Text = row["candidateFirstName"].ToString();
                txtLastName.Text = row["candidateLastName"].ToString();
                txtNameJob.Text = row["jobName"].ToString();
                txtSkill.Text = row["Skill"].ToString();
                txtAddress.Text = row["candidateAddress"].ToString();
                yob.Value = DateTime.Parse(row["candidateBirth"].ToString());
                txtEducation.Text = row["CVEducation"].ToString();
                if (bool.Parse(row["candidateGender"].ToString()))
                {
                    boy.Checked = true;
                    girl.Checked = false;
                }
                else
                {
                    boy.Checked = false;
                    girl.Checked = true;
                }
                Stack<uC_LoadIfJob> containUC = new Stack<uC_LoadIfJob>();
                ControlManager controlManager = new ControlManager(idCV, idCandidate);
                string s = row["CVDescription"].ToString().Trim();
                if (s.Trim().Length > 0 && s[0] == '+')
                {
                    string[] array = s.Split(new char[] { '|', '!' }, StringSplitOptions.RemoveEmptyEntries);
                    fpn.Controls.Clear();
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] != "")
                        {
                            uC_LoadIfJob uC_LoadIfJob = new uC_LoadIfJob();
                            containUC.Push(uC_LoadIfJob);
                            string[] subArray = array[i].Split(new char[] {'|', '#'}, StringSplitOptions.RemoveEmptyEntries);
                            uC_LoadIfJob.txtWhatJob.Text = subArray[0];
                            string[] subArray1 = subArray[1].Split(new char[] {'|', '^'}, StringSplitOptions.RemoveEmptyEntries);
                            uC_LoadIfJob.txtTime.Text = subArray1[0];
                            if (i == array.Length - 1)
                            {
                                uC_LoadIfJob.btnAddPanel.Visible = true;
                            }
                            uC_LoadIfJob.txtReviewJob.Text = subArray1[1];
                            AddEventUC(uC_LoadIfJob, containUC, fpn, controlManager);
                        }
                    }
                    
                }
                else
                {
                    uC_LoadIfJob uC_LoadIfJob = new uC_LoadIfJob();
                    uC_LoadIfJob.btnAddPanel.Visible = true;
                    containUC.Push(uC_LoadIfJob );
                    AddEventUC(uC_LoadIfJob, containUC, fpn, controlManager);
                }
            }
        }

        public Image InsertImage(string imageName, Guna2PictureBox pb, uC_imageFeedBack uC_ImageFeed)
        {
            try
            {
                string imagePath = getPathImage(imageName);
                uC_ImageFeed.Path = imagePath;
                Image im = new Bitmap(imagePath);
                pb.Image = im;
                return im;
            }catch{
                MessageBox.Show("Lỗi không thể tải ảnh");
                return null;
            }

        }

        
        public Image InsertImage(string imageName,Guna2PictureBox pb)
        {
            try
            {
                string imagePath = getPathImage(imageName.Trim());
                Image im = new Bitmap(imagePath);
                pb.Image = im;
                return im;
            }
            catch
            {
                MessageBox.Show("Lỗi không thể tải ảnh");
                return null;
            }

        }
        public string getPathImage(string link)
        {
            string projectFolderPath = Directory.GetParent(Application.StartupPath).Parent.FullName + "\\image";
            return Path.Combine(projectFolderPath, link);
        }
        private string GetUniqueFileName(string folderPath, string fileName)
        {
            int count = 1;
            string newFileName = fileName;
            string extension = ".JPEG";
            string fileNameOnly = Path.GetFileNameWithoutExtension(fileName);

            while (File.Exists(Path.Combine(folderPath, newFileName)))
            {
                newFileName = $"{fileNameOnly} ({count++}){extension}";
            }

            return Path.Combine(folderPath, newFileName);
        }
        public string SaveImage(string imagePath)
        {
            string imageFolder = Directory.GetParent(Application.StartupPath).Parent.FullName + "\\image";
            string nameImage = Path.GetFileName(imagePath);
            string destinationPath = GetUniqueFileName(imageFolder, nameImage);
            File.Copy(imagePath, destinationPath);
            return Path.GetFileName(destinationPath);
        }

        public List<string> loadImageFeedBack(string path, FlowLayoutPanel fpn, Guna2PictureBox picImage, List<string> path_new)
        {
            if(path != "")
            {
                uC_imageFeedBack uC_ImageFeedBack = new uC_imageFeedBack();
                uC_ImageFeedBack.btnDeleteImage.Click += (sender, e) =>
                {
                    
                    fpn.Controls.Remove(uC_ImageFeedBack); 
                    path_new.Remove(path);
                    if(fpn.Controls.Count == 1)
                    {
                        picImage.Visible = true;
                    }
                };
                InsertImage(path, uC_ImageFeedBack.picImageFeedBack, uC_ImageFeedBack);
                fpn.Controls.Add(uC_ImageFeedBack);
            }
            return path_new;
        }
        public string SelectImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Tất cả các tệp (*.*)|*.*|Ảnh (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] path = openFileDialog.FileNames;
                        if(path.Length == 1)
                        {
                            return openFileDialog.FileName;
                        }
                        string temp = "";
                        for(int i = 0; i < path.Length; ++i)
                        {
                            if (i == path.Length - 1)
                            {
                                temp += path[i];

                            }
                            else
                            {
                                temp += path[i] + "+";
                            }
                        }
                        return temp;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở tệp ảnh: " + ex.Message);
                    }
                }
            }
            return null;
        }
        public string HandleNumbers(int number)
        {
            StringBuilder str = new StringBuilder();
            str.Append("");
            if (number < 1000)
            {
                str.Append(number.ToString());
            }
            else if (number >= 1000 && number < 1000000)
            {
                int n1 = number / 1000;
                number %= 1000;
                int n2 = number / 100;

                str.Append(n1.ToString());
                if (n2 > 0)
                {
                    str.Append("," + n2.ToString());
                }
                str.Append(" N");
            }
            else
            {
                int n1 = number / 1000000;
                number %= 1000000;
                int n2 = number / 100000;

                str.Append(n1.ToString());
                if (n2 > 0)
                {
                    str.Append("," + n2.ToString());
                }
                str.Append(" Tr");
            }
            return str.ToString();
        }
        public void LoadUc_JobEvaluate(SqlDataReader dr,FlowLayoutPanel flpnUC)
        {
            flpnUC.Controls.Clear();
            uc_Evaluate uc_Evaluate = new uc_Evaluate();
            while (dr.Read())
            {
                uc_Evaluate uc = uc_Evaluate.LoadIntoIntoUC(dr);
                flpnUC.Controls.Add(uc);
            }
        }
        public void LoadInfoEvaluate(SqlDataReader dr, UC_EvaluateInfo uC_EvaluateInfo)
        {
            if (dr.Read())
            {
                List<int> list = new List<int>();
                float avg = 0;
                for (int i = 1; i <= 5; i++)
                {
                    int x = int.Parse(dr[$"s{i}"] != DBNull.Value ? dr[$"s{i}"].ToString() : "0");
                    list.Add(x);
                    avg += x * i;
                }

                avg /= list.Sum();
                float roundedRating = (float)Math.Round(avg * 2) / 2;
                uC_EvaluateInfo.rsJob.Value = roundedRating;
                uC_EvaluateInfo.lblStar.Text = roundedRating.ToString();
                uC_EvaluateInfo.lbl5.Location = new Point(uC_EvaluateInfo.lblStar.Location.X + uC_EvaluateInfo.lblStar.Size.Width, uC_EvaluateInfo.lblStar.Location.Y + 5);
                uC_EvaluateInfo.lblStar5.Text += " (" + HandleNumbers(list[4]) + ")";
                uC_EvaluateInfo.lblStar4.Text += " (" + HandleNumbers(list[3]) + ")";
                uC_EvaluateInfo.lblStar3.Text += " (" + HandleNumbers(list[2]) + ")";
                uC_EvaluateInfo.lblStar2.Text += " (" + HandleNumbers(list[1]) + ")";
                uC_EvaluateInfo.lblStar1.Text += " (" + HandleNumbers(list[0]) + ")";
                SetLocation(uC_EvaluateInfo.lblStar5, uC_EvaluateInfo.lblStar4);
                SetLocation(uC_EvaluateInfo.lblStar4, uC_EvaluateInfo.lblStar3);
                SetLocation(uC_EvaluateInfo.lblStar3, uC_EvaluateInfo.lblStar2);
                SetLocation(uC_EvaluateInfo.lblStar2, uC_EvaluateInfo.lblStar1);



            }

        }
        private void SetLocation(Label x, Label y)
        {
            y.Location = new Point(x.Location.X + x.Width + 20, x.Location.Y);
        }
    }
}
